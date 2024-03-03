using System.Threading.Tasks;
using Qcentris.EventSourcing.Core.Messages;

namespace SCE.ServicingPartnerInfoCheck.Contracts.Abstracts
{
    /// <summary>
    /// Abstraction for infochecker
    /// </summary>
    public interface IInfoChecker
    {
        /// <summary>
        /// Key of the servicing partner
        /// </summary>
        string ServicingPartner { get; }

        /// <summary>
        /// Performs info checking
        /// </summary>
        /// <param name="entity">Entity to be checked</param>
        /// <returns></returns>
        Task<IExecutionResult> CheckAsync(object entity);

        /// <summary>
        /// Fetch data from provider and store it
        /// </summary>
        /// <param name="requestDto">Request object</param>
        /// <returns>Success or fail</returns>
        Task<IExecutionResult> FetchAsync(object requestDto);
    }
}