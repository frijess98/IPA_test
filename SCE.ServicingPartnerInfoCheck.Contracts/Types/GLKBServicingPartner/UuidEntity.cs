using Newtonsoft.Json;

namespace SCE.ServicingPartnerInfoCheck.Contracts.Types.GLKBServicingPartner
{
    /// <summary>
    /// Represents an Entity with Uuid
    /// </summary>
    public class UuidEntity
    {
        /// <summary>
        /// Uuid - specific ID for Glkb
        /// </summary>
        [JsonProperty(PropertyName = "uuid")]
        public string Uuid { get; set; }
    }
}
