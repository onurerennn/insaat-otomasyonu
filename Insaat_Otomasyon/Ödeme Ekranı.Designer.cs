namespace Insaat_Otomasyon
{
    partial class Ödeme_Ekranı
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ödeme_Ekranı));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_geri = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_miktar = new System.Windows.Forms.TextBox();
            this.btn_ode = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(80, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(80, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // btn_geri
            // 
            this.btn_geri.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_geri.Appearance.Options.UseFont = true;
            this.btn_geri.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btn_geri.Location = new System.Drawing.Point(21, 377);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(99, 52);
            this.btn_geri.TabIndex = 2;
            this.btn_geri.Text = "Geri\r\n";
            this.btn_geri.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(82, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(357, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ödemek istediğiniz tutarı giriniz =  ";
            // 
            // txt_miktar
            // 
            this.txt_miktar.Location = new System.Drawing.Point(455, 206);
            this.txt_miktar.Name = "txt_miktar";
            this.txt_miktar.Size = new System.Drawing.Size(100, 22);
            this.txt_miktar.TabIndex = 4;
            // 
            // btn_ode
            // 
            this.btn_ode.Appearance.Font = new System.Drawing.Font("Bodoni MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ode.Appearance.Options.UseFont = true;
            this.btn_ode.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_ode.ImageOptions.Image")));
            this.btn_ode.Location = new System.Drawing.Point(639, 380);
            this.btn_ode.Name = "btn_ode";
            this.btn_ode.Size = new System.Drawing.Size(143, 70);
            this.btn_ode.TabIndex = 5;
            this.btn_ode.Text = "Öde";
            this.btn_ode.Click += new System.EventHandler(this.btn_ode_Click);
            // 
            // Ödeme_Ekranı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(900, 502);
            this.Controls.Add(this.btn_ode);
            this.Controls.Add(this.txt_miktar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_geri);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ödeme_Ekranı";
            this.Text = "Ödeme Ekranı";
            this.Load += new System.EventHandler(this.Ödeme_Ekranı_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton btn_geri;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_miktar;
        private DevExpress.XtraEditors.SimpleButton btn_ode;
    }
}