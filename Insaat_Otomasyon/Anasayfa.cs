using System;
using System.Windows.Forms;

namespace Insaat_Otomasyon
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {
            try
            {
                label1.Text = "HOŞGELDİN " + Program.GirisYapanAd.ToUpper();

                // Timer için ayarlar
                Timer timer = new Timer();
                timer.Interval = 1000; // 1000 milisaniye = 1 saniye
                timer.Tick += timer1_Tick;
                timer.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Anasayfa yüklenirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_siparis_ver_Click(object sender, EventArgs e)
        {
            try
            {
                Sipariş_Ver s1 = new Sipariş_Ver();
                s1.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sipariş verme sayfası açılırken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_borc_ogren_Click(object sender, EventArgs e)
        {
            try
            {
                Borç_Öğren b1 = new Borç_Öğren();
                b1.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Borç öğrenme sayfası açılırken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                Siparis_tamamla s1 = new Siparis_tamamla();
                s1.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sipariş tamamlama sayfası açılırken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                // Şu anki zamanı al
                DateTime suAn = DateTime.Now;

                // Zamanı label3'e yazdır
                label2.Text = suAn.ToString("HH:mm:ss");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Timer çalışırken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
