using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Insaat_Otomasyon
{
    public partial class Misyonumuz : Form
    {
        public Misyonumuz()
        {
            InitializeComponent();

            try
            {
                StringBuilder metinBuilder = new StringBuilder();

                metinBuilder.AppendLine("İnşaat sektöründe dönüştürücü etkiler yaratmak, mükemmelliği teşvik etmek ve geleceğin inşaat projelerine ilham vermek amacıyla, teknoloji ve inovasyonu birleştiriyoruz. Misyonumuz, müşterilerimize, ortaklarımıza ve endüstriye değer katmak üzerine odaklanmıştır.");
                metinBuilder.AppendLine();
                metinBuilder.AppendLine("Değerlerimiz");
                metinBuilder.AppendLine();
                metinBuilder.AppendLine("İnovasyon ve Teknoloji: İnşaat sektöründeki en son teknolojileri takip ediyor ve bu teknolojileri kullanarak sürekli olarak yeni ve etkili çözümler geliştiriyoruz.");
                metinBuilder.AppendLine();
                metinBuilder.AppendLine("Sürdürülebilirlik: Çevresel ve toplumsal sorumluluklarımızı bilincinde olarak, sürdürülebilir uygulamalara öncelik veriyoruz. Gelecek nesillere daha yaşanabilir bir dünya bırakma taahhüdümüzü sürdürüyoruz.");
                metinBuilder.AppendLine();
                metinBuilder.AppendLine("İşbirliği ve Müşteri Odaklılık: Müşteri memnuniyeti ve ihtiyaçlarına odaklanarak, etkili iletişim ve işbirliği ile güçlü müşteri ilişkileri kuruyoruz.");
                metinBuilder.AppendLine();
                metinBuilder.AppendLine("Kalite ve Güvenilirlik: Yüksek kaliteli ürünler ve hizmetler sunarak müşterilerimizin güvenini kazanıyoruz. Kalite standartlarına bağlılığımızı sürdürüyor ve sürekli iyileşme için çaba harcıyoruz.");
                metinBuilder.AppendLine();
                metinBuilder.AppendLine("İnsan Odaklılık: Çalışanlarımızın gelişimi, sağlığı ve güvenliği konularında öncelikli bir tutum benimseyerek, güçlü bir takım kültürü oluşturuyoruz.");

                richTextBox1.ReadOnly = true;
                richTextBox1.Text = metinBuilder.ToString();
                // Tüm metni seç
                richTextBox1.SelectAll();
                // Kalın yapmak için yazı tipini belirle
                richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold);
                //renk ayarladık
                richTextBox1.SelectionColor = Color.DarkCyan;
                richTextBox1.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
    }
}
