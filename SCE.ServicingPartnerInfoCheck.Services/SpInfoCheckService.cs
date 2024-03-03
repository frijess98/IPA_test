using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Qcentris.EventSourcing.Core.Messages;
using SCE.ServicingPartnerInfoCheck.Contracts.Abstracts;
using SCE.ServicingPartnerInfoCheck.Contracts.Types;

namespace SCE.ServicingPartnerInfoCheck.Services
{
    /// <summary>
    /// This Service Converting entity to export type and send the result to external service
    /// </summary>
    public class SpInfoCheckService : ISpInfoCheckService
	{
        private readonly IEnumerable<IInfoChecker> infoCheckers;
        private readonly ISpInfoCheckRepository spInfoCheckRepository;

        /// <summary>
        /// Cosntructor
        /// </summary>
        /// <param name="spInfoCheckRepository">Repository of SpInfoCheck</param>
        /// <param name="infoCheckers">List of InfoCheckers</param>
        public SpInfoCheckService(ISpInfoCheckRepository spInfoCheckRepository, params IInfoChecker[] infoCheckers)
        {;
            this.infoCheckers = infoCheckers;
            this.spInfoCheckRepository = spInfoCheckRepository;
        }

        #region public methods
        /// <summary>
        /// Checks whether there is an successful response in the history
        /// </summary>
        /// <param name="requestId">Request Id in this context = Offer Id</param>
        /// <returns>True if Exist, False if not</returns>
        public bool CheckIfSuccessfulCheckingExistsByRequestId(string requestId)
            => (spInfoCheckRepository
              .Query<ServicingPartnerInfoCheckEntity>()
              .FirstOrDefault(x => x.RequestId == requestId && x.IsSuccessful) != null);

        /// <summary>
        /// Extract history of requests for specific Request Id
        /// </summary>
        /// <param name="requestId">Request Id in this context = Offer Id</param>
        /// <returns>List Requests</returns>
        public List<ServicingPartnerInfoCheckEntity> GetProcessingHistoryById(string requestId)
            => spInfoCheckRepository
              .Query<ServicingPartnerInfoCheckEntity>()
              .Where(x => x.RequestId == requestId)
              .OrderByDescending(x => x.CreationDate)
              .ToList();

		/// <summary>
		/// Fetch data from the servicing partner
		/// </summary>
		/// <param name="entityWrapper">Request object</param>
		/// <returns>Success or fail</returns>
		public Task<IExecutionResult> FetchInfoChecksAsync(EntityWrapper entityWrapper) 
            => GetInfoChecker(entityWrapper.Infocchecker)
              .FetchAsync(entityWrapper.Entity);

		/// <summary>
		/// ProcessInfoCheckAsync
		/// </summary>
		/// <param name="entityWrapper">
		///  Entity which is going to be mapped and sent to external service
		/// </param>
		/// <returns>Response from the external service</returns>
		public Task<IExecutionResult> ProcessInfoCheckAsync(EntityWrapper entityWrapper) 
            => GetInfoChecker(entityWrapper.Infocchecker)
              .CheckAsync(entityWrapper.Entity);
        #endregion

        #region private methods
        private IInfoChecker GetInfoChecker(string infoCheckServicingPartnerKey)
        {
            var ic = infoCheckers.FirstOrDefault(x => string.Equals(x.ServicingPartner, infoCheckServicingPartnerKey, StringComparison.OrdinalIgnoreCase));

			if (ic == null)
            {
                throw new Exception("Partner not found");
            }

            return ic;
        }
        #endregion
    }
}
