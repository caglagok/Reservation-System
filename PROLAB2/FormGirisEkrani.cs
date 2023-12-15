using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace prolab2
{
    public partial class FormGirisEkrani : Form
    {
        public FormGirisEkrani()
        {
            InitializeComponent();
        }
        public class GirisKontrol
        {
            public static string AdminKullaniciAdi = "admin";
            public static string AdminSifre = "admin";

            public static string KullaniciAdiFirmaA = "firmaA";
            public static string SifreFirmaA = "firmaA";

            public static string KullaniciAdiFirmaB = "firmaB";
            public static string SifreFirmaB = "firmaB";

            public static string KullaniciAdiFirmaC = "firmaC";
            public static string SifreFirmaC = "firmaC";

            public static string KullaniciAdiFirmaD = "firmaD";
            public static string SifreFirmaD = "firmaD";

            public static string KullaniciAdiFirmaF = "firmaF";
            public static string SifreFirmaF = "firmaF";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == GirisKontrol.AdminKullaniciAdi && textBox2.Text == GirisKontrol.AdminSifre)
            {
                FormAdmin adminform = new FormAdmin();
                adminform.Show();
                this.Hide();
            }
            else if (textBox1.Text == GirisKontrol.KullaniciAdiFirmaA && textBox2.Text == GirisKontrol.SifreFirmaA)
            {
                FormAfirma afirma = new FormAfirma(GirisKontrol.KullaniciAdiFirmaA);
                afirma.Show();
                this.Hide();
            }
            else if (textBox1.Text == GirisKontrol.KullaniciAdiFirmaB && textBox2.Text == GirisKontrol.SifreFirmaB)
            {
                FormAfirma bfirma = new FormAfirma(GirisKontrol.KullaniciAdiFirmaB);
                bfirma.Show();
                this.Hide();
            }
            else if (textBox1.Text == GirisKontrol.KullaniciAdiFirmaC && textBox2.Text == GirisKontrol.SifreFirmaC)
            {
                FormAfirma afirma = new FormAfirma(GirisKontrol.KullaniciAdiFirmaC);
                afirma.Show();
                this.Hide();
            }
            else if (textBox1.Text == GirisKontrol.KullaniciAdiFirmaD && textBox2.Text == GirisKontrol.SifreFirmaD)
            {
                FormAfirma afirma = new FormAfirma(GirisKontrol.KullaniciAdiFirmaD);
                afirma.Show();
                this.Hide();
            }
            else if (textBox1.Text == GirisKontrol.KullaniciAdiFirmaF && textBox2.Text == GirisKontrol.SifreFirmaF)
            {
                FormAfirma afirma = new FormAfirma(GirisKontrol.KullaniciAdiFirmaF);
                afirma.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Geçersiz kullanıcı türü!");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }
    }
}

