using Newtonsoft.Json;

namespace SCE.ServicingPartnerInfoCheck.Contracts.Types.PostFinanceServicingPartner
{
	public class IncomeGeneratingProperties
	{
		[JsonProperty(PropertyName = "NetRentalIncome")]
		public int NetRentalIncome { get; set; }

		[JsonProperty(PropertyName = "IncomePropertyMortgage")]
		public int IncomePropertyMortgage { get; set; }

		[JsonProperty(PropertyName = "PostalCode")]
		public string PostalCode { get; set; }

		[JsonProperty(PropertyName = "Location")]
		public string Location { get; set; }

		[JsonProperty(PropertyName = "FiscalValue")]
		public int FiscalValue { get; set; }
	}
}