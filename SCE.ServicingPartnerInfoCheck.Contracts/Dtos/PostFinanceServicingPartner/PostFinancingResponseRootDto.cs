using SCE.ServicingPartnerInfoCheck.Contracts.Types.PostFinanceServicingPartner;
using System;
using System.Collections.Generic;

namespace SCE.ServicingPartnerInfoCheck.Contracts.Dtos.PostFinanceServicingPartner
{
	public class PostFinancingResponseRootDto
	{

		public string Currency { get; set; }

		/// <summary>
		/// List of items with Offers details
		/// </summary>
		public List<Financing> OffersDetails { get; set; }

		/// <summary>
		/// ErrorMessages
		/// </summary>
		public bool SuccessfulRequest { get; set; }

		/// <summary>
		/// Time stamp
		/// </summary>
		public DateTime Timestamp { get; set; }
	}
}