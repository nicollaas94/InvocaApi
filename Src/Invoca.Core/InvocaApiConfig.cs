using System;

namespace Invoca.Core
{
    public class InvocaApiConfig
    {
        private const string WSDL_PRODUCTION = "invoca.net/api";
        
        public Uri Url(bool haveSubdomain = false)
        {
            return new Uri($"https://{(haveSubdomain? Subdomain + ".":"")}{WSDL_PRODUCTION}/{Version}/");
        }

        /// <summary>
        /// Invoca Network Id
        /// </summary>
        public int NetworkId { get; set; }

        /// <summary>
        /// advertiser id
        /// </summary>
        public int AdvertiserId { get; set; }

        /// <summary>
        /// Affiliate id
        /// </summary>
        public int AffiliateId { get; set; }

        /// <summary>
        /// Invoca Api Key
        /// </summary>
        public string ApiKey { get; set; }

        /// <summary>
        /// Invoca Transaction subdomain
        /// </summary>
        public string Subdomain { get; set; }

        /// <summary>
        /// Mode
        /// </summary>
        public InvocaApiMode Mode { get; set; } = InvocaApiMode.Production;

        public string Version { get; set; } = "2017-02-01";
    }

    public enum InvocaApiMode
    {
        Development,
        Production
    }
}
