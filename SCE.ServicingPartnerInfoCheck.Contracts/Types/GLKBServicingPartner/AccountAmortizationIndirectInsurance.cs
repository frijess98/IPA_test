using Newtonsoft.Json;

namespace SCE.ServicingPartnerInfoCheck.Contracts.Types.GLKBServicingPartner
{
    public class AccountAmortizationIndirectInsurance : AccountAmortizationBase
    {
        [JsonProperty(PropertyName = "policenNr")]
        public string PoliceNumber { get; set; }
    }
}
