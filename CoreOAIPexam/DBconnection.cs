using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace CoreOAIPexam
{
    public class DBconnection
    {
        public static AudiDodelat_33__33__33__33__33__33__33Entities1 connection = new AudiDodelat_33__33__33__33__33__33__33Entities1();
        

        public static List<Auto> GetAutos()
        {
            return new List<Auto>(connection.Auto);
        }

        public static void AddCar(Auto avto)
        {
            connection.Auto.Add(avto);
            connection.SaveChanges();
        }

        public static void DeleteCar(int id)
        {
            
            Auto deletAuto = connection.Auto.FirstOrDefault<Auto>(p => p.id_auto == id);
            connection.Auto.Remove(deletAuto);
            connection.SaveChanges();
        }
        public static void DeleteCar(string name)
        {

            Auto deletAuto = connection.Auto.FirstOrDefault<Auto>(p => p.name == name);
            connection.Auto.Remove(deletAuto);
            connection.SaveChanges();
        }

        public static void UpdateAuto(int id,Auto avto)
        {
            Auto updateAuto = connection.Auto.FirstOrDefault<Auto>(p => p.id_auto == id);
            updateAuto = avto;
            connection.SaveChanges();

        }
    }
}
