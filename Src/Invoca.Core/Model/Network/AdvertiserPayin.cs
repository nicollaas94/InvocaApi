using System.Collections.Generic;

namespace Invoca.Core.Model.Network
{
    public class AdvertiserPayin
    {
        public int Min { get; set; }
        public string Currency { get; set; }
        public string Pricing { get; set; }
        public int Max { get; set; }
        public List<Policy> Policies { get; set; }
        public string Range { get; set; }
    }
}