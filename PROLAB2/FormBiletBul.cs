using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static prolab2.Trip;

namespace prolab2
{
    public partial class FormBiletBul : Form
    {
        Trip trip = new Trip();
        public FormBiletBul()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string binis = listBox1.SelectedItem.ToString();
            string varis = listBox2.SelectedItem.ToString();
            int kisiSayisi = Convert.ToInt32(listBox3.SelectedItem.ToString());

            KullaniciBilgisi kullanici = new KullaniciBilgisi
            {
                BinisDuragi = binis,
                InisDuragi = varis
            };
            List<Sefer> uygunSeferler = trip.UygunSeferiBul(kullanici);
            if (uygunSeferler.Count > 0)
            {
                FormSeferBilgi formSeferBilgi = new FormSeferBilgi(uygunSeferler, kisiSayisi, binis, varis);
                formSeferBilgi.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Uygun sefer bulunamadı.");
            }
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
