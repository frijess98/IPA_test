using System.Collections.Generic;

namespace SCE.ServicingPartnerInfoCheck.Contracts.Dtos.Otc
{
    /// <summary>
    /// Root object for Otc
    /// </summary>
    public class OtcRootDto
    {
        /// <summary>
        ///  Financing
        /// </summary>
        public FinancingItemDto Financing { get; set; }

        /// <summary>
        ///  List of Otc Tranches
        /// </summary>
        public List<TrancheItemDto> Tranches { get; set; }

        /// <summary>
        /// List of Otc Applicants
        /// </summary>
        public List<ApplicantItemDto> Applicants { get; set; }
    }
}
