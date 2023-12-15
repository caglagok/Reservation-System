using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prolab2
{
    public class Bus : Vehicle
    {
        public Bus() { }

        public override double CalculateFuelCost(string arananFirmaAdi)
        {
            List<Company.FirmaBilgisi> firmaListesi = Company.firmaBilgisi();

            double toplamSonuc = 0;

            foreach (var firma in firmaListesi)
            {
                if (firma.FirmaAdi == arananFirmaAdi)
                {
                    double seferKilometresi = firma.SeferKilometresi;
                    double kilometreBasiYakitFiyati = firma.KilometreBasiYakitFiyati;

                    double sonuc = seferKilometresi * kilometreBasiYakitFiyati * 2;
                    toplamSonuc += sonuc;

                }
            }
            
            return toplamSonuc;
        }
    }
}
