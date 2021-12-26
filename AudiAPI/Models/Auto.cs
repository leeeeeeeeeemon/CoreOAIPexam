using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AudiAPI.Models
{
    public class Auto
    {
        int Id { get; set; }
        string model { get; set; }
        string name { get; set; }
        string category { get; set; }
        int engine_power { get; set; }
        string acceleration_from_0_to_100sec { get; set; }
        decimal price { get; set; }
        string characterisric{ get; set; }
    }
}
