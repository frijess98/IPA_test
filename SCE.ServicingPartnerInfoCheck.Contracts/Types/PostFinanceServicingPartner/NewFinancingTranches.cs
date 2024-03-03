using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using SCE.ServicingPartnerInfoCheck.Contracts.Types.PostFinanceServicingPartner.Enums;

namespace SCE.ServicingPartnerInfoCheck.Contracts.Types.PostFinanceServicingPartner
{
	public class NewFinancingTranches
	{
		[JsonProperty(PropertyName = "IsTrancheIncrease")]
		public bool IsTrancheIncrease { get; set; }

		[JsonProperty(PropertyName = "ToBePaidOutToCustomers")]
		public int ToBePaidOutToCustomers { get; set; }

		[JsonProperty(PropertyName = "TrancheId")]
		public int TrancheId { get; set; }

		[JsonProperty(PropertyName = "ProductType")]
		public ProductType ProductType { get; set; }

		[JsonProperty(PropertyName = "DayCountConvention")]
		public string DayCountConvention { get; set; }

		[JsonProperty(PropertyName = "TypeOfInvoice")]
		public TypeOfInvoice TypeOfInvoice { get; set; }

		[JsonProperty(PropertyName = "InterestPaymentPeriodicity")]
		public string InterestPaymentPeriodicity { get; set; }

		[JsonProperty(PropertyName = "FirstInterestPaymentDate")]
		public DateTime FirstInterestPaymentDate { get; set; }

		[JsonProperty(PropertyName = "Amount")]
		public int Amount { get; set; }

		[JsonProperty(PropertyName = "TrancheLimit")]
		public int TrancheLimit { get; set; }

		[JsonProperty(PropertyName = "DisbursementOfTheTranche")]
		public DateTime DisbursementOfTheTranche { get; set; }

		[JsonProperty(PropertyName = "TrancheStatus")]
		public TrancheStatus TrancheStatus { get; set; }

		[JsonProperty(PropertyName = "Duration")]
		public decimal Duration { get; set; }

		[JsonProperty(PropertyName = "InterestRate")]
		public decimal InterestRate { get; set; }

		[JsonProperty(PropertyName = "GrossInterestRateYearly")]
		public decimal GrossInterestRateYearly { get; set; }

		[JsonProperty(PropertyName = "SpecialConditions")]
		public string SpecialConditions { get; set; }//null

		[JsonProperty(PropertyName = "SpecialConditionsType")]
		public List<SpecialConditionsType> SpecialConditionsType { get; set; }

		[JsonProperty(PropertyName = "MarginRate")]
		public string MarginRate { get; set; }//null

		[JsonProperty(PropertyName = "ExpiryDate")]
		public DateTime ExpiryDate { get; set; }

		[JsonProperty(PropertyName = "NumberOfAmortizationEntries")]
		public int NumberOfAmortizationEntries { get; set; }
	}
}