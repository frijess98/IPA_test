using Newtonsoft.Json;

namespace SCE.ServicingPartnerInfoCheck.Contracts.Types.PostFinanceServicingPartner
{
	public class Mortgage
	{

		[JsonProperty(PropertyName = "NominalAmount")]
		public decimal NominalAmount { get; set; }

		[JsonProperty(PropertyName = "CurrentFinancing")]
		public CurrentFinancing CurrentFinancing { get; set; }

		[JsonProperty(PropertyName = "NewFinancing")]
		public NewFinancing NewFinancing { get; set; }

		[JsonProperty(PropertyName = "IsDebenturesExist")]
		public bool IsDebenturesExist { get; set; }

		[JsonProperty(PropertyName = "DisbursementAccount")]
		public string DisbursementAccount { get; set; }

		[JsonProperty(PropertyName = "InTheNameOf")]
		public string InTheNameOf { get; set; }

		[JsonProperty(PropertyName = "NumberOfDebentures")]
		public int NumberOfDebentures { get; set; }

		[JsonProperty(PropertyName = "Debentures")]
		public Debentures Debentures { get; set; }
	}
}