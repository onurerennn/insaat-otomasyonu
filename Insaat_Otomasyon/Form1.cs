using System;
using System.Windows.Forms;
using System.Drawing;

namespace Insaat_Otomasyon
{
    public partial class Form1 : Form
    {
        private Timer arkaPlanTimer = new Timer();
        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            // Timer'ı başlat
            arkaPlanTimer.Interval = 1000; // 1 saniye
            arkaPlanTimer.Tick += ArkaPlanTimer_Tick;
            arkaPlanTimer.Start();

            // İlk kez arka planı değiştir
            ArkaPlanRengiDegistir();
        }

        private void ArkaPlanTimer_Tick(object sender, EventArgs e)
        {
            // Her zaman arka planı değiştir
            ArkaPlanRengiDegistir();
        }

        private void ArkaPlanRengiDegistir()
        {
            // Rastgele renk oluştur
            Color randomRenk = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));

            // Formun arka plan rengini değiştir
            label1.BackColor = randomRenk;
        }

        private void btn_kayıt_Click(object sender, EventArgs e)
        {
            try
            {
                Kayıt k1 = new Kayıt();
                k1.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kayıt formu açılırken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            try
            {
                giris g1 = new giris();
                g1.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Giriş formu açılırken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_yonetici_Click(object sender, EventArgs e)
        {
            try
            {
                AdminGiris a1 = new AdminGiris();
                a1.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Yönetici giriş formu açılırken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            btn_yonetici.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btn_yonetici.Visible = false;
        }

        private void iletişimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mail adresimiz\neren23233636@gmail.com");
        }

        private void vizyonumuzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Vizyonumuz v1 = new Vizyonumuz();
                v1.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vizyonumuz formu açılırken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void misyonumuzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Misyonumuz m1 = new Misyonumuz();
                m1.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Misyonumuz formu açılırken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
