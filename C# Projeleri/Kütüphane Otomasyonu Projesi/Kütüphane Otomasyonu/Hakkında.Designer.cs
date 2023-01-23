
namespace Kütüphane_Otomasyonu
{
    partial class Hakkinda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hakkinda));
            this.rTxtHakkinda = new System.Windows.Forms.RichTextBox();
            this.ssp4 = new System.Windows.Forms.StatusStrip();
            this.tsslTime4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssbHelp = new System.Windows.Forms.ToolStripSplitButton();
            this.timer_4 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ssp4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rTxtHakkinda
            // 
            this.rTxtHakkinda.BackColor = System.Drawing.SystemColors.Info;
            this.rTxtHakkinda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rTxtHakkinda.Enabled = false;
            this.rTxtHakkinda.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rTxtHakkinda.ForeColor = System.Drawing.Color.Red;
            this.rTxtHakkinda.Location = new System.Drawing.Point(31, 110);
            this.rTxtHakkinda.Name = "rTxtHakkinda";
            this.rTxtHakkinda.ReadOnly = true;
            this.rTxtHakkinda.Size = new System.Drawing.Size(731, 275);
            this.rTxtHakkinda.TabIndex = 0;
            this.rTxtHakkinda.Text = "Bu proje Salih SARITEPE ve Muharrem Can ÖNCE işbirliğinde hazırlanmıştır.\n\nİletiş" +
    "im: \nsalih-srt45@hotmail.com ->Salih SARITEPE\ncanonce2000@hotmail.com.tr ->Muhar" +
    "rem Can ÖNCE\n";
            // 
            // ssp4
            // 
            this.ssp4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ssp4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslTime4,
            this.tssbHelp});
            this.ssp4.Location = new System.Drawing.Point(0, 428);
            this.ssp4.Name = "ssp4";
            this.ssp4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ssp4.Size = new System.Drawing.Size(800, 22);
            this.ssp4.SizingGrip = false;
            this.ssp4.TabIndex = 1;
            this.ssp4.Text = "statusStrip1";
            // 
            // tsslTime4
            // 
            this.tsslTime4.Name = "tsslTime4";
            this.tsslTime4.Size = new System.Drawing.Size(39, 17);
            this.tsslTime4.Text = "Time4";
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
            // timer_4
            // 
            this.timer_4.Tick += new System.EventHandler(this.timer_4_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Kütüphane_Otomasyonu.Properties.Resources.Beykent_Universitesi_Logo_Yeni;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Hakkinda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ssp4);
            this.Controls.Add(this.rTxtHakkinda);
            this.Cursor = System.Windows.Forms.Cursors.Help;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Hakkinda";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hakkında";
            this.Load += new System.EventHandler(this.Hakkında_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Hakkında_KeyDown);
            this.ssp4.ResumeLayout(false);
            this.ssp4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip ssp4;
        private System.Windows.Forms.ToolStripStatusLabel tsslTime4;
        private System.Windows.Forms.Timer timer_4;
        private System.Windows.Forms.ToolStripSplitButton tssbHelp;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.RichTextBox rTxtHakkinda;
    }
}