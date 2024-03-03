using System;
using Newtonsoft.Json;

namespace SCE.ServicingPartnerInfoCheck.Contracts.Dtos.Otc
{
    /// <summary>
    /// Otc Tranche Dto
    /// </summary>
    public class TrancheItemDto
    {
        /// <summary>
        /// Account Number
        /// </summary>
        [JsonProperty("kontoNr")]
        public int? AccountNumber { get; set; }

        /// <summary>
        /// Condition number
        /// </summary>
        [JsonProperty("konditionNr")]
        public int? ConditionNumber { get; set; }

        /// <summary>
        /// Tranche Id 
        /// </summary>
        [JsonProperty("tranchenId")]
        public string ContractNumber { get; set; }

        /// <summary>
        /// Product / mandant
        /// </summary>
        [JsonProperty("mandant")]
        public string Product { get; set; }

        /// <summary>
        /// Currenct. CHF by default
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; } = "CHF";

        /// <summary>
        /// Tranche amount
        /// </summary>
        [JsonProperty("saldo")]
        public decimal Amount { get; set; }

        /// <summary>
        /// Start date
        /// </summary>
        [JsonProperty("laufzeitVon")]
        public string DurationStart { get; set; }

        /// <summary>
        /// End date
        /// </summary>
        [JsonProperty("laufzeitBis")]
        public string DurationEnd { get; set; }

        /// <summary>
        /// Final Interest Rate: sum of all interest rates including discount
        /// </summary>
        [JsonProperty("kundenZins")]
        public decimal InterestRate { get; set; }

        /// <summary>
        /// Valid after
        /// </summary>
        [JsonProperty(PropertyName = "gueltigNach")]
        public DateTime ValidAfter { get; set; }
    }
}
