using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prolab2
{
    public interface IProfitable
    {
        public class Sefer
        {
            public string[] Duraklar { get; set; }
            public string UlasimTipi { get; set; }
            public int SeferUcreti { get; set; }
        }
        public int gunlukYakitGideri(List<Sefer> yakit);
    }
}
