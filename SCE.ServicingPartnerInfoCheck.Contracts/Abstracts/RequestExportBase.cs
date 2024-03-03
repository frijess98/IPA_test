using Newtonsoft.Json;

namespace SCE.ServicingPartnerInfoCheck.Contracts.Abstracts
{
    /// <summary>
    /// Base class for every entity which can be mapped and checked
    /// </summary>
    public abstract class RequestExportBase
    {
        /// <summary>
        /// Identifier for the entity
        /// </summary>
        [JsonIgnore]
        public string RequestId { get; set; }
    }
}