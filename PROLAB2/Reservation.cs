using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prolab2
{
    public class Reservation
    {
        public string Ad { get; set; }
        public string Soyad {  get; set; }
        public string AracAdi { get; set; }
        public string TC { get; set; }
        public string DogumTarihi { get; set; }
        public string KoltukNo { get; set; }
        public int Fiyat { get; set; }

        public Reservation()
        {
            
        }

        public Reservation(string ad, string soyad, string Tc, string dogumtarihi, string aracadi, string koltukno, int fiyat)
        {
            Ad = ad;
            Soyad = soyad;
            AracAdi = aracadi;
            TC = Tc;
            DogumTarihi = dogumtarihi;
            Fiyat = fiyat;
        }

        public List<Reservation> rezervation = new List<Reservation>
        {

        };

    }
}

