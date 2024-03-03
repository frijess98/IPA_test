using Newtonsoft.Json;

namespace SCE.ServicingPartnerInfoCheck.Contracts.Types.GLKBServicingPartner
{
    public class BorrowerClientBase : UuidEntity
    {
        [JsonProperty(PropertyName = "kundenNr")]
        public long BorrowerNumber { get; set; }

        [JsonProperty(PropertyName = "fremdId")]
        public string PartnerId { get; set; }

        [JsonProperty(PropertyName = "hausnummer")]
        public string HouseNumber { get; set; }

        [JsonProperty(PropertyName = "korrespondenzsprache")]
        public string Language { get; set; }

        [JsonProperty(PropertyName = "kundenart")]
        public string TypeOfClient { get; set; }

        [JsonProperty(PropertyName = "kundenberater")]
        public string CustomerAdvisor { get; set; }

        [JsonProperty(PropertyName = "vertriebseinheit")]
        public string PartnerName { get; set; }

        [JsonProperty(PropertyName = "strasse")]
        public string Street { get; set; }

        [JsonProperty(PropertyName = "plz")]
        public string Zip { get; set; }

        [JsonProperty(PropertyName = "ort")]
        public string Location { get; set; }

        [JsonProperty(PropertyName = "land")]
        public string Country { get; set; }

        [JsonProperty(PropertyName = "kundenratingDatum")]
        public string OfferCalculationDate { get; set; }

        [JsonProperty(PropertyName = "kundenrating")]
        public string WinningInvestorRating { get; set; }

        [JsonProperty(PropertyName = "mandant")]
        public string Client { get; set; }

        [JsonProperty(PropertyName = "bemerkung")]
        public string Remark { get; set; }
    }
}
