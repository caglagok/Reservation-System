using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace prolab2
{
    public class Transport : IReservable
    {
        public string Firma { get; set; }
        public string Seferno { get; set; }
        public string AracNo { get; set; }
        public string KoltukSayisi { get; set; }
        public int KilometreUcreti {  get; set; }
        public int Kilometre { get; set; }
        public Transport(string aracno, string koltuksayisi, string seferno)
        {
            Seferno = seferno;
            AracNo = aracno;
            KoltukSayisi = koltuksayisi;
        }


        public static List<Transport> TransportListA = new List<Transport>()
        {
            new Transport("Otobüs1", "20","Sefer3"),
            new Transport("Otobüs2","15", "Sefer3"),
        };
        public static List<Transport> TransportListB = new List<Transport>()
        {
            new Transport("Otobüs1", "15","Sefer3"),
            new Transport("Otobüs2","20", "Sefer4"),
        };
        public static List<Transport> TransportListC = new List<Transport>()
        {
            new Transport("Otobüs1", "20","Sefer4"),
            new Transport("Uçak1","30", "Sefer5"),
            new Transport("Uçak2","30", "Sefer5"),
        };
        public static List<Transport> TransportListD = new List<Transport>()
        {
            new Transport("Tren1", "25","Sefer1"),
            new Transport("Tren2","25", "Sefer2"),
            new Transport("Tren3","25", "Sefer2"),
        };
        public static List<Transport> TransportListF = new List<Transport>()
        {
            new Transport("Uçak1", "30","Sefer6"),
            new Transport("Uçak2","30", "Sefer6"),
        };

        public int reservable(string firmaadi)
        {
            throw new NotImplementedException();
        }
        public static int[] ToplamFiyatHesapla()
        {
            List<Route> routeList = Route.rotalistesi();
            int toplamA = 0, toplamB = 0, toplamC = 0, toplamD = 0, toplamF = 0;

            foreach (Route route in routeList)
            {
                string routeName = route.SeferAdi;

                foreach (Transport transport in TransportListA)
                {
                    if (transport.Seferno == routeName)
                    {
                        toplamA += route.SeferUcreti;
                    }
                }

                foreach (Transport transport in TransportListB)
                {
                    if (transport.Seferno == routeName)
                    {
                        toplamB += route.SeferUcreti;
                    }
                }

                foreach (Transport transport in TransportListC)
                {
                    if (transport.Seferno == routeName)
                    {
                        toplamC += route.SeferUcreti;
                    }
                }

                foreach (Transport transport in TransportListD)
                {
                    if (transport.Seferno == routeName)
                    {
                        toplamD += route.SeferUcreti;
                    }
                }

                foreach (Transport transport in TransportListF)
                {
                    if (transport.Seferno == routeName)
                    {
                        toplamF += route.SeferUcreti;
                    }
                }
            }

            Random random = new Random();
            int randomSayiA = random.Next(10, 36);
            toplamA = toplamA * randomSayiA;

            int randomSayiB = random.Next(10, 36);
            toplamB = toplamB * randomSayiB;

            int randomSayiC = random.Next(10, 81);
            toplamC = toplamC * randomSayiC;

            int randomSayiD = random.Next(10, 76);
            toplamD = toplamD * randomSayiD;

            int randomSayiF = random.Next(10, 61);
            toplamF = toplamF * randomSayiF;


            return new int[] { toplamA, toplamB, toplamC, toplamD, toplamF };
        }
    }
}
