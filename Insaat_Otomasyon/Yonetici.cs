using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Insaat_Otomasyon
{
    public partial class Yonetici : Form
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=musteri.mdb");
        DataTable tablo = new DataTable();

        public Yonetici()
        {
            InitializeComponent();
        }

        void listele()
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }

                OleDbDataAdapter ol = new OleDbDataAdapter("SELECT * FROM musteri", baglanti);
                DataTable tablo = new DataTable();
                ol.Fill(tablo);
                dataGridView1.DataSource = tablo;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Listeleme hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open)
                {
                    baglanti.Close();
                }
            }
        }

        private void Yonetici_Load(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }

                OleDbDataAdapter adtr = new OleDbDataAdapter("select * from musteri", baglanti);
                adtr.Fill(tablo);
                dataGridView1.DataSource = tablo;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Yükleme hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open)
                {
                    baglanti.Close();
                }
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow == null)
                {
                    MessageBox.Show("Lütfen bir kayıt seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = MessageBox.Show("Kaydı silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    String sorgu = "DELETE FROM musteri where adı=@adı";
                    OleDbCommand komutt = new OleDbCommand(sorgu, baglanti);
                    komutt.Parameters.AddWithValue("@adı", dataGridView1.CurrentRow.Cells[0].Value);

                    if (baglanti.State == ConnectionState.Closed)
                    {
                        baglanti.Open();
                    }

                    komutt.ExecuteNonQuery();
                    listele();
                    MessageBox.Show("Silme işlemi başarılı");
                }
                else
                {
                    MessageBox.Show("Kayıt silinemedi");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Silme hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open)
                {
                    baglanti.Close();
                }
            }
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            try
            {
                Form1 f1 = new Form1();
                f1.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Form geçiş hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
