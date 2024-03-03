using Newtonsoft.Json;

namespace SCE.ServicingPartnerInfoCheck.Contracts.Types.PostFinanceServicingPartner
{
	public class InvestorDetail
	{
		[JsonProperty(PropertyName = "InvestorPartner")]
		public string InvestorPartner { get; set; }

		[JsonProperty(PropertyName = "InvestorPartnerId")]
		public int InvestorPartnerId { get; set; }

		[JsonProperty(PropertyName = "NetLtv")]
		public decimal NetLtv { get; set; }

		[JsonProperty(PropertyName = "GrossLtv")]
		public decimal GrossLtv { get; set; }

		[JsonProperty(PropertyName = "PropertyValueUsed")]
		public decimal PropertyValueUsed { get; set; }

		[JsonProperty(PropertyName = "Rating")]
		public int Rating { get; set; }

		[JsonProperty(PropertyName = "Affordability")]
		public decimal Affordability { get; set; }

		[JsonProperty(PropertyName = "AffordabilityInAge")]
		public int? AffordabilityInAge { get; set; }//null

		[JsonProperty(PropertyName = "InvestorPortfolioCode")]
		public string InvestorPortfolioCode { get; set; }

		[JsonProperty(PropertyName = "InvestorPortfolioID")]
		public string InvestorPortfolioID { get; set; }
	}
}