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
    public partial class Sipariş_Ver : Form
    {
        public Sipariş_Ver()
        {
            InitializeComponent();
        }

        private void Sipariş_Ver_Load(object sender, EventArgs e)
        {
            try
            {
                // Sipariş Ver formunun yüklenme işlemleri
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btn_kaba_Click(object sender, EventArgs e)
        {
            try
            {
                kaba_inşaat k1 = new kaba_inşaat();
                k1.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btn_ince_Click(object sender, EventArgs e)
        {
            try
            {
                İnce_İşler i1 = new İnce_İşler();
                i1.Show();
                this.Hide();
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
