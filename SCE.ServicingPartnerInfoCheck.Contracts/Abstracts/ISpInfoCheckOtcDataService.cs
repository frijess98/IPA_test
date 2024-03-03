using System.Threading.Tasks;
using Qcentris.EventSourcing.Core.Messages;
using SCE.ServicingPartnerInfoCheck.Contracts.Dtos.GlkbServicingPartner;

namespace SCE.ServicingPartnerInfoCheck.Contracts.Abstracts
{
    /// <summary>
    /// 
    /// </summary>
    public interface ISpInfoCheckOtcDataService
    {
        /// <summary>
        /// Get list of Otc items
        /// </summary>
        /// <returns>Otc items wrapped in IExecutionResult</returns>
        Task<IExecutionResult> GetOtcItemsAsync();

        /// <summary>
        /// Get Otc item
        /// </summary>
        /// <param name="otcRequestDto">Request object</param>
        /// <returns>Otc item wrapped in IExecutionResult</returns>
        Task<IExecutionResult> GetOtcItemAsync(OtcRequestDto otcRequestDto);
    }
}