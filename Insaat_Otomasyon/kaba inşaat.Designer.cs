namespace Insaat_Otomasyon
{
    partial class kaba_inşaat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kaba_inşaat));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_duvar = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmb_cati = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmb_beton = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txt_duvar = new System.Windows.Forms.TextBox();
            this.txt_cati = new System.Windows.Forms.TextBox();
            this.txt_beton = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_hesapla = new DevExpress.XtraEditors.SimpleButton();
            this.btn_geri = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_duvar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_cati.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_beton.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(150, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "DUVAR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(332, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "ÇATI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(494, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "BETON";
            // 
            // cmb_duvar
            // 
            this.cmb_duvar.Location = new System.Drawing.Point(154, 283);
            this.cmb_duvar.Name = "cmb_duvar";
            this.cmb_duvar.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_duvar.Properties.Items.AddRange(new object[] {
            "tuğla",
            "bims",
            "ytong"});
            this.cmb_duvar.Size = new System.Drawing.Size(69, 22);
            this.cmb_duvar.TabIndex = 3;
            // 
            // cmb_cati
            // 
            this.cmb_cati.Location = new System.Drawing.Point(336, 283);
            this.cmb_cati.Name = "cmb_cati";
            this.cmb_cati.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_cati.Properties.Items.AddRange(new object[] {
            "sac",
            "osb"});
            this.cmb_cati.Size = new System.Drawing.Size(69, 22);
            this.cmb_cati.TabIndex = 4;
            // 
            // cmb_beton
            // 
            this.cmb_beton.Location = new System.Drawing.Point(497, 283);
            this.cmb_beton.Name = "cmb_beton";
            this.cmb_beton.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_beton.Properties.Items.AddRange(new object[] {
            "C-45",
            "C-50"});
            this.cmb_beton.Size = new System.Drawing.Size(69, 22);
            this.cmb_beton.TabIndex = 5;
            // 
            // txt_duvar
            // 
            this.txt_duvar.Location = new System.Drawing.Point(154, 349);
            this.txt_duvar.Name = "txt_duvar";
            this.txt_duvar.Size = new System.Drawing.Size(52, 22);
            this.txt_duvar.TabIndex = 6;
            // 
            // txt_cati
            // 
            this.txt_cati.Location = new System.Drawing.Point(336, 349);
            this.txt_cati.Name = "txt_cati";
            this.txt_cati.Size = new System.Drawing.Size(52, 22);
            this.txt_cati.TabIndex = 7;
            // 
            // txt_beton
            // 
            this.txt_beton.Location = new System.Drawing.Point(498, 349);
            this.txt_beton.Name = "txt_beton";
            this.txt_beton.Size = new System.Drawing.Size(52, 22);
            this.txt_beton.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(41, 349);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "M^2";
            // 
            // btn_hesapla
            // 
            this.btn_hesapla.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_hesapla.Appearance.Options.UseFont = true;
            this.btn_hesapla.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btn_hesapla.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_hesapla.ImageOptions.Image")));
            this.btn_hesapla.Location = new System.Drawing.Point(497, 404);
            this.btn_hesapla.Name = "btn_hesapla";
            this.btn_hesapla.Size = new System.Drawing.Size(147, 72);
            this.btn_hesapla.TabIndex = 10;
            this.btn_hesapla.Text = "Hesapla";
            this.btn_hesapla.Click += new System.EventHandler(this.btn_hesapla_Click);
            // 
            // btn_geri
            // 
            this.btn_geri.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_geri.ImageOptions.Image")));
            this.btn_geri.Location = new System.Drawing.Point(12, 417);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(103, 43);
            this.btn_geri.TabIndex = 11;
            this.btn_geri.Text = "geri";
            this.btn_geri.Click += new System.EventHandler(this.btn_geri_Click);
            // 
            // kaba_inşaat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(699, 503);
            this.Controls.Add(this.btn_geri);
            this.Controls.Add(this.btn_hesapla);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_beton);
            this.Controls.Add(this.txt_cati);
            this.Controls.Add(this.txt_duvar);
            this.Controls.Add(this.cmb_beton);
            this.Controls.Add(this.cmb_cati);
            this.Controls.Add(this.cmb_duvar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "kaba_inşaat";
            this.Text = "kaba inşaat";
            ((System.ComponentModel.ISupportInitialize)(this.cmb_duvar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_cati.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_beton.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.ComboBoxEdit cmb_duvar;
        private DevExpress.XtraEditors.ComboBoxEdit cmb_cati;
        private DevExpress.XtraEditors.ComboBoxEdit cmb_beton;
        private System.Windows.Forms.TextBox txt_duvar;
        private System.Windows.Forms.TextBox txt_cati;
        private System.Windows.Forms.TextBox txt_beton;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SimpleButton btn_hesapla;
        private DevExpress.XtraEditors.SimpleButton btn_geri;
    }
}