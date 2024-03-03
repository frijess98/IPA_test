using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using NLog;
using Qcentris.EventSourcing.Core.Messages;
using RestSharp;
using SCE.ServicingPartnerInfoCheck.Contracts.Abstracts;
using SCE.ServicingPartnerInfoCheck.Contracts.Constants;
using SCE.ServicingPartnerInfoCheck.Contracts.Dtos.GlkbServicingPartner;
using SCE.ServicingPartnerInfoCheck.Contracts.Dtos.Otc;
using SCE.ServicingPartnerInfoCheck.Contracts.Types;
using SCE.ServicingPartnerInfoCheck.Contracts.Types.Settings;
using SCE.ServicingPartnerInfoCheck.Services.Extensions.GlkbExtensions;
using SCE.ServicingPartnerInfoCheck.Services.Helpers.GlkbHelpers;

namespace SCE.ServicingPartnerInfoCheck.Services.SpInfoCheckers
{
    /// <summary>
    /// Infochecker for GLKB
    /// </summary>
    public class GlkbInfoChecker : IInfoChecker
    {
        private readonly Func<object, Task<RequestExportBase>> mapper;
        private readonly GlkbServicingPartnerSettings settings;
        private readonly ISpInfoCheckRepository spInfoCheckRepository;
        private readonly ILogger logger;
        private readonly GlkbHttpHelper httpHelper;
        private readonly GlkbDeserealizerHelper deserealizeHelper;
        private readonly GlkbUrlBuilderHelper glkbUrlBuilderHelper;

        /// <summary>
        /// Default key of current SP
        /// </summary>
        public string ServicingPartner => ServicingPartners.Glkb;

        /// <summary>
        /// Cpnstructor
        /// </summary>
        /// <param name="mapper">Mapper which will do mapping</param>
        /// <param name="settings">Settings for GLKB</param>
        /// <param name="spInfoCheckRepository">Repository</param>
        /// <param name="httpHelper">Http Helper for processing requests</param>
        /// <param name="glkbDeserealizerHelper">Custom deserealization helper</param>
        /// <param name="glkbUrlBuilderHelper">Custom deserealization helper</param>
        public GlkbInfoChecker(
            Func<object, Task<RequestExportBase>> mapper,
            GlkbServicingPartnerSettings settings,
            ISpInfoCheckRepository spInfoCheckRepository,
            GlkbHttpHelper httpHelper,
            GlkbDeserealizerHelper glkbDeserealizerHelper,
            GlkbUrlBuilderHelper glkbUrlBuilderHelper)
        {
            this.mapper = mapper;
            this.settings = settings;
            this.spInfoCheckRepository = spInfoCheckRepository;
            this.httpHelper = httpHelper;
            this.deserealizeHelper = glkbDeserealizerHelper;
            this.glkbUrlBuilderHelper = glkbUrlBuilderHelper;
            this.logger = LogManager.GetCurrentClassLogger();
        }

        /// <summary>
        /// Performing request send to external service (GLKB)
        /// </summary>
        /// <param name="entity">Entity to be sent</param>
        /// <returns></returns>
        public async Task<IExecutionResult> CheckAsync(object entity)
        {
            var dto = await mapper(entity);

            return await SendAsync(dto);
        }

        /// <summary>
        /// Fetches and stores data
        /// </summary>
        /// <param name="requestDto">Request object</param>
        /// <returns></returns>
        public Task<IExecutionResult> FetchAsync(object requestDto)
        {
            return GetAsync(requestDto as GlkbFinancingRequestDto);
        }

        #region private methods
        private async Task<IEnumerable<OtcRootDto>> GetOtcRoots(GlkbFinancingRequestDto requestDto)
        {
            var offset = 0;

            var list = new List<OtcRootDto>();

            while (true)
            {
                var response = await httpHelper
                    .SendRequestAsync(settings.GlkbOtcUsername,
                                      settings.GlkbOtcPassword,
                                      glkbUrlBuilderHelper.BuildFinancingUrl(offset, requestDto, settings),
                                      Method.GET, string.Empty)
                    .ConfigureAwait(false);

                if (response.Success == false)
                {
                    break;
                }

                var root = new FinancingResponseRootDto();

                var success = deserealizeHelper.TryDeserealize(response.Response, out root);

                if (success == false || root?.Count == 0)
                {
                    break;
                }

                offset += requestDto.Take;

                list.AddRange(root.Content.Select(content => content.ToOtcRoot()));
            }

            return list;
        }

        private async Task<IExecutionResult> GetAsync(GlkbFinancingRequestDto requestDto)
        {
            try
            {
                if (requestDto.Take == 0)
                {
                    throw new Exception("Limit cannot be zero");
                }

                var otcRoots = await GetOtcRoots(requestDto);

                return await Task.FromResult((IExecutionResult)new ExecutionResult<IEnumerable<OtcRootDto>>(otcRoots)).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                logger.Log(LogLevel.Error, ex, "Operation cancelled.");

                return ExecutionResult.Fail(ex.Message);
            }
        }

        private async Task<IExecutionResult> SendAsync(RequestExportBase mappedMortgage)
        {
            try
            {
                var body = JsonConvert.SerializeObject(mappedMortgage,
                                                       new JsonSerializerSettings
                                                       {
                                                           NullValueHandling = NullValueHandling.Ignore
                                                       });

                var response = await httpHelper.SendRequestAsync(settings.GlkbSpUsername, settings.GlkbSpPassword, settings.GlkbPostOfferUrl, Method.POST, body).ConfigureAwait(false);

                logger.Log(LogLevel.Warn, $"Success: {(response.Success ? "true" : "false")}.");

                var responseObject = JsonConvert.DeserializeObject<dynamic>(response.Response);

                //if we are here - that means we have something in response. we need to store it, doesn't matter if it succesful or not.
                await SaveInfoCheckResponseAsync(mappedMortgage.RequestId,
                                            Convert.ToDateTime(responseObject?.finanzierung?.creationDate ?? DateTime.Now),
                                            response.Response,
                                            SpInfoCheckResponseTypes.SpInfoCheckResponse,
                                            Convert.ToString(responseObject?.finanzierung?.finanzierungsNr),
                                            response.Success).ConfigureAwait(false);

                if (response.Success == false)
                {
                    return ExecutionResult.Fail(response.Response);
                }

                return ExecutionResult.Success;
            }
            catch (Exception ex)
            {
                await SaveInfoCheckResponseAsync(mappedMortgage.RequestId,
                                            DateTime.Now,
                                            ex.Message,
                                            SpInfoCheckResponseTypes.SpInfoCheckResponse).ConfigureAwait(false);

                logger.Log(LogLevel.Error, ex, "Sending request to Glkb failed");

                return ExecutionResult.Fail(ex.Message);
            }
        }

        private Task SaveInfoCheckResponseAsync(string requestId, DateTime creationDate, string json, string modelType, string servicingPartnerKey = null, bool isSuccessful = false)
        {
            spInfoCheckRepository.Add(new ServicingPartnerInfoCheckEntity()
            {
                Id = Guid.NewGuid(),
                RequestId = requestId,
                IsSuccessful = isSuccessful,
                ResponseJSON = json,
                ServicingPartnerKey = servicingPartnerKey,
                CreationDate = creationDate,
                ModelType = modelType
            });

            return spInfoCheckRepository.SaveChangesAsync();
        }
        #endregion
    }
}
