using Newtonsoft.Json;

namespace SCE.ServicingPartnerInfoCheck.Contracts.Types.PostFinanceServicingPartner
{
	public class Comment
	{
		[JsonProperty(PropertyName = "Author")]
		public string Author { get; set; }

		[JsonProperty(PropertyName = "Text")]
		public string Text { get; set; }
	}
}