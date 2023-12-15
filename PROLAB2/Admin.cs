using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prolab2
{
    public class Admin : User
    {
        public Admin (string kullaniciadi, string sifre) :base(kullaniciadi,sifre) 
        {
        }
        
        public bool Login(string kullaniciAdi, string sifre)
        {
            return KullaniciAdi == kullaniciAdi && KullaniciSifresi == sifre;
        }


    }
}
