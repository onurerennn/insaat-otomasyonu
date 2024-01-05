namespace Insaat_Otomasyon
{
    partial class İnce_İşçilik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(İnce_İşçilik));
            this.btn_geri = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_siva = new System.Windows.Forms.TextBox();
            this.txt_yalitim = new System.Windows.Forms.TextBox();
            this.txt_boya = new System.Windows.Forms.TextBox();
            this.btn_hesapla = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // btn_geri
            // 
            this.btn_geri.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_geri.Appearance.Options.UseFont = true;
            this.btn_geri.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_geri.ImageOptions.Image")));
            this.btn_geri.Location = new System.Drawing.Point(39, 432);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(126, 62);
            this.btn_geri.TabIndex = 0;
            this.btn_geri.Text = "Geri";
            this.btn_geri.Click += new System.EventHandler(this.btn_geri_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(521, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "BOYA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(359, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "YALITIM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(177, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "SIVA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(50, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "M^2";
            // 
            // txt_siva
            // 
            this.txt_siva.Location = new System.Drawing.Point(172, 324);
            this.txt_siva.Name = "txt_siva";
            this.txt_siva.Size = new System.Drawing.Size(55, 22);
            this.txt_siva.TabIndex = 7;
            // 
            // txt_yalitim
            // 
            this.txt_yalitim.Location = new System.Drawing.Point(363, 324);
            this.txt_yalitim.Name = "txt_yalitim";
            this.txt_yalitim.Size = new System.Drawing.Size(75, 22);
            this.txt_yalitim.TabIndex = 8;
            // 
            // txt_boya
            // 
            this.txt_boya.Location = new System.Drawing.Point(525, 326);
            this.txt_boya.Name = "txt_boya";
            this.txt_boya.Size = new System.Drawing.Size(55, 22);
            this.txt_boya.TabIndex = 9;
            // 
            // btn_hesapla
            // 
            this.btn_hesapla.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btn_hesapla.Location = new System.Drawing.Point(584, 427);
            this.btn_hesapla.Name = "btn_hesapla";
            this.btn_hesapla.Size = new System.Drawing.Size(123, 59);
            this.btn_hesapla.TabIndex = 10;
            this.btn_hesapla.Text = "Hesapla";
            this.btn_hesapla.Click += new System.EventHandler(this.btn_hesapla_Click);
            // 
            // İnce_İşçilik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(802, 520);
            this.Controls.Add(this.btn_hesapla);
            this.Controls.Add(this.txt_boya);
            this.Controls.Add(this.txt_yalitim);
            this.Controls.Add(this.txt_siva);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_geri);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "İnce_İşçilik";
            this.Text = "İnce İşçilik";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_geri;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_siva;
        private System.Windows.Forms.TextBox txt_yalitim;
        private System.Windows.Forms.TextBox txt_boya;
        private DevExpress.XtraEditors.SimpleButton btn_hesapla;
    }
}