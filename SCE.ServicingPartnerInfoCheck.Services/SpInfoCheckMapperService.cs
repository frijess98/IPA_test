using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SCE.ServicingPartnerInfoCheck.Contracts.Abstracts;

namespace SCE.ServicingPartnerInfoCheck.Services
{
    /// <summary>
    /// This service is responsible on mapping
    /// </summary>
    public class SpInfoCheckMapperService : ISpInfoCheckMapperService
    {
        private readonly IList<ISpInfoCheckerMapper> infoCheckMappers;
        private readonly InfoCheckSettings infoCheckSettings;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="infoCheckSettings">Settings</param>
        /// <param name="infoCheckMappers">List of InfoCheckers</param>
        public SpInfoCheckMapperService(InfoCheckSettings infoCheckSettings, params ISpInfoCheckerMapper[] infoCheckMappers)
        {
            this.infoCheckMappers = infoCheckMappers;
            this.infoCheckSettings = infoCheckSettings;
        }

        /// <summary>
        /// Do model mapping based on model type. Mapper itself represented in a collection
        /// </summary>
        /// <param name="entity">Entity to be mapped</param>
        /// <returns>Mapped object</returns>
        public async Task<RequestExportBase> MapModel(object entity)
        {
            try
            {
                return await infoCheckMappers
                    .First(x => x.SpInfoCheckPartnerKey == infoCheckSettings.DefaultSpInfoCheckPartnerKey)
                    .Map(entity);
            }
            catch (ArgumentNullException)
            {
                throw new Exception("SpInfoCheckerPartnerKey is not found");
            }
        }
    }
}
