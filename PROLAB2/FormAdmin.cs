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
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();

            foreach (Company company in Company.companyList)
            {
                dataGridView1.Rows.Add(company.FirmaAdi, company.Kullaniciadi, company.Kullanicisifresi);

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAdminFirmaEkleme adminFirmaEkleme = new FormAdminFirmaEkleme();

            adminFirmaEkleme.FirmaBilgileriGüncelle += (firmaadi, kullaniciadi, sifre) =>
            {
                dataGridView1.Rows.Add(firmaadi, kullaniciadi, sifre);
            };
            DialogResult result = adminFirmaEkleme.ShowDialog();
            if (result == DialogResult.OK)
            {
                Company companyNew = new Company(adminFirmaEkleme.firmaadi, adminFirmaEkleme.kullaniciadi, adminFirmaEkleme.sifre);
                Company.companyList.Add(companyNew);
                dataGridView1.Rows.Add(companyNew.FirmaAdi, companyNew.Kullaniciadi, companyNew.Kullanicisifresi);
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

            FormAdminFirmaEkleme guncelleme = new FormAdminFirmaEkleme();

            guncelleme.firmaadi = dataGridViewRow.Cells[0].Value.ToString();
            guncelleme.kullaniciadi = dataGridViewRow.Cells[1].Value.ToString();
            guncelleme.sifre = dataGridViewRow.Cells[2].Value.ToString();

            DialogResult result = guncelleme.ShowDialog();
            if (result == DialogResult.OK)
            {
                return;
            }

            dataGridViewRow.Cells[0].Value = guncelleme.firmaadi;
            dataGridViewRow.Cells[1].Value = guncelleme.kullaniciadi;
            dataGridViewRow.Cells[2].Value = guncelleme.sifre;

        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
        }
    }
}
