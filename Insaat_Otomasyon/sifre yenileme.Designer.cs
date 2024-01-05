namespace Insaat_Otomasyon
{
    partial class sifre_yenileme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sifre_yenileme));
            this.txt_sfre_tekrar = new System.Windows.Forms.TextBox();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_kaydet = new DevExpress.XtraEditors.SimpleButton();
            this.chc_sifre_göster = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txt_sfre_tekrar
            // 
            this.txt_sfre_tekrar.Location = new System.Drawing.Point(449, 159);
            this.txt_sfre_tekrar.Name = "txt_sfre_tekrar";
            this.txt_sfre_tekrar.Size = new System.Drawing.Size(100, 22);
            this.txt_sfre_tekrar.TabIndex = 8;
            this.txt_sfre_tekrar.UseSystemPasswordChar = true;
            // 
            // txt_sifre
            // 
            this.txt_sifre.Location = new System.Drawing.Point(449, 96);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Size = new System.Drawing.Size(100, 22);
            this.txt_sifre.TabIndex = 7;
            this.txt_sifre.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Şifre tekrar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(280, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Şifre";
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Location = new System.Drawing.Point(540, 283);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(103, 36);
            this.btn_kaydet.TabIndex = 9;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // chc_sifre_göster
            // 
            this.chc_sifre_göster.AutoSize = true;
            this.chc_sifre_göster.Location = new System.Drawing.Point(449, 228);
            this.chc_sifre_göster.Name = "chc_sifre_göster";
            this.chc_sifre_göster.Size = new System.Drawing.Size(101, 21);
            this.chc_sifre_göster.TabIndex = 10;
            this.chc_sifre_göster.Text = "şifre göster";
            this.chc_sifre_göster.UseVisualStyleBackColor = true;
            this.chc_sifre_göster.CheckedChanged += new System.EventHandler(this.chc_sifre_göster_CheckedChanged);
            // 
            // sifre_yenileme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chc_sifre_göster);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.txt_sfre_tekrar);
            this.Controls.Add(this.txt_sifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "sifre_yenileme";
            this.Text = "sifre yenileme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_sfre_tekrar;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btn_kaydet;
        private System.Windows.Forms.CheckBox chc_sifre_göster;
    }
}