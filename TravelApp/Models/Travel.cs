using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TravelApp.Models
{
    public class Travel
    {
        public int OriginId { get; set; }
        public int DestinationId { get; set; }
        public string DepartureDate { get; set; }
    }
    
}
