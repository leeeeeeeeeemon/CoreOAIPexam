using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AudiAPI.Models
{
    public class AutoM
    {
        public int id_auto { get; set; }
        public string model { get; set; }
        public string name { get; set; }
        public string category { get; set; }
        public int engine_power { get; set; }
        public string acceleration_from_0_to_100_sec____ { get; set; }
        public decimal price { get; set; }
        public string characterisric { get; set; }
    }
}
