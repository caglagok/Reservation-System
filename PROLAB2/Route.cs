using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace prolab2
{
    public class Route
    {
        public string SeferAdi { get; set; }
        public int SeferUcreti { get; set; }
        public Route(string seferadi, int seferucreti)
        {
            SeferAdi = seferadi;
            SeferUcreti = seferucreti;
        }

        public static List<Route> rotalistesi()
        {
            List<Route> routes = new List<Route>()
        {
            new Route("Sefer1", 250),
            new Route("Sefer2", 300),
            new Route("Sefer3", 300),
            new Route("Sefer4", 300),
            new Route("Sefer5", 1200),
            new Route("Sefer6", 1000),
        };
            return routes;
        }
       

    }
}
