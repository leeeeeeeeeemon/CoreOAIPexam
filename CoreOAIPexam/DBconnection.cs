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
        //private static string connStr = ConfigurationManager.ConnectionStrings["AudiDodelat_33__33__33__33__33__33__33"].ConnectionString;
        //public static IDbConnection connection2 = new SqlConnection(connStr);

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
            //var deleteDetail =
            //    from Auto in connection.Auto
            //    where Auto.id_auto == id
            //    select Auto;
            //foreach(var detail in deleteDetail)
            //{
            //    connection.Auto.At(detail);
            //    connection.SaveChanges();
            //}
            //connection2.Query($"delete [dbo].[Auto] where [id_auto] = {id}");
            //try
            //{
            //    SqlConnection con = new SqlConnection(connStr);
            //    SqlCommand cmd = new SqlCommand($"DELETE  from [Auto] where id_auto = {id}");
            //    con.Open();
            //    cmd.ExecuteNonQuery();
            //    con.Close();
            //}
            //catch (SqlException)
            //{

            //}
            Auto deletAuto = connection.Auto.FirstOrDefault<Auto>(p => p.id_auto == id);
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
