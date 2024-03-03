using System.Collections.Generic;
using SCE.ServicingPartnerInfoCheck.Contracts.Types.GLKBServicingPartner;

namespace SCE.ServicingPartnerInfoCheck.Contracts.Dtos.GlkbServicingPartner
{
    /// <summary>
    /// Root Dto for Financing Response
    /// </summary>
    public class FinancingResponseRootDto
    {
        /// <summary>
        /// List of items with response data
        /// </summary>
        public List<Financing> Content { get; set; }

        /// <summary>
        /// Number of items in current response
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// Number of items in total
        /// </summary>
        public int TotalCount { get; set; }
    }
}
