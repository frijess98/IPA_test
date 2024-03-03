using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using SCE.ServicingPartnerInfoCheck.Contracts.Types.PostFinanceServicingPartner.Enums;

namespace SCE.ServicingPartnerInfoCheck.Contracts.Types.PostFinanceServicingPartner
{
	public class Financing
	{
		[JsonProperty(PropertyName = "DistributionPartner")]
		public string DistributionPartner { get; set; }

		[JsonProperty(PropertyName = "DistributionPartnerId")]
		public int DistributionPartnerId { get; set; }

		[JsonProperty(PropertyName = "TeamId")]
		public int TeamId { get; set; }

		[JsonProperty(PropertyName = "InternalTeamId")]
		public string InternalTeamId { get; set; }

		[JsonProperty(PropertyName = "InternalUserId")]
		public string InternalUserId { get; set; }

		[JsonProperty(PropertyName = "UserId")]
		public int UserId { get; set; }

		[JsonProperty(PropertyName = "InternalLeadId")]
		public string InternalLeadId { get; set; }//null

		[JsonProperty(PropertyName = "MultiServicerCaseUUID")]
		public string MultiServicerCaseUUID { get; set; }

		[JsonProperty(PropertyName = "MultiServicerRoles")]
		public List<MultiServicerRole> MultiServicerRoles { get; set; }

		[JsonProperty(PropertyName = "OriginatorUserId")]
		public string OriginatorUserId { get; set; }

		[JsonProperty(PropertyName = "OriginatorTeamId")]
		public string OriginatorTeamId { get; set; }

		[JsonProperty(PropertyName = "OriginatorInternalTeamId")]
		public string OriginatorInternalTeamId { get; set; }

		[JsonProperty(PropertyName = "OriginatorInternalUserId")]
		public string OriginatorInternalUserId { get; set; }

		[JsonProperty(PropertyName = "PeriodicControlDate")]
		public DateTime PeriodicControlDate { get; set; }

		[JsonProperty(PropertyName = "ManualIntervention")]
		public bool ManualIntervention { get; set; }

		[JsonProperty(PropertyName = "InvestorDetails")]
		public List<InvestorDetail> InvestorDetails { get; set; }

		[JsonProperty(PropertyName = "Borrowers")]
		public Borrower Borrowers { get; set; }

		[JsonProperty(PropertyName = "DuTxRef")]
		public string DuTxRef { get; set; }

		[JsonProperty(PropertyName = "InvTxRef")]
		public string InvTxRef { get; set; }

		[JsonProperty(PropertyName = "LastDataUpdateTimestamp")]
		public DateTime LastDataUpdateTimestamp { get; set; }

		[JsonProperty(PropertyName = "OfferId")]
		public int OfferId { get; set; }

		[JsonProperty(PropertyName = "WorkflowType")]
		public WorkflowTypes WorkflowType { get; set; }

		[JsonProperty(PropertyName = "Status")]
		public string Status { get; set; }

		[JsonProperty(PropertyName = "OfferType")]
		public OfferTypes OfferType { get; set; }

		[JsonProperty(PropertyName = "TransactionType")]
		public TransactionTypes TransactionType { get; set; }

		[JsonProperty(PropertyName = "MortgageRequestOpened")]
		public DateTime MortgageRequestOpened { get; set; }

		[JsonProperty(PropertyName = "OfferCreated")]
		public DateTime OfferCreated { get; set; }

		[JsonProperty(PropertyName = "OfferRejected")]
		public string OfferRejected { get; set; }//null

		[JsonProperty(PropertyName = "ContractGenerated")]
		public DateTime ContractGenerated { get; set; }

		[JsonProperty(PropertyName = "OfferExpired")]
		public string OfferExpired { get; set; }//null

		[JsonProperty(PropertyName = "SubmittedToInfoCheck")]
		public DateTime SubmittedToInfoCheck { get; set; }

		[JsonProperty(PropertyName = "InfoCheckCompleted")]
		public DateTime InfoCheckCompleted { get; set; }

		[JsonProperty(PropertyName = "SettlementProcessingInitiated")]
		public DateTime SettlementProcessingInitiated { get; set; }

		[JsonProperty(PropertyName = "SettlementCompleted")]
		public string SettlementCompleted { get; set; }//null

		[JsonProperty(PropertyName = "ClientInDefault")]
		public string ClientInDefault { get; set; }//null

		[JsonProperty(PropertyName = "ClientInRecovery")]
		public string ClientInRecovery { get; set; }//null

		[JsonProperty(PropertyName = "MortgageReplaced")]
		public string MortgageReplaced { get; set; }//null

		[JsonProperty(PropertyName = "LastStatusChange")]
		public DateTime LastStatusChange { get; set; }

		[JsonProperty(PropertyName = "Property")]
		public Property Property { get; set; }

		[JsonProperty(PropertyName = "AdditionalProperties")]
		public AdditionalProperties AdditionalProperties { get; set; }

		[JsonProperty(PropertyName = "RealEstateEvaluation")]
		public RealEstateEvaluation RealEstateEvaluation { get; set; }

		[JsonProperty(PropertyName = "Mortgage")]
		public Mortgage Mortgage { get; set; }

		[JsonProperty(PropertyName = "Comments")]
		public List<Comment> Comments { get; set; }
	}
}