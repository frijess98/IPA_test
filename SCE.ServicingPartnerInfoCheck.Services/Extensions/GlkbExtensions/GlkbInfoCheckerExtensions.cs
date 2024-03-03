using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using SCE.ServicingPartnerInfoCheck.Contracts.Dtos.Otc;
using SCE.ServicingPartnerInfoCheck.Contracts.Types.GLKBServicingPartner;

namespace SCE.ServicingPartnerInfoCheck.Services.Extensions.GlkbExtensions
{
    /// <summary>
    /// Extension methods for Otc
    /// </summary>
    public static class GlkbInfoCheckerExtensions
    {
        private readonly static CultureInfo glkbCulture = new CultureInfo("de-DE");
        private readonly static string glkbDateTimeFormat = "yyyy-MM-dd";

        /// <summary>
        /// Make Otc Root object from Glkb Financing
        /// </summary>
        /// <param name="financing">Source object</param>
        /// <returns></returns>
        public static OtcRootDto ToOtcRoot(this Financing financing)
        {
            return new OtcRootDto()
                .AddFinancing(financing)
                .AddClients(financing)
                .AddTranches(financing);
        }

        private static OtcRootDto AddFinancing(this OtcRootDto me, Financing financing)
        {
            me.Financing = new FinancingItemDto()
            {
                ServicingPartnerKey = financing.FiancningId,
                CreationDate = financing.CreationDate ?? default,
                Investor = financing.Client,
                MortgageAmount = financing.InitialMortgageAmount,
                OutsourcedRequestId = financing.ApplicationId,
                OtcRequestId = financing.RequestId
            };

            return me;
        }

        private static OtcRootDto AddClients(this OtcRootDto me, Financing financing)
        {
            if (financing.Borrower is BorrowerPrivateClient privateClient)
            {
                me.Applicants = new List<ApplicantItemDto>()
                {
                    new ApplicantItemDto()
                    {
                        BirthDate = privateClient.BirthDate,
                        ClientNumber = privateClient.BorrowerId,
                        Country = privateClient.Country,
                        Location = privateClient.Location,
                        PartnerNumber = privateClient.PartnerId,
                        PostalCode = privateClient.Zip,
                        FirstName = privateClient.FirstName,
                        LastName = privateClient.LastName,
                        Salutation = privateClient.Salutation
                    }
                };
            }
            else if (financing.Borrower is BorrowerTrunkClient trunkClient)
            {
                me.Applicants = trunkClient.Borrowers != null
                    ? trunkClient.Borrowers.Select(familyPrivateClient => new ApplicantItemDto()
                    {
                        ClientNumber = familyPrivateClient.BorrowerId,
                        BirthDate = familyPrivateClient.BirthDate,
                        Country = familyPrivateClient.Country,
                        Location = familyPrivateClient.Location,
                        PartnerNumber = familyPrivateClient.PartnerId,
                        PostalCode = familyPrivateClient.Zip,
                        FirstName = familyPrivateClient.FirstName,
                        LastName = familyPrivateClient.LastName,
                        Salutation = familyPrivateClient.Salutation
                    }).ToList()
                    : new[]
                    {
                        new ApplicantItemDto
                        {
                            ClientNumber = Convert.ToInt32(trunkClient.BorrowerNumber),
                            Country = trunkClient.Country,
                            Location = trunkClient.Location,
                            PartnerNumber = trunkClient.PartnerId,
                            PostalCode = trunkClient.Zip,
                            FirstName = trunkClient.BorrowerTrunkFullName,
                            LastName = string.Empty,
                            Salutation = string.Empty
                        }
                    }.ToList();
            }
            else if (financing.Borrower is BorrowerCorporateClient corporateClient)
            {
                me.Applicants = new List<ApplicantItemDto>()
                {
                    new ApplicantItemDto()
                    {
                        FirstName =  corporateClient.Corporation,
                        LastName =  corporateClient.LegalForm,
                        Country = corporateClient.Country,
                        Location = corporateClient.Location,
                        PartnerNumber = corporateClient.PartnerId,
                        PostalCode = corporateClient.Zip,
                        ClientNumber = corporateClient.BorrowerId
                    }
                };
            }

            return me;
        }

        private static OtcRootDto AddTranches(this OtcRootDto me, Financing financing)
        {
            me.Tranches = financing.Accounts.Select(a => a.Conditions.Select(c => new TrancheItemDto()
            {
                ValidAfter = DateTime.ParseExact(c.ValidAfter, glkbDateTimeFormat, glkbCulture),
                AccountNumber = a.AccountNr,
                ConditionNumber = c.ConditionNr,
                ContractNumber = a.TrancheId,
                Amount = a.Limite,
                DurationStart = c.DisbursementOfTheTranche,
                DurationEnd = c.ExpiryDate,
                Currency = "CHF",
                Product = financing.Client,
                InterestRate = ((c.EmployeeDiscount ?? 0.0M) +
                                    (c.BaseRate ?? 0.0M) +
                                    c.SaronSurcharge +
                                    c.ForwardSurcharge +
                                    c.SpecialRate +
                                    c.InterestRate) * 100
            }))
                .SelectMany(x => x)
                .ToList();

            return me;
        }
    }
}
