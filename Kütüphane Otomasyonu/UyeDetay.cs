using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kütüphane_Otomasyonu
{
    public partial class UyeDetay : Form
    {
        public UyeDetay()
        {
            InitializeComponent();
        }
        KutuphaneOtomasyonuEntities db = new KutuphaneOtomasyonuEntities();
        private void UyeDetay_Load(object sender, EventArgs e)
        {
            timer_7.Start();
            sspTime7.BackColor = Color.FromArgb(0, 0, 0, 0);
            dgvUyeDetay.DataSource = db.tbl_Uyeler.Where(x=>x.ID>=0).Select(x=> new {x.Ad,x.Soyad,x.TC,x.Tel,x.Cinsiyet }).OrderBy(x=>x.Ad).ToList();
        }

        private void timer_7_Tick(object sender, EventArgs e)
        {
            tsslTime7.Text = DateTime.Now.ToString();
        }

        private void btnYazdır_Click(object sender, EventArgs e)
        {
            DialogResult dr = printDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void btnOnizle_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int x = 170, y = 230;
            string satır = "";


            Font myFont = new Font("Arial", 25);
            Font myFont2 = new Font("Arial", 8);
            SolidBrush sb = new SolidBrush(Color.Black);
            Pen myPen = new Pen(Color.Yellow, 10);
            Pen myPen2 = new Pen(Color.LightSkyBlue, 10);
            Pen myPen3 = new Pen(Color.Black, 2);
            Pen myPen4 = new Pen(Color.Black, 1);

            e.Graphics.DrawString("Beykent Üniversitesi Kütüphane Otomasyonu", myFont, sb, 70, 100);
            e.Graphics.DrawString("Tarih: " + DateTime.Now.ToString(), myFont2, sb, 100, 180);

            for (int i = 0; i < dgvUyeDetay.Columns.Count; i++)
            {
                satır = dgvUyeDetay.Columns[i].Name;
                if (i == 0)
                {
                    e.Graphics.DrawString(satır, myFont2, sb, x, y);
                    x += 100;
                }
                else if (i == 1)
                {
                    e.Graphics.DrawString(satır, myFont2, sb, x, y);
                    x += 100;
                }
                else
                {
                    e.Graphics.DrawString(satır, myFont2, sb, x, y);
                    x += 100;
                }
            }
            y = 250;
            x = 170;
            //Tablo Yatay çizgileri
            e.Graphics.DrawLine(myPen4, 169, 243, 669, 243);
            e.Graphics.DrawLine(myPen4, 169, 229, 669, 229);
            e.Graphics.DrawLine(myPen4, 169, 1000, 669, 1000);

            //Beykent Üniversitesi Renkleri
            e.Graphics.DrawLine(myPen, 100, 200, 750, 200);
            e.Graphics.DrawLine(myPen2, 100, 210, 750, 210);
            e.Graphics.DrawLine(myPen3, 100, 205, 750, 205);

            e.Graphics.DrawLine(myPen, 100, 1050, 750, 1050);
            e.Graphics.DrawLine(myPen2, 100, 1060, 750, 1060);
            e.Graphics.DrawLine(myPen3, 100, 1055, 750, 1055);

            //Tablo Dik Çizgileri
            e.Graphics.DrawLine(myPen4, 169, 229, 169, 1000);
            e.Graphics.DrawLine(myPen4, 269, 229, 269, 1000);
            e.Graphics.DrawLine(myPen4, 369, 229, 369, 1000);
            e.Graphics.DrawLine(myPen4, 469, 229, 469, 1000);
            e.Graphics.DrawLine(myPen4, 569, 229, 569, 1000);
            e.Graphics.DrawLine(myPen4, 669, 229, 669, 1000);
            

            

            for (int i = 0; i < dgvUyeDetay.Rows.Count; i++)
            {
                for (int j = 0; j < dgvUyeDetay.Columns.Count; j++)
                {
                    if (j == 0)
                    {
                        satır = dgvUyeDetay.Rows[i].Cells[j].Value.ToString() + "  ";
                        e.Graphics.DrawString(satır, myFont2, sb, x, y);
                        x += 100;
                    }
                    else if (j == 1)
                    {
                        satır = dgvUyeDetay.Rows[i].Cells[j].Value.ToString() + "  ";
                        e.Graphics.DrawString(satır, myFont2, sb, x, y);
                        x += 100;
                    }
                    else
                    {
                        satır = dgvUyeDetay.Rows[i].Cells[j].Value.ToString() + "  ";
                        e.Graphics.DrawString(satır, myFont2, sb, x, y);
                        x += 100;
                    }

                }

                satır = string.Empty;
                x = 170;
                y += 20;
            }

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dgvUyeDetay.DataSource = db.tbl_Uyeler.OrderBy(x => x.Ad).ToList();

        }

        private void cmsSiralaSoyad_Click(object sender, EventArgs e)
        {
            dgvUyeDetay.DataSource = db.tbl_Uyeler.OrderBy(x => x.Soyad).ToList();

        }

        private void cmsSiralaTC_Click(object sender, EventArgs e)
        {
            dgvUyeDetay.DataSource = db.tbl_Uyeler.OrderBy(x => x.TC).ToList();

        }

        private void cmsSiralaTel_Click(object sender, EventArgs e)
        {
            dgvUyeDetay.DataSource = db.tbl_Uyeler.OrderBy(x => x.Tel).ToList();

        }

        private void cmsSiralaCins_Click(object sender, EventArgs e)
        {
            dgvUyeDetay.DataSource = db.tbl_Uyeler.OrderBy(x => x.Cinsiyet).ToList();

        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            switch (cmsAramaCMB.SelectedIndex)
            {
                case 0:
                    var sonuc = db.tbl_Uyeler.Where(x => x.Ad.StartsWith(cmsAramaTXT.Text)).OrderBy(x => x.TC).ToList();
                    if (sonuc.Count() != 0)
                    {
                        dgvUyeDetay.DataSource = sonuc;
                    }
                    else { MessageBox.Show("Böyle bir kayıt yoktur."); }
                    break;
                case 1:
                    sonuc = db.tbl_Uyeler.Where(x => x.Soyad.StartsWith(cmsAramaTXT.Text)).OrderBy(x => x.TC).ToList();
                    if (sonuc.Count() != 0)
                    {
                        dgvUyeDetay.DataSource = sonuc;
                    }
                    else { MessageBox.Show("Böyle bir kayıt yoktur."); }
                    break;
                case 2:
                    sonuc = db.tbl_Uyeler.Where(x => x.TC.StartsWith(cmsAramaTXT.Text)).OrderBy(x => x.TC).ToList();
                    if (sonuc.Count() != 0)
                    {
                        dgvUyeDetay.DataSource = sonuc;
                    }
                    else { MessageBox.Show("Böyle bir kayıt yoktur."); }
                    break;
                case 3:
                    string tel = "(" + cmsAramaTXT.Text;
                    sonuc = db.tbl_Uyeler.Where(x => x.Tel.StartsWith(tel)).OrderBy(x => x.TC).ToList();
                    if (sonuc.Count() != 0)
                    {
                        dgvUyeDetay.DataSource = sonuc;
                    }
                    else { MessageBox.Show("Böyle bir kayıt yoktur."); }
                    break;
                case 4:
                    sonuc = db.tbl_Uyeler.Where(x => x.Cinsiyet.StartsWith(cmsAramaTXT.Text)).OrderBy(x => x.TC).ToList();
                    if (sonuc.Count() != 0)
                    {
                        dgvUyeDetay.DataSource = sonuc;
                    }
                    else { MessageBox.Show("Böyle bir kayıt yoktur."); }
                    break;
                default:
                    MessageBox.Show("Lütfen aramak istediğiniz kriteri seçiniz.");
                    break;
            }
        }
    }
}
