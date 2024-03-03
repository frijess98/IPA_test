using Newtonsoft.Json;

namespace SCE.ServicingPartnerInfoCheck.Contracts.Types.GLKBServicingPartner
{
    public class SecurityItemBase
    {
        [JsonProperty(PropertyName = "sicherheitenNr")]
        public int? CollateralNumber { get; set; }

        [JsonProperty(PropertyName = "beanspruchtEigene")]
        public decimal ClaimedAsYourOwn { get; set; }

        [JsonProperty(PropertyName = "sicherheitenart")]
        public string SecurityType { get; set; }

        [JsonProperty(PropertyName = "mandant")]
        public string Client { get; set; }
    }
}
