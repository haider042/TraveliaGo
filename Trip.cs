using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavelia_Go.Shared
{
    public class Trip
    {
        public int Id { get; set; }
        public string? Destination { get; set; }
        public DateTime DepartureDate { get; set; }
        public decimal Price { get; set; }
    }
}
