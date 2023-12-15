using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prolab2
{
    public interface ILoginable
    {
        static string KullaniciAdi { get; set; }
        static string KullaniciSifresi { get; set; }

        bool Login(string kullaniciadi, string sifre);
    }
}
