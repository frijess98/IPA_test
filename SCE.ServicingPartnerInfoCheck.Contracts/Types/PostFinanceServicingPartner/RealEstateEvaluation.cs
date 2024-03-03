using Newtonsoft.Json;

namespace SCE.ServicingPartnerInfoCheck.Contracts.Types.PostFinanceServicingPartner
{
	public class RealEstateEvaluation
	{
		[JsonProperty(PropertyName = "PrimaryEvaluator")]
		public string PrimaryEvaluator { get; set; }

		[JsonProperty(PropertyName = "SecondaryEvaluator")]
		public string SecondaryEvaluator { get; set; }

		[JsonProperty(PropertyName = "PrimaryValuation")]
		public decimal PrimaryValuation { get; set; }

		[JsonProperty(PropertyName = "SecondaryValuation")]
		public string SecondaryValuation { get; set; }//null

		[JsonProperty(PropertyName = "PrimaryValuationAccuracy")]
		public string PrimaryValuationAccuracy { get; set; }

		[JsonProperty(PropertyName = "SecondaryValuationAccuracy")]
		public string SecondaryValuationAccuracy { get; set; }//null

		[JsonProperty(PropertyName = "PropertyValueTaken")]
		public decimal PropertyValueTaken { get; set; }

		[JsonProperty(PropertyName = "PropertyAccuracyTaken")]
		public string PropertyAccuracyTaken { get; set; }

		[JsonProperty(PropertyName = "PropertyValuationRule")]
		public string PropertyValuationRule { get; set; }
	}
}