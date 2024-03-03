using System;
using Newtonsoft.Json;
using SCE.ServicingPartnerInfoCheck.Contracts.Types.PostFinanceServicingPartner.Enums;

namespace SCE.ServicingPartnerInfoCheck.Contracts.Types.PostFinanceServicingPartner
{
	public class GeneralInformation
	{
		[JsonProperty(PropertyName = "Nationality3LetterCode")]
		public string Nationality3LetterCode { get; set; }

		[JsonProperty(PropertyName = "ClientId")]
		public int ClientId { get; set; }

		[JsonProperty(PropertyName = "IdentifieadAs")]
		public string IdentifieadAs { get; set; }

		[JsonProperty(PropertyName = "FirstName")]
		public string FirstName { get; set; }

		[JsonProperty(PropertyName = "LastName")]
		public string LastName { get; set; }

		[JsonProperty(PropertyName = "Gender")]
		public Genders Gender { get; set; }

		[JsonProperty(PropertyName = "DateOfBirth")]
		public DateTime DateOfBirth { get; set; }

		[JsonProperty(PropertyName = "CivilStatus")]
		public CivilStatus CivilStatus { get; set; }

		[JsonProperty(PropertyName = "Children")]
		public bool Children { get; set; }

		[JsonProperty(PropertyName = "Language")]
		public Languages Language { get; set; }

		[JsonProperty(PropertyName = "Street")]
		public string Street { get; set; }

		[JsonProperty(PropertyName = "Number")]
		public string Number { get; set; }

		[JsonProperty(PropertyName = "PostalCode")]
		public string PostalCode { get; set; }

		[JsonProperty(PropertyName = "Location")]
		public string Location { get; set; }

		[JsonProperty(PropertyName = "Country3LetterCode")]
		public string Country3LetterCode { get; set; }

		[JsonProperty(PropertyName = "Phone")]
		public string Phone { get; set; }//null

		[JsonProperty(PropertyName = "Email")]
		public string Email { get; set; }//null

		[JsonProperty(PropertyName = "TypeOfIncome")]
		public TypeOfIncome TypeOfIncome { get; set; }

		[JsonProperty(PropertyName = "DebtRecoveryActions")]
		public string DebtRecoveryActions { get; set; }

		[JsonProperty(PropertyName = "Employee")]
		public bool Employee { get; set; }

		[JsonProperty(PropertyName = "InternalClientId")]
		public string InternalClientId { get; set; }//null
	}
}