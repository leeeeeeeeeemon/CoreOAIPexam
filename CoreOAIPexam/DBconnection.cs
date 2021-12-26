using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreOAIPexam
{
    class DBconnection
    {
        public static AudiDodelat_33__33__33__33__33__33__33Entities connection = new AudiDodelat_33__33__33__33__33__33__33Entities();

        public List<Auto> GetAutos()
        {
            return new List<Auto>(connection.Auto);
        }
    }
}
