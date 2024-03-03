using Newtonsoft.Json;

namespace SCE.ServicingPartnerInfoCheck.Contracts.Types.PostFinanceServicingPartner
{
	public class Debentures
	{
		[JsonProperty(PropertyName = "DebentureId")]
		public int DebentureId { get; set; }

		[JsonProperty(PropertyName = "IssuedTo")]
		public string IssuedTo { get; set; }

		[JsonProperty(PropertyName = "Kind")]
		public string Kind { get; set; }

		[JsonProperty(PropertyName = "AmountInPreviousRank")]
		public decimal AmountInPreviousRank { get; set; }

		[JsonProperty(PropertyName = "NominalAmount")]
		public decimal NominalAmount { get; set; }

		[JsonProperty(PropertyName = "Rank")]
		public decimal Rank { get; set; }

		[JsonProperty(PropertyName = "LandRegistry")]
		public string LandRegistry { get; set; }

		[JsonProperty(PropertyName = "LandRegistryNumber")]
		public string LandRegistryNumber { get; set; }
	}
}