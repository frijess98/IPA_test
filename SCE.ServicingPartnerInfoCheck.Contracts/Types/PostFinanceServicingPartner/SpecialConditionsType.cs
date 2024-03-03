using Newtonsoft.Json;

namespace SCE.ServicingPartnerInfoCheck.Contracts.Types.PostFinanceServicingPartner
{
	public class SpecialConditionsType
	{
		[JsonProperty(PropertyName = "EmployeeDiscount")]
		public bool EmployeeDiscount { get; set; } = false;
	}
}