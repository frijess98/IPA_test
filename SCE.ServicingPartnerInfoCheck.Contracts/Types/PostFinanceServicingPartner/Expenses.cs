using Newtonsoft.Json;

namespace SCE.ServicingPartnerInfoCheck.Contracts.Types.PostFinanceServicingPartner
{
	public class Expenses
	{
		[JsonProperty(PropertyName = "AlimonyObligations")]
		public decimal AlimonyObligations { get; set; }

		[JsonProperty(PropertyName = "InstallmentsConsumerLoansLeasing")]
		public decimal InstallmentsConsumerLoansLeasing { get; set; }

		[JsonProperty(PropertyName = "InstallmentsLoansWithThirdParties")]
		public decimal InstallmentsLoansWithThirdParties { get; set; }

		[JsonProperty(PropertyName = "OtherRegularCommitments")]
		public decimal OtherRegularCommitments { get; set; }

		[JsonProperty(PropertyName = "ContingentLiabilitiesguarantees")]
		public decimal ContingentLiabilitiesguarantees { get; set; }

		[JsonProperty(PropertyName = "OtherDebts")]
		public decimal OtherDebts { get; set; }
	}
}