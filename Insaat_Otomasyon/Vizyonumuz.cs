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
    public partial class Vizyonumuz : Form
    {
        public Vizyonumuz()
        {
            InitializeComponent();
            try
            {
                // StringBuilder kullanarak metni birleştir
                StringBuilder vizyonMetni = new StringBuilder();
                vizyonMetni.AppendLine("Vizyon: İnşaatın Geleceğini Şekillendiriyoruz");
                vizyonMetni.AppendLine();
                vizyonMetni.AppendLine("İnşaat sektörü, her geçen gün daha karmaşık hale gelen projelerle karşı karşıya. Biz, inşaat otomasyonu alanında öncü bir vizyon ile sektörde dönüşümü liderliğe taşımayı hedefliyoruz. Geleceğin inşaat projelerini şekillendirmek, teknoloji ve inovasyonun gücünü kullanarak sektöre öncülük etmek ve sürdürülebilirlik ilkelerini en üst düzeye çıkarmak için buradayız.");
                vizyonMetni.AppendLine();
                vizyonMetni.AppendLine("Teknoloji ve İnovasyon:");
                vizyonMetni.AppendLine();
                vizyonMetni.AppendLine("İnşaat otomasyonu, sektördeki en son teknolojilerin ve inovasyonun kullanımını gerektirir. Biz, bu gerekliliği aşan, sürekli olarak yeni çözümler üreten bir ekiple çalışıyoruz. Yapay zeka, nesnelerin interneti (IoT), veri analitiği ve diğer ileri teknolojileri entegre ederek, inşaat projelerini daha akıllı, verimli ve ölçülebilir hale getiriyoruz.");
                vizyonMetni.AppendLine();
                vizyonMetni.AppendLine("Sürdürülebilirlik:");
                vizyonMetni.AppendLine();
                vizyonMetni.AppendLine("Çevresel ve toplumsal sorumluluğun bilinciyle, projelerimizi sürdürülebilirlik ilkelerine odaklıyoruz. Yeşil teknolojileri benimseyerek, enerji verimliliğini artırarak ve atık yönetimine duyarlı bir yaklaşım benimseyerek, gelecek nesillere daha yaşanabilir bir dünya bırakma taahhüdümüzü sürdürüyoruz.");
                vizyonMetni.AppendLine();
                vizyonMetni.AppendLine("İşbirliği ve Müşteri Memnuniyeti:");
                vizyonMetni.AppendLine();
                vizyonMetni.AppendLine("İnşaat otomasyonu, etkili iletişim ve işbirliği gerektiren bir alandır. Müşteri memnuniyetini ön planda tutarak, proje süreçlerini şeffaf ve katılımcı bir yaklaşımla yönetiyoruz. Müşterilerimizle güçlü bir işbirliği kurarak, ihtiyaçlarını anlamak ve beklentilerini aşmak için çaba harcıyoruz.");
                vizyonMetni.AppendLine();
                vizyonMetni.AppendLine("Kalite ve Güvenilirlik:");
                vizyonMetni.AppendLine();
                vizyonMetni.AppendLine("Yüksek kaliteli hizmet ve ürünler sunarak müşterilerimizin güvenini kazanıyoruz. Kalite standartlarına bağlılığımızı sürdürüyor ve sürekli iyileşme için çaba harcıyoruz. Güvenilir bir ortak olarak, inşaat projelerindeki başarıları birlikte kutlamak için buradayız.");
                vizyonMetni.AppendLine();
                vizyonMetni.AppendLine("Biz, inşaat otomasyonunda liderliği sürdürerek, sektördeki normları yeniden belirleyecek ve geleceğin inşaat projelerine yön vereceğiz. İnşaatın geleceğini birlikte şekillendiriyoruz.");
                richTextBox1.ReadOnly = true;
                // StringBuilder içeriğini RichTextBox'a yerleştir
                richTextBox1.Text = vizyonMetni.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
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
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
    }
}
