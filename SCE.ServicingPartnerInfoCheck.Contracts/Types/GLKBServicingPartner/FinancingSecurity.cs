using Newtonsoft.Json;

namespace SCE.ServicingPartnerInfoCheck.Contracts.Types.GLKBServicingPartner
{
    public class FinancingSecurity
    {
        [JsonProperty(PropertyName = "anrechnung")]
        public decimal? CalculatedPropertyAmount { get; set; }

        [JsonProperty(PropertyName = "sicherheit")]
        public SecurityItemBase Security { get; set; }
    }
}
