namespace Insaat_Otomasyon
{
    partial class giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(giris));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_adi = new System.Windows.Forms.TextBox();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.lnklbl_sifre_unuttum = new System.Windows.Forms.LinkLabel();
            this.btn_geri = new DevExpress.XtraEditors.SimpleButton();
            this.btn_giris = new DevExpress.XtraEditors.SimpleButton();
            this.chc_sifre_goster = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(146, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(146, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre";
            // 
            // txt_adi
            // 
            this.txt_adi.Location = new System.Drawing.Point(334, 81);
            this.txt_adi.Name = "txt_adi";
            this.txt_adi.Size = new System.Drawing.Size(100, 22);
            this.txt_adi.TabIndex = 2;
            // 
            // txt_sifre
            // 
            this.txt_sifre.Location = new System.Drawing.Point(334, 159);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Size = new System.Drawing.Size(100, 22);
            this.txt_sifre.TabIndex = 3;
            this.txt_sifre.UseSystemPasswordChar = true;
            // 
            // lnklbl_sifre_unuttum
            // 
            this.lnklbl_sifre_unuttum.AutoSize = true;
            this.lnklbl_sifre_unuttum.Location = new System.Drawing.Point(365, 335);
            this.lnklbl_sifre_unuttum.Name = "lnklbl_sifre_unuttum";
            this.lnklbl_sifre_unuttum.Size = new System.Drawing.Size(108, 17);
            this.lnklbl_sifre_unuttum.TabIndex = 5;
            this.lnklbl_sifre_unuttum.TabStop = true;
            this.lnklbl_sifre_unuttum.Text = "Şifremi Unuttum";
            this.lnklbl_sifre_unuttum.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btn_geri
            // 
            this.btn_geri.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_geri.Appearance.Options.UseFont = true;
            this.btn_geri.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btn_geri.Location = new System.Drawing.Point(70, 365);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(113, 49);
            this.btn_geri.TabIndex = 6;
            this.btn_geri.Text = "geri";
            this.btn_geri.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btn_giris
            // 
            this.btn_giris.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_giris.Appearance.Options.UseFont = true;
            this.btn_giris.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btn_giris.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_giris.ImageOptions.Image")));
            this.btn_giris.Location = new System.Drawing.Point(353, 234);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(114, 58);
            this.btn_giris.TabIndex = 7;
            this.btn_giris.Text = "Giriş";
            this.btn_giris.Click += new System.EventHandler(this.btn_giris_Click);
            // 
            // chc_sifre_goster
            // 
            this.chc_sifre_goster.AutoSize = true;
            this.chc_sifre_goster.Location = new System.Drawing.Point(334, 207);
            this.chc_sifre_goster.Name = "chc_sifre_goster";
            this.chc_sifre_goster.Size = new System.Drawing.Size(113, 21);
            this.chc_sifre_goster.TabIndex = 8;
            this.chc_sifre_goster.Text = "Şifreyi göster";
            this.chc_sifre_goster.UseVisualStyleBackColor = true;
            this.chc_sifre_goster.CheckedChanged += new System.EventHandler(this.chc_sifre_goster_CheckedChanged);
            // 
            // giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chc_sifre_goster);
            this.Controls.Add(this.btn_giris);
            this.Controls.Add(this.btn_geri);
            this.Controls.Add(this.lnklbl_sifre_unuttum);
            this.Controls.Add(this.txt_sifre);
            this.Controls.Add(this.txt_adi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "giris";
            this.Text = "giris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_adi;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.LinkLabel lnklbl_sifre_unuttum;
        private DevExpress.XtraEditors.SimpleButton btn_geri;
        private DevExpress.XtraEditors.SimpleButton btn_giris;
        private System.Windows.Forms.CheckBox chc_sifre_goster;
    }
}