
namespace Kütüphane_Otomasyonu
{
    partial class Anasayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anasayfa));
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.tsmiUye = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiKitap = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEmanet = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiKullanici = new System.Windows.Forms.ToolStripMenuItem();
            this.timer_1 = new System.Windows.Forms.Timer(this.components);
            this.sspTime1 = new System.Windows.Forms.StatusStrip();
            this.tsslTime1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssbInfo = new System.Windows.Forms.ToolStripSplitButton();
            this.tssbHelp = new System.Windows.Forms.ToolStripSplitButton();
            this.tsslUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlKitap = new System.Windows.Forms.Panel();
            this.lblKitap = new System.Windows.Forms.Label();
            this.pnlUye = new System.Windows.Forms.Panel();
            this.lblUye = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picBoxLogo = new System.Windows.Forms.PictureBox();
            this.msMenu.SuspendLayout();
            this.sspTime1.SuspendLayout();
            this.pnlKitap.SuspendLayout();
            this.pnlUye.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // msMenu
            // 
            this.msMenu.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiUye,
            this.tsmiKitap,
            this.tsmiEmanet,
            this.tsmiKullanici});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(447, 24);
            this.msMenu.TabIndex = 10;
            this.msMenu.Text = "menuStrip1";
            // 
            // tsmiUye
            // 
            this.tsmiUye.Name = "tsmiUye";
            this.tsmiUye.Size = new System.Drawing.Size(86, 20);
            this.tsmiUye.Text = "&Üye İşlemleri";
            this.tsmiUye.Click += new System.EventHandler(this.tsmiUye_Click);
            this.tsmiUye.MouseEnter += new System.EventHandler(this.tsmiUye_MouseEnter);
            this.tsmiUye.MouseLeave += new System.EventHandler(this.tsmiUye_MouseLeave);
            // 
            // tsmiKitap
            // 
            this.tsmiKitap.Name = "tsmiKitap";
            this.tsmiKitap.Size = new System.Drawing.Size(93, 20);
            this.tsmiKitap.Text = "&Kitap İşlemleri";
            this.tsmiKitap.Click += new System.EventHandler(this.tsmiKitap_Click);
            this.tsmiKitap.MouseEnter += new System.EventHandler(this.tsmiKitap_MouseEnter);
            this.tsmiKitap.MouseLeave += new System.EventHandler(this.tsmiKitap_MouseLeave);
            // 
            // tsmiEmanet
            // 
            this.tsmiEmanet.Name = "tsmiEmanet";
            this.tsmiEmanet.Size = new System.Drawing.Size(106, 20);
            this.tsmiEmanet.Text = "&Emanet İşlemleri";
            this.tsmiEmanet.Click += new System.EventHandler(this.tsmiEmanet_Click);
            this.tsmiEmanet.MouseEnter += new System.EventHandler(this.tsmiEmanet_MouseEnter);
            this.tsmiEmanet.MouseLeave += new System.EventHandler(this.tsmiEmanet_MouseLeave);
            // 
            // tsmiKullanici
            // 
            this.tsmiKullanici.Name = "tsmiKullanici";
            this.tsmiKullanici.Size = new System.Drawing.Size(111, 20);
            this.tsmiKullanici.Text = "&Kullanıcı İşlemleri";
            this.tsmiKullanici.Click += new System.EventHandler(this.tsmiKullanici_Click);
            this.tsmiKullanici.MouseEnter += new System.EventHandler(this.tsmiKullanici_MouseEnter);
            this.tsmiKullanici.MouseLeave += new System.EventHandler(this.tsmiKullanici_MouseLeave);
            // 
            // timer_1
            // 
            this.timer_1.Tick += new System.EventHandler(this.timer_1_Tick);
            // 
            // sspTime1
            // 
            this.sspTime1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sspTime1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslTime1,
            this.tssbInfo,
            this.tssbHelp,
            this.tsslUser});
            this.sspTime1.Location = new System.Drawing.Point(0, 230);
            this.sspTime1.Name = "sspTime1";
            this.sspTime1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.sspTime1.Size = new System.Drawing.Size(447, 22);
            this.sspTime1.SizingGrip = false;
            this.sspTime1.TabIndex = 12;
            this.sspTime1.Text = "statusStrip1";
            // 
            // tsslTime1
            // 
            this.tsslTime1.Name = "tsslTime1";
            this.tsslTime1.Size = new System.Drawing.Size(39, 17);
            this.tsslTime1.Text = "Time1";
            // 
            // tssbInfo
            // 
            this.tssbInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tssbInfo.DropDownButtonWidth = 0;
            this.tssbInfo.Image = global::Kütüphane_Otomasyonu.Properties.Resources.info;
            this.tssbInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tssbInfo.Name = "tssbInfo";
            this.tssbInfo.Size = new System.Drawing.Size(21, 20);
            this.tssbInfo.Text = "toolStripSplitButton1";
            this.tssbInfo.Click += new System.EventHandler(this.tssbInfo_Click);
            this.tssbInfo.MouseEnter += new System.EventHandler(this.tssbInfo_MouseEnter);
            this.tssbInfo.MouseLeave += new System.EventHandler(this.tssbInfo_MouseLeave);
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
            // tsslUser
            // 
            this.tsslUser.Name = "tsslUser";
            this.tsslUser.Size = new System.Drawing.Size(0, 17);
            // 
            // pnlKitap
            // 
            this.pnlKitap.BackColor = System.Drawing.Color.AntiqueWhite;
            this.pnlKitap.Controls.Add(this.lblKitap);
            this.pnlKitap.Location = new System.Drawing.Point(242, 27);
            this.pnlKitap.Name = "pnlKitap";
            this.pnlKitap.Size = new System.Drawing.Size(200, 61);
            this.pnlKitap.TabIndex = 14;
            // 
            // lblKitap
            // 
            this.lblKitap.AutoSize = true;
            this.lblKitap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKitap.Location = new System.Drawing.Point(3, 18);
            this.lblKitap.Name = "lblKitap";
            this.lblKitap.Size = new System.Drawing.Size(0, 20);
            this.lblKitap.TabIndex = 0;
            // 
            // pnlUye
            // 
            this.pnlUye.BackColor = System.Drawing.Color.AntiqueWhite;
            this.pnlUye.Controls.Add(this.lblUye);
            this.pnlUye.Controls.Add(this.label1);
            this.pnlUye.Location = new System.Drawing.Point(242, 94);
            this.pnlUye.Name = "pnlUye";
            this.pnlUye.Size = new System.Drawing.Size(200, 61);
            this.pnlUye.TabIndex = 15;
            // 
            // lblUye
            // 
            this.lblUye.AutoSize = true;
            this.lblUye.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUye.Location = new System.Drawing.Point(3, 18);
            this.lblUye.Name = "lblUye";
            this.lblUye.Size = new System.Drawing.Size(0, 20);
            this.lblUye.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(3, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 0;
            // 
            // picBoxLogo
            // 
            this.picBoxLogo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.picBoxLogo.Image = global::Kütüphane_Otomasyonu.Properties.Resources.Beykent_Universitesi_Logo_Yeni;
            this.picBoxLogo.Location = new System.Drawing.Point(21, 27);
            this.picBoxLogo.Name = "picBoxLogo";
            this.picBoxLogo.Size = new System.Drawing.Size(200, 200);
            this.picBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxLogo.TabIndex = 13;
            this.picBoxLogo.TabStop = false;
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(447, 252);
            this.Controls.Add(this.pnlUye);
            this.Controls.Add(this.pnlKitap);
            this.Controls.Add(this.picBoxLogo);
            this.Controls.Add(this.sspTime1);
            this.Controls.Add(this.msMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msMenu;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Anasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anasayfa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Anasayfa_FormClosing);
            this.Load += new System.EventHandler(this.Anasayfa_Load);
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.sspTime1.ResumeLayout(false);
            this.sspTime1.PerformLayout();
            this.pnlKitap.ResumeLayout(false);
            this.pnlKitap.PerformLayout();
            this.pnlUye.ResumeLayout(false);
            this.pnlUye.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiUye;
        private System.Windows.Forms.ToolStripMenuItem tsmiKitap;
        private System.Windows.Forms.ToolStripMenuItem tsmiEmanet;
        private System.Windows.Forms.Timer timer_1;
        private System.Windows.Forms.StatusStrip sspTime1;
        private System.Windows.Forms.ToolStripStatusLabel tsslTime1;
        private System.Windows.Forms.ToolStripSplitButton tssbInfo;
        private System.Windows.Forms.PictureBox picBoxLogo;
        private System.Windows.Forms.ToolStripSplitButton tssbHelp;
        private System.Windows.Forms.ToolStripStatusLabel tsslUser;
        private System.Windows.Forms.ToolStripMenuItem tsmiKullanici;
        private System.Windows.Forms.Panel pnlKitap;
        private System.Windows.Forms.Label lblKitap;
        private System.Windows.Forms.Panel pnlUye;
        private System.Windows.Forms.Label lblUye;
        private System.Windows.Forms.Label label1;
    }
}