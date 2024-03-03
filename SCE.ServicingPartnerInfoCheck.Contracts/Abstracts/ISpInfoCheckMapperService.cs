using System.Threading.Tasks;

namespace SCE.ServicingPartnerInfoCheck.Contracts.Abstracts
{
    /// <summary>
    /// Abstraction for decoupling mapper implementation and mapper logic
    /// </summary>
    public interface ISpInfoCheckMapperService
    {
        /// <summary>
        /// Performs mapping
        /// </summary>
        /// <param name="entity">Entity to be mapped</param>
        /// <returns></returns>
        Task<RequestExportBase> MapModel(object entity);
    }
}