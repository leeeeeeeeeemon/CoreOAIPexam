using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AudiAPI.Models;
using static CoreOAIPexam.DBconnection;
using Bogus.DataSets;
using DocumentFormat.OpenXml.Wordprocessing;
using CoreOAIPexam;

namespace AudiAPI.Service
{
    public static class ProjectService
    {
        static List<AutoM> Autos { get; }
        static List<Auto> AutoBD;

        static ProjectService()
        {
            AutoBD = GetAutos();
            Autos = new List<AutoM> { };
           // Autos.AddRange(AutoBD.ToArray());
           foreach(var f in AutoBD)
            {
                //Autos.Add(new AutoM() { id_auto = f.id_auto, model = f.model, name = f.name, category = f.category, engine_power = (int)f.engine_power, acceleration_from_0_to_100_sec____ = f.acceleration_from_0_to_100_sec____, characterisric = f.characteristic, price = (Decimal)f.price });
                Autos.Add(new AutoM() {id_auto = f.id_auto, model = f.model, name = f.name, category= f.category, acceleration_from_0_to_100_sec____ = f.acceleration_from_0_to_100_sec____, characterisric = f.characteristic });
            }
            
        }
        public static List<AutoM> GetAll() => Autos;

        public static AutoM Get(int id) => Autos.FirstOrDefault(p => p.id_auto == id);

        public static void Add(Auto autom)
        {
            AddCar(autom);
        }

        public static void Delete(int id)
        {
            var auto = Get(id);
            if (auto is null)
                return;

            DeleteCar(id);
        }

        public static void Update(int id, Auto auto)
        {
            
            UpdateAuto(id, auto);
        }

    }
}
