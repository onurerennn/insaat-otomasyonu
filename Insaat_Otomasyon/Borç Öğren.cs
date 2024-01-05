using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Insaat_Otomasyon
{
    public partial class Borç_Öğren : Form
    {
        private string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=musteri.mdb";

        public Borç_Öğren()
        {
            InitializeComponent();
        }

        private void Borç_Öğren_Load(object sender, EventArgs e)
        {
            try
            {
                // Timer için ayarlar
                Timer timer = new Timer();
                timer.Interval = 1000; // 1000 milisaniye = 1 saniye
                timer.Tick += timer1_Tick;
                timer.Start();

                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    // Giriş yapan kullanıcının borç bilgisini veritabanından çek
                    string selectQuery = "SELECT fiyat FROM musteri WHERE adı = @adı";

                    using (OleDbCommand command = new OleDbCommand(selectQuery, connection))
                    {
                        command.Parameters.AddWithValue("@adı", Program.GirisYapanAd);

                        // ExecuteScalar, tek bir değer döndüren sorgular için kullanılır
                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            decimal borc = Convert.ToDecimal(result);
                            label1.Text = "Fatura kesilen kişinin adı = " + Program.GirisYapanAd.ToUpper();
                            label2.Text = "Toplam borcunuz = " + borc.ToString("C"); // Currency format
                        }
                        else
                        {
                            MessageBox.Show("Borç bilgisi bulunamadı.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                Anasayfa a1 = new Anasayfa();
                a1.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Anasayfa açılırken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_odeme_Click(object sender, EventArgs e)
        {
            try
            {
                Ödeme_Ekranı o1 = new Ödeme_Ekranı();
                o1.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ödeme ekranı açılırken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                DateTime suAn = DateTime.Now;

                // Zamanı label3'e yazdır
                label3.Text = suAn.ToString("HH:mm:ss");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Timer çalışırken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
