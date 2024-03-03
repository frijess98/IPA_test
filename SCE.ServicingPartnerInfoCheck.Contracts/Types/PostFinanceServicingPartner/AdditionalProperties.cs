using System.Collections.Generic;
using Newtonsoft.Json;

namespace SCE.ServicingPartnerInfoCheck.Contracts.Types.PostFinanceServicingPartner
{
	public class AdditionalProperties
	{
		[JsonProperty(PropertyName = "NumberOfHolidayHomes")]
		public int NumberOfHolidayHomes { get; set; }

		[JsonProperty(PropertyName = "HolidayHome")]
		public List<HolidayHome> HolidayHome { get; set; }

		[JsonProperty(PropertyName = "NumberOfIncomeGeneratingProperties")]
		public int NumberOfIncomeGeneratingProperties { get; set; }

		[JsonProperty(PropertyName = "IncomeGeneratingProperties")]
		public List<IncomeGeneratingProperties> IncomeGeneratingProperties { get; set; }
	}
}