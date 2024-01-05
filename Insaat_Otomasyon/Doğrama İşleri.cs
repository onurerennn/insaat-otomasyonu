using System;
using System.Windows.Forms;

namespace Insaat_Otomasyon
{
    public partial class Doğrama_İşleri : Form
    {
        public Doğrama_İşleri()
        {
            InitializeComponent();
        }

        private void Doğrama_İşleri_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }

        private void btn_hesapla_Click(object sender, EventArgs e)
        {
            try
            {
                Ince_Insaat i1 = new Ince_Insaat();

                if (cmb_pencere.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txt_genislik_pencere.Text) || string.IsNullOrWhiteSpace(txt_yükseklik_pencere.Text) || string.IsNullOrWhiteSpace(txt_acilim_pencere.Text) || string.IsNullOrWhiteSpace(txt_pencere_adet.Text))
                {
                    throw new Exception("Lütfen pencere bilgilerini eksiksiz girin.");
                }

                if (cmb_pencere.SelectedIndex == 0)
                {
                    i1.Fiyat += 2 * Convert.ToDouble(txt_genislik_pencere.Text) * Convert.ToDouble(txt_yükseklik_pencere.Text) * Convert.ToDouble(txt_acilim_pencere.Text) * 300 * Convert.ToDouble(txt_pencere_adet.Text);
                    cmb_pencere.SelectedIndex = -1;
                    Temizle(txt_genislik_pencere, txt_yükseklik_pencere, txt_acilim_pencere, txt_pencere_adet);
                }
                else if (cmb_pencere.SelectedIndex == 1)
                {
                    i1.Fiyat += 2 * Convert.ToDouble(txt_genislik_pencere.Text) * Convert.ToDouble(txt_yükseklik_pencere.Text) * Convert.ToDouble(txt_acilim_pencere.Text) * 500 * Convert.ToDouble(txt_pencere_adet.Text);
                    cmb_pencere.SelectedIndex = -1;
                    Temizle(txt_genislik_pencere, txt_yükseklik_pencere, txt_acilim_pencere, txt_pencere_adet);
                }

                if (cmb_kapi.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txt_genislik_kapi.Text) || string.IsNullOrWhiteSpace(txt_yükseklik_kapi.Text) || string.IsNullOrWhiteSpace(txt_kapi_adet.Text))
                {
                    throw new Exception("Lütfen kapı bilgilerini eksiksiz girin.");
                }

                if (cmb_kapi.SelectedIndex == 0)
                {
                    if (rdn_beyaz.Checked)
                    {
                        i1.Fiyat += 2 * Convert.ToDouble(txt_genislik_kapi.Text) * Convert.ToDouble(txt_yükseklik_kapi.Text) * 300 * Convert.ToDouble(txt_kapi_adet.Text);
                        Temizle(txt_genislik_kapi, txt_yükseklik_kapi, txt_kapi_adet);
                    }
                    else if (rdn_renkli.Checked)
                    {
                        i1.Fiyat += 2 * Convert.ToDouble(txt_genislik_kapi.Text) * Convert.ToDouble(txt_yükseklik_kapi.Text) * 500 * Convert.ToDouble(txt_kapi_adet.Text);
                        Temizle(txt_genislik_kapi, txt_yükseklik_kapi, txt_kapi_adet);
                    }
                    cmb_kapi.SelectedIndex = -1;
                    groupBox1.Visible = false;
                }
                else if (cmb_kapi.SelectedIndex == 1)
                {
                    i1.Fiyat += 2 * Convert.ToDouble(txt_genislik_kapi.Text) * Convert.ToDouble(txt_yükseklik_kapi.Text) * 700 * Convert.ToDouble(txt_kapi_adet.Text);
                    cmb_kapi.SelectedIndex = -1;
                    Temizle(txt_genislik_kapi, txt_yükseklik_kapi, txt_kapi_adet);
                }
                else if (cmb_kapi.SelectedIndex == 2)
                {
                    i1.Fiyat += 2 * Convert.ToDouble(txt_genislik_kapi.Text) * Convert.ToDouble(txt_yükseklik_kapi.Text) * 1300 * Convert.ToDouble(txt_kapi_adet.Text);
                    cmb_kapi.SelectedIndex = -1;
                    Temizle(txt_genislik_kapi, txt_yükseklik_kapi, txt_kapi_adet);
                }

                Program.toplam_fiyat += Convert.ToDouble(i1.fiyat_ver());

                MessageBox.Show("Toplam doğrama ücreti:\n" + i1.fiyat_ver().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Hata durumunda tüm textbox ve combobox'ları temizle
                Temizle(txt_genislik_pencere, txt_yükseklik_pencere, txt_acilim_pencere, txt_pencere_adet);
                Temizle(txt_genislik_kapi, txt_yükseklik_kapi, txt_kapi_adet);
                cmb_pencere.SelectedIndex = -1;
                cmb_kapi.SelectedIndex = -1;
                groupBox1.Visible = false;
            }
        }

        private void cmb_kapi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_kapi.SelectedIndex == 0)
            {
                groupBox1.Visible = true;
            }
            else
            {
                groupBox1.Visible = false;
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
                MessageBox.Show("Anasayfa açılırken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Temizle(TextBox t1, TextBox t2, TextBox t3, TextBox t4)
        {
            try
            {
                t1.Clear();
                t2.Clear();
                t3.Clear();
                t4.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("TextBox temizlenirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Temizle(TextBox t1, TextBox t2, TextBox t3)
        {
            try
            {
                t1.Clear();
                t2.Clear();
                t3.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("TextBox temizlenirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
