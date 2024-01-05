using System;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace Insaat_Otomasyon
{
    public partial class Kayıt : Form
    {
        private OleDbConnection baglanti;

        public Kayıt()
        {
            InitializeComponent();
            baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=musteri.mdb");
        }

        private void btn_kayit_Click(object sender, EventArgs e)
        {
            label6.Visible = true;

            try
            {
                if (string.IsNullOrWhiteSpace(txt_adi.Text) || string.IsNullOrWhiteSpace(txt_soyadi.Text) || string.IsNullOrWhiteSpace(txt_sifre.Text) ||
                    string.IsNullOrWhiteSpace(txt_telefon.Text) || string.IsNullOrWhiteSpace(txt_E_Mail.Text))
                {
                    MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                baglanti.Open();

                using (OleDbCommand komut = new OleDbCommand("INSERT INTO musteri(adı, soyadı, sifre, telefon, E_Mail) VALUES (@adi, @soyadi, @sifre, @telefon, @E_Mail)", baglanti))
                {
                    komut.Parameters.AddWithValue("@adi", txt_adi.Text);
                    komut.Parameters.AddWithValue("@soyadi", txt_soyadi.Text);
                    komut.Parameters.AddWithValue("@sifre", txt_sifre.Text);
                    komut.Parameters.AddWithValue("@telefon", txt_telefon.Text);
                    komut.Parameters.AddWithValue("@E_Mail", txt_E_Mail.Text);

                    komut.ExecuteNonQuery();
                }

                timer1.Start();
            }
            catch (Exception ex)
            {
                label6.Text = "Kayıt eklenirken hata oluştu: " + ex.Message;
                label6.ForeColor = Color.Red;
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(10);
            if (progressBar1.Value == 100)
            {
                label6.Text = "Kayıt işlemi tamamlandı";
                label6.ForeColor = Color.Green;
                timer1.Stop();
                if (progressBar1.Value == 100)
                {
                    MessageBox.Show("Kayıt eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    giris g1 = new giris();
                    g1.Show();
                    this.Hide();
                }
            }
            else if (progressBar1.Value < 100)
            {
                label6.Text = "Kayıt yapılıyor";
                label6.ForeColor = Color.Blue;
            }
        }
    }
}
