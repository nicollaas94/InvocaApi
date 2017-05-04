using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoca.Core.Model.Network.PromoNumbers
{
    public class PromoNumbersResponse
    {
        public int Id { get; set; }
        public string IdFromNetwork { get; set; }
        public string MediaType { get; set; }
        public string Description { get; set; }
        public string PromoNumber { get; set; }
        public string ObjectUrl { get; set; }
        public CustomData CustomData { get; set; }
    }
}
