using System;
using Newtonsoft.Json;

namespace SCE.ServicingPartnerInfoCheck.Contracts.Types.PostFinanceServicingPartner
{
	public class HolidayHome
	{
		[JsonProperty(PropertyName = "Country3LetterCode")]
		public string Country3LetterCode { get; set; }

		[JsonProperty(PropertyName = "FiscalValue")]
		public int FiscalValue { get; set; }

		[JsonProperty(PropertyName = "Street")]
		public string Street { get; set; }

		[JsonProperty(PropertyName = "Number")]
		public string Number { get; set; }

		[JsonProperty(PropertyName = "PostalCode")]
		public string PostalCode { get; set; }

		[JsonProperty(PropertyName = "PurchaseDate")]
		public DateTime PurchaseDate { get; set; }

		[JsonProperty(PropertyName = "ConstructionYear")]
		public int ConstructionYear { get; set; }

		[JsonProperty(PropertyName = "HasHolidayHomeMortgage")]
		public bool HasHolidayHomeMortgage { get; set; }

		[JsonProperty(PropertyName = "HolidayHomeMortgageAmount")]
		public int HolidayHomeMortgageAmount { get; set; }
	}
}