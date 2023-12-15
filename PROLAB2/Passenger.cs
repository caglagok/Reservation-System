using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prolab2
{
    public class Passenger : Person
    {
        public string AracAdi { get; set; }
        public string TC { get; set; }
        public string DogumTarihi { get; set; }
        public string KoltukNo { get; set; }
        public int Fiyat { get; set; }
        public static string ad { get; }
        public static string soyad { get; }

        public Passenger(string Tc, string dogumtarihi, string aracadi, string koltukno, int fiyat) : base(ad, soyad)
        {
            Ad = ad;
            Soyad = soyad;
            TC = Tc;
            DogumTarihi = dogumtarihi;
            AracAdi = aracadi;
            Fiyat = fiyat;
            KoltukNo = koltukno;

        }

        public Passenger(): base(ad,soyad)
        {
        }

        public List<Passenger> passengerlist = new List<Passenger>
        {

        };
    }
}
