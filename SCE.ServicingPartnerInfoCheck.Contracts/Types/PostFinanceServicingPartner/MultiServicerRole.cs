using Newtonsoft.Json;

namespace SCE.ServicingPartnerInfoCheck.Contracts.Types.PostFinanceServicingPartner
{
	public class MultiServicerRole
	{
		[JsonProperty(PropertyName = "DistributionServicer")]
		public string DistributionServicer { get; set; }

		[JsonProperty(PropertyName = "DistributionAccount")]
		public string DistributionAccount { get; set; }

		[JsonProperty(PropertyName = "PositionKeeper")]
		public string PositionKeeper { get; set; }

		[JsonProperty(PropertyName = "RiskCarrierAccount")]
		public string RiskCarrierAccount { get; set; }
	}
}