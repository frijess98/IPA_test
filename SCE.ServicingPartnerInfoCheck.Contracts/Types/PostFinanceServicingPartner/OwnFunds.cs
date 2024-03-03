using Newtonsoft.Json;

namespace SCE.ServicingPartnerInfoCheck.Contracts.Types.PostFinanceServicingPartner
{
	public class OwnFunds
	{
		[JsonProperty(PropertyName = "Cash")]
		public decimal Cash { get; set; }

		[JsonProperty(PropertyName = "EarlyWithdrawal2ndPillar")]
		public decimal EarlyWithdrawal2ndPillar { get; set; }

		[JsonProperty(PropertyName = "EarlyWithdrawal3rdPillar")]
		public decimal EarlyWithdrawal3rdPillar { get; set; }
	}
}