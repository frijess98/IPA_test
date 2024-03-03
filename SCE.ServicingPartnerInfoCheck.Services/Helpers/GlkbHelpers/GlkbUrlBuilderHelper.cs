using System.Text;
using SCE.ServicingPartnerInfoCheck.Contracts.Dtos.GlkbServicingPartner;
using SCE.ServicingPartnerInfoCheck.Contracts.Types.Settings;

namespace SCE.ServicingPartnerInfoCheck.Services.Helpers.GlkbHelpers
{
    /// <summary>
    /// 
    /// </summary>
    public class GlkbUrlBuilderHelper
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="offset"></param>
        /// <param name="requestDto"></param>
        /// <param name="settings"></param>
        /// <returns></returns>
        public string BuildFinancingUrl(int offset, GlkbFinancingRequestDto requestDto, GlkbServicingPartnerSettings settings)
        {
            var urlBuilder = new StringBuilder($"{settings.GlkbGetFinancingUrl}?expand={(requestDto.IsExpanded ? "all" : "none")}");

            urlBuilder.Append($"&offset={offset}");

            if (requestDto.AttachLimit)
            {
                urlBuilder.Append($"&limit={requestDto.Take}");
            }

            if (requestDto.DateStart != null && requestDto.DateEnd != null)
            {
                urlBuilder.Append($"&creationDateStart={requestDto.DateStart:yyyy-MM-dd}");
                urlBuilder.Append($"&creationDateEnd={requestDto.DateEnd:yyyy-MM-dd}");
            }

            return urlBuilder.ToString();
        }
    }
}
