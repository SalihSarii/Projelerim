namespace Kütüphane_Otomasyonu
{
    partial class UyeIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UyeIslemleri));
            this.grbUye = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.mtxtTel = new System.Windows.Forms.MaskedTextBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.grbCinsiyet = new System.Windows.Forms.GroupBox();
            this.rdbKadin = new System.Windows.Forms.RadioButton();
            this.rdbErkek = new System.Windows.Forms.RadioButton();
            this.lblTel = new System.Windows.Forms.Label();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.lblTC = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.lblAd = new System.Windows.Forms.Label();
            this.timer_8 = new System.Windows.Forms.Timer(this.components);
            this.sspTime8 = new System.Windows.Forms.StatusStrip();
            this.tsslTime8 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslHelp = new System.Windows.Forms.ToolStripSplitButton();
            this.dgvUyeler = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsSirala = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsSiralaAd = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsSiralaSoyad = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsSiralaTC = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsSiralaTel = new System.Windows.Forms.ToolStripMenuItem();
            this.cinsiyeteGöreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsArama = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsAramaCMB = new System.Windows.Forms.ToolStripComboBox();
            this.cmsAramaTXT = new System.Windows.Forms.ToolStripTextBox();
            this.araToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grbUye.SuspendLayout();
            this.grbCinsiyet.SuspendLayout();
            this.sspTime8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUyeler)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbUye
            // 
            this.grbUye.Controls.Add(this.btnUpdate);
            this.grbUye.Controls.Add(this.mtxtTel);
            this.grbUye.Controls.Add(this.btnSil);
            this.grbUye.Controls.Add(this.btnKaydet);
            this.grbUye.Controls.Add(this.grbCinsiyet);
            this.grbUye.Controls.Add(this.lblTel);
            this.grbUye.Controls.Add(this.txtTC);
            this.grbUye.Controls.Add(this.lblTC);
            this.grbUye.Controls.Add(this.txtSoyad);
            this.grbUye.Controls.Add(this.lblSoyad);
            this.grbUye.Controls.Add(this.txtAd);
            this.grbUye.Controls.Add(this.lblAd);
            this.grbUye.Location = new System.Drawing.Point(8, 5);
            this.grbUye.Name = "grbUye";
            this.grbUye.Size = new System.Drawing.Size(359, 184);
            this.grbUye.TabIndex = 0;
            this.grbUye.TabStop = false;
            this.grbUye.Text = "Üye Bilgileri:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Image = global::Kütüphane_Otomasyonu.Properties.Resources.update;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(125, 122);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(114, 41);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "GÜNCELLE";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // mtxtTel
            // 
            this.mtxtTel.Location = new System.Drawing.Point(83, 96);
            this.mtxtTel.Mask = "(999) 000-0000";
            this.mtxtTel.Name = "mtxtTel";
            this.mtxtTel.Size = new System.Drawing.Size(100, 20);
            this.mtxtTel.TabIndex = 3;
            // 
            // btnSil
            // 
            this.btnSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSil.Image = global::Kütüphane_Otomasyonu.Properties.Resources.delete;
            this.btnSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSil.Location = new System.Drawing.Point(245, 122);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(82, 41);
            this.btnSil.TabIndex = 7;
            this.btnSil.Text = "SİL";
            this.btnSil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKaydet.Image = global::Kütüphane_Otomasyonu.Properties.Resources.add;
            this.btnKaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKaydet.Location = new System.Drawing.Point(21, 122);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(98, 41);
            this.btnKaydet.TabIndex = 6;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // grbCinsiyet
            // 
            this.grbCinsiyet.Controls.Add(this.rdbKadin);
            this.grbCinsiyet.Controls.Add(this.rdbErkek);
            this.grbCinsiyet.Location = new System.Drawing.Point(189, 17);
            this.grbCinsiyet.Name = "grbCinsiyet";
            this.grbCinsiyet.Size = new System.Drawing.Size(114, 95);
            this.grbCinsiyet.TabIndex = 4;
            this.grbCinsiyet.TabStop = false;
            this.grbCinsiyet.Text = "Cinsiyet:";
            // 
            // rdbKadin
            // 
            this.rdbKadin.AutoSize = true;
            this.rdbKadin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbKadin.Location = new System.Drawing.Point(26, 59);
            this.rdbKadin.Name = "rdbKadin";
            this.rdbKadin.Size = new System.Drawing.Size(52, 17);
            this.rdbKadin.TabIndex = 5;
            this.rdbKadin.TabStop = true;
            this.rdbKadin.Text = "Kadın";
            this.rdbKadin.UseVisualStyleBackColor = true;
            this.rdbKadin.CheckedChanged += new System.EventHandler(this.rdbKadin_CheckedChanged);
            // 
            // rdbErkek
            // 
            this.rdbErkek.AutoSize = true;
            this.rdbErkek.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbErkek.Location = new System.Drawing.Point(26, 36);
            this.rdbErkek.Name = "rdbErkek";
            this.rdbErkek.Size = new System.Drawing.Size(53, 17);
            this.rdbErkek.TabIndex = 4;
            this.rdbErkek.TabStop = true;
            this.rdbErkek.Text = "Erkek";
            this.rdbErkek.UseVisualStyleBackColor = true;
            this.rdbErkek.CheckedChanged += new System.EventHandler(this.rdbErkek_CheckedChanged);
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(52, 99);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(25, 13);
            this.lblTel.TabIndex = 6;
            this.lblTel.Text = "Tel:";
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(83, 70);
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(100, 20);
            this.txtTC.TabIndex = 2;
            this.txtTC.TextChanged += new System.EventHandler(this.txtTC_TextChanged);
            this.txtTC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTC_KeyPress);
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.Location = new System.Drawing.Point(53, 76);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(24, 13);
            this.lblTC.TabIndex = 4;
            this.lblTC.Text = "TC:";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(83, 44);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtSoyad.TabIndex = 1;
            this.txtSoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoyad_KeyPress);
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(42, 47);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(40, 13);
            this.lblSoyad.TabIndex = 2;
            this.lblSoyad.Text = "Soyad:";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(83, 18);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 20);
            this.txtAd.TabIndex = 0;
            this.txtAd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAd_KeyPress);
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(59, 21);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(23, 13);
            this.lblAd.TabIndex = 0;
            this.lblAd.Text = "Ad:";
            // 
            // timer_8
            // 
            this.timer_8.Tick += new System.EventHandler(this.timer_8_Tick);
            // 
            // sspTime8
            // 
            this.sspTime8.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslTime8,
            this.tsslHelp});
            this.sspTime8.Location = new System.Drawing.Point(0, 189);
            this.sspTime8.Name = "sspTime8";
            this.sspTime8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.sspTime8.Size = new System.Drawing.Size(822, 22);
            this.sspTime8.SizingGrip = false;
            this.sspTime8.TabIndex = 12;
            this.sspTime8.Text = "statusStrip1";
            // 
            // tsslTime8
            // 
            this.tsslTime8.Image = global::Kütüphane_Otomasyonu.Properties.Resources.Beykent_Universitesi_Logo_Yeni;
            this.tsslTime8.Name = "tsslTime8";
            this.tsslTime8.Size = new System.Drawing.Size(55, 17);
            this.tsslTime8.Text = "Time8";
            // 
            // tsslHelp
            // 
            this.tsslHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsslHelp.DropDownButtonWidth = 0;
            this.tsslHelp.Image = global::Kütüphane_Otomasyonu.Properties.Resources.Help;
            this.tsslHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsslHelp.Name = "tsslHelp";
            this.tsslHelp.Size = new System.Drawing.Size(21, 20);
            this.tsslHelp.ButtonClick += new System.EventHandler(this.tsslHelp_ButtonClick);
            this.tsslHelp.MouseEnter += new System.EventHandler(this.tsslHelp_MouseEnter);
            this.tsslHelp.MouseLeave += new System.EventHandler(this.tsslHelp_MouseLeave);
            // 
            // dgvUyeler
            // 
            this.dgvUyeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUyeler.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvUyeler.Location = new System.Drawing.Point(373, 5);
            this.dgvUyeler.Name = "dgvUyeler";
            this.dgvUyeler.ReadOnly = true;
            this.dgvUyeler.Size = new System.Drawing.Size(449, 174);
            this.dgvUyeler.TabIndex = 13;
            this.dgvUyeler.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvUyeler_CellMouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsSirala,
            this.cmsArama});
            this.contextMenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(110, 48);
            // 
            // cmsSirala
            // 
            this.cmsSirala.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsSiralaAd,
            this.cmsSiralaSoyad,
            this.cmsSiralaTC,
            this.cmsSiralaTel,
            this.cinsiyeteGöreToolStripMenuItem});
            this.cmsSirala.Name = "cmsSirala";
            this.cmsSirala.Size = new System.Drawing.Size(109, 22);
            this.cmsSirala.Text = "Sırala";
            // 
            // cmsSiralaAd
            // 
            this.cmsSiralaAd.Name = "cmsSiralaAd";
            this.cmsSiralaAd.Size = new System.Drawing.Size(152, 22);
            this.cmsSiralaAd.Text = "Ad\'a göre";
            this.cmsSiralaAd.Click += new System.EventHandler(this.cmsSiralaAd_Click);
            // 
            // cmsSiralaSoyad
            // 
            this.cmsSiralaSoyad.Name = "cmsSiralaSoyad";
            this.cmsSiralaSoyad.Size = new System.Drawing.Size(152, 22);
            this.cmsSiralaSoyad.Text = "Soyad\'a göre";
            this.cmsSiralaSoyad.Click += new System.EventHandler(this.cmsSiralaSoyad_Click);
            // 
            // cmsSiralaTC
            // 
            this.cmsSiralaTC.Name = "cmsSiralaTC";
            this.cmsSiralaTC.Size = new System.Drawing.Size(152, 22);
            this.cmsSiralaTC.Text = "TC\'ye göre";
            this.cmsSiralaTC.Click += new System.EventHandler(this.cmsSiralaTC_Click);
            // 
            // cmsSiralaTel
            // 
            this.cmsSiralaTel.Name = "cmsSiralaTel";
            this.cmsSiralaTel.Size = new System.Drawing.Size(152, 22);
            this.cmsSiralaTel.Text = "Tel\'e göre";
            this.cmsSiralaTel.Click += new System.EventHandler(this.cmsSiralaTel_Click);
            // 
            // cinsiyeteGöreToolStripMenuItem
            // 
            this.cinsiyeteGöreToolStripMenuItem.Name = "cinsiyeteGöreToolStripMenuItem";
            this.cinsiyeteGöreToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cinsiyeteGöreToolStripMenuItem.Text = "Cinsiyet\'e göre";
            this.cinsiyeteGöreToolStripMenuItem.Click += new System.EventHandler(this.cinsiyeteGöreToolStripMenuItem_Click);
            // 
            // cmsArama
            // 
            this.cmsArama.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsAramaCMB,
            this.cmsAramaTXT,
            this.araToolStripMenuItem});
            this.cmsArama.Name = "cmsArama";
            this.cmsArama.Size = new System.Drawing.Size(109, 22);
            this.cmsArama.Text = "Arama";
            // 
            // cmsAramaCMB
            // 
            this.cmsAramaCMB.Items.AddRange(new object[] {
            "Ad",
            "Soyad",
            "TC",
            "Tel",
            "Cinsiyet"});
            this.cmsAramaCMB.Name = "cmsAramaCMB";
            this.cmsAramaCMB.Size = new System.Drawing.Size(121, 23);
            this.cmsAramaCMB.Text = "Seçiniz...";
            // 
            // cmsAramaTXT
            // 
            this.cmsAramaTXT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmsAramaTXT.Name = "cmsAramaTXT";
            this.cmsAramaTXT.Size = new System.Drawing.Size(100, 23);
            this.cmsAramaTXT.Text = "Aranacak kelime";
            this.cmsAramaTXT.Click += new System.EventHandler(this.cmsAramaTXT_Click);
            // 
            // araToolStripMenuItem
            // 
            this.araToolStripMenuItem.Image = global::Kütüphane_Otomasyonu.Properties.Resources.ara;
            this.araToolStripMenuItem.Name = "araToolStripMenuItem";
            this.araToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.araToolStripMenuItem.Text = "Ara";
            this.araToolStripMenuItem.Click += new System.EventHandler(this.araToolStripMenuItem_Click);
            // 
            // UyeIslemleri
            // 
            this.AcceptButton = this.btnKaydet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(822, 211);
            this.Controls.Add(this.dgvUyeler);
            this.Controls.Add(this.sspTime8);
            this.Controls.Add(this.grbUye);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UyeIslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Üye İşlemleri";
            this.Load += new System.EventHandler(this.UyeIslemleri_Load);
            this.grbUye.ResumeLayout(false);
            this.grbUye.PerformLayout();
            this.grbCinsiyet.ResumeLayout(false);
            this.grbCinsiyet.PerformLayout();
            this.sspTime8.ResumeLayout(false);
            this.sspTime8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUyeler)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbUye;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.GroupBox grbCinsiyet;
        private System.Windows.Forms.RadioButton rdbKadin;
        private System.Windows.Forms.RadioButton rdbErkek;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.Label lblTC;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Timer timer_8;
        private System.Windows.Forms.StatusStrip sspTime8;
        private System.Windows.Forms.ToolStripStatusLabel tsslTime8;
        private System.Windows.Forms.ToolStripSplitButton tsslHelp;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.DataGridView dgvUyeler;
        private System.Windows.Forms.MaskedTextBox mtxtTel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cmsSirala;
        private System.Windows.Forms.ToolStripMenuItem cmsSiralaAd;
        private System.Windows.Forms.ToolStripMenuItem cmsSiralaSoyad;
        private System.Windows.Forms.ToolStripMenuItem cmsSiralaTC;
        private System.Windows.Forms.ToolStripMenuItem cmsSiralaTel;
        private System.Windows.Forms.ToolStripMenuItem cmsArama;
        private System.Windows.Forms.ToolStripComboBox cmsAramaCMB;
        private System.Windows.Forms.ToolStripTextBox cmsAramaTXT;
        private System.Windows.Forms.ToolStripMenuItem araToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cinsiyeteGöreToolStripMenuItem;
    }
}