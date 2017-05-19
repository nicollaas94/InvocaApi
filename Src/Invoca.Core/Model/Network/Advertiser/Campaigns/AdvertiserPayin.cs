using System.Collections.Generic;

namespace Invoca.Core.Model.Network.Advertiser.Campaigns
{
    public class AdvertiserPayin
    {
        /// <summary>
        /// Not documented
        /// </summary>
        public int Min { get; set; }

        /// <summary>
        /// string	USD, GBP, EUR.
        /// </summary>
        public string Currency { get; set; }

        /// <summary>
        /// Not documented
        /// </summary>
        public string Pricing { get; set; }

        /// <summary>
        /// Not documented
        /// </summary>
        public int Max { get; set; }

        /// <summary>
        /// The policies list
        /// </summary>
        public List<Policy> Policies { get; set; }

        /// <summary>
        /// Not documented
        /// </summary>
        public string Range { get; set; }
    }
}