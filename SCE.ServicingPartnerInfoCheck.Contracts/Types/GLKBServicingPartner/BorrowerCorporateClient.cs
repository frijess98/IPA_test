using Newtonsoft.Json;

namespace SCE.ServicingPartnerInfoCheck.Contracts.Types.GLKBServicingPartner
{
    public class BorrowerCorporateClient : BorrowerClientBase
    {
        [JsonProperty(PropertyName = "kundenNr")]
        public int? BorrowerId { get; set; }

        [JsonProperty(PropertyName = "firma")]
        public string Corporation { get; set; }

        [JsonProperty(PropertyName = "rechtsform")]
        public string LegalForm { get; set; }

        [JsonProperty(PropertyName = "vsbAufnahme")]
        public string VsbAdmission { get; set; }

        [JsonProperty(PropertyName = "branche")]
        public string Industry { get; set; }
    }
}
