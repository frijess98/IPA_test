using Newtonsoft.Json;
using SCE.ServicingPartnerInfoCheck.Contracts.Abstracts;

namespace SCE.ServicingPartnerInfoCheck.Contracts.Types.GLKBServicingPartner
{
    public class GlkbRequestExport : RequestExportBase
    {
        [JsonProperty(PropertyName = "finanzierung")]
        public Financing Financing { get; set; }
    }
}
