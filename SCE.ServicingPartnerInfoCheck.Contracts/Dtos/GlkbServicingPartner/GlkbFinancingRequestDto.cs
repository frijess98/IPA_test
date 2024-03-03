using System;

namespace SCE.ServicingPartnerInfoCheck.Contracts.Dtos.GlkbServicingPartner
{
    /// <summary>
    /// Request Dto 
    /// </summary>
    public class GlkbFinancingRequestDto
    {
        /// <summary>
        /// Start date
        /// </summary>
        public DateTime? DateStart { get; set; }

        /// <summary>
        /// End date
        /// </summary>
        public DateTime? DateEnd { get; set; }

        /// <summary>
        /// If true - provides all possible properties
        /// </summary>
        public bool IsExpanded { get; set; } = true;

        /// <summary>
        /// Items to take per request 
        /// </summary>
        public int Take { get; set; }

        /// <summary>
        /// Provide limit to the service or not
        /// </summary>
        public bool AttachLimit { get; set; }
    }
}
