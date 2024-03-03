using System.Collections.Generic;
using Newtonsoft.Json;

namespace SCE.ServicingPartnerInfoCheck.Contracts.Types.GLKBServicingPartner
{
    public class FinancingAccount
    {
        [JsonProperty(PropertyName = "tranchenId")]
        public string TrancheId { get; set; }

        [JsonProperty(PropertyName = "kontoNr")]
        public int? AccountNr { get; set; }

        [JsonProperty(PropertyName = "abschlussperiodizitaet")]
        public string CompletionPeriodicity { get; set; }

        [JsonProperty(PropertyName = "bezeichnung")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "limite")]
        public decimal Limite { get; set; }

        [JsonProperty(PropertyName = "zinsusanz")]
        public string InterestSubsidy { get; set; }

        [JsonProperty(PropertyName = "naechstesmalPer")]
        public string NextPaymentDate { get; set; }

        [JsonProperty(PropertyName = "zahlungsart")]
        public string PaymentMethod { get; set; }

        [JsonProperty(PropertyName = "zinskonto")]
        public string DisbursementAccount { get; set; }

        [JsonProperty(PropertyName = "inhaberZinskonto")]
        public UuidEntity AccountOwner { get; set; }

        [JsonProperty(PropertyName = "voravis")]
        public string PreAdvice { get; set; }

        [JsonProperty(PropertyName = "versandart")]
        public string ShippingMethod { get; set; }

        [JsonProperty(PropertyName = "produkt")]
        public string Product { get; set; }

        [JsonProperty(PropertyName = "portfolio")]
        public string Portfolio { get; set; }

        [JsonProperty(PropertyName = "uebertragungsdatum")]
        public string PayoutTrancheDate { get; set; }


        [JsonProperty(PropertyName = "konditionen")]
        public List<AccountCondition> Conditions { get; set; }

        [JsonProperty(PropertyName = "reduktionen")]
        public List<AccountAmortizationBase> Amortizations { get; set; }
    }
}
