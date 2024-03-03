using System;
using Newtonsoft.Json;
using SCE.ServicingPartnerInfoCheck.Contracts.Types.PostFinanceServicingPartner.Enums;

namespace SCE.ServicingPartnerInfoCheck.Contracts.Types.PostFinanceServicingPartner
{
	public class Insurance
	{
		[JsonProperty(PropertyName = "InsuranceId")]
		public int InsuranceId { get; set; }

		[JsonProperty(PropertyName = "InsuranceType")]
		public InsuranceTypes InsuranceType { get; set; }

		[JsonProperty(PropertyName = "ExistingInsurancePolicy")]
		public bool ExistingInsurancePolicy { get; set; }

		[JsonProperty(PropertyName = "IsReferenceNumberKnown")]
		public bool IsReferenceNumberKnown { get; set; }

		[JsonProperty(PropertyName = "Company")]
		public string Company { get; set; }

		[JsonProperty(PropertyName = "CashSurrenderValue")]
		public decimal CashSurrenderValue { get; set; }

		[JsonProperty(PropertyName = "ReferenceNumber")]
		public string ReferenceNumber { get; set; }

		[JsonProperty(PropertyName = "FundBased")]
		public bool FundBased { get; set; }

		[JsonProperty(PropertyName = "ExpiryDate")]
		public DateTime ExpiryDate { get; set; }
	}
}