using System;
using System.Collections.Generic;

namespace SCE.ServicingPartnerInfoCheck.Contracts.Dtos.Errors
{
    /// <summary>
    /// SendOfferExportSpInfoCheck error message model
    /// </summary>
    public class SendOfferExportSpInfoCheckErrorMessage
    {
        /// <summary>
        /// MessageId
        /// </summary>
        public string MessageId { get; set; }

        /// <summary>
        /// Timestamp when error occurred
        /// </summary>
        public DateTime Timestamp { get; set; }

        /// <summary>
        /// Current qind of error
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// List of fields with detail error information
        /// </summary>
        public List<ErrorFieldDetailInfo> Fields { get; set; } = new List<ErrorFieldDetailInfo>();
    }
}
