using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prolab2
{
    public class Personel : Person
    {
        public static int PersonelSayisi = 4;
        public string FirmaTürüPersonel { get; set; }
        public string KullanilanArac { get; set; }
        public string Firmaadi { get; set; }
        public double Personelucreti { get; set; }
        public Personel(string firmaadi, string kullanilanArac, string name, string surname, string firmaTürüPersoneli, double personelucreti) : base(name, surname)
        {
            Firmaadi = firmaadi;
            FirmaTürüPersonel = firmaTürüPersoneli;
            KullanilanArac = kullanilanArac;
            Personelucreti = personelucreti;
        }
        public static List<Personel> PersonelListesi()
        {
            List<Personel> personelBilgi = new List<Personel>()
            {
                new Personel("A Firması", "Otobüs1", "Pargalı", "İbrahim", "Soför",5000),
                new Personel("A Firması", "Otobüs1", "Kanuni", "Sülüman", "Soför",5000),
                new Personel("A Firması", "Otobüs1", "Pargalı", "İbrahim", "Muavin",2000),
                new Personel("A Firması", "Otobüs1", "sherlock", "Holmes", "Muavin",2000),
                new Personel("A Firması", "Otobüs2", "Mimar", "Sinan", "Soför", 5000),
                new Personel("A Firması", "Otobüs2", "Cahit", "Arf", "Soför", 5000),
                new Personel("A Firması", "Otobüs2", "Nicole", "Tesla", "Muavin", 2000),
                new Personel("A Firması", "Otobüs2", "Sigmunt", "Freud", "Muavin", 2000),

                new Personel("B Firması", "Otobüs1", "Mihrimah", "Sultan", "Soför",3000),
                new Personel("B Firması", "Otobüs1", "Elon", "Musk", "Soför",3000),
                new Personel("B Firması", "Otobüs1", "Nigar", "Kalfa", "Muavin",1500),
                new Personel("B Firması", "Otobüs1", "Hande", "Yener", "Muavin",1500),
                new Personel("B Firması", "Otobüs2", "Steve", "Job", "Soför",3000),
                new Personel("B Firması", "Otobüs2", "Arda", "Turan", "Soför",3000),
                new Personel("B Firması", "Otobüs2", "Selena", "Gomez", "Muavin",1500),
                new Personel("B Firması", "Otobüs2", "Taylor", "Swift", "Muavin",1500),

                new Personel("C Firması", "Otobüs1", "Bugs", "Bunny", "Soför",4000),
                new Personel("C Firması", "Otobüs1", "Kraliçe", "Elsa", "Soför",4000),
                new Personel("C Firması", "Otobüs1", "Maden", "Suyu", "Muavin",2000),
                new Personel("C Firması", "Otobüs1", "Meyve", "Suyu", "Muavin",2000),
                new Personel("C Firması", "Uçak1", "Bugs", "Bunny", "Soför",10000),
                new Personel("C Firması", "Uçak1", "DR", "Watson", "Soför",10000),
                new Personel("C Firması", "Uçak1", "Paul", "Walker", "Muavin",6000),
                new Personel("C Firması", "Uçak1", "Dominic", "Toreto", "Muavin",6000),
                new Personel("C Firması", "Uçak2", "Bella", "Swan", "Soför",10000),
                new Personel("C Firması", "Uçak2", "Edward", "Cullen", "Soför", 10000),
                new Personel("C Firması", "Uçak2", "Jacob", "Black", "Muavin",6000),
                new Personel("C Firması", "Uçak2", "Seda", "Seyan", "Muavin", 6000),

                new Personel("D Firması", "Tren1", "Safıye", "Soyman", "Soför",2000),
                new Personel("D Firması", "Tren1", "Faik", "Soyman", "Soför",2000),
                new Personel("D Firması", "Tren1", "Bülent", "Ersoy", "Muavin",1000),
                new Personel("D Firması", "Tren1", "Banu", "Alkan", "Muavin",1000),
                new Personel("D Firması", "Tren2", "Gülben", "Ergen", "Soför", 2000),
                new Personel("D Firması", "Tren2", "Yıldırım", "Beyazıt", "Soför", 2000),
                new Personel("D Firması", "Tren2", "Beyazıt", "Öztürk", "Muavin",1000),
                new Personel("D Firması", "Tren2", "Tom", "Hiddetlison", "Muavin",1000),
                new Personel("D Firması", "Tren3", "Savcı", "Esra", "Soför",2000),
                new Personel("D Firması", "Tren3", "Kerem", "Bursin", "Soför",2000),
                new Personel("D Firması", "Tren3", "Behzat", "Ç", "Muavin", 1000),
                new Personel("D Firması", "Tren3", "Polat", "Alemdar", "Muavin", 1000),

                new Personel("F Firması", "Uçak1", "Hürrem", "Sultan", "Soför",7500),
                new Personel("F Firması", "Uçak1", "Abdul", "Hey", "Soför",7500),
                new Personel("F Firması", "Uçak1", "Memati", "Baş", "Muavin",4000),
                new Personel("F Firması", "Uçak1", "Emir", "Kozcuoğlu", "Muavin",4000),
                new Personel("F Firması", "Uçak2", "Barış", "Manço", "Soför",7500),
                new Personel("F Firması", "Uçak2", "Cem", "Karaca", "Soför",7500),
                new Personel("F Firması", "Uçak2", "Maraz", "Ali", "Muavin",4000),
                new Personel("F Firması", "Uçak2", "Adanalı", "Yavuz", "Muavin",4000),

            };

            return personelBilgi;
        }
        public static double ToplamPersonelUcreti(string firmaAdi)
        {
            List<Personel> personelListesi = Personel.PersonelListesi();

            double toplamUcret = personelListesi.Where(p => p.Firmaadi == firmaAdi).Sum(p => p.Personelucreti);

            return toplamUcret * 2;
        }
    }
}
