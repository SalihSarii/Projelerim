namespace Kütüphane_Otomasyonu
{
    partial class EmanetDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmanetDetay));
            this.dgvEmanet = new System.Windows.Forms.DataGridView();
            this.sspTime8 = new System.Windows.Forms.StatusStrip();
            this.tsslTime8 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnOnizle = new System.Windows.Forms.Button();
            this.btnYazdır = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.cms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.siralaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsSiralaAd = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsSiralaSoyad = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsSiralaTC = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsSiralaTel = new System.Windows.Forms.ToolStripMenuItem();
            this.kitapAdınaGöreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yazarAdınaGöreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yayınevineGöreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.durumaGöreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AramatoolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsAramaCMB = new System.Windows.Forms.ToolStripComboBox();
            this.cmsAramaTXT = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmanet)).BeginInit();
            this.sspTime8.SuspendLayout();
            this.cms.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEmanet
            // 
            this.dgvEmanet.AllowUserToAddRows = false;
            this.dgvEmanet.AllowUserToDeleteRows = false;
            this.dgvEmanet.AllowUserToResizeColumns = false;
            this.dgvEmanet.AllowUserToResizeRows = false;
            this.dgvEmanet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmanet.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgvEmanet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmanet.ContextMenuStrip = this.cms;
            this.dgvEmanet.Location = new System.Drawing.Point(1, -1);
            this.dgvEmanet.Name = "dgvEmanet";
            this.dgvEmanet.ReadOnly = true;
            this.dgvEmanet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmanet.Size = new System.Drawing.Size(1259, 418);
            this.dgvEmanet.TabIndex = 11;
            // 
            // sspTime8
            // 
            this.sspTime8.BackColor = System.Drawing.Color.Transparent;
            this.sspTime8.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslTime8});
            this.sspTime8.Location = new System.Drawing.Point(0, 420);
            this.sspTime8.Name = "sspTime8";
            this.sspTime8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.sspTime8.Size = new System.Drawing.Size(1260, 22);
            this.sspTime8.SizingGrip = false;
            this.sspTime8.TabIndex = 14;
            this.sspTime8.Text = "statusStrip1";
            // 
            // tsslTime8
            // 
            this.tsslTime8.Image = global::Kütüphane_Otomasyonu.Properties.Resources.Beykent_Universitesi_Logo_Yeni;
            this.tsslTime8.Name = "tsslTime8";
            this.tsslTime8.Size = new System.Drawing.Size(55, 17);
            this.tsslTime8.Text = "Time8";
            // 
            // btnOnizle
            // 
            this.btnOnizle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOnizle.Image = global::Kütüphane_Otomasyonu.Properties.Resources.preview1;
            this.btnOnizle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOnizle.Location = new System.Drawing.Point(61, 419);
            this.btnOnizle.Name = "btnOnizle";
            this.btnOnizle.Size = new System.Drawing.Size(81, 23);
            this.btnOnizle.TabIndex = 16;
            this.btnOnizle.Text = "Önizleme";
            this.btnOnizle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOnizle.UseVisualStyleBackColor = true;
            this.btnOnizle.Click += new System.EventHandler(this.btnOnizle_Click);
            // 
            // btnYazdır
            // 
            this.btnYazdır.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYazdır.Image = global::Kütüphane_Otomasyonu.Properties.Resources.printer2;
            this.btnYazdır.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYazdır.Location = new System.Drawing.Point(1, 419);
            this.btnYazdır.Name = "btnYazdır";
            this.btnYazdır.Size = new System.Drawing.Size(61, 23);
            this.btnYazdır.TabIndex = 15;
            this.btnYazdır.Text = "Yazdır";
            this.btnYazdır.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnYazdır.UseVisualStyleBackColor = true;
            this.btnYazdır.Click += new System.EventHandler(this.btnYazdır_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Text = "Baskı önizleme";
            this.printPreviewDialog1.Visible = false;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // cms
            // 
            this.cms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siralaToolStripMenuItem,
            this.AramatoolStripMenuItem6});
            this.cms.Name = "cms";
            this.cms.Size = new System.Drawing.Size(110, 48);
            // 
            // siralaToolStripMenuItem
            // 
            this.siralaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsSiralaAd,
            this.cmsSiralaSoyad,
            this.cmsSiralaTC,
            this.cmsSiralaTel,
            this.kitapAdınaGöreToolStripMenuItem,
            this.yazarAdınaGöreToolStripMenuItem,
            this.yayınevineGöreToolStripMenuItem,
            this.durumaGöreToolStripMenuItem});
            this.siralaToolStripMenuItem.Name = "siralaToolStripMenuItem";
            this.siralaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.siralaToolStripMenuItem.Text = "Sırala";
            // 
            // cmsSiralaAd
            // 
            this.cmsSiralaAd.Name = "cmsSiralaAd";
            this.cmsSiralaAd.Size = new System.Drawing.Size(180, 22);
            this.cmsSiralaAd.Text = "Ada Göre";
            this.cmsSiralaAd.Click += new System.EventHandler(this.cmsSiralaAd_Click);
            // 
            // cmsSiralaSoyad
            // 
            this.cmsSiralaSoyad.Name = "cmsSiralaSoyad";
            this.cmsSiralaSoyad.Size = new System.Drawing.Size(180, 22);
            this.cmsSiralaSoyad.Text = "Soyada Göre";
            this.cmsSiralaSoyad.Click += new System.EventHandler(this.cmsSiralaSoyad_Click);
            // 
            // cmsSiralaTC
            // 
            this.cmsSiralaTC.Name = "cmsSiralaTC";
            this.cmsSiralaTC.Size = new System.Drawing.Size(180, 22);
            this.cmsSiralaTC.Text = "TC\'ye göre";
            this.cmsSiralaTC.Click += new System.EventHandler(this.cmsSiralaTC_Click);
            // 
            // cmsSiralaTel
            // 
            this.cmsSiralaTel.Name = "cmsSiralaTel";
            this.cmsSiralaTel.Size = new System.Drawing.Size(180, 22);
            this.cmsSiralaTel.Text = "Telefona göre";
            this.cmsSiralaTel.Click += new System.EventHandler(this.cmsSiralaTel_Click);
            // 
            // kitapAdınaGöreToolStripMenuItem
            // 
            this.kitapAdınaGöreToolStripMenuItem.Name = "kitapAdınaGöreToolStripMenuItem";
            this.kitapAdınaGöreToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kitapAdınaGöreToolStripMenuItem.Text = "Kitap Adına göre";
            this.kitapAdınaGöreToolStripMenuItem.Click += new System.EventHandler(this.kitapAdınaGöreToolStripMenuItem_Click);
            // 
            // yazarAdınaGöreToolStripMenuItem
            // 
            this.yazarAdınaGöreToolStripMenuItem.Name = "yazarAdınaGöreToolStripMenuItem";
            this.yazarAdınaGöreToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.yazarAdınaGöreToolStripMenuItem.Text = "Yazar Adına göre";
            this.yazarAdınaGöreToolStripMenuItem.Click += new System.EventHandler(this.yazarAdınaGöreToolStripMenuItem_Click);
            // 
            // yayınevineGöreToolStripMenuItem
            // 
            this.yayınevineGöreToolStripMenuItem.Name = "yayınevineGöreToolStripMenuItem";
            this.yayınevineGöreToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.yayınevineGöreToolStripMenuItem.Text = "Yayınevine göre";
            this.yayınevineGöreToolStripMenuItem.Click += new System.EventHandler(this.yayınevineGöreToolStripMenuItem_Click);
            // 
            // durumaGöreToolStripMenuItem
            // 
            this.durumaGöreToolStripMenuItem.Name = "durumaGöreToolStripMenuItem";
            this.durumaGöreToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.durumaGöreToolStripMenuItem.Text = "Duruma göre";
            this.durumaGöreToolStripMenuItem.Click += new System.EventHandler(this.durumaGöreToolStripMenuItem_Click);
            // 
            // AramatoolStripMenuItem6
            // 
            this.AramatoolStripMenuItem6.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsAramaCMB,
            this.cmsAramaTXT,
            this.toolStripMenuItem6});
            this.AramatoolStripMenuItem6.Name = "AramatoolStripMenuItem6";
            this.AramatoolStripMenuItem6.Size = new System.Drawing.Size(180, 22);
            this.AramatoolStripMenuItem6.Text = "Arama";
            // 
            // cmsAramaCMB
            // 
            this.cmsAramaCMB.Items.AddRange(new object[] {
            "Ad",
            "Soyad",
            "TC",
            "Tel",
            "Kitap Adı",
            "Yazar Adı",
            "Yayınevi",
            "Durum"});
            this.cmsAramaCMB.Name = "cmsAramaCMB";
            this.cmsAramaCMB.Size = new System.Drawing.Size(121, 23);
            this.cmsAramaCMB.Text = "Seçiniz..";
            // 
            // cmsAramaTXT
            // 
            this.cmsAramaTXT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmsAramaTXT.Name = "cmsAramaTXT";
            this.cmsAramaTXT.Size = new System.Drawing.Size(100, 23);
            this.cmsAramaTXT.Text = "Aranacak Kelime";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Image = global::Kütüphane_Otomasyonu.Properties.Resources.ara;
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuItem6.Text = "Ara";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // EmanetDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1260, 442);
            this.Controls.Add(this.btnOnizle);
            this.Controls.Add(this.btnYazdır);
            this.Controls.Add(this.sspTime8);
            this.Controls.Add(this.dgvEmanet);
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Name = "EmanetDetay";
            this.Text = "Emanetler";
            this.Load += new System.EventHandler(this.EmanetDetay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmanet)).EndInit();
            this.sspTime8.ResumeLayout(false);
            this.sspTime8.PerformLayout();
            this.cms.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvEmanet;
        private System.Windows.Forms.StatusStrip sspTime8;
        private System.Windows.Forms.ToolStripStatusLabel tsslTime8;
        private System.Windows.Forms.Button btnOnizle;
        private System.Windows.Forms.Button btnYazdır;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ContextMenuStrip cms;
        private System.Windows.Forms.ToolStripMenuItem siralaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cmsSiralaAd;
        private System.Windows.Forms.ToolStripMenuItem cmsSiralaSoyad;
        private System.Windows.Forms.ToolStripMenuItem cmsSiralaTC;
        private System.Windows.Forms.ToolStripMenuItem cmsSiralaTel;
        private System.Windows.Forms.ToolStripMenuItem kitapAdınaGöreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yazarAdınaGöreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yayınevineGöreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem durumaGöreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AramatoolStripMenuItem6;
        private System.Windows.Forms.ToolStripComboBox cmsAramaCMB;
        private System.Windows.Forms.ToolStripTextBox cmsAramaTXT;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
    }
}