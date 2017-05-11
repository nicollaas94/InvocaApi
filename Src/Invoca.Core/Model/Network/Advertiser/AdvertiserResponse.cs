using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoca.Core.Model.Network.Advertiser
{
    public class AdvertiserResponse
    {
        /// <summary>
        /// integer (read-only)	The internal Invoca id for this Advertiser.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// string (required)	The network id for this Advertiser. Unique within network. Not required when auto-generation is enabled at network level.
        /// </summary>
        public string IdFromNetwork { get; set; }

        /// <summary>
        /// string
        /// </summary>
        public string WebIntegrationPhoneNumber { get; set; }

        /// <summary>
        /// string (one of): Applied, Approved (default), Declined, Suspended, Archived	Approval status for this advertiser.
        /// </summary>
        public string ApprovalStatus { get; set; }

        /// <summary>
        /// string (read-only)	URL for reaching the advertiser in the UI.
        /// </summary>
        public string ObjectUrl { get; set; }

        /// <summary>
        ///  array of hashes	1 or more pairs of id_from_network [and name].
        /// </summary>
        public List<Site> Sites { get; set; }

        /// <summary>
        /// string (required)	The name of the Advertiser. Unique within network.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// array of hashes	0 or more users for the organization.
        /// </summary>
        public List<User> Users { get; set; }

        /// <summary>
        /// integer
        /// </summary>
        public string DefaultCreativeIdFromNetwork { get; set; }
        public string OauthRefreshToken { get; set; }
    }

}
