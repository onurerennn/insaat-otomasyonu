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
    public partial class İnce_İşçilik : Form
    {
        int sıva = 0, yalıtım = 0, boya = 0;

        public İnce_İşçilik()
        {
            InitializeComponent();
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            Anasayfa a1 = new Anasayfa();
            a1.Show();
            this.Hide();
        }

        private void btn_hesapla_Click(object sender, EventArgs e)
        {
            try
            {
                Ince_Insaat i1 = new Ince_Insaat();
                i1.Fiyat += 120 * Convert.ToInt32(txt_siva.Text);
                sıva = 120 * Convert.ToInt32(txt_siva.Text);

                i1.Fiyat += 150 * Convert.ToInt32(txt_boya.Text);
                boya = 150 * Convert.ToInt32(txt_boya.Text);

                i1.Fiyat += 200 * Convert.ToInt32(txt_yalitim.Text);
                yalıtım = 200 * Convert.ToInt32(txt_yalitim.Text);

                int toplam = sıva + yalıtım + boya;
                MessageBox.Show(i1.bilgi_yazdir(label1.Text, sıva, label2.Text, yalıtım, label3.Text, boya) + "\ntoplam = " + toplam);

                Program.toplam_fiyat += Convert.ToDouble(i1.fiyat_ver());

                // Hesaplama tamamlandığında textbox'ları temizle
                Temizle(txt_siva, txt_boya, txt_yalitim);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);

                // Hata durumunda textbox'ları temizle
                Temizle(txt_siva, txt_boya, txt_yalitim);
            }
        }

        private void Temizle(params TextBox[] textboxes)
        {
            foreach (TextBox textbox in textboxes)
            {
                textbox.Clear();
            }
        }
    }
}
