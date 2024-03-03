using System;
using Newtonsoft.Json;

namespace SCE.ServicingPartnerInfoCheck.Contracts.Types.PostFinanceServicingPartner
{
	public class Tranche
	{
		[JsonProperty(PropertyName = "Amount")]
		public int Amount { get; set; }

		[JsonProperty(PropertyName = "Date")]
		public DateTime Date { get; set; }

		[JsonProperty(PropertyName = "CreditInstitution")]
		public string CreditInstitution { get; set; }

		[JsonProperty(PropertyName = "ContactPerson")]
		public string ContactPerson { get; set; }
	}
}