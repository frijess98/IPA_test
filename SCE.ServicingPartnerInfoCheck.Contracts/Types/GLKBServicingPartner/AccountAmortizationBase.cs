using Newtonsoft.Json;

namespace SCE.ServicingPartnerInfoCheck.Contracts.Types.GLKBServicingPartner
{
    public class AccountAmortizationBase
    {
        [JsonProperty(PropertyName = "naechstesmalPer")]
        public string FirstAmortizationPaymentDate { get; set; }

        [JsonProperty(PropertyName = "reduktionsart")]
        public string ReductionType { get; set; }

        [JsonProperty(PropertyName = "betrag")]
        public decimal? Amount { get; set; }

        [JsonProperty(PropertyName = "periodizitaet")]
        public string Periodicity { get; set; }

        [JsonProperty(PropertyName = "stoppBetrag")]
        public decimal? Balance { get; set; }

        [JsonProperty(PropertyName = "rahmenlimite")]
        public string ReduceLimits { get; set; }
    }
}
