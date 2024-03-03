using Newtonsoft.Json;

namespace SCE.ServicingPartnerInfoCheck.Contracts.Types.PostFinanceServicingPartner
{
	public class IncomeAssets
	{
		[JsonProperty(PropertyName = "SelfEmploymentIncome")]
		public decimal SelfEmploymentIncome { get; set; }

		[JsonProperty(PropertyName = "GrossEarningExclusiveBonus")]
		public decimal GrossEarningExclusiveBonus { get; set; }

		[JsonProperty(PropertyName = "VariableIncome")]
		public decimal? VariableIncome { get; set; }

		[JsonProperty(PropertyName = "AlimonyIncome")]
		public decimal? AlimonyIncome { get; set; }

		[JsonProperty(PropertyName = "OtherRegularIncome")]
		public decimal? OtherRegularIncome { get; set; }

		[JsonProperty(PropertyName = "ExpectedBVGIncome")]
		public decimal ExpectedBVGIncome { get; set; }

		[JsonProperty(PropertyName = "RentalIncome")]
		public decimal? RentalIncome { get; set; }

		[JsonProperty(PropertyName = "PensionIncome")]
		public decimal PensionIncome { get; set; }

		[JsonProperty(PropertyName = "OtherAssets")]
		public decimal? OtherAssets { get; set; }

		[JsonProperty(PropertyName = "ConsideredAssets")]
		public string ConsideredAssets { get; set; }//null

		[JsonProperty(PropertyName = "IGPConcideredIncome")]
		public string IGPConcideredIncome { get; set; }//null

		[JsonProperty(PropertyName = "ExpectedBVGPensionLumpSumPayment")]
		public decimal ExpectedBVGPensionLumpSumPayment { get; set; }
	}
}