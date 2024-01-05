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
    public partial class kaba_inşaat : Form
    {
        public kaba_inşaat()
        {
            InitializeComponent();
        }
        int beton = 0, cati = 0, duvar = 0;
        private void btn_hesapla_Click(object sender, EventArgs e)
        {
            try
            {
                Kaba_Insaat k1 = new Kaba_Insaat();

                // Her bir ComboBox için seçili çeşidin fiyatını hesapla

                if (cmb_duvar.SelectedIndex == 0)
                {
                    k1.Fiyat += 270 * Convert.ToInt32(txt_duvar.Text);
                    k1.Cesit = cmb_duvar.SelectedText;
                    duvar = 270 * Convert.ToInt32(txt_duvar.Text);
                    k1.Toplam += duvar;
                }
                else if (cmb_duvar.SelectedIndex == 1)
                {
                    k1.Fiyat += 300 * Convert.ToInt32(txt_duvar.Text);
                    k1.Cesit = cmb_duvar.SelectedText;
                    duvar = 300 * Convert.ToInt32(txt_duvar.Text);
                    k1.Toplam += duvar;
                }
                else if (cmb_duvar.SelectedIndex == 2)
                {
                    k1.Fiyat += 350 * Convert.ToInt32(txt_duvar.Text);
                    k1.Cesit = cmb_duvar.SelectedText;
                    duvar = 350 * Convert.ToInt32(txt_duvar.Text);
                    k1.Toplam += duvar;
                }

                if (cmb_cati.SelectedIndex == 0)
                {
                    k1.Fiyat += 75 * Convert.ToInt32(txt_cati.Text);
                    k1.Cesit = cmb_cati.SelectedText;
                    cati = 75 * Convert.ToInt32(txt_cati.Text);
                    k1.Toplam += cati;
                }
                else if (cmb_cati.SelectedIndex == 1)
                {
                    k1.Fiyat += 140 * Convert.ToInt32(txt_cati.Text);
                    k1.Cesit = cmb_cati.SelectedText;
                    cati = 140 * Convert.ToInt32(txt_cati.Text);
                    k1.Toplam += cati;
                }

                if (cmb_beton.SelectedIndex == 0)
                {
                    k1.Fiyat += 2500 * Convert.ToInt32(txt_beton.Text);
                    k1.Cesit = cmb_beton.SelectedText;
                    beton = 2500 * Convert.ToInt32(txt_beton.Text);
                    k1.Toplam += beton;
                }
                else if (cmb_beton.SelectedIndex == 1)
                {
                    k1.Fiyat += 2800 * Convert.ToInt32(txt_beton.Text);
                    k1.Cesit = cmb_beton.SelectedText;
                    beton = 2800 * Convert.ToInt32(txt_beton.Text);
                    k1.Toplam += beton;
                }

                // Toplu fiyatı ve çeşitleri göster
                MessageBox.Show("Toplam Kaba İşcilik Ücretiniz = " + k1.fiyat_ver().ToString() + "\n"
                    + k1.cesit_yazdir(cmb_duvar.SelectedItem.ToString(), duvar, cmb_cati.SelectedItem.ToString(), cati, cmb_beton.SelectedItem.ToString(), beton));

                Program.toplam_fiyat += Convert.ToDouble(k1.fiyat_ver());
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
                Anasayfa s1 = new Anasayfa();
                s1.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
    }
}
