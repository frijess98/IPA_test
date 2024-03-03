namespace SCE.ServicingPartnerInfoCheck.Contracts.Types.Settings
{
    /// <summary>
    /// Glkb Specific Settings
    /// </summary>
    public class GlkbServicingPartnerSettings
    {
        /// <summary>
        /// Username
        /// </summary>
        public string GlkbSpUsername { get; }

        /// <summary>
        /// Password
        /// </summary>
        public string GlkbSpPassword { get; }

        /// <summary>
        /// Glkb Otc Username
        /// </summary>
        public string GlkbOtcUsername { get; }

        /// <summary>
        /// Glkb Otc Password
        /// </summary>
        public string GlkbOtcPassword { get; }

        /// <summary>
        /// Login Api Url
        /// </summary>
        public string GlkbLoginUrl { get; }

        /// <summary>
        /// Url for sneding requests
        /// </summary>
        public string GlkbPostOfferUrl { get; }

        /// <summary>
        /// Glkb Get Financing Url
        /// </summary>
        public string GlkbGetFinancingUrl { get; }

        /// <summary>
        /// Filename of certificate
        /// </summary>
        public string GlkbCertificateName { get; }

        /// <summary>
        /// PassKey for certificate
        /// </summary>
        public string GlkbCertificatePassKey { get; }

        /// <summary>
        /// Glkb Certificate Folder Path
        /// </summary>
        public string GlkbCertificateFolder { get; }

        /// <summary>
        /// TLS / SSL Security Protocol Type
        /// </summary>
        public string SecurityProtocolType { get; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="glkbSpUsername">Username</param>
        /// <param name="glkbSpPassword">Password</param>
        /// <param name="glkbLoginUrl">Login Api Url</param>
        /// <param name="glkbPostOfferUrl">Url for sneding requests</param>
        /// <param name="glkbCertificateName">Filename of certificate</param>
        /// <param name="glkbCertificatePassKey">PassKey for certificate</param>
        /// <param name="glkbGetFinancingUrl">PassKey for certificate</param>
        /// <param name="securityProtocolType">PassKey for certificate</param>
        /// <param name="glkbOtcUsername">PassKey for certificate</param>
        /// <param name="glkbOtcPassword">PassKey for certificate</param>
        /// <param name="glkbCertificateBasePath">PassKey for certificate</param>
        public GlkbServicingPartnerSettings(
            string glkbSpUsername,
            string glkbSpPassword,
            string glkbLoginUrl,
            string glkbPostOfferUrl,
            string glkbCertificateName,
            string glkbCertificatePassKey,
            string glkbGetFinancingUrl,
            string glkbOtcUsername,
            string glkbOtcPassword,
            string securityProtocolType,
            string glkbCertificateBasePath = null
            )
        {
            GlkbSpUsername = glkbSpUsername;
            GlkbSpPassword = glkbSpPassword;
            GlkbLoginUrl = glkbLoginUrl;
            GlkbPostOfferUrl = glkbPostOfferUrl;
            GlkbCertificateName = glkbCertificateName;
            GlkbCertificatePassKey = glkbCertificatePassKey;
            GlkbGetFinancingUrl = glkbGetFinancingUrl;
            GlkbOtcUsername = glkbOtcUsername;
            GlkbOtcPassword = glkbOtcPassword;
            SecurityProtocolType = securityProtocolType;
            GlkbCertificateFolder = glkbCertificateBasePath;
        }
    }
}
