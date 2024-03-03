using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCE.ServicingPartnerInfoCheck.Contracts.Abstracts
{
    public interface ISpInfoCheckRepository
    {
        /// <summary>
        /// Generic Add
        /// </summary>
        /// <typeparam name="T">Type</typeparam>
        /// <param name="entity">Entity to be Added</param>
        /// <returns>Newly created entity</returns>
        T Add<T>(T entity) where T : class;

        /// <summary>
        /// Requests data provider for a record by identifier
        /// </summary>
        /// <typeparam name="T">Type</typeparam>
        /// <param name="id"></param>
        /// <returns>Returns record or null if record not found</returns>
        T Find<T>(int id) where T : class;

        /// <summary>
        /// Querying for the data
        /// </summary>
        /// <typeparam name="T">Type</typeparam>
        /// <returns></returns>
        IQueryable<T> Query<T>() where T : class;

        /// <summary>
        /// Removing entity
        /// </summary>
        /// <typeparam name="T">Type</typeparam>
        /// <param name="entity">Entity to remove</param>
        void Remove<T>(T entity) where T : class;

        /// <summary>
        /// Remove list of entities
        /// </summary>
        /// <typeparam name="T">Type</typeparam>
        /// <param name="entities">Entities to remove</param>
        void RemoveRange<T>(IEnumerable<T> entities) where T : class;

        /// <summary>
        /// Performs changes saving
        /// </summary>
        void SaveChanges();

        /// <summary>
        /// Async version of changes saving
        /// </summary>
        /// <returns></returns>
        Task SaveChangesAsync();
    }
}