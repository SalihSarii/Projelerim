namespace Kütüphane_Otomasyonu
{
    partial class EmanetIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmanetIslemleri));
            this.btnKitapDetay = new System.Windows.Forms.Button();
            this.btnUyeDetay = new System.Windows.Forms.Button();
            this.lblTarih = new System.Windows.Forms.Label();
            this.lblDurum = new System.Windows.Forms.Label();
            this.dtpEmanet = new System.Windows.Forms.DateTimePicker();
            this.cmbDurum = new System.Windows.Forms.ComboBox();
            this.dtpIade = new System.Windows.Forms.DateTimePicker();
            this.lblTarih2 = new System.Windows.Forms.Label();
            this.grbEmanet = new System.Windows.Forms.GroupBox();
            this.btnKayit = new System.Windows.Forms.Button();
            this.dgvUye = new System.Windows.Forms.DataGridView();
            this.dgvKitap = new System.Windows.Forms.DataGridView();
            this.sspTime2 = new System.Windows.Forms.StatusStrip();
            this.tsslTime2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssbHelp = new System.Windows.Forms.ToolStripSplitButton();
            this.timer_2 = new System.Windows.Forms.Timer(this.components);
            this.dgvEmanet = new System.Windows.Forms.DataGridView();
            this.btnEmanetDetay = new System.Windows.Forms.Button();
            this.grbEmanet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKitap)).BeginInit();
            this.sspTime2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmanet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKitapDetay
            // 
            this.btnKitapDetay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKitapDetay.Location = new System.Drawing.Point(448, 225);
            this.btnKitapDetay.Name = "btnKitapDetay";
            this.btnKitapDetay.Size = new System.Drawing.Size(107, 23);
            this.btnKitapDetay.TabIndex = 1;
            this.btnKitapDetay.Text = "Kitap Detay";
            this.btnKitapDetay.UseVisualStyleBackColor = true;
            this.btnKitapDetay.Click += new System.EventHandler(this.btnKitapDetay_Click);
            // 
            // btnUyeDetay
            // 
            this.btnUyeDetay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUyeDetay.Location = new System.Drawing.Point(110, 225);
            this.btnUyeDetay.Name = "btnUyeDetay";
            this.btnUyeDetay.Size = new System.Drawing.Size(106, 23);
            this.btnUyeDetay.TabIndex = 0;
            this.btnUyeDetay.Text = "Üye Detay";
            this.btnUyeDetay.UseVisualStyleBackColor = true;
            this.btnUyeDetay.Click += new System.EventHandler(this.btnUyeDetay_Click);
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Location = new System.Drawing.Point(6, 25);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(73, 13);
            this.lblTarih.TabIndex = 5;
            this.lblTarih.Text = "Verilme Tarihi:";
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Location = new System.Drawing.Point(38, 77);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(41, 13);
            this.lblDurum.TabIndex = 7;
            this.lblDurum.Text = "Durum:";
            // 
            // dtpEmanet
            // 
            this.dtpEmanet.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEmanet.Location = new System.Drawing.Point(85, 25);
            this.dtpEmanet.Name = "dtpEmanet";
            this.dtpEmanet.Size = new System.Drawing.Size(121, 20);
            this.dtpEmanet.TabIndex = 2;
            // 
            // cmbDurum
            // 
            this.cmbDurum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbDurum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDurum.FormattingEnabled = true;
            this.cmbDurum.Items.AddRange(new object[] {
            "Alındı",
            "Verildi"});
            this.cmbDurum.Location = new System.Drawing.Point(85, 77);
            this.cmbDurum.Name = "cmbDurum";
            this.cmbDurum.Size = new System.Drawing.Size(121, 21);
            this.cmbDurum.TabIndex = 4;
            this.cmbDurum.SelectedIndexChanged += new System.EventHandler(this.cmbDurum_SelectedIndexChanged);
            // 
            // dtpIade
            // 
            this.dtpIade.Checked = false;
            this.dtpIade.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIade.Location = new System.Drawing.Point(85, 51);
            this.dtpIade.Name = "dtpIade";
            this.dtpIade.Size = new System.Drawing.Size(121, 20);
            this.dtpIade.TabIndex = 3;
            // 
            // lblTarih2
            // 
            this.lblTarih2.AutoSize = true;
            this.lblTarih2.Location = new System.Drawing.Point(19, 51);
            this.lblTarih2.Name = "lblTarih2";
            this.lblTarih2.Size = new System.Drawing.Size(60, 13);
            this.lblTarih2.TabIndex = 10;
            this.lblTarih2.Text = "İade Tarihi:";
            // 
            // grbEmanet
            // 
            this.grbEmanet.Controls.Add(this.btnKayit);
            this.grbEmanet.Controls.Add(this.dtpIade);
            this.grbEmanet.Controls.Add(this.lblTarih2);
            this.grbEmanet.Controls.Add(this.cmbDurum);
            this.grbEmanet.Controls.Add(this.dtpEmanet);
            this.grbEmanet.Controls.Add(this.lblDurum);
            this.grbEmanet.Controls.Add(this.lblTarih);
            this.grbEmanet.Location = new System.Drawing.Point(234, 228);
            this.grbEmanet.Name = "grbEmanet";
            this.grbEmanet.Size = new System.Drawing.Size(208, 173);
            this.grbEmanet.TabIndex = 12;
            this.grbEmanet.TabStop = false;
            // 
            // btnKayit
            // 
            this.btnKayit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKayit.Image = global::Kütüphane_Otomasyonu.Properties.Resources.add;
            this.btnKayit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKayit.Location = new System.Drawing.Point(100, 104);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(85, 49);
            this.btnKayit.TabIndex = 5;
            this.btnKayit.Text = "Kaydet";
            this.btnKayit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKayit.UseVisualStyleBackColor = true;
            this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
            // 
            // dgvUye
            // 
            this.dgvUye.AllowUserToAddRows = false;
            this.dgvUye.AllowUserToDeleteRows = false;
            this.dgvUye.AllowUserToResizeColumns = false;
            this.dgvUye.AllowUserToResizeRows = false;
            this.dgvUye.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUye.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUye.Location = new System.Drawing.Point(12, 7);
            this.dgvUye.Name = "dgvUye";
            this.dgvUye.ReadOnly = true;
            this.dgvUye.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUye.Size = new System.Drawing.Size(338, 212);
            this.dgvUye.TabIndex = 10;
            this.dgvUye.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvUye_CellMouseClick);
            // 
            // dgvKitap
            // 
            this.dgvKitap.AllowUserToAddRows = false;
            this.dgvKitap.AllowUserToDeleteRows = false;
            this.dgvKitap.AllowUserToResizeColumns = false;
            this.dgvKitap.AllowUserToResizeRows = false;
            this.dgvKitap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKitap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKitap.Location = new System.Drawing.Point(356, 7);
            this.dgvKitap.Name = "dgvKitap";
            this.dgvKitap.ReadOnly = true;
            this.dgvKitap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKitap.Size = new System.Drawing.Size(338, 212);
            this.dgvKitap.TabIndex = 11;
            this.dgvKitap.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvKitap_CellMouseClick);
            // 
            // sspTime2
            // 
            this.sspTime2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslTime2,
            this.tssbHelp});
            this.sspTime2.Location = new System.Drawing.Point(0, 403);
            this.sspTime2.Name = "sspTime2";
            this.sspTime2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.sspTime2.Size = new System.Drawing.Size(1321, 22);
            this.sspTime2.SizingGrip = false;
            this.sspTime2.TabIndex = 15;
            this.sspTime2.Text = "statusStrip1";
            // 
            // tsslTime2
            // 
            this.tsslTime2.Image = global::Kütüphane_Otomasyonu.Properties.Resources.Beykent_Universitesi_Logo_Yeni;
            this.tsslTime2.Name = "tsslTime2";
            this.tsslTime2.Size = new System.Drawing.Size(55, 17);
            this.tsslTime2.Text = "Time2";
            // 
            // tssbHelp
            // 
            this.tssbHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tssbHelp.DropDownButtonWidth = 0;
            this.tssbHelp.Image = global::Kütüphane_Otomasyonu.Properties.Resources.Help;
            this.tssbHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tssbHelp.Name = "tssbHelp";
            this.tssbHelp.Size = new System.Drawing.Size(21, 20);
            this.tssbHelp.Click += new System.EventHandler(this.tssbHelp_Click);
            this.tssbHelp.MouseEnter += new System.EventHandler(this.tssbHelp_MouseEnter);
            this.tssbHelp.MouseLeave += new System.EventHandler(this.tssbHelp_MouseLeave);
            // 
            // timer_2
            // 
            this.timer_2.Tick += new System.EventHandler(this.timer_2_Tick);
            // 
            // dgvEmanet
            // 
            this.dgvEmanet.AllowUserToAddRows = false;
            this.dgvEmanet.AllowUserToDeleteRows = false;
            this.dgvEmanet.AllowUserToResizeColumns = false;
            this.dgvEmanet.AllowUserToResizeRows = false;
            this.dgvEmanet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmanet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmanet.Location = new System.Drawing.Point(700, 7);
            this.dgvEmanet.Name = "dgvEmanet";
            this.dgvEmanet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmanet.Size = new System.Drawing.Size(609, 212);
            this.dgvEmanet.TabIndex = 16;
            this.dgvEmanet.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvEmanet_CellMouseClick);
            // 
            // btnEmanetDetay
            // 
            this.btnEmanetDetay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmanetDetay.Location = new System.Drawing.Point(916, 225);
            this.btnEmanetDetay.Name = "btnEmanetDetay";
            this.btnEmanetDetay.Size = new System.Drawing.Size(122, 23);
            this.btnEmanetDetay.TabIndex = 17;
            this.btnEmanetDetay.Text = "Emanet Detay";
            this.btnEmanetDetay.UseVisualStyleBackColor = true;
            this.btnEmanetDetay.Click += new System.EventHandler(this.btnEmanetDetay_Click);
            // 
            // EmanetIslemleri
            // 
            this.AcceptButton = this.btnKayit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1321, 425);
            this.Controls.Add(this.btnEmanetDetay);
            this.Controls.Add(this.dgvEmanet);
            this.Controls.Add(this.sspTime2);
            this.Controls.Add(this.dgvKitap);
            this.Controls.Add(this.dgvUye);
            this.Controls.Add(this.grbEmanet);
            this.Controls.Add(this.btnUyeDetay);
            this.Controls.Add(this.btnKitapDetay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EmanetIslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmanetIslemleri";
            this.Load += new System.EventHandler(this.EmanetIslemleri_Load);
            this.grbEmanet.ResumeLayout(false);
            this.grbEmanet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKitap)).EndInit();
            this.sspTime2.ResumeLayout(false);
            this.sspTime2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmanet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnKitapDetay;
        private System.Windows.Forms.Button btnUyeDetay;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.DateTimePicker dtpEmanet;
        private System.Windows.Forms.ComboBox cmbDurum;
        private System.Windows.Forms.DateTimePicker dtpIade;
        private System.Windows.Forms.Label lblTarih2;
        private System.Windows.Forms.GroupBox grbEmanet;
        public System.Windows.Forms.DataGridView dgvUye;
        public System.Windows.Forms.DataGridView dgvKitap;
        private System.Windows.Forms.Button btnKayit;
        private System.Windows.Forms.StatusStrip sspTime2;
        private System.Windows.Forms.ToolStripStatusLabel tsslTime2;
        private System.Windows.Forms.Timer timer_2;
        private System.Windows.Forms.ToolStripSplitButton tssbHelp;
        public System.Windows.Forms.DataGridView dgvEmanet;
        private System.Windows.Forms.Button btnEmanetDetay;
    }
}