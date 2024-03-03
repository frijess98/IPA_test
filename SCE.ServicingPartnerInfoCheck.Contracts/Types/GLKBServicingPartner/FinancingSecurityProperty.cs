using System.Collections.Generic;
using Newtonsoft.Json;

namespace SCE.ServicingPartnerInfoCheck.Contracts.Types.GLKBServicingPartner
{
    /// <summary>
    /// Collateral GRUNDSTUECK
    /// </summary>
    public class FinancingSecurityProperty : SecurityItemBase
    {
        [JsonProperty(PropertyName = "immobilienTyp")]
        public string PropertyType { get; set; }

        [JsonProperty(PropertyName = "nutzungsart")]
        public string UsageType { get; set; }

        [JsonProperty(PropertyName = "pkVorbezug")]
        public string SecondPillarWithdrawal { get; set; }

        [JsonProperty(PropertyName = "baurecht")]
        public string RightToBuild { get; set; }

        [JsonProperty(PropertyName = "faelligkeitsdatumBaurecht")]
        public string DeadlineDateOfConstruction { get; set; }

        [JsonProperty(PropertyName = "strasse")]
        public string Street { get; set; }

        [JsonProperty(PropertyName = "hausnummer")]
        public string HouseNumber { get; set; }

        [JsonProperty(PropertyName = "plz")]
        public string PostalCode { get; set; }

        [JsonProperty(PropertyName = "ort")]
        public string Location { get; set; }

        [JsonProperty(PropertyName = "land")]
        public string Country { get; set; }

        [JsonProperty(PropertyName = "egrid")]
        public string Egrid { get; set; }

        [JsonProperty(PropertyName = "grundbuch")]
        public string LandRegister { get; set; }

        [JsonProperty(PropertyName = "grundbuchamtPlz")]
        public string LandRegisterZip { get; set; }

        [JsonProperty(PropertyName = "grundbuchamtOrt")]
        public string LandRegisterLocation { get; set; }

        [JsonProperty(PropertyName = "grundbuchamtLand")]
        public string LandRegisterCountry { get; set; }

        [JsonProperty(PropertyName = "grundbuchNr")]
        public string LandRegisterNumber { get; set; }

        [JsonProperty(PropertyName = "eigentumsverhaeltnis")]
        public string Ownership { get; set; }

        [JsonProperty(PropertyName = "schaetzungsart")]
        public string TypeOfEstimation { get; set; }

        [JsonProperty(PropertyName = "quelle")]
        public string Source { get; set; }

        [JsonProperty(PropertyName = "schaetzdatum")]
        public string DateOfValuation { get; set; }

        [JsonProperty(PropertyName = "schaetzwert")]
        public decimal? EstimatedValueOfProperty { get; set; }

        [JsonProperty(PropertyName = "immobilienwert")]
        public decimal? RealEstateValue { get; set; }

        [JsonProperty(PropertyName = "korrektur")]
        public decimal Correction { get; set; }

        [JsonProperty(PropertyName = "luxusobjekt")]
        public string LuxuryProperty { get; set; }

        [JsonProperty(PropertyName = "baujahr")]
        public int? ConstructionYear { get; set; }

        [JsonProperty(PropertyName = "sanierungsjahr")]
        public int? YearOfRenovation { get; set; }

        [JsonProperty(PropertyName = "gebaeudezustand")]
        public string BuildingCondition { get; set; }

        [JsonProperty(PropertyName = "nettowohnflaeche")]
        public int? NetLivingArea { get; set; }

        [JsonProperty(PropertyName = "volumen")]
        public int? Volume { get; set; }

        [JsonProperty(PropertyName = "anzahlSeparateGaragen")]
        public int? NumberOfSeparateGarages { get; set; }

        [JsonProperty(PropertyName = "anzahlTiefgaragenplaetze")]
        public int? NumberOfUndergroundParkingSpots { get; set; }

        [JsonProperty(PropertyName = "anzahlAbstellplaetze")]
        public int? NumberOfParkingSpots { get; set; }

        [JsonProperty(PropertyName = "schaetzwertMandant")]
        public decimal ClientValue { get; set; }

        [JsonProperty(PropertyName = "schaetzungsdatumMandant")]
        public string ClientValuationDate { get; set; }

        [JsonProperty(PropertyName = "quelleMandant")]
        public string ClientSource { get; set; }

        [JsonProperty(PropertyName = "kaufpreis")]
        public decimal? Purchase { get; set; }

        [JsonProperty(PropertyName = "kaufdatum")]
        public string PurchaseDate { get; set; }


        [JsonProperty(PropertyName = "eigentuemer")]
        public BorrowerClientBase Borrower { get; set; }

        [JsonProperty(PropertyName = "grundpfaender")]
        public List<SecurityDebenture> Debentures { get; set; }
    }
}
