namespace prolab2
{
    public partial class FormBaslangic : Form
    {
        public FormBaslangic()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormGirisEkrani girisEkrani = new FormGirisEkrani();
            girisEkrani.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormBiletBul biletBul = new FormBiletBul();
            biletBul.Show();
            this.Hide();
        }

        private void FormBaslangic_Load_1(object sender, EventArgs e)
        {

        }
    }
}