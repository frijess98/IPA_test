using Newtonsoft.Json;
using SCE.ServicingPartnerInfoCheck.Contracts.Abstracts;

namespace SCE.ServicingPartnerInfoCheck.Contracts.Types.PostFinanceServicingPartner
{
	public class PostFinanceRequestExport : RequestExportBase
	{
		[JsonProperty(PropertyName = "Financing")]
		public Financing Financing { get; set; }
	}
}