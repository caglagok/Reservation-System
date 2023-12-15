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
    public partial class FormSeferBilgi : Form
    {
        List<Trip.Sefer> uygunSeferler;
        int kisisayisi;
        string nereden;
        string nereye;
        int sayac = 0;
        List<Button> rezerveEdilenKoltuklar = new List<Button>();
        List<Reservation> reservationList = new List<Reservation>();
        List<Passenger> passengerlist = new List<Passenger>();

        private Dictionary<string, Func<string, string, int>> fiyatMetodlari = new Dictionary<string, Func<string, string, int>>();
        public FormSeferBilgi(List<Trip.Sefer> uygunSeferler, int kisisayisi, string nereden, string nereye)
        {
            InitializeComponent();
            foreach (var sefer in uygunSeferler)
            {
                comboBox1.Items.Add($"{sefer.UlasimTipi}");

            }

            this.kisisayisi = kisisayisi;
            this.nereden = nereden;
            this.nereye = nereye;

            fiyatMetodlari.Add("A Firması/Otobüs1", FiyatHesaplaKarayolu);
            fiyatMetodlari.Add("A Firması/Otobüs2", FiyatHesaplaKarayolu);
            fiyatMetodlari.Add("B Firması/Otobüs1", FiyatHesaplaKarayolu);
            fiyatMetodlari.Add("B Firması/Otobüs2", FiyatHesaplaKarayolu);
            fiyatMetodlari.Add("C Firması/Otobüs1", FiyatHesaplaKarayolu);
            fiyatMetodlari.Add("C Firması/Uçak1", FiyatHesaplaHavayolu);
            fiyatMetodlari.Add("C Firması/Uçak2", FiyatHesaplaHavayolu);
            fiyatMetodlari.Add("D Firması/Tren1", FiyatHesaplaDemiryolu);
            fiyatMetodlari.Add("D Firması/Tren2", FiyatHesaplaDemiryolu);
            fiyatMetodlari.Add("D Firması/Tren3", FiyatHesaplaDemiryolu);
            fiyatMetodlari.Add("F Firması/Uçak1", FiyatHesaplaHavayolu);
            fiyatMetodlari.Add("F Firması/Uçak2", FiyatHesaplaHavayolu);
        }
        private int FiyatHesaplaKarayolu(string kalkis, string varis)
        {
            Dictionary<string, Dictionary<string, int>> karayoluFiyatlar = new Dictionary<string, Dictionary<string, int>>
            {
                { "İstanbul", new Dictionary<string, int> { { "Kocaeli", 50 }, { "Bilecik", 0 }, { "Ankara", 300 }, { "Eskişehir", 150 }, { "Konya", 300 } } },
                { "Kocaeli", new Dictionary<string, int> { { "İstanbul", 50 }, { "Bilecik", 0 }, { "Ankara", 400 }, { "Eskişehir", 100 }, { "Konya", 250 } } },
                { "Ankara", new Dictionary<string, int> { { "İstanbul", 300 }, { "Kocaeli", 400 }, { "Bilecik", 0 }, { "Eskişehir", 0 }, { "Konya", 0 } } },
                { "Eskişehir", new Dictionary<string, int> { { "İstanbul", 150 }, { "Kocaeli", 100 }, { "Bilecik", 0 }, { "Ankara", 0 }, { "Konya", 150 } } },
                { "Konya", new Dictionary<string, int> { { "İstanbul", 300 }, { "Kocaeli", 250 }, { "Bilecik", 0 }, { "Ankara", 0 }, { "Eskişehir", 150 } } }
            };

            return karayoluFiyatlar[kalkis][varis];
        }

        private int FiyatHesaplaHavayolu(string kalkis, string varis)
        {
            Dictionary<string, Dictionary<string, int>> havayoluFiyatlar = new Dictionary<string, Dictionary<string, int>>
            {
                { "İstanbul", new Dictionary<string, int> { { "Kocaeli", 0 }, { "Bilecik", 0 }, { "Ankara", 1000 }, { "Eskişehir", 0 }, { "Konya", 1200 } } },
                { "Ankara", new Dictionary<string, int> { { "İstanbul", 1000 }, { "Kocaeli", 0 }, { "Bilecik", 0 }, { "Eskişehir", 0 }, { "Konya", 0 } } },
                { "Konya", new Dictionary<string, int> { { "İstanbul", 1200 }, { "Kocaeli", 0 }, { "Bilecik", 0 }, { "Ankara", 0 }, { "Eskişehir", 0 } } }
            };

            return havayoluFiyatlar[kalkis][varis];
        }

        private int FiyatHesaplaDemiryolu(string kalkis, string varis)
        {
            Dictionary<string, Dictionary<string, int>> demiryoluFiyatlar = new Dictionary<string, Dictionary<string, int>>
            {
                { "İstanbul", new Dictionary<string, int> { { "Kocaeli", 50 }, { "Bilecik", 150 }, { "Ankara", 250 }, { "Eskişehir", 200 }, { "Konya", 300 } } },
                { "Kocaeli", new Dictionary<string, int> { { "İstanbul", 50 }, { "Bilecik", 50 }, { "Ankara", 200 }, { "Eskişehir", 100 }, { "Konya", 250 } } },
                { "Bilecik", new Dictionary<string, int> { { "İstanbul", 150 }, { "Kocaeli", 50 }, { "Ankara", 150 }, { "Eskişehir", 50 }, { "Konya", 200 } } },
                { "Ankara", new Dictionary<string, int> { { "İstanbul", 250 }, { "Kocaeli", 200 }, { "Bilecik", 150 }, { "Eskişehir", 100 }, { "Konya", 0 } } },
                { "Eskisehir", new Dictionary<string, int> { { "İstanbul", 200 }, { "Kocaeli", 100 }, { "Bilecik", 50 }, { "Ankara", 100 }, { "Konya", 150 } } },
                { "Konya", new Dictionary<string, int> { { "İstanbul", 300 }, { "Kocaeli", 250 }, { "Bilecik", 200 }, { "Ankara", 0 }, { "Eskişehir", 150 } } }
            };

            return demiryoluFiyatlar[kalkis][varis];
        }

        Random random = new Random();
        Button RastgeleKoltukSec(List<Button> tumKoltuklar)
        {
            if (tumKoltuklar.Count == 0)
            {
                return null;
            }
            int randomIndex = random.Next(0, tumKoltuklar.Count);
            return tumKoltuklar[randomIndex];
        }

        void RastgeleKoltukBoyama(int koltukSayisi)
        {
            List<Button> tumKoltuklar = this.Controls.OfType<Button>().ToList();

            int boyanacakKoltukSayisi = Math.Min(koltukSayisi, tumKoltuklar.Count);
            for (int i = 0; i < boyanacakKoltukSayisi; i++)
            {
                Button rastgeleKoltuk = RastgeleKoltukSec(tumKoltuklar);
                if (rastgeleKoltuk != null && rastgeleKoltuk.Name != "button1")
                {
                    rastgeleKoltuk.BackColor = Color.Blue;
                }
            }
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int koltukSayisi = 0;

            switch (comboBox1.Text)
            {
                case "A Firması/Otobüs1":
                    koltukSayisi = 20;
                    KoltukOto(koltukSayisi);
                    break;
                case "A Firması/Otobüs2":
                    koltukSayisi = 15;
                    KoltukOto(koltukSayisi);
                    break;
                case "B Firması/Otobüs1":
                    koltukSayisi = 15;
                    KoltukOto(koltukSayisi);
                    break;
                case "B Firması/Otobüs2":
                    koltukSayisi = 20;
                    KoltukOto(koltukSayisi);
                    break;
                case "C Firması/Otobüs1":
                    koltukSayisi = 20;
                    KoltukOto(koltukSayisi);
                    break;
                case "C Firması/Uçak1":
                    koltukSayisi = 30;
                    KoltukUcak(koltukSayisi);
                    break;
                case "C Firması/Uçak2":
                    koltukSayisi = 30;
                    KoltukUcak(koltukSayisi);
                    break;
                case "D Firması/Tren1":
                    koltukSayisi = 25;
                    KoltukTren(koltukSayisi);
                    break;
                case "D Firması/Tren2":
                    koltukSayisi = 25;
                    KoltukTren(koltukSayisi);
                    break;
                case "D Firması/Tren3":
                    koltukSayisi = 25;
                    KoltukTren(koltukSayisi);
                    break;
                case "F Firması/Uçak1":
                    koltukSayisi = 30;
                    KoltukUcak(koltukSayisi);
                    break;
                case "F Firması/Uçak2":
                    koltukSayisi = 30;
                    KoltukUcak(koltukSayisi);
                    break;
            }
            RastgeleKoltukBoyama(koltukSayisi);
            //otobüs
            void KoltukOto(int koltuksay)
            {
            yavaslat:
                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl is Button)
                    {
                        Button btn = ctrl as Button;
                        if (btn.Text == "kaydet")
                        {
                            continue;
                        }
                        else if (ctrl.Name != "button1")
                        {
                            this.Controls.Remove(ctrl);
                            goto yavaslat;
                        }

                    }
                }
                int koltukNo = 1;
                int modumuz = koltuksay % 4;
                int yenisay = koltuksay - modumuz;
                int bolum = yenisay / 4;

                for (int i = 0; i < bolum; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (j == 2)
                        {
                            continue;
                        }
                        Button koltuk = new Button();
                        koltuk.Height = koltuk.Width = 40;
                        koltuk.Top = 30 + (i * 45);
                        koltuk.Left = 5 + (j * 45);
                        koltuk.Text = koltukNo.ToString();
                        koltukNo++;
                        koltuk.ContextMenuStrip = contextMenuStrip1;
                        koltuk.MouseDown += Koltuk_MouseDown;
                        this.Controls.Add(koltuk);
                    }
                }
                for (int i = bolum; i < bolum + 1; i++)
                {
                    if (modumuz == 3)
                    {
                        for (int j = 0; j < modumuz + 1; j++)
                        {
                            if (j == 2)
                            {
                                continue;
                            }
                            Button koltuk = new Button();
                            koltuk.Height = koltuk.Width = 40;
                            koltuk.Top = 30 + (i * 45);
                            koltuk.Left = 5 + (j * 45);
                            koltuk.Text = koltukNo.ToString();
                            koltukNo++;
                            koltuk.ContextMenuStrip = contextMenuStrip1;
                            koltuk.MouseDown += Koltuk_MouseDown;
                            this.Controls.Add(koltuk);
                        }
                    }
                    else
                    {
                        for (int j = 0; j < modumuz; j++)
                        {
                            if (j == 2)
                            {
                                continue;
                            }
                            Button koltuk = new Button();
                            koltuk.Height = koltuk.Width = 40;
                            koltuk.Top = 30 + (i * 45);
                            koltuk.Left = 5 + (j * 45);
                            koltuk.Text = koltukNo.ToString();
                            koltukNo++;
                            koltuk.ContextMenuStrip = contextMenuStrip1;
                            koltuk.MouseDown += Koltuk_MouseDown;
                            this.Controls.Add(koltuk);
                        }

                    }

                }

            }
            void KoltukTren(int koltuksay)
            {
            yavaslat:
                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl is Button)
                    {
                        Button btn = ctrl as Button;
                        if (btn.Text == "kaydet")
                        {
                            continue;
                        }
                        else if (ctrl.Name != "button1")
                        {
                            this.Controls.Remove(ctrl);
                            goto yavaslat;
                        }

                    }
                }
                int koltukNo = 1;
                int modumuz = koltuksay % 4;
                int yenisay = koltuksay - modumuz;
                int bolum = yenisay / 4;

                for (int i = 0; i < bolum; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (j == 2)
                        {
                            continue;
                        }
                        Button koltuk = new Button();
                        koltuk.Height = koltuk.Width = 40;
                        koltuk.Top = 30 + (i * 45);
                        koltuk.Left = 5 + (j * 45);
                        koltuk.Text = koltukNo.ToString();
                        koltukNo++;
                        koltuk.ContextMenuStrip = contextMenuStrip1;
                        koltuk.MouseDown += Koltuk_MouseDown;
                        this.Controls.Add(koltuk);
                    }
                }
                for (int i = bolum; i < bolum + 1; i++)
                {
                    for (int j = 0; j < modumuz; j++)
                    {
                        if (j == 2)
                        {
                            continue;
                        }
                        Button koltuk = new Button();
                        koltuk.Height = koltuk.Width = 40;
                        koltuk.Top = 30 + (i * 45);
                        koltuk.Left = 5 + (j * 45);
                        koltuk.Text = koltukNo.ToString();
                        koltukNo++;
                        koltuk.ContextMenuStrip = contextMenuStrip1;
                        koltuk.MouseDown += Koltuk_MouseDown;
                        this.Controls.Add(koltuk);
                    }
                }
            }
            void KoltukUcak(int koltuksay)
            {
            yavaslat:
                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl is Button)
                    {
                        Button btn = ctrl as Button;
                        if (btn.Text == "kaydet")
                        {
                            continue;
                        }
                        else if (ctrl.Name != "button1")
                        {
                            this.Controls.Remove(ctrl);
                            goto yavaslat;
                        }

                    }
                }
                int koltukNo = 1;
                for (int i = 0; i < koltuksay / 6; i++)
                {
                    for (int j = 0; j < 7; j++)
                    {
                        if (j == 3)
                        {
                            continue;
                        }
                        Button koltuk = new Button();
                        koltuk.Height = koltuk.Width = 40;
                        koltuk.Top = 30 + (i * 45);
                        koltuk.Left = 5 + (j * 45);
                        koltuk.Text = koltukNo.ToString();
                        koltukNo++;
                        koltuk.ContextMenuStrip = contextMenuStrip1;
                        koltuk.MouseDown += Koltuk_MouseDown;
                        this.Controls.Add(koltuk);

                    }
                }
            }
        }
        Button tiklanan;
        int fiyattoplam = 0;

        private void Koltuk_MouseDown(object? sender, MouseEventArgs e)
        {
            tiklanan = sender as Button;

        }
        private void rezerveEtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sayac >= kisisayisi)
            {
                MessageBox.Show($"Maksimum rezerve sayısına ulaşıldı ({kisisayisi}).", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tiklanan.BackColor == Color.Blue || tiklanan.BackColor == Color.DarkOrange)
            {
                MessageBox.Show("Bu koltuk zaten rezerve edilmiş!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            FormKullaniciBilgi kayıtformu = new FormKullaniciBilgi();
            DialogResult sonuc = kayıtformu.ShowDialog();

            if (sonuc == DialogResult.OK)
            {
                string comboBoxDeger = comboBox1.SelectedItem?.ToString();
                int fiyat = fiyatMetodlari[comboBoxDeger](nereden, nereye);
                fiyattoplam += fiyat;
                ListViewItem lsv = new ListViewItem();
                lsv.Text = string.Format("{0} {1}", kayıtformu.textBox1.Text, kayıtformu.textBox2.Text);
                lsv.SubItems.Add(kayıtformu.maskedTextBox1.Text);
                lsv.SubItems.Add(kayıtformu.maskedTextBox2.Text);
                lsv.SubItems.Add(comboBoxDeger);
                lsv.SubItems.Add(tiklanan.Text);
                lsv.SubItems.Add(fiyat.ToString());

                tiklanan.BackColor = Color.DarkOrange;

                listView1.Items.Add(lsv);

                sayac++;

                Reservation newReservation = new Reservation()
                {
                    Ad = kayıtformu.textBox1.Text,
                    Soyad = kayıtformu.textBox2.Text,
                    TC = kayıtformu.maskedTextBox1.Text,
                    DogumTarihi = kayıtformu.maskedTextBox2.Text,
                    AracAdi = comboBoxDeger,
                    KoltukNo = tiklanan.Text,
                    Fiyat = fiyat
                };
                reservationList.Add(newReservation);

                Passenger newpassenger = new Passenger()
                {
                    Ad = kayıtformu.textBox1.Text,
                    Soyad = kayıtformu.textBox2.Text,
                    TC = kayıtformu.maskedTextBox1.Text,
                    DogumTarihi = kayıtformu.maskedTextBox2.Text,
                    AracAdi = comboBoxDeger,
                    KoltukNo = tiklanan.Text
                };
                passengerlist.Add(newpassenger);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show($"Toplam Ödemeniz: {fiyattoplam}₺. Ödemeniz Başarıyla Yapıldı. Bizi Tercih Ettiğiniz İçin Teşekkürler.");
            this.Close();

        }

        private void FormSeferBilgi_Load(object sender, EventArgs e)
        {

        }
    }
}
