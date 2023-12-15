using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace prolab2
{
    public partial class FormAracEkleme : Form
    {
        public string aracadi
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
        public string seferno
        {
            get
            {
                return comboBox1.Text;
            }
            set
            {
                comboBox1.Text = value;
            }
        }

        public string koltuksayisi
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
        public FormAracEkleme()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string kontrol = textBox1.Text;

            if (kontrol.StartsWith("Otobüs"))
            {
                comboBox1.Items.Clear();

                comboBox1.Items.Add("Sefer3");
                comboBox1.Items.Add("Sefer4");
            }
            else if (kontrol.StartsWith("Tren"))
            {
                comboBox1.Items.Clear();

                comboBox1.Items.Add("Sefer1");
                comboBox1.Items.Add("Sefer2");
            }
            else if (kontrol.StartsWith("Uçak"))
            {
                comboBox1.Items.Clear();

                comboBox1.Items.Add("Sefer5");
                comboBox1.Items.Add("Sefer6");
            }

        }

        public event Action<string, string, string> AracBilgileriGüncelle;
        private void button1_Click(object sender, EventArgs e)
        {
            AracBilgileriGüncelle?.Invoke(aracadi, koltuksayisi, seferno);
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
