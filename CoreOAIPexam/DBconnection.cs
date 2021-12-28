using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Collections.ObjectModel;

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

        public static void buyCar(string name)
        {
            Auto buyAuto = connection.Auto.FirstOrDefault<Auto>(p => p.name == name);
            Sale_Auto saleOp = new Sale_Auto();
            saleOp.id_auto = buyAuto.id_auto;
            saleOp.id_user = 1;
            saleOp.tlephon_number = "89393378504";
            connection.Sale_Auto.Add(saleOp);
            connection.SaveChanges();
        }
        public static void SaleCar(Sale_Auto sale)
        {
            connection.Sale_Auto.Add(sale);
            connection.SaveChanges();
        }

        public static void addCar(string modelT, string nameT, string categoryT, int engPwr, string accel, decimal priceD, string charT)
        {
            var u = new Auto();
            u.model = modelT;
            u.name = nameT;
            u.category = categoryT;
            u.engine_power = engPwr;
            u.acceleration_from_0_to_100_sec____ = accel;
            u.price = priceD;
            u.characteristic = charT;
            connection.Auto.Add(u);
            connection.SaveChanges();
        }

        public static ObservableCollection<users> GetUsers()
        {
            return new ObservableCollection<users>(connection.users.ToList());

        }
        public static void regUser(users user)
        {
            connection.users.Add(user);
            connection.SaveChanges();
        }
    }
}
