using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prolab2
{
    public class Company : User, IProfitable
    {
        public string FirmaAdi { get; set; }
        public string Kullaniciadi { get; set; }
        public string Kullanicisifresi { get; set; }
        public Company(string firmaadi, string kullaniciadi, string sifre) :base(kullaniciadi, sifre)
        {
            FirmaAdi = firmaadi;
            Kullanicisifresi = sifre;
            Kullaniciadi = kullaniciadi;

        }
        public class Yakit
        {
            public string Firma { get; set; }
            public string yakit { get; set; }
            public int yakitucreti { get; set; }

        }
        public List<Yakit> yakit = new List<Yakit>
        {
            new Yakit{Firma="A Firması",yakit="Benzin",yakitucreti=10},
            new Yakit{Firma="B Firması",yakit="Motorin",yakitucreti=5},
            new Yakit{Firma="C Firması",yakit="Motorin",yakitucreti=6},
            new Yakit{Firma="C Firması",yakit="Gaz",yakitucreti=25},
            new Yakit{Firma="D Firması",yakit="Elektrik",yakitucreti=3},
            new Yakit{Firma="F Firması",yakit="Gaz",yakitucreti=20},
        };

        public bool Login(string kullaniciAdi, string Sifre)
        {
            return KullaniciAdi == KullaniciAdi && KullaniciSifresi == Sifre;
        }


        int IProfitable.gunlukYakitGideri(List<IProfitable.Sefer> yakit)
        {
            throw new NotImplementedException();
        }

        public static List<Company> companyList = new List<Company>
        {
            new Company("Firma A", "firmaA", "firmaA"),
            new Company("Firma B", "firmaB", "firmaB"),
            new Company("Firma C", "firmaC", "firmaC"),
            new Company("Firma D", "firmaD", "firmaD"),
            new Company("Firma F", "firmaF", "firmaF")
        };

        public class FirmaBilgisi
        {
            public string FirmaAdi { get; set; }
            public string AracTuru { get; set; }
            public int SeferNo { get; set; }
            public double SeferKilometresi { get; set; }
            public double KilometreBasiYakitFiyati { get; set; }
        }
        public static List<FirmaBilgisi> firmaBilgisi()
        {
            List<FirmaBilgisi> firmaListesi = new List<FirmaBilgisi>
        {
            new FirmaBilgisi { FirmaAdi = "FirmaA", AracTuru = "Otobüs1", SeferNo = 3, SeferKilometresi = 500, KilometreBasiYakitFiyati = 10 },
            new FirmaBilgisi { FirmaAdi = "FirmaA", AracTuru = "Otobüs2", SeferNo = 3, SeferKilometresi = 500, KilometreBasiYakitFiyati = 10 },
            new FirmaBilgisi { FirmaAdi = "FirmaB", AracTuru = "Otobüs1", SeferNo = 3, SeferKilometresi = 500, KilometreBasiYakitFiyati = 5 },
            new FirmaBilgisi { FirmaAdi = "FirmaB", AracTuru = "Otobüs2", SeferNo = 4, SeferKilometresi = 600, KilometreBasiYakitFiyati = 5 },
            new FirmaBilgisi { FirmaAdi = "FirmaC", AracTuru = "Otobüs1", SeferNo = 4, SeferKilometresi = 600, KilometreBasiYakitFiyati = 6 },
            new FirmaBilgisi { FirmaAdi = "FirmaC", AracTuru = "Uçak1", SeferNo = 5, SeferKilometresi = 300, KilometreBasiYakitFiyati = 25 },
            new FirmaBilgisi { FirmaAdi = "FirmaC", AracTuru = "Uçak2", SeferNo = 5, SeferKilometresi = 300, KilometreBasiYakitFiyati = 25 },
            new FirmaBilgisi { FirmaAdi = "FirmaD", AracTuru = "Tren1", SeferNo = 1, SeferKilometresi = 375, KilometreBasiYakitFiyati = 3 },
            new FirmaBilgisi { FirmaAdi = "FirmaD", AracTuru = "Tren2", SeferNo = 2, SeferKilometresi = 450, KilometreBasiYakitFiyati = 3 },
            new FirmaBilgisi { FirmaAdi = "FirmaD", AracTuru = "Tren3", SeferNo = 2, SeferKilometresi = 450, KilometreBasiYakitFiyati = 3 },
            new FirmaBilgisi { FirmaAdi = "FirmaF", AracTuru = "Uçak1", SeferNo = 6, SeferKilometresi = 250, KilometreBasiYakitFiyati = 20 },
            new FirmaBilgisi { FirmaAdi = "FirmaF", AracTuru = "Uçak2", SeferNo = 6, SeferKilometresi = 250, KilometreBasiYakitFiyati = 20 },
        };
            return firmaListesi;

        }

    }
}
