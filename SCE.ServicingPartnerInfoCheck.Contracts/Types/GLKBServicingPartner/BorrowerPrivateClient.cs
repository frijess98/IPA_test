using Newtonsoft.Json;

namespace SCE.ServicingPartnerInfoCheck.Contracts.Types.GLKBServicingPartner
{
    public class BorrowerPrivateClient : BorrowerClientBase
    {
        [JsonProperty(PropertyName = "clientId")]
        public int? ClientId { get; set; }

        [JsonProperty(PropertyName = "kundenNr")]
        public int? BorrowerId { get; set; } 

        [JsonProperty(PropertyName = "anrede")]
        public string Salutation { get; set; }

        [JsonProperty(PropertyName = "vorname")]
        public string FirstName { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string LastName { get; set; }

        [JsonProperty(PropertyName = "geburtsdatum")]
        public string BirthDate { get; set; }

        [JsonProperty(PropertyName = "nationalitaet")]
        public string Nationality { get; set; }

        [JsonProperty(PropertyName = "zivilstand")]
        public string CivilStatus { get; set; }

        [JsonProperty(PropertyName = "branche")]
        public string Industry { get; set; }

        [JsonProperty(PropertyName = "vsbAufnahme")]
        public string VsbAdmission { get; set; }

        [JsonProperty(PropertyName = "kinder")]
        public string Children { get; set; }

        [JsonProperty(PropertyName = "hauptverdienstBruttoExklBonus")]
        public decimal? MainIncomeGrossExcludingBonus { get; set; }

        [JsonProperty(PropertyName = "einkommenAusSelbstArbeit")]
        public decimal SelfEmploymentIncome { get; set; }

        [JsonProperty(PropertyName = "renteneinkuenfte")]
        public decimal? PensionIncome { get; set; }

        [JsonProperty(PropertyName = "variablesEinkommen")]
        public decimal VariableIncome { get; set; }

        [JsonProperty(PropertyName = "voraussichtlicheBvgRente")]
        public decimal BvgIncome { get; set; }

        [JsonProperty(PropertyName = "alimenteEmpfaenger")]
        public decimal AlimonyIncome { get; set; }

        [JsonProperty(PropertyName = "sonstigeEinnahmen")]
        public decimal OtherRegularIncome { get; set; }

        [JsonProperty(PropertyName = "mieteinnahmen")]
        public decimal RentalIncome { get; set; }

        [JsonProperty(PropertyName = "uebrigeVermoegen")]
        public decimal OtherAssets { get; set; }

        [JsonProperty(PropertyName = "alimenteLeistungspflicht")]
        public decimal? AlimonyObligations { get; set; }

        [JsonProperty(PropertyName = "ratenKonsumkreditLeasing")]
        public decimal? ConsumerLoansOrLeasing { get; set; }

        [JsonProperty(PropertyName = "ratenDrittdarlehen")]
        public decimal? LoansWithThirdParties { get; set; }

        [JsonProperty(PropertyName = "sonstigeAufwendungen")]
        public decimal? OtherRegularCommitments { get; set; }

        [JsonProperty(PropertyName = "eventualverpflichtungenBuergschaften")]
        public decimal? ContingentLiabilitiesAndGuarantees { get; set; }

        [JsonProperty(PropertyName = "uebrigeSchulden")]
        public decimal? OtherDebts { get; set; }

        [JsonProperty(PropertyName = "hypothekenFerienhaus")]
        public decimal HolidayHomeMortgageAmount { get; set; }

        [JsonProperty(PropertyName = "arbeitgeber")]
        public string Employer { get; set; }

        [JsonProperty(PropertyName = "mitarbeiter")]
        public string StaffMember { get; set; }
    }
}
