using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreOAIPexam;

namespace AudiWeb.Core
{
    
    public class AutoStorage
    {
        //public static List<Auto> Autos { get; set; } = new List<Auto>
        //{

        //    new Auto
        //    {
        //        name = "CGI Examples",
        //        model = "https://github.com/kdrygin/CgiExamples",
        //        characteristic = "dotNet Core 3.1 C# CGI Examples"
        //    }
        //};
        public static List<Auto> Autos { get; set; } = DBconnection.GetAutos();

        public static void Add(Auto auto)
        {
            CoreOAIPexam.DBconnection.AddCar(auto);
        }

        public static void RemoveByName(string nameSSS)
        {
            
            CoreOAIPexam.DBconnection.DeleteCar(nameSSS);
        }

    }
}
