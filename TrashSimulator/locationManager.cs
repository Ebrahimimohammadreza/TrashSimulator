using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrashSimulator
{
    public static class locationManager
    {

        public static double getDistance(double lat1,double lat2,double lon1,double lon2)
        {
            var p = 0.017453292519943295;
            var a =0.5  - Math.Cos ((lat2-lat1)*p)/2 + Math.Cos(lat1* p)* Math.Cos(lat2*p)*(1-Math.Cos((lon2-lon1)*p))/2;
            return 12742 * Math.Asin(Math.Sqrt(a));
        }


        public static double Latitude ()
        {
            Random rnd = new Random();
            return 51 + rnd.NextDouble();
        }

        public static double Longitude()
        {
            Random rnd = new Random();
            return 35 + rnd.NextDouble();
        }

    }
}
