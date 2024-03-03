using System.Threading.Tasks;

namespace SCE.ServicingPartnerInfoCheck.Contracts.Abstracts
{
    /// <summary>
    /// Abstraction for Specific InfoChecker
    /// </summary>
    public interface ISpInfoCheckerMapper
    {
        /// <summary>
        /// Represents Mapper Partner Key
        /// </summary>
        string SpInfoCheckPartnerKey { get; }

        /// <summary>
        /// Performs mapping
        /// </summary>
        /// <param name="application">Application to map</param>
        /// <returns></returns>
        Task<RequestExportBase> Map(object application);
    }
}