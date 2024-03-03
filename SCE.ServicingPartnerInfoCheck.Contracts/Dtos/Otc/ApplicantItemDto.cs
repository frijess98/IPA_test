using Newtonsoft.Json;

namespace SCE.ServicingPartnerInfoCheck.Contracts.Dtos.Otc
{
    /// <summary>
    /// Otc Applicant Dto
    /// </summary>
    public class ApplicantItemDto
    {
        /// <summary>
        /// Client number
        /// </summary>
        [JsonProperty("kundenNr")]
        public int? ClientNumber { get; set; }

        /// <summary>
        /// Partner number
        /// </summary>
        [JsonProperty("fremdId")]
        public string PartnerNumber { get; set; }

        /// <summary>
        /// Birth Date
        /// </summary>
        [JsonProperty("geburtsdatum")]
        public string BirthDate { get; set; }

        /// <summary>
        /// Zip / Postal Code
        /// </summary>
        [JsonProperty("plz")]
        public string PostalCode { get; set; }

        /// <summary>
        /// Location
        /// </summary>
        [JsonProperty("ort")]
        public string Location { get; set; }

        /// <summary>
        /// Country
        /// </summary>
        [JsonProperty("land")]
        public string Country { get; set; }

        /// <summary>
        /// Firstname
        /// </summary>
        [JsonProperty("name")]
        public string FirstName { get; set; }


        /// <summary>
        /// Lastname
        /// </summary>
        [JsonProperty("vorname")]
        public string LastName { get; set; }

        /// <summary>
        /// Salutation
        /// </summary>
        [JsonProperty("anrede")]
        public string Salutation { get; set; }
    }
}
