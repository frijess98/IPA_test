using System.Collections.Generic;
using Qcentris.EventSourcing.Core.Messages;
using System.Threading.Tasks;
using SCE.ServicingPartnerInfoCheck.Contracts.Types;

namespace SCE.ServicingPartnerInfoCheck.Contracts.Abstracts
{
    /// <summary>
    /// Abstraction for info checking service
    /// </summary>
    public interface ISpInfoCheckService
    {
		/// <summary>
		/// Performs Info Checking
		/// </summary>
		/// <param name="entityWrapper">Entity to be checked</param>
		/// <returns></returns>
		Task<IExecutionResult> ProcessInfoCheckAsync(EntityWrapper entityWrapper);

		/// <summary>
		/// Fetch Data and store it
		/// </summary>
		/// <param name="entityWrapper"></param>
		/// <returns></returns>
		Task<IExecutionResult> FetchInfoChecksAsync(EntityWrapper entityWrapper);

		/// <summary>
		/// Get history of sent requests by
		/// </summary>
		/// <param name="requestId"></param>
		/// <returns></returns>
		List<ServicingPartnerInfoCheckEntity> GetProcessingHistoryById(string requestId);

        /// <summary>
        /// Checks whether suuccess request exist
        /// </summary>
        /// <param name="requestId"></param>
        /// <returns></returns>
        bool CheckIfSuccessfulCheckingExistsByRequestId(string requestId);
    }
}