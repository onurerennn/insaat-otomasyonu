using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Insaat_Otomasyon
{
    public partial class Siparis_tamamla : Form
    {
        private string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=musteri.mdb";
        İnsaat i1 = new İnsaat();
        private double toplamFiyat;
        public Siparis_tamamla()
        {
            InitializeComponent();
        }

        private void Borç_ödeme_Load(object sender, EventArgs e)
        {
            try
            {
                label1.Text = "MERHABA " + Program.GirisYapanAd + " HOŞGELDİN";
                toplamFiyat = Program.toplam_fiyat;
                label2.Text = "ödemeniz gereken toplam tutar = " + Program.toplam_fiyat;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btn_siparis_olustur_Click(object sender, EventArgs e)
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    // Giriş yapan kullanıcının adına sahip kaydı güncelle
                    string updateQuery = "UPDATE musteri SET fiyat = fiyat + @odemeMiktari WHERE adı = @adı";

                    using (OleDbCommand command = new OleDbCommand(updateQuery, connection))
                    {
                        // Sadece @odemeMiktari parametresini ekleyin
                        command.Parameters.AddWithValue("@odemeMiktari", Program.toplam_fiyat);

                        // Sadece belirli bir ad ile eşleşen kaydın fiyatını güncelle
                        command.Parameters.AddWithValue("@adı", Program.GirisYapanAd);

                        // Sorguyu çalıştır
                        int affectedRows = command.ExecuteNonQuery();

                        if (affectedRows > 0)
                        {
                            MessageBox.Show("Siparişiniz başarıyla alındı.");
                            Program.toplam_fiyat = 0;
                        }
                        else
                        {
                            MessageBox.Show("Güncelleme işlemi başarısız oldu. Kayıt bulunamadı.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            try
            {
                Anasayfa a1 = new Anasayfa();
                a1.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
    }
}
