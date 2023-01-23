namespace Kütüphane_Otomasyonu
{
    partial class KitapDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KitapDetay));
            this.dgvKitapDetay = new System.Windows.Forms.DataGridView();
            this.sspTime5 = new System.Windows.Forms.StatusStrip();
            this.tsslTime5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer_5 = new System.Windows.Forms.Timer(this.components);
            this.btnYazdır = new System.Windows.Forms.Button();
            this.btnOnizle = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsSirala = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsSiralaAd = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsSiralaYazar = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsSiralaTur = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsSiralaYayin = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsArama = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsAramaCMB = new System.Windows.Forms.ToolStripComboBox();
            this.cmsAramaTXT = new System.Windows.Forms.ToolStripTextBox();
            this.araToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKitapDetay)).BeginInit();
            this.sspTime5.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvKitapDetay
            // 
            this.dgvKitapDetay.AllowUserToAddRows = false;
            this.dgvKitapDetay.AllowUserToDeleteRows = false;
            this.dgvKitapDetay.AllowUserToResizeColumns = false;
            this.dgvKitapDetay.AllowUserToResizeRows = false;
            this.dgvKitapDetay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKitapDetay.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgvKitapDetay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvKitapDetay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKitapDetay.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvKitapDetay.Location = new System.Drawing.Point(0, 0);
            this.dgvKitapDetay.Name = "dgvKitapDetay";
            this.dgvKitapDetay.ReadOnly = true;
            this.dgvKitapDetay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKitapDetay.Size = new System.Drawing.Size(800, 448);
            this.dgvKitapDetay.TabIndex = 0;
            // 
            // sspTime5
            // 
            this.sspTime5.BackColor = System.Drawing.Color.Transparent;
            this.sspTime5.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslTime5});
            this.sspTime5.Location = new System.Drawing.Point(0, 451);
            this.sspTime5.Name = "sspTime5";
            this.sspTime5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.sspTime5.Size = new System.Drawing.Size(800, 22);
            this.sspTime5.SizingGrip = false;
            this.sspTime5.TabIndex = 1;
            this.sspTime5.Text = "statusStrip1";
            // 
            // tsslTime5
            // 
            this.tsslTime5.Image = global::Kütüphane_Otomasyonu.Properties.Resources.Beykent_Universitesi_Logo_Yeni;
            this.tsslTime5.Name = "tsslTime5";
            this.tsslTime5.Size = new System.Drawing.Size(55, 17);
            this.tsslTime5.Text = "Time5";
            // 
            // timer_5
            // 
            this.timer_5.Tick += new System.EventHandler(this.timer_5_Tick);
            // 
            // btnYazdır
            // 
            this.btnYazdır.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYazdır.Image = global::Kütüphane_Otomasyonu.Properties.Resources.printer2;
            this.btnYazdır.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYazdır.Location = new System.Drawing.Point(0, 449);
            this.btnYazdır.Name = "btnYazdır";
            this.btnYazdır.Size = new System.Drawing.Size(66, 23);
            this.btnYazdır.TabIndex = 2;
            this.btnYazdır.Text = "Yazdır";
            this.btnYazdır.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnYazdır.UseVisualStyleBackColor = true;
            this.btnYazdır.Click += new System.EventHandler(this.btnYazdır_Click);
            // 
            // btnOnizle
            // 
            this.btnOnizle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOnizle.Image = global::Kütüphane_Otomasyonu.Properties.Resources.preview1;
            this.btnOnizle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOnizle.Location = new System.Drawing.Point(65, 449);
            this.btnOnizle.Name = "btnOnizle";
            this.btnOnizle.Size = new System.Drawing.Size(84, 23);
            this.btnOnizle.TabIndex = 3;
            this.btnOnizle.Text = "Önizleme";
            this.btnOnizle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOnizle.UseVisualStyleBackColor = true;
            this.btnOnizle.Click += new System.EventHandler(this.btnOnizle_Click);
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
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsSirala,
            this.cmsArama});
            this.contextMenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 70);
            // 
            // cmsSirala
            // 
            this.cmsSirala.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsSiralaAd,
            this.cmsSiralaYazar,
            this.cmsSiralaTur,
            this.cmsSiralaYayin});
            this.cmsSirala.Name = "cmsSirala";
            this.cmsSirala.Size = new System.Drawing.Size(180, 22);
            this.cmsSirala.Text = "Sırala";
            // 
            // cmsSiralaAd
            // 
            this.cmsSiralaAd.Name = "cmsSiralaAd";
            this.cmsSiralaAd.Size = new System.Drawing.Size(180, 22);
            this.cmsSiralaAd.Text = "Ad\'a göre";
            this.cmsSiralaAd.Click += new System.EventHandler(this.cmsSiralaAd_Click);
            // 
            // cmsSiralaYazar
            // 
            this.cmsSiralaYazar.Name = "cmsSiralaYazar";
            this.cmsSiralaYazar.Size = new System.Drawing.Size(180, 22);
            this.cmsSiralaYazar.Text = "Yazar\'a göre";
            this.cmsSiralaYazar.Click += new System.EventHandler(this.cmsSiralaYazar_Click);
            // 
            // cmsSiralaTur
            // 
            this.cmsSiralaTur.Name = "cmsSiralaTur";
            this.cmsSiralaTur.Size = new System.Drawing.Size(180, 22);
            this.cmsSiralaTur.Text = "Tür\'e göre";
            this.cmsSiralaTur.Click += new System.EventHandler(this.cmsSiralaTur_Click);
            // 
            // cmsSiralaYayin
            // 
            this.cmsSiralaYayin.Name = "cmsSiralaYayin";
            this.cmsSiralaYayin.Size = new System.Drawing.Size(180, 22);
            this.cmsSiralaYayin.Text = "Yayınevi\'ne göre";
            this.cmsSiralaYayin.Click += new System.EventHandler(this.cmsSiralaYayin_Click);
            // 
            // cmsArama
            // 
            this.cmsArama.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsAramaCMB,
            this.cmsAramaTXT,
            this.araToolStripMenuItem});
            this.cmsArama.Name = "cmsArama";
            this.cmsArama.Size = new System.Drawing.Size(180, 22);
            this.cmsArama.Text = "Arama";
            // 
            // cmsAramaCMB
            // 
            this.cmsAramaCMB.Items.AddRange(new object[] {
            "Kitap Adı",
            "Yazar Adı",
            "Kitap Türü",
            "Yayınevi"});
            this.cmsAramaCMB.Name = "cmsAramaCMB";
            this.cmsAramaCMB.Size = new System.Drawing.Size(121, 23);
            this.cmsAramaCMB.Text = "Seçiniz..";
            // 
            // cmsAramaTXT
            // 
            this.cmsAramaTXT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmsAramaTXT.Name = "cmsAramaTXT";
            this.cmsAramaTXT.Size = new System.Drawing.Size(100, 23);
            this.cmsAramaTXT.Text = "Aranacak kelime";
            // 
            // araToolStripMenuItem
            // 
            this.araToolStripMenuItem.Image = global::Kütüphane_Otomasyonu.Properties.Resources.ara;
            this.araToolStripMenuItem.Name = "araToolStripMenuItem";
            this.araToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.araToolStripMenuItem.Text = "Ara";
            this.araToolStripMenuItem.Click += new System.EventHandler(this.araToolStripMenuItem_Click);
            // 
            // KitapDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 473);
            this.Controls.Add(this.btnOnizle);
            this.Controls.Add(this.btnYazdır);
            this.Controls.Add(this.sspTime5);
            this.Controls.Add(this.dgvKitapDetay);
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KitapDetay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitaplar";
            this.Load += new System.EventHandler(this.KitapDetay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKitapDetay)).EndInit();
            this.sspTime5.ResumeLayout(false);
            this.sspTime5.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKitapDetay;
        private System.Windows.Forms.StatusStrip sspTime5;
        private System.Windows.Forms.ToolStripStatusLabel tsslTime5;
        private System.Windows.Forms.Timer timer_5;
        private System.Windows.Forms.Button btnYazdır;
        private System.Windows.Forms.Button btnOnizle;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cmsSirala;
        private System.Windows.Forms.ToolStripMenuItem cmsSiralaAd;
        private System.Windows.Forms.ToolStripMenuItem cmsSiralaYazar;
        private System.Windows.Forms.ToolStripMenuItem cmsSiralaTur;
        private System.Windows.Forms.ToolStripMenuItem cmsSiralaYayin;
        private System.Windows.Forms.ToolStripMenuItem cmsArama;
        private System.Windows.Forms.ToolStripComboBox cmsAramaCMB;
        private System.Windows.Forms.ToolStripTextBox cmsAramaTXT;
        private System.Windows.Forms.ToolStripMenuItem araToolStripMenuItem;
    }
}