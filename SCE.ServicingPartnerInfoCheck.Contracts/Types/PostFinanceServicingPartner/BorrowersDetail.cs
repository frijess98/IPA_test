using Newtonsoft.Json;

namespace SCE.ServicingPartnerInfoCheck.Contracts.Types.PostFinanceServicingPartner
{
	public class BorrowersDetail
	{
		[JsonProperty(PropertyName = "GeneralInformation")]
		public GeneralInformation GeneralInformation { get; set; }

		[JsonProperty(PropertyName = "AdditionalCollateral")]
		public AdditionalCollateral AdditionalCollateral { get; set; }

		[JsonProperty(PropertyName = "SelfEmployed")]
		public bool SelfEmployed { get; set; }

		[JsonProperty(PropertyName = "DebtRecoveryActions")]
		public bool DebtRecoveryActions { get; set; }

		[JsonProperty(PropertyName = "IsLegalPerson")]
		public bool IsLegalPerson { get; set; }

		[JsonProperty(PropertyName = "IsUSTaxLiableOrUSCitizen")]
		public bool IsUSTaxLiableOrUSCitizen { get; set; }

		[JsonProperty(PropertyName = "IncomeAssets")]
		public IncomeAssets IncomeAssets { get; set; }

		[JsonProperty(PropertyName = "Expenses")]
		public Expenses Expenses { get; set; }

		[JsonProperty(PropertyName = "OwnFunds")]
		public OwnFunds OwnFunds { get; set; }
	}
}