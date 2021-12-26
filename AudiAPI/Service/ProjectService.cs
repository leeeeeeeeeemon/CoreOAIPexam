using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AudiAPI.Models;
using Bogus.DataSets;
using DocumentFormat.OpenXml.Wordprocessing;

namespace AudiAPI.Service
{
    public static class ProjectService
    {
        static List<AutoM> Autos { get; }


        static ProjectService()
        {
            Autos = new List<AutoM>
            {
                new AutoM
                {
                    id_auto = 1,
                    model = "2",
                    name = "2",
                    category = "2",
                    engine_power = 4,
                    acceleration_from_0_to_100sec = "2.1",
                    price = 1000,
                    characterisric = "2"
                }
            };
        }
        public static List<AutoM> GetAll() => Autos;
    }
}
