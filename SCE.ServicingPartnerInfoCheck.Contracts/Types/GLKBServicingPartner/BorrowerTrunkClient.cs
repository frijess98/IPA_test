using System.Collections.Generic;
using Newtonsoft.Json;

namespace SCE.ServicingPartnerInfoCheck.Contracts.Types.GLKBServicingPartner
{
    public class BorrowerTrunkClient : BorrowerClientBase
    {
        [JsonProperty(PropertyName = "anredeVornameName")]
        public string BorrowerTrunkFullName { get; set; }

        [JsonProperty(PropertyName = "kunden")]
        public List<BorrowerPrivateClient> Borrowers { get; set; }
    }
}
