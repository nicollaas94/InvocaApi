using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoca.Core.Model.Network
{
    public class AdvertiserCampaingResponse
    {
        public int Id { get; set; }
        public string IdFromNetwork { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public string ObjectUrl { get; set; }
        public CurrentTerms CurrentTerms { get; set; }
        public FutureTerms FutureTerms { get; set; }
        public CustomData CustomData { get; set; }
    }
}
