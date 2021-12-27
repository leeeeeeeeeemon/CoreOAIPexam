using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreOAIPexam
{
    public class DBconnection
    {
        public static AudiDodelat_33__33__33__33__33__33__33Entities connection = new AudiDodelat_33__33__33__33__33__33__33Entities();

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
            var deleteDetail =
                from Auto in connection.Auto
                where Auto.id_auto == id
                select Auto;
            foreach(var detail in deleteDetail)
            {
                connection.Auto.Remove(detail);
            }
        }

        public static void Update(Auto avto)
        {

        }
    }
}
