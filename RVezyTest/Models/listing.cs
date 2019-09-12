using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RVezyTest.Models
{
    public class Listing
    {
        public string id { get; set; }
        public string listing_url { get; set; }
        public string name { get; set; }
        public string summary { get; set; }
        public string space { get; set; }
        public string description { get; set; }
        public string property_type { get; set; }
    }
}
