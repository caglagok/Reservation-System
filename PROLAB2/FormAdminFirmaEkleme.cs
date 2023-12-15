using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prolab2
{
    public partial class FormAdminFirmaEkleme : Form
    {
        public FormAdminFirmaEkleme()
        {
            InitializeComponent();
        }
        public string kullaniciadi
        {
            get
            {
                return textBox1.Text;
            }
            set
            {
                textBox1.Text = value;
            }
        }
        public string sifre
        {
            get
            {
                return textBox3.Text;
            }
            set
            {
                textBox3.Text = value;
            }
        }
        public string firmaadi
        {
            get
            {
                return textBox2.Text;
            }
            set
            {
                textBox2.Text = value;
            }
        }


        public event Action<string, string, string> FirmaBilgileriGüncelle;

        private void button2_Click(object sender, EventArgs e)
        {
            FirmaBilgileriGüncelle?.Invoke(firmaadi, kullaniciadi, sifre);
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
