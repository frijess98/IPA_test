using Newtonsoft.Json;

namespace SCE.ServicingPartnerInfoCheck.Contracts.Types.GLKBServicingPartner
{
    public class SecurityDebenture
    {
        [JsonProperty(PropertyName = "titelart")]
        public string TitleType { get; set; }

        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        [JsonProperty(PropertyName = "betrag")]
        public decimal Amount { get; set; }

        [JsonProperty(PropertyName = "datumTitel")]
        public string DateTitle { get; set; }

        [JsonProperty(PropertyName = "glaeubiger")]
        public string Creditor { get; set; }

        [JsonProperty(PropertyName = "lagerungSchuldbrief")]
        public string StorageOfDebtLetter { get; set; }

        [JsonProperty(PropertyName = "rang")]
        public int Rank { get; set; }

    }
}
