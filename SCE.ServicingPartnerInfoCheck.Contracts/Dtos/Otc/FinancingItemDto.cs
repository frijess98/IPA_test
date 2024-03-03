using System;
using Newtonsoft.Json;

namespace SCE.ServicingPartnerInfoCheck.Contracts.Dtos.Otc
{
    /// <summary>
    /// Otc Financing Dto
    /// </summary>
    public class FinancingItemDto
    {
        /// <summary>
        /// Financing key
        /// </summary>
        [JsonProperty("finanzierungsNr")]
        public string ServicingPartnerKey { get; set; }

        /// <summary>
        /// Offer Id in special format
        /// </summary>
        [JsonProperty("offerId")]
        public string OutsourcedRequestId { get; set; }

        /// <summary>
        /// Request Id for matching
        /// </summary>
        [JsonProperty("requestId")]
        public string OtcRequestId { get; set; }

        /// <summary>
        /// Mortgage amount
        /// </summary>
        [JsonProperty("rahmenlimite")]
        public decimal MortgageAmount { get; set; }

        /// <summary>
        /// Investor / mandant
        /// </summary>
        [JsonProperty("mandant")]
        public string Investor { get; set; }

        /// <summary>
        /// Date of creation
        /// </summary>
        [JsonProperty("creationDate")]
        public DateTime CreationDate { get; set; }
    }
}
