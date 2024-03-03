using Newtonsoft.Json;

namespace SCE.ServicingPartnerInfoCheck.Contracts.Types.GLKBServicingPartner
{
    /// <summary>
    /// Collateral VERSICHERUNG
    /// </summary>
    public class FinancingSecurityInsurance : SecurityItemBase
    {
        [JsonProperty(PropertyName = "policenart")]
        public string PoliceType { get; set; }

        [JsonProperty(PropertyName = "versicherungsnehmer")] //if we have borrower or stamm -> uuid of it, else - > empty
        public UuidEntity PoliceHolder { get; set; }

        [JsonProperty(PropertyName = "versichertePerson")]
        public UuidEntity InsuredPerson { get; set; }

        [JsonIgnore] //"gesellschaft"
        public UuidEntity Company { get; set; }

        [JsonProperty(PropertyName = "policenNr")]
        public string PoliceNumber { get; set; }

        [JsonProperty(PropertyName = "policendatum")]
        public string PoliceDate { get; set; }

        [JsonProperty(PropertyName = "versicherungsablauf")]
        public string InsuranceExpiry { get; set; }

        [JsonProperty(PropertyName = "nominalwert")]
        public decimal? NominalValue { get; set; }

        [JsonProperty(PropertyName = "rueckkaufswert")]
        public decimal ReturnValue { get; set; }

        [JsonProperty(PropertyName = "datumPer")]
        public string DateBy { get; set; }

        [JsonProperty(PropertyName = "bemerkung")]
        public string Remark { get; set; }

        [JsonProperty(PropertyName = "belehnungssatz")]
        public decimal? LoanToValueSet { get; set; }

        [JsonProperty(PropertyName = "belehnungswert")]
        public decimal? CollateralValue { get; set; }

        [JsonProperty(PropertyName = "beanspruchtDritte")]
        public decimal? ClaimedThirdParties { get; set; }

        [JsonProperty(PropertyName = "beanspruchtEigene")]
        public decimal ClaimedAsYourOwn { get; set; }

        [JsonProperty(PropertyName = "verfuegbar")]
        public decimal? Available { get; set; }

        [JsonProperty(PropertyName = "gesellschaft")]
        public string CompanyName { get; set; }
    }
}
