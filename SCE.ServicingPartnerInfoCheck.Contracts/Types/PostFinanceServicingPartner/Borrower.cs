using System.Collections.Generic;
using Newtonsoft.Json;

namespace SCE.ServicingPartnerInfoCheck.Contracts.Types.PostFinanceServicingPartner
{
	public class Borrower
	{
		[JsonProperty(PropertyName = "InternalClientGroupId")]
		public string InternalClientGroupId { get; set; }//null

		[JsonProperty(PropertyName = "BorrowersDetails")]
		public List<BorrowersDetail> BorrowersDetails { get; set; }
	}
}