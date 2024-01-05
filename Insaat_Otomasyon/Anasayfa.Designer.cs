namespace Insaat_Otomasyon
{
    partial class Anasayfa
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anasayfa));
            this.btn_borc_ogren = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_siparis_ver = new DevExpress.XtraEditors.SimpleButton();
            this.btn_siparis_tamamla = new DevExpress.XtraEditors.SimpleButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_borc_ogren
            // 
            this.btn_borc_ogren.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_borc_ogren.Appearance.Options.UseFont = true;
            this.btn_borc_ogren.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btn_borc_ogren.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_borc_ogren.ImageOptions.Image")));
            this.btn_borc_ogren.Location = new System.Drawing.Point(447, 498);
            this.btn_borc_ogren.Name = "btn_borc_ogren";
            this.btn_borc_ogren.Size = new System.Drawing.Size(196, 86);
            this.btn_borc_ogren.TabIndex = 0;
            this.btn_borc_ogren.Text = "borç öğren";
            this.btn_borc_ogren.Click += new System.EventHandler(this.btn_borc_ogren_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(122, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // btn_siparis_ver
            // 
            this.btn_siparis_ver.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_siparis_ver.Appearance.Options.UseFont = true;
            this.btn_siparis_ver.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btn_siparis_ver.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_siparis_ver.ImageOptions.Image")));
            this.btn_siparis_ver.Location = new System.Drawing.Point(68, 498);
            this.btn_siparis_ver.Name = "btn_siparis_ver";
            this.btn_siparis_ver.Size = new System.Drawing.Size(194, 86);
            this.btn_siparis_ver.TabIndex = 1;
            this.btn_siparis_ver.Text = "Sipariş ver";
            this.btn_siparis_ver.Click += new System.EventHandler(this.btn_siparis_ver_Click);
            // 
            // btn_siparis_tamamla
            // 
            this.btn_siparis_tamamla.Appearance.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_siparis_tamamla.Appearance.Options.UseFont = true;
            this.btn_siparis_tamamla.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btn_siparis_tamamla.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btn_siparis_tamamla.Location = new System.Drawing.Point(263, 639);
            this.btn_siparis_tamamla.Name = "btn_siparis_tamamla";
            this.btn_siparis_tamamla.Size = new System.Drawing.Size(253, 72);
            this.btn_siparis_tamamla.TabIndex = 3;
            this.btn_siparis_tamamla.Text = "Siparişi tamamla";
            this.btn_siparis_tamamla.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(45, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 22);
            this.label2.TabIndex = 6;
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(778, 723);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_siparis_tamamla);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_siparis_ver);
            this.Controls.Add(this.btn_borc_ogren);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Anasayfa";
            this.Text = "Anasayfa";
            this.Load += new System.EventHandler(this.Anasayfa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_borc_ogren;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btn_siparis_ver;
        private DevExpress.XtraEditors.SimpleButton btn_siparis_tamamla;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
    }
}