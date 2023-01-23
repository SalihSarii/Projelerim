
namespace Kütüphane_Otomasyonu
{
    partial class Giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris));
            this.lblKulAd = new System.Windows.Forms.Label();
            this.lblSifre = new System.Windows.Forms.Label();
            this.txtKulAd = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.chbSifre = new System.Windows.Forms.CheckBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.lblSayac = new System.Windows.Forms.Label();
            this.sspTime3 = new System.Windows.Forms.StatusStrip();
            this.tsslTime3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslbInfo = new System.Windows.Forms.ToolStripSplitButton();
            this.tssbHelp = new System.Windows.Forms.ToolStripSplitButton();
            this.timer_3 = new System.Windows.Forms.Timer(this.components);
            this.picBoxGiris = new System.Windows.Forms.PictureBox();
            this.picBoxCaptcha = new System.Windows.Forms.PictureBox();
            this.txtCaptcha = new System.Windows.Forms.TextBox();
            this.grbCaptcha = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblCaptcha = new System.Windows.Forms.Label();
            this.sspTime3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxGiris)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCaptcha)).BeginInit();
            this.grbCaptcha.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblKulAd
            // 
            this.lblKulAd.AutoSize = true;
            this.lblKulAd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblKulAd.Location = new System.Drawing.Point(165, 71);
            this.lblKulAd.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblKulAd.Name = "lblKulAd";
            this.lblKulAd.Size = new System.Drawing.Size(169, 31);
            this.lblKulAd.TabIndex = 0;
            this.lblKulAd.Text = "Kullanıcı Adı:";
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSifre.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblSifre.Location = new System.Drawing.Point(256, 155);
            this.lblSifre.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(78, 31);
            this.lblSifre.TabIndex = 1;
            this.lblSifre.Text = "Şifre:";
            // 
            // txtKulAd
            // 
            this.txtKulAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKulAd.Location = new System.Drawing.Point(353, 71);
            this.txtKulAd.Name = "txtKulAd";
            this.txtKulAd.Size = new System.Drawing.Size(237, 29);
            this.txtKulAd.TabIndex = 1;
            this.txtKulAd.TextChanged += new System.EventHandler(this.txtKulAd_TextChanged_1);
            this.txtKulAd.MouseEnter += new System.EventHandler(this.txtKulAd_MouseEnter);
            this.txtKulAd.MouseLeave += new System.EventHandler(this.txtKulAd_MouseLeave);
            // 
            // txtSifre
            // 
            this.txtSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.Location = new System.Drawing.Point(353, 155);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(237, 29);
            this.txtSifre.TabIndex = 2;
            this.txtSifre.MouseEnter += new System.EventHandler(this.txtSifre_MouseEnter);
            this.txtSifre.MouseLeave += new System.EventHandler(this.txtSifre_MouseLeave);
            // 
            // chbSifre
            // 
            this.chbSifre.AutoSize = true;
            this.chbSifre.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.chbSifre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chbSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chbSifre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.chbSifre.Location = new System.Drawing.Point(297, 216);
            this.chbSifre.Name = "chbSifre";
            this.chbSifre.Size = new System.Drawing.Size(138, 24);
            this.chbSifre.TabIndex = 7;
            this.chbSifre.Text = "Şifreyi Göster";
            this.chbSifre.UseVisualStyleBackColor = false;
            this.chbSifre.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnGiris
            // 
            this.btnGiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGiris.Location = new System.Drawing.Point(240, 376);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(350, 50);
            this.btnGiris.TabIndex = 5;
            this.btnGiris.Text = "Giriş Yap";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // lblSayac
            // 
            this.lblSayac.AutoSize = true;
            this.lblSayac.Location = new System.Drawing.Point(444, 209);
            this.lblSayac.Name = "lblSayac";
            this.lblSayac.Size = new System.Drawing.Size(0, 31);
            this.lblSayac.TabIndex = 6;
            this.lblSayac.Visible = false;
            // 
            // sspTime3
            // 
            this.sspTime3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslTime3,
            this.tsslbInfo,
            this.tssbHelp});
            this.sspTime3.Location = new System.Drawing.Point(0, 439);
            this.sspTime3.Name = "sspTime3";
            this.sspTime3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.sspTime3.Size = new System.Drawing.Size(868, 22);
            this.sspTime3.SizingGrip = false;
            this.sspTime3.TabIndex = 7;
            this.sspTime3.Text = "statusStrip1";
            // 
            // tsslTime3
            // 
            this.tsslTime3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tsslTime3.Name = "tsslTime3";
            this.tsslTime3.Size = new System.Drawing.Size(39, 17);
            this.tsslTime3.Text = "Time3";
            // 
            // tsslbInfo
            // 
            this.tsslbInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsslbInfo.DropDownButtonWidth = 0;
            this.tsslbInfo.Image = global::Kütüphane_Otomasyonu.Properties.Resources.info;
            this.tsslbInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsslbInfo.Name = "tsslbInfo";
            this.tsslbInfo.Size = new System.Drawing.Size(21, 20);
            this.tsslbInfo.Text = "toolStripSplitButton1";
            this.tsslbInfo.Click += new System.EventHandler(this.tsslbInfo_Click);
            this.tsslbInfo.MouseEnter += new System.EventHandler(this.tsslbInfo_MouseEnter);
            this.tsslbInfo.MouseLeave += new System.EventHandler(this.tsslbInfo_MouseLeave);
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
            // timer_3
            // 
            this.timer_3.Tick += new System.EventHandler(this.timer_3_Tick);
            // 
            // picBoxGiris
            // 
            this.picBoxGiris.Image = global::Kütüphane_Otomasyonu.Properties.Resources.Beykent_Universitesi_Logo_Yeni;
            this.picBoxGiris.Location = new System.Drawing.Point(688, 12);
            this.picBoxGiris.Name = "picBoxGiris";
            this.picBoxGiris.Size = new System.Drawing.Size(155, 155);
            this.picBoxGiris.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxGiris.TabIndex = 8;
            this.picBoxGiris.TabStop = false;
            // 
            // picBoxCaptcha
            // 
            this.picBoxCaptcha.BackColor = System.Drawing.SystemColors.ControlLight;
            this.picBoxCaptcha.Location = new System.Drawing.Point(22, 46);
            this.picBoxCaptcha.Name = "picBoxCaptcha";
            this.picBoxCaptcha.Size = new System.Drawing.Size(131, 29);
            this.picBoxCaptcha.TabIndex = 9;
            this.picBoxCaptcha.TabStop = false;
            // 
            // txtCaptcha
            // 
            this.txtCaptcha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCaptcha.Location = new System.Drawing.Point(240, 46);
            this.txtCaptcha.Name = "txtCaptcha";
            this.txtCaptcha.Size = new System.Drawing.Size(164, 29);
            this.txtCaptcha.TabIndex = 4;
            this.txtCaptcha.TextChanged += new System.EventHandler(this.txtCaptcha_TextChanged);
            // 
            // grbCaptcha
            // 
            this.grbCaptcha.BackColor = System.Drawing.Color.Transparent;
            this.grbCaptcha.Controls.Add(this.btnRefresh);
            this.grbCaptcha.Controls.Add(this.picBoxCaptcha);
            this.grbCaptcha.Controls.Add(this.txtCaptcha);
            this.grbCaptcha.ForeColor = System.Drawing.Color.White;
            this.grbCaptcha.Location = new System.Drawing.Point(210, 250);
            this.grbCaptcha.Name = "grbCaptcha";
            this.grbCaptcha.Size = new System.Drawing.Size(419, 100);
            this.grbCaptcha.TabIndex = 3;
            this.grbCaptcha.TabStop = false;
            this.grbCaptcha.Text = "Güvenlik Kodu";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Image = global::Kütüphane_Otomasyonu.Properties.Resources.refresh;
            this.btnRefresh.Location = new System.Drawing.Point(168, 37);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(48, 44);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblCaptcha
            // 
            this.lblCaptcha.AutoSize = true;
            this.lblCaptcha.BackColor = System.Drawing.Color.Transparent;
            this.lblCaptcha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCaptcha.ForeColor = System.Drawing.Color.White;
            this.lblCaptcha.Location = new System.Drawing.Point(635, 296);
            this.lblCaptcha.Name = "lblCaptcha";
            this.lblCaptcha.Size = new System.Drawing.Size(0, 25);
            this.lblCaptcha.TabIndex = 12;
            // 
            // Giris
            // 
            this.AcceptButton = this.btnGiris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kütüphane_Otomasyonu.Properties.Resources.Library_bg_giris;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(868, 461);
            this.Controls.Add(this.lblCaptcha);
            this.Controls.Add(this.grbCaptcha);
            this.Controls.Add(this.picBoxGiris);
            this.Controls.Add(this.sspTime3);
            this.Controls.Add(this.lblSayac);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.chbSifre);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKulAd);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.lblKulAd);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giris";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Giris_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Giris_FormClosed);
            this.Load += new System.EventHandler(this.Giris_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Giris_KeyDown);
            this.sspTime3.ResumeLayout(false);
            this.sspTime3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxGiris)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCaptcha)).EndInit();
            this.grbCaptcha.ResumeLayout(false);
            this.grbCaptcha.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKulAd;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.TextBox txtKulAd;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.CheckBox chbSifre;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Label lblSayac;
        private System.Windows.Forms.StatusStrip sspTime3;
        private System.Windows.Forms.ToolStripStatusLabel tsslTime3;
        private System.Windows.Forms.Timer timer_3;
        private System.Windows.Forms.PictureBox picBoxGiris;
        private System.Windows.Forms.ToolStripSplitButton tsslbInfo;
        private System.Windows.Forms.ToolStripSplitButton tssbHelp;
        private System.Windows.Forms.PictureBox picBoxCaptcha;
        private System.Windows.Forms.TextBox txtCaptcha;
        private System.Windows.Forms.GroupBox grbCaptcha;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblCaptcha;
    }
}

