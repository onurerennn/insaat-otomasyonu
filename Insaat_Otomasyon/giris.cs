using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Insaat_Otomasyon
{
    public partial class giris : Form
    {
        private OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=musteri.mdb");

        public giris()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Sifremi_Unuttum s1 = new Sifremi_Unuttum();
            s1.Show();
            Hide();
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                OleDbCommand giris = new OleDbCommand("SELECT * FROM musteri WHERE adı=@adı AND sifre=@sifre", baglanti);
                giris.Parameters.AddWithValue("@adı", txt_adi.Text);
                giris.Parameters.AddWithValue("@sifre", txt_sifre.Text);

                OleDbDataReader dr = giris.ExecuteReader();

                if (dr.Read())
                {
                    MessageBox.Show("Giriş başarılı, ana sayfaya yönlendiriliyorsunuz");
                    Program.GirisYapanAd = txt_adi.Text;

                    Anasayfa a1 = new Anasayfa();
                    a1.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Hatalı giriş");
                    txt_adi.Clear();
                    txt_sifre.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void chc_sifre_goster_CheckedChanged(object sender, EventArgs e)
        {
            txt_sifre.UseSystemPasswordChar = !chc_sifre_goster.Checked;
        }
    }
}
