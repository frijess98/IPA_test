using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SCE.ServicingPartnerInfoCheck.Contracts.Abstracts;

namespace SCE.ServicingPartnerInfoCheck.DAL
{
    /// <summary>
    /// Repository for data accessing
    /// </summary>
    public class SpInfoCheckRepository : ISpInfoCheckRepository
    {
        /// <summary>
        /// Bounded context reference 
        /// </summary>
        protected readonly SpInfoCheckContext Context;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context">Bounded context</param>
        public SpInfoCheckRepository(SpInfoCheckContext context)
        {
            this.Context = context;
        }

        /// <summary>
        /// Generic Add
        /// </summary>
        /// <typeparam name="T">Type</typeparam>
        /// <param name="entity">Entity to be Added</param>
        /// <returns>Newly created entity</returns>
        public T Add<T>(T entity) where T : class =>
            Context.Set<T>().Add(entity).Entity;

        /// <summary>
        /// Requests data provider for a record by identifier
        /// </summary>
        /// <typeparam name="T">Type</typeparam>
        /// <param name="id"></param>
        /// <returns>Returns record or null if record not found</returns>
        public T Find<T>(int id) where T : class =>
            Context.Set<T>().Find(id);

        /// <summary>
        /// Querying for the data
        /// </summary>
        /// <typeparam name="T">Type</typeparam>
        /// <returns></returns>
        public IQueryable<T> Query<T>() where T : class =>
            Context.Set<T>();

        /// <summary>
        /// Removing entity
        /// </summary>
        /// <typeparam name="T">Type</typeparam>
        /// <param name="entity">Entity to remove</param>
        public void Remove<T>(T entity) where T : class
        {
            Context.Set<T>().Remove(entity);
        }

        /// <summary>
        /// Remove list of entities
        /// </summary>
        /// <typeparam name="T">Type</typeparam>
        /// <param name="entities">Entities to remove</param>
        public void RemoveRange<T>(IEnumerable<T> entities) where T : class
        {
            Context.Set<T>().RemoveRange(entities);
        }

        /// <summary>
        /// Performs changes saving
        /// </summary>
        public void SaveChanges() =>
            Context.SaveChanges();

        /// <summary>
        /// Async version of changes saving
        /// </summary>
        /// <returns></returns>
        public Task SaveChangesAsync() =>
            Context.SaveChangesAsync();
    }
}
