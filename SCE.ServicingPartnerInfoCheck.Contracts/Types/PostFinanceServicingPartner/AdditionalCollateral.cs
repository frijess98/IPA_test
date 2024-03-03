using System.Collections.Generic;
using Newtonsoft.Json;

namespace SCE.ServicingPartnerInfoCheck.Contracts.Types.PostFinanceServicingPartner
{
    public class AdditionalCollateral
	{
		[JsonProperty(PropertyName = "NumberOfInsurances")]
		public int NumberOfInsurances { get; set; }

		[JsonProperty(PropertyName = "Insurances")]
		public List<Insurance> Insurances { get; set; }

		[JsonProperty(PropertyName = "NumberOfSavings3rdPillarAccounts")]
		public int NumberOfSavings3rdPillarAccounts { get; set; }

		[JsonProperty(PropertyName = "Saving3rdPillar")]
		public List<Saving3rdPillar> Saving3rdPillar { get; set; }

		[JsonProperty(PropertyName = "NumberOfPensionFunds")]
		public int NumberOfPensionFunds { get; set; }

		[JsonProperty(PropertyName = "PensionFunds")]
		public List<PensionFunds> PensionFunds { get; set; }
	}
}