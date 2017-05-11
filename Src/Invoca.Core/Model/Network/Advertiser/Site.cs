namespace Invoca.Core.Model.Network.Advertiser
{
    public class Site
    {
        /// <summary>
        /// integer site_id (PID)	The site_id (PID). At least one is required. The first becomes the default.
        /// </summary>
        public string IdFromNetwork { get; set; }

        /// <summary>
        /// string	The site name that matches site_id.
        /// </summary>
        public string Name { get; set; }
    }

}
