using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Insaat_Otomasyon
{
    public partial class Ödeme_Ekranı : Form
    {
        private decimal guncelFiyat;

        public Ödeme_Ekranı()
        {
            InitializeComponent();
        }

        private void Ödeme_Ekranı_Load(object sender, EventArgs e)
        {
            label1.Text = "Ödeme ekranına hoşgeldin " + Program.GirisYapanAd;

            try
            {
                // Kullanıcı adına bağlı olarak fiyat bilgisini Access veritabanından al
                guncelFiyat = KullaniciFiyatiniAl(Program.GirisYapanAd);

                label2.Text = "Güncel borcunuz " + guncelFiyat.ToString("C");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private decimal KullaniciFiyatiniAl(string kullaniciAdi)
        {
            try
            {
                string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=musteri.mdb";
                string query = "SELECT Fiyat FROM musteri WHERE adı = @KullaniciAdi";

                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi);

                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            return Convert.ToDecimal(result);
                        }
                        else
                        {
                            return 0.0M;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0.0M;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                Borç_Öğren b1 = new Borç_Öğren();
                b1.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_ode_Click(object sender, EventArgs e)
        {
            try
            {
                int miktar = Convert.ToInt32(txt_miktar.Text);

                if (miktar > guncelFiyat)
                {
                    MessageBox.Show("Ödeme miktarı, güncel borçtan fazla olamaz!");
                    return;
                }

                int kalan = Convert.ToInt32(guncelFiyat) - miktar;

                // Veritabanındaki fiyat bilgisini güncelle
                GuncelFiyatiGuncelle(Program.GirisYapanAd, kalan);

                MessageBox.Show("Kalan borcunuz: " + kalan.ToString("C"));
                txt_miktar.Clear();
                // Yeniden yükleyerek güncel bilgileri göster
                guncelFiyat = KullaniciFiyatiniAl(Program.GirisYapanAd);
                label2.Text = "Güncel borcunuz " + guncelFiyat.ToString("C");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GuncelFiyatiGuncelle(string kullaniciAdi, decimal yeniFiyat)
        {
            try
            {
                string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=musteri.mdb";
                string updateQuery = "UPDATE musteri SET Fiyat = @YeniFiyat WHERE adı = @KullaniciAdi";

                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    using (OleDbCommand command = new OleDbCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@YeniFiyat", yeniFiyat);
                        command.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
