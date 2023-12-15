using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prolab2
{
    public abstract class Vehicle
    {
        public string Yakit { get; set; }
        public string Firma { get; set; }
        public string SeferNo { get; set; }
        public string KoltukSaysi { get; set; }

        public abstract double CalculateFuelCost(string arananfirmaadi);

    }
}
