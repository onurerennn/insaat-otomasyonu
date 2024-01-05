using System;
using System.Windows.Forms;

namespace Insaat_Otomasyon
{
    public partial class AdminGiris : Form
    {
        public AdminGiris()
        {
            InitializeComponent();
        }

        private void btn_giriş_Click(object sender, EventArgs e)
        {
            try
            {
                string kullaniciAdi = "ejder";
                string sifre = "3636";

                if (txt_kullanici_adi.Text.Trim().Equals(kullaniciAdi) && txt_sifre.Text.Equals(sifre))
                {
                    MessageBox.Show("Yönetici bilgileriniz doğru, ilgili sayfaya yönlendiriliyorsunuz");
                    Yonetici y1 = new Yonetici();
                    y1.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Bilgileriniz yanlış");
                    txt_kullanici_adi.Clear();
                    txt_sifre.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Giriş hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                Form1 f1 = new Form1();
                f1.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Geçiş hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chc_sifre_goster_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                txt_sifre.UseSystemPasswordChar = !chc_sifre_goster.Checked;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Şifre gösterme hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
