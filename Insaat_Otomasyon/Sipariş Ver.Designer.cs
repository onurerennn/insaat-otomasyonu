namespace Insaat_Otomasyon
{
    partial class Sipariş_Ver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sipariş_Ver));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_kaba = new DevExpress.XtraEditors.SimpleButton();
            this.btn_ince = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(216, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yapmak İstediğiniz İşlemi Seçin";
            // 
            // btn_kaba
            // 
            this.btn_kaba.Appearance.Font = new System.Drawing.Font("Yu Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kaba.Appearance.Options.UseFont = true;
            this.btn_kaba.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_kaba.ImageOptions.Image")));
            this.btn_kaba.Location = new System.Drawing.Point(86, 383);
            this.btn_kaba.Name = "btn_kaba";
            this.btn_kaba.Size = new System.Drawing.Size(181, 71);
            this.btn_kaba.TabIndex = 1;
            this.btn_kaba.Text = "Kaba İnşaat";
            this.btn_kaba.Click += new System.EventHandler(this.btn_kaba_Click);
            // 
            // btn_ince
            // 
            this.btn_ince.Appearance.Font = new System.Drawing.Font("Yu Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ince.Appearance.Options.UseFont = true;
            this.btn_ince.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_ince.ImageOptions.Image")));
            this.btn_ince.Location = new System.Drawing.Point(461, 383);
            this.btn_ince.Name = "btn_ince";
            this.btn_ince.Size = new System.Drawing.Size(181, 71);
            this.btn_ince.TabIndex = 2;
            this.btn_ince.Text = "İnce İnşaat";
            this.btn_ince.Click += new System.EventHandler(this.btn_ince_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(40, 484);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(117, 51);
            this.simpleButton1.TabIndex = 3;
            this.simpleButton1.Text = "Geri";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // Sipariş_Ver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(749, 557);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.btn_ince);
            this.Controls.Add(this.btn_kaba);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Sipariş_Ver";
            this.Text = "Sipariş Ver";
            this.Load += new System.EventHandler(this.Sipariş_Ver_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btn_kaba;
        private DevExpress.XtraEditors.SimpleButton btn_ince;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}