using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace SCE.ServicingPartnerInfoCheck.Contracts.Types.GLKBServicingPartner
{
    public class Financing
    {
        [JsonProperty(PropertyName = "finanzierungsNr")]
        public string FiancningId { get; set; }

        [JsonProperty(PropertyName = "offerId")]
        public string ApplicationId { get; set; }

        [JsonProperty("requestId")]
        public string RequestId { get; set; }

        [JsonProperty(PropertyName = "tragbarkeit")]
        public decimal Affordability { get; set; }

        [JsonProperty(PropertyName = "rahmenlimite")]
        public decimal InitialMortgageAmount { get; set; }

        [JsonProperty(PropertyName = "wiedervorlagedatum")]
        public string ResubmissionDate { get; set; }

        [JsonProperty(PropertyName = "verwendungszweck")]
        public string TransactionType { get; set; }

        [JsonProperty(PropertyName = "verkaufsplattform")]
        public string Platform { get; set; }

        [JsonProperty(PropertyName = "verkaufsberater")]
        public string ClientAdvisor { get; set; }

        [JsonProperty(PropertyName = "manualIntervention")]
        public string ManualIntervention { get; set; }

        [JsonProperty(PropertyName = "mandant")]
        public string Client { get; set; }

        [JsonProperty(PropertyName = "creationDate")]
        public DateTime? CreationDate { get; set; }

        [JsonProperty(PropertyName = "vertriebId")]
        public string DistributionTransactionReference { get; set; }

        [JsonProperty(PropertyName = "investorId")]
        public string InvestorTransactionReference { get; set; }

        [JsonProperty(PropertyName = "konten")]
        public List<FinancingAccount> Accounts { get; set; }

        [JsonProperty(PropertyName = "kreditnehmer")]
        public BorrowerClientBase Borrower { get; set; }

        [JsonProperty(PropertyName = "sicherheiten")]
        public List<FinancingSecurity> Securities { get; set; }
    }
}
