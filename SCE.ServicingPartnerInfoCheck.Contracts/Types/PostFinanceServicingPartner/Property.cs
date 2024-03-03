using System;
using Newtonsoft.Json;
using SCE.ServicingPartnerInfoCheck.Contracts.Types.PostFinanceServicingPartner.Enums;

namespace SCE.ServicingPartnerInfoCheck.Contracts.Types.PostFinanceServicingPartner
{
	public class Property
	{
		[JsonProperty(PropertyName = "PropertyType")]
		public PropertyType PropertyType { get; set; }

		[JsonProperty(PropertyName = "Location")]
		public string Location { get; set; }

		[JsonProperty(PropertyName = "Number")]
		public string Number { get; set; }

		[JsonProperty(PropertyName = "PostalCode")]
		public string PostalCode { get; set; }

		[JsonProperty(PropertyName = "PurchasePrice")]
		public decimal PurchasePrice { get; set; }

		[JsonProperty(PropertyName = "RenovationValue")]
		public string RenovationValue { get; set; }//null

		[JsonProperty(PropertyName = "PurchaseDate")]
		public DateTime PurchaseDate { get; set; }

		[JsonProperty(PropertyName = "HouseType")]
		public string HouseType { get; set; }//null

		[JsonProperty(PropertyName = "Volume")]
		public int? Volume { get; set; }

		[JsonProperty(PropertyName = "LandArea")]
		public string LandArea { get; set; }//null

		[JsonProperty(PropertyName = "LuxuryProperty")]
		public bool LuxuryProperty { get; set; }

		[JsonProperty(PropertyName = "NetLivingArea")]
		public int NetLivingArea { get; set; }

		[JsonProperty(PropertyName = "RoomVolumeStandard")]
		public string RoomVolumeStandard { get; set; }

		[JsonProperty(PropertyName = "ConvertibleAttic")]
		public bool ConvertibleAttic { get; set; }

		[JsonProperty(PropertyName = "ConstructionYear")]
		public int ConstructionYear { get; set; }

		[JsonProperty(PropertyName = "Renovation")]
		public bool Renovation { get; set; }

		[JsonProperty(PropertyName = "YearOfRenovation")]
		public int? YearOfRenovation { get; set; }

		[JsonProperty(PropertyName = "BuildingConditionValue")]
		public decimal BuildingConditionValue { get; set; }

		[JsonProperty(PropertyName = "ConstructionQualityValue")]
		public decimal ConstructionQualityValue { get; set; }

		[JsonProperty(PropertyName = "MinergieStandard")]
		public string MinergieStandard { get; set; }

		[JsonProperty(PropertyName = "NumberOfRooms")]
		public decimal NumberOfRooms { get; set; }

		[JsonProperty(PropertyName = "RoomCounting")]
		public string RoomCounting { get; set; }

		[JsonProperty(PropertyName = "NumberOfSeparateWCs")]
		public int NumberOfSeparateWCs { get; set; }

		[JsonProperty(PropertyName = "GrannyFlat")]
		public decimal GrannyFlat { get; set; }

		[JsonProperty(PropertyName = "NumberOfBathroom")]
		public int NumberOfBathroom { get; set; }

		[JsonProperty(PropertyName = "NumberOfSeparateGarages")]
		public int NumberOfSeparateGarages { get; set; }

		[JsonProperty(PropertyName = "NumberOfUndergroundParkingSpots")]
		public int NumberOfUndergroundParkingSpots { get; set; }

		[JsonProperty(PropertyName = "NumberOfParkingSpots")]
		public int NumberOfParkingSpots { get; set; }

		[JsonProperty(PropertyName = "BuildingInsurance")]
		public bool BuildingInsurance { get; set; }

		[JsonProperty(PropertyName = "Building")]
		public string Building { get; set; }

		[JsonProperty(PropertyName = "NumberOfApartments")]
		public int NumberOfApartments { get; set; }

		[JsonProperty(PropertyName = "ApartmentType")]
		public string ApartmentType { get; set; }

		[JsonProperty(PropertyName = "MultiStorey")]
		public bool MultiStorey { get; set; }

		[JsonProperty(PropertyName = "Floor")]
		public int Floor { get; set; }

		[JsonProperty(PropertyName = "NumberOfFloorsExclGroundFloor")]
		public int NumberOfFloorsExclGroundFloor { get; set; }

		[JsonProperty(PropertyName = "LocationInTheBuildingValue")]
		public int LocationInTheBuildingValue { get; set; }

		[JsonProperty(PropertyName = "HobbyRoomSurfaceArea")]
		public int HobbyRoomSurfaceArea { get; set; }

		[JsonProperty(PropertyName = "BalconyTerraceArea")]
		public int BalconyTerraceArea { get; set; }

		[JsonProperty(PropertyName = "OwnershipRation1000")]
		public int OwnershipRation1000 { get; set; }

		[JsonProperty(PropertyName = "ApartmentConditionValue")]
		public int ApartmentConditionValue { get; set; }

		[JsonProperty(PropertyName = "PropertyFeatures")]
		public string PropertyFeatures { get; set; }//null

		[JsonProperty(PropertyName = "FutureRenovation")]
		public string FutureRenovation { get; set; }//null
	}
}