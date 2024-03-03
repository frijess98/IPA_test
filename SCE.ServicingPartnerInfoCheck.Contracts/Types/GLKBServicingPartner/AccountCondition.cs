using Newtonsoft.Json;

namespace SCE.ServicingPartnerInfoCheck.Contracts.Types.GLKBServicingPartner
{
    public class AccountCondition
    {
        [JsonProperty(PropertyName = "laufzeitVon")]
        public string DisbursementOfTheTranche { get; set; }

        [JsonProperty(PropertyName = "konditionNr")]
        public int? ConditionNr { get; set; }

        [JsonProperty(PropertyName = "laufzeitBis")]
        public string ExpiryDate { get; set; }

        [JsonProperty(PropertyName = "gueltigNach")]
        public string ValidAfter { get; set; }

        [JsonProperty(PropertyName = "basiszins")]
        public decimal? BaseRate { get; set; }

        [JsonProperty(PropertyName = "basiszinsManuell")]
        public decimal SaronSurcharge { get; set; }

        [JsonProperty(PropertyName = "terminzuschlag")]
        public decimal ForwardSurcharge { get; set; }

        [JsonProperty(PropertyName = "sonderkonditionen")]
        public decimal SpecialRate { get; set; }

        [JsonProperty(PropertyName = "marge")]
        public decimal InterestRate { get; set; }

        [JsonProperty(PropertyName = "abschlussdatum")]
        public string MortgageCreationDate { get; set; }

        [JsonProperty(PropertyName = "mitarbeiterRabatt")]
        public decimal? EmployeeDiscount { get; set; }

        [JsonProperty(PropertyName = "arbeitgeber")]
        public string Employer { get; set; }

    }
}
