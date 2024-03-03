using Newtonsoft.Json;

namespace SCE.ServicingPartnerInfoCheck.Contracts.Types.GLKBServicingPartner
{
    public class AccountAmortizationIndirect : AccountAmortizationBase
    {
        [JsonProperty(PropertyName = "sparen3Konto")]
        public string Saving3rdPillar { get; set; }
    }
}
