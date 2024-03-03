using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Qcentris.EventSourcing.Core.Messages;
using SCE.ServicingPartnerInfoCheck.Contracts.Abstracts;
using SCE.ServicingPartnerInfoCheck.Contracts.Constants;
using SCE.ServicingPartnerInfoCheck.Contracts.Dtos.GlkbServicingPartner;
using SCE.ServicingPartnerInfoCheck.Contracts.Dtos.Otc;
using SCE.ServicingPartnerInfoCheck.Contracts.Types;

namespace SCE.ServicingPartnerInfoCheck.Services
{
    /// <summary>
    /// Data providing service
    /// </summary>
    public class SpInfoCheckOtcDataService : ISpInfoCheckOtcDataService
    {
        private readonly ISpInfoCheckRepository spInfoCheckRepository;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="spInfoCheckRepository">Repository to access data</param>
        public SpInfoCheckOtcDataService(ISpInfoCheckRepository spInfoCheckRepository)
        {
            this.spInfoCheckRepository = spInfoCheckRepository;
        }

        /// <summary>
        /// Get list of Otc items
        /// </summary>
        /// <returns>Otc items wrapped in IExecutionResult</returns>
        public Task<IExecutionResult> GetOtcItemsAsync()
        {
            var dbEntries = spInfoCheckRepository
                .Query<ServicingPartnerInfoCheckEntity>()
                .Where(x => x.ModelType == SpInfoCheckResponseTypes.FinancingReadResponse)
                .OrderByDescending(x => x.CreationDate)
                .ToList();

            var list = dbEntries
                .Select(x => JsonConvert.DeserializeObject<OtcRootDto>(x.ResponseJSON))
                .ToList();

            return Task.FromResult((IExecutionResult)new ExecutionResult<List<OtcRootDto>>(list));
        }

        /// <summary>
        /// Get Otc item
        /// </summary>
        /// <param name="otcRequestDto">Request object</param>
        /// <returns>Otc item wrapped in IExecutionResult</returns>
        public Task<IExecutionResult> GetOtcItemAsync(OtcRequestDto otcRequestDto)
        {
            var dbEntry = spInfoCheckRepository
                .Query<ServicingPartnerInfoCheckEntity>()
                .FirstOrDefault(x => x.ModelType == SpInfoCheckResponseTypes.FinancingReadResponse && x.ServicingPartnerKey == otcRequestDto.Id);

            if (dbEntry != null)
            {
                var item = JsonConvert.DeserializeObject<OtcRootDto>(dbEntry.ResponseJSON);

                return Task.FromResult((IExecutionResult)new ExecutionResult<OtcRootDto>(item));
            }

            throw new Exception($"ServicingPartnerInfoCheckEntity is not found. ServicingPartnerKey = {otcRequestDto.Id}");
        }
    }
}
