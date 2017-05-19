using System.Collections.Generic;

namespace Invoca.Core.Model.Network.Advertiser.Campaigns
{
    public class AffiliatePayout
    {
        public double? Min { get; set; }
        public double? Max { get; set; }
        public string Currency { get; set; }
        public string Range { get; set; }
        public string Pricing { get; set; }
        public List<Policy> Policies { get; set; }
    }
}