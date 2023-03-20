using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks.Sweeft.CountriesAPI.Models
{
    public class Country
    {
        public Name name { get; set; }
        public string region { get; set; }
        public string subregion { get; set; }
        public IEnumerable<decimal> latlng { get; set; }
        public decimal area { get; set; }
        public ulong population { get; set; }
    }
}
