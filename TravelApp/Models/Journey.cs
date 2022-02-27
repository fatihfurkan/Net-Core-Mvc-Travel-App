using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelApp.Models
{
    public class Journey
    {
        public string Origin { get; set; }
        public string Destination { get; set; }
        public string Arrival { get; set; }
        public string Departure { get; set; }
        public string OriginalPrice { get; set; }
    }
}
