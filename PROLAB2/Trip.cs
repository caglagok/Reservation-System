using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prolab2
{
    public class Trip
    {
        public List<Sefer> uygunSeferler = new List<Sefer>();
        public class Sefer
        {
            public string[] Duraklar { get; set; }
            public string UlasimTipi { get; set; }
        }

        public class KullaniciBilgisi
        {
            public string BinisDuragi { get; set; }
            public string InisDuragi { get; set; }
        }
        public static List<Sefer> dondur()
        {
            List<Sefer> seferler = new List<Sefer>
            {
                //gidiş
                new Sefer { Duraklar = new[]{"Sefer1","İstanbul", "Kocaeli", "Bilecik", "Eskişehir", "Ankara"}, UlasimTipi = "D Firması/Tren1"},
                new Sefer { Duraklar = new[]{"Sefer2","İstanbul", "Kocaeli", "Bilecik", "Eskişehir", "Konya" }, UlasimTipi = "D Firması/Tren2"},
                new Sefer { Duraklar = new[]{"Sefer2","İstanbul", "Kocaeli", "Bilecik", "Eskişehir", "Konya" }, UlasimTipi = "D Firması/Tren3"},
                new Sefer { Duraklar = new[]{"Sefer3","İstanbul", "Kocaeli", "Ankara"}, UlasimTipi = "A Firması/Otobüs1"},
                new Sefer { Duraklar = new[]{"Sefer3","İstanbul", "Kocaeli", "Ankara" }, UlasimTipi = "A Firması/Otobüs2"},
                new Sefer { Duraklar = new[]{"Sefer3","İstanbul", "Kocaeli", "Ankara" }, UlasimTipi = "B Firması/Otobüs1"},
                new Sefer { Duraklar = new[]{"Sefer4","İstanbul", "Kocaeli", "Eskişehir", "Konya" }, UlasimTipi = "B Firması/Otobüs2"},
                new Sefer { Duraklar = new[]{"Sefer4","İstanbul", "Kocaeli", "Eskişehir", "Konya" }, UlasimTipi = "C Firması/Otobüs1"},
                new Sefer { Duraklar = new[]{"Sefer5","İstanbul", "Konya" }, UlasimTipi = "C Firması/Uçak1"},
                new Sefer { Duraklar = new[]{"Sefer5","İstanbul", "Konya" }, UlasimTipi = "C Firması/Uçak2"},
                new Sefer { Duraklar = new[]{"Sefer6","İstanbul", "Ankara" }, UlasimTipi = "F Firması/Uçak1"},
                new Sefer { Duraklar = new[]{"Sefer6","İstanbul", "Ankara" }, UlasimTipi = "F Firması/Uçak2"},
                //donus
                new Sefer { Duraklar = new[]{"Sefer1","Ankara", "Eskişehir", "Bilecik", "Kocaeli", "İstanbul" }, UlasimTipi = "D Firması/Tren1"},
                new Sefer { Duraklar = new[]{"Sefer2","Konya", "Eskişehir", "Bilecik", "Kocaeli", "İstanbul" }, UlasimTipi = "D Firması/Tren2"},
                new Sefer { Duraklar = new[]{"Sefer2","Konya", "Eskişehir", "Bilecik", "Kocaeli", "İstanbul" }, UlasimTipi = "D Firması/Tren3"},
                new Sefer { Duraklar = new[]{"Sefer3","Ankara", "Kocaeli", "İstanbul" }, UlasimTipi = "A Firması/Otobüs1"},
                new Sefer { Duraklar = new[]{"Sefer3","Ankara", "Kocaeli", "İstanbul" }, UlasimTipi = "A Firması/Otobüs2"},
                new Sefer { Duraklar = new[]{"Sefer3","Ankara", "Kocaeli", "İstanbul" }, UlasimTipi = "B Firması/Otobüs1"},
                new Sefer { Duraklar = new[]{"Sefer4","Konya", "Eskişehir", "Kocaeli", "İstanbul" }, UlasimTipi = "B Firması/Otobüs2"},
                new Sefer { Duraklar = new[]{"Sefer4","Konya", "Eskişehir", "Kocaeli", "İstanbul" }, UlasimTipi = "C Firması/Otobüs1"},
                new Sefer { Duraklar = new[]{"Sefer5","Konya", "İstanbul" }, UlasimTipi = "C Firması/Uçak1"},
                new Sefer { Duraklar = new[]{"Sefer5","Konya", "İstanbul" }, UlasimTipi = "C Firması/Uçak2"},
                new Sefer { Duraklar = new[]{"Sefer6","Ankara", "İstanbul" }, UlasimTipi = "F Firması/Uçak1"},
                new Sefer { Duraklar = new[]{"Sefer6","Ankara", "İstanbul" }, UlasimTipi = "F Firması/Uçak2"},
            };
            return seferler;
        }

        List<Sefer> seferlerList = Trip.dondur();
        public List<Sefer> UygunSeferiBul(KullaniciBilgisi kullanici)
        {
            uygunSeferler.Clear(); 

            foreach (var sefer in seferlerList)
            {
                int binisIndex = Array.IndexOf(sefer.Duraklar, kullanici.BinisDuragi);
                int inisIndex = Array.IndexOf(sefer.Duraklar, kullanici.InisDuragi);

                if (binisIndex != -1 && inisIndex != -1 && binisIndex < inisIndex)
                {
                    uygunSeferler.Add(sefer); 
                }
            }
            return uygunSeferler; 
        }

    }
}
