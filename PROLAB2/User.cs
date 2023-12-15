using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace prolab2
{
    public abstract class User : ILoginable
    {
        public static string KullaniciAdi { get; set; }
        public static string KullaniciSifresi { get; set; }

        public bool Login(string kullaniciAdi, string sifre)
        {
            return KullaniciAdi == kullaniciAdi && KullaniciSifresi == sifre;
        }
        public User(string kullaniciadi, string kullanicisifresi)
        {
            KullaniciAdi = kullaniciadi;
            KullaniciSifresi = kullanicisifresi;
        }
    }
}
