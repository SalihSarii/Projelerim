
namespace Kütüphane_Otomasyonu
{
    partial class UyeDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UyeDetay));
            this.dgvUyeDetay = new System.Windows.Forms.DataGridView();
            this.timer_7 = new System.Windows.Forms.Timer(this.components);
            this.sspTime7 = new System.Windows.Forms.StatusStrip();
            this.tsslTime7 = new System.Windows.Forms.ToolStripStatusLabel();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.btnOnizle = new System.Windows.Forms.Button();
            this.btnYazdır = new System.Windows.Forms.Button();
            this.cms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.siralaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsSiralaAd = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsSiralaSoyad = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsSiralaTC = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsSiralaTel = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsSiralaCins = new System.Windows.Forms.ToolStripMenuItem();
            this.AramatoolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsAramaCMB = new System.Windows.Forms.ToolStripComboBox();
            this.cmsAramaTXT = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUyeDetay)).BeginInit();
            this.sspTime7.SuspendLayout();
            this.cms.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUyeDetay
            // 
            this.dgvUyeDetay.AllowUserToAddRows = false;
            this.dgvUyeDetay.AllowUserToDeleteRows = false;
            this.dgvUyeDetay.AllowUserToResizeColumns = false;
            this.dgvUyeDetay.AllowUserToResizeRows = false;
            this.dgvUyeDetay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUyeDetay.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgvUyeDetay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUyeDetay.ContextMenuStrip = this.cms;
            this.dgvUyeDetay.Location = new System.Drawing.Point(-3, -1);
            this.dgvUyeDetay.Name = "dgvUyeDetay";
            this.dgvUyeDetay.ReadOnly = true;
            this.dgvUyeDetay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUyeDetay.Size = new System.Drawing.Size(805, 426);
            this.dgvUyeDetay.TabIndex = 0;
            // 
            // timer_7
            // 
            this.timer_7.Tick += new System.EventHandler(this.timer_7_Tick);
            // 
            // sspTime7
            // 
            this.sspTime7.BackColor = System.Drawing.Color.Transparent;
            this.sspTime7.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslTime7});
            this.sspTime7.Location = new System.Drawing.Point(0, 428);
            this.sspTime7.Name = "sspTime7";
            this.sspTime7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.sspTime7.Size = new System.Drawing.Size(800, 22);
            this.sspTime7.SizingGrip = false;
            this.sspTime7.TabIndex = 1;
            this.sspTime7.Text = "statusStrip1";
            // 
            // tsslTime7
            // 
            this.tsslTime7.Image = global::Kütüphane_Otomasyonu.Properties.Resources.Beykent_Universitesi_Logo_Yeni;
            this.tsslTime7.Name = "tsslTime7";
            this.tsslTime7.Size = new System.Drawing.Size(55, 17);
            this.tsslTime7.Text = "Time7";
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
            this.printPreviewDialog1.Visible = false;
            // 
            // btnOnizle
            // 
            this.btnOnizle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOnizle.Image = global::Kütüphane_Otomasyonu.Properties.Resources.preview1;
            this.btnOnizle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOnizle.Location = new System.Drawing.Point(65, 427);
            this.btnOnizle.Name = "btnOnizle";
            this.btnOnizle.Size = new System.Drawing.Size(91, 23);
            this.btnOnizle.TabIndex = 5;
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
            this.btnYazdır.Location = new System.Drawing.Point(0, 427);
            this.btnYazdır.Name = "btnYazdır";
            this.btnYazdır.Size = new System.Drawing.Size(66, 23);
            this.btnYazdır.TabIndex = 4;
            this.btnYazdır.Text = "Yazdır";
            this.btnYazdır.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnYazdır.UseVisualStyleBackColor = true;
            this.btnYazdır.Click += new System.EventHandler(this.btnYazdır_Click);
            // 
            // cms
            // 
            this.cms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siralaToolStripMenuItem,
            this.AramatoolStripMenuItem6});
            this.cms.Name = "cms";
            this.cms.Size = new System.Drawing.Size(181, 70);
            // 
            // siralaToolStripMenuItem
            // 
            this.siralaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsSiralaAd,
            this.cmsSiralaSoyad,
            this.cmsSiralaTC,
            this.cmsSiralaTel,
            this.cmsSiralaCins});
            this.siralaToolStripMenuItem.Name = "siralaToolStripMenuItem";
            this.siralaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.siralaToolStripMenuItem.Text = "Sırala";
            // 
            // cmsSiralaAd
            // 
            this.cmsSiralaAd.Name = "cmsSiralaAd";
            this.cmsSiralaAd.Size = new System.Drawing.Size(180, 22);
            this.cmsSiralaAd.Text = "Ada Göre";
            this.cmsSiralaAd.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
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
            // cmsSiralaCins
            // 
            this.cmsSiralaCins.Name = "cmsSiralaCins";
            this.cmsSiralaCins.Size = new System.Drawing.Size(180, 22);
            this.cmsSiralaCins.Text = "Cinsiyete göre";
            this.cmsSiralaCins.Click += new System.EventHandler(this.cmsSiralaCins_Click);
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
            "Cinsiyet"});
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
            // UyeDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOnizle);
            this.Controls.Add(this.btnYazdır);
            this.Controls.Add(this.sspTime7);
            this.Controls.Add(this.dgvUyeDetay);
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UyeDetay";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Üyeler";
            this.Load += new System.EventHandler(this.UyeDetay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUyeDetay)).EndInit();
            this.sspTime7.ResumeLayout(false);
            this.sspTime7.PerformLayout();
            this.cms.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUyeDetay;
        private System.Windows.Forms.Timer timer_7;
        private System.Windows.Forms.StatusStrip sspTime7;
        private System.Windows.Forms.ToolStripStatusLabel tsslTime7;
        private System.Windows.Forms.Button btnOnizle;
        private System.Windows.Forms.Button btnYazdır;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.ContextMenuStrip cms;
        private System.Windows.Forms.ToolStripMenuItem siralaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cmsSiralaAd;
        private System.Windows.Forms.ToolStripMenuItem cmsSiralaSoyad;
        private System.Windows.Forms.ToolStripMenuItem cmsSiralaTC;
        private System.Windows.Forms.ToolStripMenuItem cmsSiralaTel;
        private System.Windows.Forms.ToolStripMenuItem cmsSiralaCins;
        private System.Windows.Forms.ToolStripMenuItem AramatoolStripMenuItem6;
        private System.Windows.Forms.ToolStripComboBox cmsAramaCMB;
        private System.Windows.Forms.ToolStripTextBox cmsAramaTXT;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
    }
}