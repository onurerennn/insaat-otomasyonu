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
    public partial class İnce_İşler : Form
    {
        public İnce_İşler()
        {
            InitializeComponent();
        }

        private void btn_dograma_Click(object sender, EventArgs e)
        {
            try
            {
                Doğrama_İşleri d1 = new Doğrama_İşleri();
                d1.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            try
            {
                Sipariş_Ver s1 = new Sipariş_Ver();
                s1.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_ince_is_Click(object sender, EventArgs e)
        {
            try
            {
                İnce_İşçilik i1 = new İnce_İşçilik();
                i1.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
                