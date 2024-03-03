using System.Collections.Generic;
using Newtonsoft.Json;

namespace SCE.ServicingPartnerInfoCheck.Contracts.Types.PostFinanceServicingPartner
{
	public class NewFinancing
	{
		[JsonProperty(PropertyName = "DebitAccount")]
		public string DebitAccount { get; set; }

		[JsonProperty(PropertyName = "IssuedTo")]
		public string IssuedTo { get; set; }

		[JsonProperty(PropertyName = "NumberOfTranches")]
		public int NumberOfTranches { get; set; }

		[JsonProperty(PropertyName = "Tranches")]
		public List<NewFinancingTranches> Tranches { get; set; }
	}
}