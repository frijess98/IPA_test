using Newtonsoft.Json;

namespace SCE.ServicingPartnerInfoCheck.Contracts.Types.GLKBServicingPartner
{
    /// <summary>
    /// Collateral GUTHABEN
    /// </summary>
    public class FinancingSecurityDeposit : SecurityItemBase
    {
        [JsonProperty(PropertyName = "kontoart")]
        public string AccountType { get; set; }

        [JsonProperty(PropertyName = "versicherungsnehmer")] //if we have borrower or stamm -> uuid of it, else - > empty
        public UuidEntity PoliceHolder { get; set; }

        [JsonIgnore] //"sicherheitengeber"
        public UuidEntity SecurityProvider { get; set; }

        [JsonProperty(PropertyName = "iban")]
        public string Iban { get; set; }

        [JsonIgnore] //"institut"
        public UuidEntity Institute { get; set; }

        [JsonProperty(PropertyName = "saldo")]
        public decimal Saldo { get; set; }

        [JsonProperty(PropertyName = "datumPer")]
        public string DateBy { get; set; }

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
