namespace Insaat_Otomasyon
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.anaSayfaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkımızdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.misyonumuzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.vizyonumuzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.iletişimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btn_kayıt = new DevExpress.XtraEditors.SimpleButton();
            this.btn_giris = new DevExpress.XtraEditors.SimpleButton();
            this.btn_yonetici = new DevExpress.XtraEditors.SimpleButton();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anaSayfaToolStripMenuItem,
            this.hakkımızdaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(914, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // anaSayfaToolStripMenuItem
            // 
            this.anaSayfaToolStripMenuItem.Enabled = false;
            this.anaSayfaToolStripMenuItem.Name = "anaSayfaToolStripMenuItem";
            this.anaSayfaToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.anaSayfaToolStripMenuItem.Text = "Ana Sayfa";
            // 
            // hakkımızdaToolStripMenuItem
            // 
            this.hakkımızdaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.misyonumuzToolStripMenuItem,
            this.toolStripSeparator1,
            this.vizyonumuzToolStripMenuItem,
            this.toolStripSeparator2,
            this.iletişimToolStripMenuItem});
            this.hakkımızdaToolStripMenuItem.Name = "hakkımızdaToolStripMenuItem";
            this.hakkımızdaToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.hakkımızdaToolStripMenuItem.Text = "Hakkımızda";
            // 
            // misyonumuzToolStripMenuItem
            // 
            this.misyonumuzToolStripMenuItem.Name = "misyonumuzToolStripMenuItem";
            this.misyonumuzToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.misyonumuzToolStripMenuItem.Text = "Misyonumuz";
            this.misyonumuzToolStripMenuItem.Click += new System.EventHandler(this.misyonumuzToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(171, 6);
            // 
            // vizyonumuzToolStripMenuItem
            // 
            this.vizyonumuzToolStripMenuItem.Name = "vizyonumuzToolStripMenuItem";
            this.vizyonumuzToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.vizyonumuzToolStripMenuItem.Text = "Vizyonumuz";
            this.vizyonumuzToolStripMenuItem.Click += new System.EventHandler(this.vizyonumuzToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(171, 6);
            // 
            // iletişimToolStripMenuItem
            // 
            this.iletişimToolStripMenuItem.Name = "iletişimToolStripMenuItem";
            this.iletişimToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.iletişimToolStripMenuItem.Text = "İletişim";
            this.iletişimToolStripMenuItem.Click += new System.EventHandler(this.iletişimToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(180, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(410, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Drag-ON İnşaata Hoşgeldiniz";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_kayıt
            // 
            this.btn_kayıt.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kayıt.Appearance.Options.UseFont = true;
            this.btn_kayıt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_kayıt.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btn_kayıt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_kayıt.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_kayıt.ImageOptions.Image")));
            this.btn_kayıt.Location = new System.Drawing.Point(68, 343);
            this.btn_kayıt.Name = "btn_kayıt";
            this.btn_kayıt.Size = new System.Drawing.Size(165, 87);
            this.btn_kayıt.TabIndex = 4;
            this.btn_kayıt.Text = "Kayıt";
            this.btn_kayıt.Click += new System.EventHandler(this.btn_kayıt_Click);
            // 
            // btn_giris
            // 
            this.btn_giris.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_giris.Appearance.Options.UseFont = true;
            this.btn_giris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_giris.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btn_giris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_giris.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_giris.ImageOptions.Image")));
            this.btn_giris.Location = new System.Drawing.Point(600, 343);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(165, 87);
            this.btn_giris.TabIndex = 5;
            this.btn_giris.Text = "Giriş";
            this.btn_giris.Click += new System.EventHandler(this.btn_giris_Click);
            // 
            // btn_yonetici
            // 
            this.btn_yonetici.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_yonetici.Appearance.Options.UseFont = true;
            this.btn_yonetici.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_yonetici.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btn_yonetici.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_yonetici.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_yonetici.ImageOptions.Image")));
            this.btn_yonetici.Location = new System.Drawing.Point(329, 435);
            this.btn_yonetici.Name = "btn_yonetici";
            this.btn_yonetici.Size = new System.Drawing.Size(165, 87);
            this.btn_yonetici.TabIndex = 6;
            this.btn_yonetici.Text = "Yönetici";
            this.btn_yonetici.Click += new System.EventHandler(this.btn_yonetici_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(914, 546);
            this.Controls.Add(this.btn_yonetici);
            this.Controls.Add(this.btn_giris);
            this.Controls.Add(this.btn_kayıt);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Drog-ON İnşaat";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem anaSayfaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkımızdaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem misyonumuzToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem vizyonumuzToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem iletişimToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btn_kayıt;
        private DevExpress.XtraEditors.SimpleButton btn_giris;
        private DevExpress.XtraEditors.SimpleButton btn_yonetici;
    }
}

