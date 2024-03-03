using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SCE.ServicingPartnerInfoCheck.Contracts.Dtos.GlkbServicingPartner;
using SCE.ServicingPartnerInfoCheck.Contracts.Types.GLKBServicingPartner;

namespace SCE.ServicingPartnerInfoCheck.Services.Helpers.GlkbHelpers
{
    /// <summary>
    /// Custom deserealizer
    /// </summary>
    public class GlkbDeserealizerHelper
    {
        /// <summary>
        /// Performs deserealization to specific objects types based on Json
        /// </summary>
        /// <param name="body"></param>
        /// <param name="financingResponseRoot"></param>
        /// <returns></returns>
        public bool TryDeserealize(string body, out FinancingResponseRootDto financingResponseRoot)
        {
            try
            {
                financingResponseRoot = new FinancingResponseRootDto()
                {
                    Content = GetContent(JObject.Parse(body).Value<JToken>("content")
                            ?? throw new Exception("[content] is not found in response. Operation cancelled.")).ToList(),
                    TotalCount = Convert.ToInt32(JObject.Parse(body).Value<JToken>("totalCount")
                            ?? throw new Exception("[totalCount] is not found in response. Operation cancelled.")),
                    Count = Convert.ToInt32(JObject.Parse(body).Value<JToken>("count")
                            ?? throw new Exception("[count] is not found in response. Operation cancelled."))
                };

                return true;
            }
            catch
            {
                financingResponseRoot = null;

                return false;
            }
        }

        private IEnumerable<Financing> GetContent(JToken contentItems)
        {
            foreach (var content in contentItems.Children())
            {
                var obj = JsonConvert.DeserializeObject<Financing>(content.ToString());

                if (obj.Borrower.TypeOfClient == "PRIVATKUNDE")
                {
                    obj.Borrower = JsonConvert.DeserializeObject<BorrowerPrivateClient>(content.Value<JToken>("kreditnehmer").ToString());
                }
                else if (obj.Borrower.TypeOfClient == "UND_STAMM")
                {
                    obj.Borrower = JsonConvert.DeserializeObject<BorrowerTrunkClient>(content.Value<JToken>("kreditnehmer").ToString());
                }
                else if(obj.Borrower.TypeOfClient == "FIRMENKUNDE")
                {
                    obj.Borrower = JsonConvert.DeserializeObject<BorrowerCorporateClient>(content.Value<JToken>("kreditnehmer").ToString());
                }

                yield return obj;
            }
        }
    }
}
