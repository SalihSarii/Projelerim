
namespace Kütüphane_Otomasyonu
{
    partial class KullanıcıIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullanıcıIslemleri));
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtKulad = new System.Windows.Forms.TextBox();
            this.txtRsifre = new System.Windows.Forms.TextBox();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblKulad = new System.Windows.Forms.Label();
            this.lblSifre = new System.Windows.Forms.Label();
            this.lblRsifre = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.dgv_Kul = new System.Windows.Forms.DataGridView();
            this.grbKul = new System.Windows.Forms.GroupBox();
            this.chbSifre2 = new System.Windows.Forms.CheckBox();
            this.chbSifre1 = new System.Windows.Forms.CheckBox();
            this.lblIptal = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslTime10 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssbHelp = new System.Windows.Forms.ToolStripSplitButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Kul)).BeginInit();
            this.grbKul.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(138, 37);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(103, 20);
            this.txtAd.TabIndex = 0;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(138, 90);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(103, 20);
            this.txtSoyad.TabIndex = 1;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(138, 196);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(103, 20);
            this.txtSifre.TabIndex = 3;
            // 
            // txtKulad
            // 
            this.txtKulad.Location = new System.Drawing.Point(138, 143);
            this.txtKulad.MaxLength = 15;
            this.txtKulad.Name = "txtKulad";
            this.txtKulad.Size = new System.Drawing.Size(103, 20);
            this.txtKulad.TabIndex = 2;
            // 
            // txtRsifre
            // 
            this.txtRsifre.Location = new System.Drawing.Point(138, 249);
            this.txtRsifre.Name = "txtRsifre";
            this.txtRsifre.PasswordChar = '*';
            this.txtRsifre.Size = new System.Drawing.Size(103, 20);
            this.txtRsifre.TabIndex = 4;
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAd.Location = new System.Drawing.Point(79, 37);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(36, 20);
            this.lblAd.TabIndex = 8;
            this.lblAd.Text = "Ad:";
            // 
            // lblKulad
            // 
            this.lblKulad.AutoSize = true;
            this.lblKulad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKulad.Location = new System.Drawing.Point(4, 143);
            this.lblKulad.Name = "lblKulad";
            this.lblKulad.Size = new System.Drawing.Size(111, 20);
            this.lblKulad.TabIndex = 9;
            this.lblKulad.Text = "Kullanıcı Adı:";
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifre.Location = new System.Drawing.Point(63, 196);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(52, 20);
            this.lblSifre.TabIndex = 10;
            this.lblSifre.Text = "Şifre:";
            // 
            // lblRsifre
            // 
            this.lblRsifre.AutoSize = true;
            this.lblRsifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRsifre.Location = new System.Drawing.Point(6, 249);
            this.lblRsifre.Name = "lblRsifre";
            this.lblRsifre.Size = new System.Drawing.Size(118, 20);
            this.lblRsifre.TabIndex = 11;
            this.lblRsifre.Text = "Yeniden Şifre";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoyad.Location = new System.Drawing.Point(51, 90);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(64, 20);
            this.lblSoyad.TabIndex = 12;
            this.lblSoyad.Text = "Soyad:";
            // 
            // dgv_Kul
            // 
            this.dgv_Kul.AllowUserToAddRows = false;
            this.dgv_Kul.AllowUserToDeleteRows = false;
            this.dgv_Kul.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Kul.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dgv_Kul.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Kul.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dgv_Kul.Location = new System.Drawing.Point(328, 28);
            this.dgv_Kul.Name = "dgv_Kul";
            this.dgv_Kul.ReadOnly = true;
            this.dgv_Kul.Size = new System.Drawing.Size(445, 368);
            this.dgv_Kul.TabIndex = 13;
            this.dgv_Kul.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_Kul_CellMouseDoubleClick);
            // 
            // grbKul
            // 
            this.grbKul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.grbKul.Controls.Add(this.chbSifre2);
            this.grbKul.Controls.Add(this.chbSifre1);
            this.grbKul.Controls.Add(this.lblIptal);
            this.grbKul.Controls.Add(this.txtAd);
            this.grbKul.Controls.Add(this.txtSoyad);
            this.grbKul.Controls.Add(this.lblSoyad);
            this.grbKul.Controls.Add(this.txtKulad);
            this.grbKul.Controls.Add(this.lblRsifre);
            this.grbKul.Controls.Add(this.txtSifre);
            this.grbKul.Controls.Add(this.lblSifre);
            this.grbKul.Controls.Add(this.txtRsifre);
            this.grbKul.Controls.Add(this.lblKulad);
            this.grbKul.Controls.Add(this.btnEkle);
            this.grbKul.Controls.Add(this.lblAd);
            this.grbKul.Controls.Add(this.btnUpdate);
            this.grbKul.Controls.Add(this.btnSil);
            this.grbKul.Location = new System.Drawing.Point(26, 12);
            this.grbKul.Name = "grbKul";
            this.grbKul.Size = new System.Drawing.Size(296, 426);
            this.grbKul.TabIndex = 14;
            this.grbKul.TabStop = false;
            this.grbKul.Text = "Kullanıcı Bilgileri";
            // 
            // chbSifre2
            // 
            this.chbSifre2.AutoSize = true;
            this.chbSifre2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chbSifre2.Location = new System.Drawing.Point(138, 275);
            this.chbSifre2.Name = "chbSifre2";
            this.chbSifre2.Size = new System.Drawing.Size(113, 21);
            this.chbSifre2.TabIndex = 16;
            this.chbSifre2.Text = "Şifreyi Göster";
            this.chbSifre2.UseVisualStyleBackColor = true;
            this.chbSifre2.CheckedChanged += new System.EventHandler(this.chbSifre2_CheckedChanged);
            // 
            // chbSifre1
            // 
            this.chbSifre1.AutoSize = true;
            this.chbSifre1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chbSifre1.Location = new System.Drawing.Point(138, 222);
            this.chbSifre1.Name = "chbSifre1";
            this.chbSifre1.Size = new System.Drawing.Size(113, 21);
            this.chbSifre1.TabIndex = 15;
            this.chbSifre1.Text = "Şifreyi Göster";
            this.chbSifre1.UseVisualStyleBackColor = true;
            this.chbSifre1.CheckedChanged += new System.EventHandler(this.chbSifre1_CheckedChanged);
            // 
            // lblIptal
            // 
            this.lblIptal.AutoSize = true;
            this.lblIptal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblIptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIptal.Location = new System.Drawing.Point(125, 369);
            this.lblIptal.Name = "lblIptal";
            this.lblIptal.Size = new System.Drawing.Size(39, 18);
            this.lblIptal.TabIndex = 13;
            this.lblIptal.Text = "İptal";
            this.lblIptal.Click += new System.EventHandler(this.lblIptal_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Image = global::Kütüphane_Otomasyonu.Properties.Resources.add;
            this.btnEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEkle.Location = new System.Drawing.Point(8, 319);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 47);
            this.btnEkle.TabIndex = 5;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Image = global::Kütüphane_Otomasyonu.Properties.Resources.update;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(100, 319);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(95, 47);
            this.btnUpdate.TabIndex = 6;
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
            this.btnSil.Location = new System.Drawing.Point(210, 319);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 47);
            this.btnSil.TabIndex = 7;
            this.btnSil.Text = "Sil";
            this.btnSil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslTime10,
            this.tssbHelp});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslTime10
            // 
            this.tsslTime10.Image = global::Kütüphane_Otomasyonu.Properties.Resources.Beykent_Universitesi_Logo_Yeni;
            this.tsslTime10.Name = "tsslTime10";
            this.tsslTime10.Size = new System.Drawing.Size(49, 17);
            this.tsslTime10.Text = "Time";
            // 
            // tssbHelp
            // 
            this.tssbHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tssbHelp.DropDownButtonWidth = 0;
            this.tssbHelp.Image = global::Kütüphane_Otomasyonu.Properties.Resources.Help;
            this.tssbHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tssbHelp.Name = "tssbHelp";
            this.tssbHelp.Size = new System.Drawing.Size(21, 20);
            this.tssbHelp.Text = "toolStripSplitButton1";
            this.tssbHelp.ButtonClick += new System.EventHandler(this.tssbHelp_ButtonClick);
            this.tssbHelp.MouseEnter += new System.EventHandler(this.tssbHelp_MouseEnter);
            this.tssbHelp.MouseLeave += new System.EventHandler(this.tssbHelp_MouseLeave);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // KullanıcıIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.grbKul);
            this.Controls.Add(this.dgv_Kul);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KullanıcıIslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Islemleri";
            this.Load += new System.EventHandler(this.KullanıcıIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Kul)).EndInit();
            this.grbKul.ResumeLayout(false);
            this.grbKul.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtKulad;
        private System.Windows.Forms.TextBox txtRsifre;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblKulad;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Label lblRsifre;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.DataGridView dgv_Kul;
        private System.Windows.Forms.GroupBox grbKul;
        private System.Windows.Forms.Label lblIptal;
        private System.Windows.Forms.CheckBox chbSifre2;
        private System.Windows.Forms.CheckBox chbSifre1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslTime10;
        private System.Windows.Forms.ToolStripSplitButton tssbHelp;
        private System.Windows.Forms.Timer timer1;
    }
}