using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Insaat_Otomasyon
{
    public partial class Sifremi_Unuttum : Form
    {
        public Sifremi_Unuttum()
        {
            InitializeComponent();
        }
        string randomcode;
        public static string to;

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection connection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=musteri.mdb");
                connection.Open();
                OleDbCommand command = new OleDbCommand("Select E_Mail from musteri where E_Mail=@E_Mail", connection);
                command.Parameters.AddWithValue("@E_Mail", textBox1.Text);
                OleDbDataReader dr;
                dr = command.ExecuteReader();
                if (dr.Read())
                {
                    string Kimden, pass, messagebody;
                    Random rand = new Random();
                    randomcode = (rand.Next(999999)).ToString();
                    MailMessage message = new MailMessage();
                    to = (textBox1.Text).ToString();
                    Kimden = "eren23233636@gmail.com";
                    pass = "Uygulama Şifreniz"; //mail adresinize girip ayarlar kısmından uygulama şifresi yazınca 16 hanelik şifre verecektir
                    messagebody = $"Sizin kodunuz Şu {randomcode}";
                    message.To.Add(to);
                    message.From = new MailAddress(Kimden);
                    message.Body = messagebody;
                    message.Subject = "Şifre Yenileme Kodu";
                    SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                    smtp.EnableSsl = true;
                    smtp.Port = 587;
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.Credentials = new NetworkCredential(Kimden, pass);
                    try
                    {
                        smtp.Send(message);
                        MessageBox.Show("Mail adresinize kod gönderildi", "Durum", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Mail gönderme hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen mail adresinizi kontrol ediniz!", "Durum", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (randomcode == textBox2.Text)
                {
                    MessageBox.Show("Şifre doğru, giriş sayfasına yönlendiriliyorsunuz.");
                    sifre_yenileme s1 = new sifre_yenileme();
                    s1.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Yanlış, Lütfen doğrulama kodunu tekrar giriniz..!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            try
            {
                giris g1 = new giris();
                g1.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
