namespace Invoca.Core.Model.Network.Advertiser.Campaigns
{
    public class AdvertiserCampaingResponse
    {
        /// <summary>
        /// integer (read-only)	The internal Invoca id for this Advertiser Campaign.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// string	The network object_id for this Advertiser Campaign. Unique within network. Not required when auto-generation is enabled at network level.
        /// </summary>
        public string IdFromNetwork { get; set; }

        /// <summary>
        /// string	Campaign name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Not documented
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// string (read-only)	URL for reaching the advertiser campaign in the UI.
        /// </summary>
        public string ObjectUrl { get; set; }

        /// <summary>
        /// The current terms object
        /// </summary>
        public CurrentTerms CurrentTerms { get; set; }

        /// <summary>
        /// The Future terms object
        /// </summary>
        public FutureTerms FutureTerms { get; set; }

        /// <summary>
        /// The Custom data object
        /// </summary>
        public CustomData CustomData { get; set; }
    }
}
