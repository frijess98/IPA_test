using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using SCE.ServicingPartnerInfoCheck.Contracts.Abstracts;
using SCE.ServicingPartnerInfoCheck.Contracts.Dtos.GlkbServicingPartner;
using SCE.ServicingPartnerInfoCheck.Contracts.Dtos.PostFinanceServicingPartner;
using SCE.ServicingPartnerInfoCheck.Contracts.Types.Settings;
using SCE.ServicingPartnerInfoCheck.DAL;
using SCE.ServicingPartnerInfoCheck.Services;
using SCE.ServicingPartnerInfoCheck.Services.Extensions.GlkbExtensions;
using SCE.ServicingPartnerInfoCheck.Services.Helpers.GlkbHelpers;
using SCE.ServicingPartnerInfoCheck.Services.SpInfoCheckers;

namespace SCE.ServicingPartnerInfoCheck.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SendFinancingHttpRequest().Wait();
            DeserealizationGlkb();
            DeserealizationcPostFinance();
			GetOtcResponses().Wait();

            Console.ReadKey();
        }

		private static void DeserealizationcPostFinance()
		{;

			var str = File.ReadAllText(Path.Combine(Environment.CurrentDirectory, Path.Combine(@"Jsons\PostFinance", "respo.json")));

			var resp = new PostFinancingResponseRootDto();
         
        }

		private static void DeserealizationGlkb()
        {
            var deserealizeHelper = new GlkbDeserealizerHelper();

            var str = File.ReadAllText(Path.Combine(Environment.CurrentDirectory, Path.Combine(@"Jsons\Glkb", "respo.json")));

            var resp = new FinancingResponseRootDto();

            deserealizeHelper.TryDeserealize(str, out resp);

            var otc = resp.Content.Select(x => x.ToOtcRoot()).ToList();

            Console.WriteLine($"{resp.Content.Count}");
        }

        private static async Task GetOtcResponses()
        {
            ISpInfoCheckRepository spInfoCheckRepository = new SpInfoCheckRepository(new SpInfoCheckContext());

            ISpInfoCheckOtcDataService spInfoCheckOtcDataService = new SpInfoCheckOtcDataService(spInfoCheckRepository);

            var otcs = await spInfoCheckOtcDataService.GetOtcItemsAsync().ConfigureAwait(false);

            Console.WriteLine(otcs.IsSuccess);
        }

        private static async Task SendFinancingHttpRequest()
        {
            var settings = new GlkbServicingPartnerSettings(
                "credexapi",
                "123456xX",
                "https://progress.inventage.com/api/login",
                "https://progress.inventage.com/api/auftraege",
                "credextest_2024.p12",
                "nimAHB9iCyVHRSrOJvZu",
                "https://progress.inventage.com/api/finanzierungen",
                "credexapi",
                "123456xX",
                "3072");

            var glkbHttpHelper = new GlkbHttpHelper(settings);

            var glkbDeserealizerHelper = new GlkbDeserealizerHelper();

            var glkbUrlBuilderHelper = new GlkbUrlBuilderHelper();

            ISpInfoCheckRepository spInfoCheckRepository = new SpInfoCheckRepository(new SpInfoCheckContext());

            var glkbInfoChecker = new GlkbInfoChecker(null,
                settings,
                spInfoCheckRepository,
                glkbHttpHelper,
                glkbDeserealizerHelper,
                glkbUrlBuilderHelper);

            var response = await glkbInfoChecker.FetchAsync(new GlkbFinancingRequestDto()
            {
                Take = 1,
                AttachLimit = true
            });
        }
    }
}
