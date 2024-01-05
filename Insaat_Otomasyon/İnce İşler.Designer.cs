namespace Insaat_Otomasyon
{
    partial class İnce_İşler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(İnce_İşler));
            this.btn_dograma = new DevExpress.XtraEditors.SimpleButton();
            this.btn_ince_is = new DevExpress.XtraEditors.SimpleButton();
            this.btn_geri = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // btn_dograma
            // 
            this.btn_dograma.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_dograma.Appearance.Options.UseFont = true;
            this.btn_dograma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_dograma.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btn_dograma.Location = new System.Drawing.Point(65, 351);
            this.btn_dograma.Name = "btn_dograma";
            this.btn_dograma.Size = new System.Drawing.Size(145, 80);
            this.btn_dograma.TabIndex = 0;
            this.btn_dograma.Text = "Doğrama İşleri";
            this.btn_dograma.Click += new System.EventHandler(this.btn_dograma_Click);
            // 
            // btn_ince_is
            // 
            this.btn_ince_is.Appearance.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ince_is.Appearance.Options.UseFont = true;
            this.btn_ince_is.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ince_is.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btn_ince_is.Location = new System.Drawing.Point(393, 351);
            this.btn_ince_is.Name = "btn_ince_is";
            this.btn_ince_is.Size = new System.Drawing.Size(145, 80);
            this.btn_ince_is.TabIndex = 1;
            this.btn_ince_is.Text = "İnce İşçilik";
            this.btn_ince_is.Click += new System.EventHandler(this.btn_ince_is_Click);
            // 
            // btn_geri
            // 
            this.btn_geri.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_geri.Appearance.Options.UseFont = true;
            this.btn_geri.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_geri.ImageOptions.Image")));
            this.btn_geri.Location = new System.Drawing.Point(44, 494);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(118, 63);
            this.btn_geri.TabIndex = 2;
            this.btn_geri.Text = "geri";
            this.btn_geri.Click += new System.EventHandler(this.btn_geri_Click);
            // 
            // İnce_İşler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(655, 579);
            this.Controls.Add(this.btn_geri);
            this.Controls.Add(this.btn_ince_is);
            this.Controls.Add(this.btn_dograma);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "İnce_İşler";
            this.Text = "İnce İşler";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_dograma;
        private DevExpress.XtraEditors.SimpleButton btn_ince_is;
        private DevExpress.XtraEditors.SimpleButton btn_geri;
    }
}