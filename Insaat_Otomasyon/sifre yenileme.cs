using System;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Insaat_Otomasyon
{
    public partial class sifre_yenileme : Form
    {
        public string E_Mail = Sifremi_Unuttum.to;

        public sifre_yenileme()
        {
            InitializeComponent();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                string sifre = txt_sifre.Text;
                string sifreTekrar = txt_sfre_tekrar.Text;

                if (sifre == sifreTekrar)
                {
                    using (OleDbConnection connection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=musteri.mdb"))
                    {
                        connection.Open();

                        // Parametre kullanarak SQL Injection'a karşı korunaklı bir sorgu oluşturuyoruz.
                        using (OleDbCommand command = new OleDbCommand("UPDATE musteri SET sifre = @sifre WHERE E_Mail = @E_Mail", connection))
                        {
                            // Parametre değerlerini ekliyoruz.
                            command.Parameters.AddWithValue("@sifre", sifre);
                            command.Parameters.AddWithValue("@E_Mail", E_Mail);

                            command.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Şifre Yenilendi", "Durum", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    MessageBox.Show("Giriş Sayfasına Yönlendiriliyoruz...", "Durum", MessageBoxButtons.OK);
                    this.Hide();
                    giris g1 = new giris();
                    g1.Show();
                }
                else
                {
                    MessageBox.Show("Şifreler uyuşmuyor. Lütfen aynı şifreyi giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chc_sifre_göster_CheckedChanged(object sender, EventArgs e)
        {
            if (chc_sifre_göster.Checked)
            {
                txt_sifre.UseSystemPasswordChar = false;
                txt_sfre_tekrar.UseSystemPasswordChar = false;
            }
            else
            {
                txt_sifre.UseSystemPasswordChar = true;
                txt_sfre_tekrar.UseSystemPasswordChar = true;
            }
        }
    }
}
