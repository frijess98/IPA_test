using System.Collections.Generic;
using Newtonsoft.Json;

namespace SCE.ServicingPartnerInfoCheck.Contracts.Types.PostFinanceServicingPartner
{
	public class CurrentFinancing
	{
		[JsonProperty(PropertyName = "NumberOfTranchesToBeReplaced")]
		public int NumberOfTranchesToBeReplaced { get; set; }

		[JsonProperty(PropertyName = "Tranches")]
		public List<Tranche> Tranches { get; set; }
	}
}