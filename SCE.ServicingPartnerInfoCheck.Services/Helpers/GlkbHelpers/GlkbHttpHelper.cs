using System;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Newtonsoft.Json;
using NLog;
using RestSharp;
using SCE.ServicingPartnerInfoCheck.Contracts.Types.Settings;

namespace SCE.ServicingPartnerInfoCheck.Services.Helpers.GlkbHelpers
{
    /// <summary>
    /// Helper class for Glkb API
    /// </summary>
    public class GlkbHttpHelper
    {
        private readonly ILogger logger;
        private readonly GlkbServicingPartnerSettings settings;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="settings">Settings object</param>
        public GlkbHttpHelper(GlkbServicingPartnerSettings settings)
        {
            this.settings = settings;
            this.logger = LogManager.GetCurrentClassLogger();
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(delegate { return true; });
            ServicePointManager.SecurityProtocol = (SecurityProtocolType)Enum.Parse(typeof(SecurityProtocolType), settings.SecurityProtocolType);
        }

        /// <summary>
        /// Sends request to specific Url using defined Http Method
        /// </summary>
        /// <param name="url">Url to send request</param>
        /// <param name="httpMethod">Http Method</param>
        /// <param name="body">Body to send</param>
        /// <param name="username">Username</param>
        /// <param name="password">Password</param>
        /// <returns></returns>
        public async Task<(bool Success, string Response)> SendRequestAsync(string username, string password, string url, Method httpMethod, string body)
        {
            var bearerToken = await GetAccessToken(username, password).ConfigureAwait(false);

            return await SendHttpRequestAsync(url, httpMethod, body, bearerToken);
        }

        private async Task<(bool Success, string Response)> SendHttpRequestAsync(string url, Method httpMethod, string body, string bearerToken = null)
        {
            try
            {
                var certificatePath = GetCertFullPath();

                var certPresent = File.Exists(certificatePath);

                logger.Debug($"{httpMethod}ing request to: {url}"
                    + $"\nGlkb certificate (pass key = {settings.GlkbCertificatePassKey}) full path: {certificatePath}"
                    + $"\nGlkb Request Body = {body ?? "<empty>"}"
                    + $"\nCertifcate {(certPresent ? "is available" : "is not available")} at the given path.");

                var restCleint = new RestClient(url);

                logger.Debug($"Attaching certificate = {certificatePath}");
                if (certPresent)
                {
                    restCleint.ClientCertificates = new X509CertificateCollection
                    {
                        new X509Certificate2(certificatePath, settings.GlkbCertificatePassKey, X509KeyStorageFlags.PersistKeySet | X509KeyStorageFlags.MachineKeySet)
                    };
                }

                var restRequest = new RestRequest(httpMethod);

                if (string.IsNullOrWhiteSpace(bearerToken) == false)
                {
                    logger.Debug($"Bearer Token = {bearerToken}");
                    restRequest.AddHeader("Authorization", "Bearer " + bearerToken);
                }

                if (string.IsNullOrWhiteSpace(body) == false)
                {
                    logger.Debug($"Attaching Body = {body}");
                    restRequest.AddJsonBody(body);
                }

                logger.Debug($"Executing request... Method = {httpMethod}");
                var restResponse = await restCleint.ExecuteAsync(restRequest);

                logger.Debug($"Code = {restResponse.StatusCode}");

                return (restResponse.IsSuccessful, restResponse.Content);
            }
            catch (Exception ex)
            {
                logger.Error(ex);

                throw new Exception(ex.Message);
            }
        }

        private async Task<string> GetAccessToken(string username, string password)
        {
            var authBody = JsonConvert.SerializeObject(new { password = password, username = username });

            var authResponse = await SendHttpRequestAsync(settings.GlkbLoginUrl, Method.POST, authBody).ConfigureAwait(false);

            if (authResponse.Success == false)
            {
                logger.Log(LogLevel.Error, $"Glkb Authorization failed: {authResponse.Response}");

                throw new Exception($"Glkb Authorization failed");
            }

            var auth = JsonConvert.DeserializeObject<dynamic>(authResponse.Response);

            return Convert.ToString(auth.access_token);
        }

        private string GetCertFullPath()
        {
            //if not provided - then default path
            if (string.IsNullOrEmpty(settings.GlkbCertificateFolder))
            {
                return Path.Combine(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "bin"),
                                    Path.Combine("Certificates", settings.GlkbCertificateName));
            }

            return Path.Combine(settings.GlkbCertificateFolder, settings.GlkbCertificateName);
        }
    }
}
