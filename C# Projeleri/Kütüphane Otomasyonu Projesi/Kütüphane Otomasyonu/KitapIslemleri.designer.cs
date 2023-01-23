namespace Kütüphane_Otomasyonu
{
    partial class KitapIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KitapIslemleri));
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtYayin = new System.Windows.Forms.TextBox();
            this.txtSayfa = new System.Windows.Forms.TextBox();
            this.txtYazar = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.lblYayin = new System.Windows.Forms.Label();
            this.lblMiktar = new System.Windows.Forms.Label();
            this.lblTur = new System.Windows.Forms.Label();
            this.lblSayfa = new System.Windows.Forms.Label();
            this.lblYazar = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.grbKitap = new System.Windows.Forms.GroupBox();
            this.lblTurDuzenleme = new System.Windows.Forms.Label();
            this.numericMiktar = new System.Windows.Forms.NumericUpDown();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.cmbTur = new System.Windows.Forms.ComboBox();
            this.timer_6 = new System.Windows.Forms.Timer(this.components);
            this.sspTime6 = new System.Windows.Forms.StatusStrip();
            this.tsslTime6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslHelp = new System.Windows.Forms.ToolStripSplitButton();
            this.dgvKitap = new System.Windows.Forms.DataGridView();
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
            this.grbKitap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericMiktar)).BeginInit();
            this.sspTime6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKitap)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEkle
            // 
            this.btnEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEkle.Image = global::Kütüphane_Otomasyonu.Properties.Resources.add;
            this.btnEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEkle.Location = new System.Drawing.Point(80, 209);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(73, 46);
            this.btnEkle.TabIndex = 6;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtYayin
            // 
            this.txtYayin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYayin.Location = new System.Drawing.Point(114, 140);
            this.txtYayin.Name = "txtYayin";
            this.txtYayin.Size = new System.Drawing.Size(272, 26);
            this.txtYayin.TabIndex = 4;
            // 
            // txtSayfa
            // 
            this.txtSayfa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSayfa.Location = new System.Drawing.Point(114, 108);
            this.txtSayfa.Name = "txtSayfa";
            this.txtSayfa.Size = new System.Drawing.Size(272, 26);
            this.txtSayfa.TabIndex = 3;
            this.txtSayfa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSayfa_KeyPress);
            // 
            // txtYazar
            // 
            this.txtYazar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYazar.Location = new System.Drawing.Point(114, 49);
            this.txtYazar.Name = "txtYazar";
            this.txtYazar.Size = new System.Drawing.Size(272, 26);
            this.txtYazar.TabIndex = 1;
            this.txtYazar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYazar_KeyPress);
            // 
            // txtAd
            // 
            this.txtAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.Location = new System.Drawing.Point(114, 17);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(272, 26);
            this.txtAd.TabIndex = 0;
            this.txtAd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAd_KeyPress);
            // 
            // lblYayin
            // 
            this.lblYayin.AutoSize = true;
            this.lblYayin.Location = new System.Drawing.Point(58, 148);
            this.lblYayin.Name = "lblYayin";
            this.lblYayin.Size = new System.Drawing.Size(50, 13);
            this.lblYayin.TabIndex = 21;
            this.lblYayin.Text = "Yayınevi:";
            // 
            // lblMiktar
            // 
            this.lblMiktar.AutoSize = true;
            this.lblMiktar.Location = new System.Drawing.Point(27, 177);
            this.lblMiktar.Name = "lblMiktar";
            this.lblMiktar.Size = new System.Drawing.Size(81, 13);
            this.lblMiktar.TabIndex = 20;
            this.lblMiktar.Text = "Eklenen Miktar:";
            // 
            // lblTur
            // 
            this.lblTur.AutoSize = true;
            this.lblTur.Location = new System.Drawing.Point(49, 84);
            this.lblTur.Name = "lblTur";
            this.lblTur.Size = new System.Drawing.Size(59, 13);
            this.lblTur.TabIndex = 19;
            this.lblTur.Text = "Kitap Türü:";
            // 
            // lblSayfa
            // 
            this.lblSayfa.AutoSize = true;
            this.lblSayfa.Location = new System.Drawing.Point(41, 116);
            this.lblSayfa.Name = "lblSayfa";
            this.lblSayfa.Size = new System.Drawing.Size(67, 13);
            this.lblSayfa.TabIndex = 18;
            this.lblSayfa.Text = "Sayfa Sayısı:";
            // 
            // lblYazar
            // 
            this.lblYazar.AutoSize = true;
            this.lblYazar.Location = new System.Drawing.Point(53, 57);
            this.lblYazar.Name = "lblYazar";
            this.lblYazar.Size = new System.Drawing.Size(55, 13);
            this.lblYazar.TabIndex = 17;
            this.lblYazar.Text = "Yazar Adı:";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(56, 25);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(52, 13);
            this.lblAd.TabIndex = 16;
            this.lblAd.Text = "Kitap Adı:";
            // 
            // grbKitap
            // 
            this.grbKitap.Controls.Add(this.lblTurDuzenleme);
            this.grbKitap.Controls.Add(this.numericMiktar);
            this.grbKitap.Controls.Add(this.btnUpdate);
            this.grbKitap.Controls.Add(this.btnSil);
            this.grbKitap.Controls.Add(this.cmbTur);
            this.grbKitap.Controls.Add(this.btnEkle);
            this.grbKitap.Controls.Add(this.txtYayin);
            this.grbKitap.Controls.Add(this.txtSayfa);
            this.grbKitap.Controls.Add(this.txtYazar);
            this.grbKitap.Controls.Add(this.txtAd);
            this.grbKitap.Controls.Add(this.lblYayin);
            this.grbKitap.Controls.Add(this.lblMiktar);
            this.grbKitap.Controls.Add(this.lblTur);
            this.grbKitap.Controls.Add(this.lblSayfa);
            this.grbKitap.Controls.Add(this.lblYazar);
            this.grbKitap.Controls.Add(this.lblAd);
            this.grbKitap.Location = new System.Drawing.Point(12, 12);
            this.grbKitap.Name = "grbKitap";
            this.grbKitap.Size = new System.Drawing.Size(417, 301);
            this.grbKitap.TabIndex = 32;
            this.grbKitap.TabStop = false;
            this.grbKitap.Text = "Kitap Bilgileri:";
            // 
            // lblTurDuzenleme
            // 
            this.lblTurDuzenleme.AutoSize = true;
            this.lblTurDuzenleme.Location = new System.Drawing.Point(307, 84);
            this.lblTurDuzenleme.Name = "lblTurDuzenleme";
            this.lblTurDuzenleme.Size = new System.Drawing.Size(79, 13);
            this.lblTurDuzenleme.TabIndex = 24;
            this.lblTurDuzenleme.Text = "Tür Düzenleme";
            this.lblTurDuzenleme.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lblTurDuzenleme_MouseClick);
            this.lblTurDuzenleme.MouseEnter += new System.EventHandler(this.lblTurDuzenleme_MouseEnter);
            this.lblTurDuzenleme.MouseLeave += new System.EventHandler(this.lblTurDuzenleme_MouseLeave);
            // 
            // numericMiktar
            // 
            this.numericMiktar.Location = new System.Drawing.Point(114, 175);
            this.numericMiktar.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericMiktar.Name = "numericMiktar";
            this.numericMiktar.Size = new System.Drawing.Size(272, 20);
            this.numericMiktar.TabIndex = 22;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Image = global::Kütüphane_Otomasyonu.Properties.Resources.update;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(172, 209);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(90, 46);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSil
            // 
            this.btnSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSil.Image = global::Kütüphane_Otomasyonu.Properties.Resources.delete;
            this.btnSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSil.Location = new System.Drawing.Point(281, 209);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(64, 46);
            this.btnSil.TabIndex = 8;
            this.btnSil.Text = "Sil";
            this.btnSil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // cmbTur
            // 
            this.cmbTur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbTur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTur.FormattingEnabled = true;
            this.cmbTur.IntegralHeight = false;
            this.cmbTur.Location = new System.Drawing.Point(114, 81);
            this.cmbTur.Name = "cmbTur";
            this.cmbTur.Size = new System.Drawing.Size(187, 21);
            this.cmbTur.TabIndex = 2;
            // 
            // timer_6
            // 
            this.timer_6.Tick += new System.EventHandler(this.timer_6_Tick);
            // 
            // sspTime6
            // 
            this.sspTime6.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslTime6,
            this.tsslHelp});
            this.sspTime6.Location = new System.Drawing.Point(0, 302);
            this.sspTime6.Name = "sspTime6";
            this.sspTime6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.sspTime6.Size = new System.Drawing.Size(798, 22);
            this.sspTime6.SizingGrip = false;
            this.sspTime6.TabIndex = 34;
            this.sspTime6.Text = "statusStrip1";
            // 
            // tsslTime6
            // 
            this.tsslTime6.Image = global::Kütüphane_Otomasyonu.Properties.Resources.Beykent_Universitesi_Logo_Yeni;
            this.tsslTime6.Name = "tsslTime6";
            this.tsslTime6.Size = new System.Drawing.Size(55, 17);
            this.tsslTime6.Text = "Time6";
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
            // dgvKitap
            // 
            this.dgvKitap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKitap.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvKitap.Location = new System.Drawing.Point(435, 12);
            this.dgvKitap.Name = "dgvKitap";
            this.dgvKitap.ReadOnly = true;
            this.dgvKitap.Size = new System.Drawing.Size(363, 287);
            this.dgvKitap.TabIndex = 35;
            this.dgvKitap.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvKitap_CellMouseDoubleClick);
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
            this.cmsSiralaAd.Size = new System.Drawing.Size(160, 22);
            this.cmsSiralaAd.Text = "Ad\'a göre";
            this.cmsSiralaAd.Click += new System.EventHandler(this.cmsSiralaAd_Click);
            // 
            // cmsSiralaYazar
            // 
            this.cmsSiralaYazar.Name = "cmsSiralaYazar";
            this.cmsSiralaYazar.Size = new System.Drawing.Size(160, 22);
            this.cmsSiralaYazar.Text = "Yazar\'a göre";
            this.cmsSiralaYazar.Click += new System.EventHandler(this.cmsSiralaYazar_Click);
            // 
            // cmsSiralaTur
            // 
            this.cmsSiralaTur.Name = "cmsSiralaTur";
            this.cmsSiralaTur.Size = new System.Drawing.Size(160, 22);
            this.cmsSiralaTur.Text = "Tür\'e göre";
            this.cmsSiralaTur.Click += new System.EventHandler(this.cmsSiralaTur_Click);
            // 
            // cmsSiralaYayin
            // 
            this.cmsSiralaYayin.Name = "cmsSiralaYayin";
            this.cmsSiralaYayin.Size = new System.Drawing.Size(160, 22);
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
            // KitapIslemleri
            // 
            this.AcceptButton = this.btnEkle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(798, 324);
            this.Controls.Add(this.dgvKitap);
            this.Controls.Add(this.sspTime6);
            this.Controls.Add(this.grbKitap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "KitapIslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KitapIslemleri";
            this.Load += new System.EventHandler(this.KitapIslemleri_Load);
            this.grbKitap.ResumeLayout(false);
            this.grbKitap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericMiktar)).EndInit();
            this.sspTime6.ResumeLayout(false);
            this.sspTime6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKitap)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtYayin;
        private System.Windows.Forms.TextBox txtSayfa;
        private System.Windows.Forms.TextBox txtYazar;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label lblYayin;
        private System.Windows.Forms.Label lblMiktar;
        private System.Windows.Forms.Label lblTur;
        private System.Windows.Forms.Label lblSayfa;
        private System.Windows.Forms.Label lblYazar;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.GroupBox grbKitap;
        private System.Windows.Forms.Timer timer_6;
        private System.Windows.Forms.StatusStrip sspTime6;
        private System.Windows.Forms.ToolStripStatusLabel tsslTime6;
        private System.Windows.Forms.ComboBox cmbTur;
        private System.Windows.Forms.ToolStripSplitButton tsslHelp;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.DataGridView dgvKitap;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cmsSirala;
        private System.Windows.Forms.ToolStripMenuItem cmsSiralaAd;
        private System.Windows.Forms.ToolStripMenuItem cmsArama;
        private System.Windows.Forms.ToolStripMenuItem cmsSiralaYazar;
        private System.Windows.Forms.ToolStripMenuItem cmsSiralaTur;
        private System.Windows.Forms.ToolStripMenuItem cmsSiralaYayin;
        private System.Windows.Forms.ToolStripComboBox cmsAramaCMB;
        private System.Windows.Forms.ToolStripTextBox cmsAramaTXT;
        private System.Windows.Forms.ToolStripMenuItem araToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown numericMiktar;
        private System.Windows.Forms.Label lblTurDuzenleme;
    }
}