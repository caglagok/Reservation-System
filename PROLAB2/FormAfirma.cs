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
    public partial class FormAfirma : Form
    {
        string KullaniciAdi;
        private double zarar;
        double kar;
        int hizmetBedeli = 1000;
        public FormAfirma(string kullaniciadi)
        {
            KullaniciAdi = kullaniciadi;
            InitializeComponent();
            Bus busnew = new Bus();
            Train trainnew = new Train();
            Airplane airplanenew = new Airplane();
            int[] toplamKazanc = Transport.ToplamFiyatHesapla();
            int kazancA = toplamKazanc[0];
            int kazancB = toplamKazanc[1];
            int kazancC = toplamKazanc[2];
            int kazancD = toplamKazanc[3];
            int kazancF = toplamKazanc[4];
            switch (KullaniciAdi)
            {
                case "firmaA":
                    foreach (Transport transport in Transport.TransportListA)
                    {
                        dataGridView1.Rows.Add(transport.AracNo, transport.KoltukSayisi, transport.Seferno);

                    }
                    zarar = busnew.CalculateFuelCost("FirmaA") + Personel.ToplamPersonelUcreti("A Firması");
                    kar = kazancA - zarar - hizmetBedeli;
                    break;
                case "firmaB":
                    foreach (Transport transport in Transport.TransportListB)
                    {
                        dataGridView1.Rows.Add(transport.AracNo, transport.KoltukSayisi, transport.Seferno);
                    }
                    zarar = busnew.CalculateFuelCost("FirmaB") + Personel.ToplamPersonelUcreti("B Firması");
                    kar = kazancB - zarar - hizmetBedeli;
                    break;
                case "firmaC":
                    foreach (Transport transport in Transport.TransportListC)
                    {
                        dataGridView1.Rows.Add(transport.AracNo, transport.KoltukSayisi, transport.Seferno);

                    }
                    zarar = (busnew.CalculateFuelCost("FirmaC") + airplanenew.CalculateFuelCost("FirmaC")) / 2 + Personel.ToplamPersonelUcreti("C Firması");
                    kar = kazancC - zarar - hizmetBedeli;
                    break;
                case "firmaD":
                    foreach (Transport transport in Transport.TransportListD)
                    {
                        dataGridView1.Rows.Add(transport.AracNo, transport.KoltukSayisi, transport.Seferno);

                    }
                    zarar = trainnew.CalculateFuelCost("FirmaD") + Personel.ToplamPersonelUcreti("D Firması");
                    kar = kazancD - zarar - hizmetBedeli;
                    break;
                case "firmaF":
                    foreach (Transport transport in Transport.TransportListF)
                    {
                        dataGridView1.Rows.Add(transport.AracNo, transport.KoltukSayisi, transport.Seferno);

                    }
                    zarar = airplanenew.CalculateFuelCost("FirmaF") + Personel.ToplamPersonelUcreti("F Firması");
                    kar = kazancF - zarar - hizmetBedeli;
                    break;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAracEkleme aracEkleme = new FormAracEkleme();

            aracEkleme.AracBilgileriGüncelle += (aracadi, koltuksayisi, seferno) =>
            {
                dataGridView1.Rows.Add(aracadi, koltuksayisi, seferno);
            };
            DialogResult result = aracEkleme.ShowDialog();
            if (result == DialogResult.OK)
            {
                Transport transportnew = new Transport(aracEkleme.aracadi, aracEkleme.koltuksayisi, aracEkleme.seferno);

                Train trainnew = new Train();
                Airplane airplanenew = new Airplane();
                switch (KullaniciAdi)
                {
                    case "firmaA":
                        Transport.TransportListA.Add(transportnew);
                        break;
                    case "firmaB":
                        Transport.TransportListB.Add(transportnew);
                        break;
                    case "firmaC":
                        Transport.TransportListC.Add(transportnew);
                        break;
                    case "firmaD":
                        Transport.TransportListD.Add(transportnew);
                        break;
                    case "firmaF":
                        Transport.TransportListF.Add(transportnew);
                        break;
                }
                dataGridView1.Rows.Add(transportnew.AracNo, transportnew.KoltukSayisi, transportnew.Seferno);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                return;
            }

            DialogResult result = MessageBox.Show(text: "Kayıt Silinecek, Onaylıyor musunuz", caption: "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
            {
                return;
            }
            dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                return;
            }

            DataGridViewRow dataGridViewRow = dataGridView1.SelectedRows[0];

            FormAracEkleme guncelleme = new FormAracEkleme();

            guncelleme.aracadi = dataGridViewRow.Cells[0].Value.ToString();
            guncelleme.koltuksayisi = dataGridViewRow.Cells[1].Value.ToString();
            guncelleme.seferno = dataGridViewRow.Cells[2].Value.ToString();

            DialogResult result = guncelleme.ShowDialog();
            if (result == DialogResult.OK)
            {
                return;
            }

            dataGridViewRow.Cells[0].Value = guncelleme.aracadi;
            dataGridViewRow.Cells[1].Value = guncelleme.koltuksayisi;
            dataGridViewRow.Cells[2].Value = guncelleme.seferno;
        }

        private void FormAfirma_Load(object sender, EventArgs e)
        {

        }


        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Toplam Kar: {kar}");
        }
    }
}
