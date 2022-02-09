using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kütüphane_Otomasyonu
{
    public partial class EmanetDetay : Form
    {
        KutuphaneOtomasyonuEntities db = new KutuphaneOtomasyonuEntities();
        public EmanetDetay()
        {
            InitializeComponent();
        }

        private void EmanetDetay_Load(object sender, EventArgs e)
        {
            timer.Start();
            //üye adı,soyad,tc,tel - kitap id, adı,yazar adı,yayınevi - verilme,iade,teslim tarihleri - durum - ceza(yoksa 0)
            dgvEmanet.DataSource = db.tbl_Emanet.Where(x => x.Sıra > 0).ToList();
            PaperSize paperSize = new PaperSize("My Envelope", 1540, 1250);
            printDocument1.DefaultPageSettings.PaperSize = paperSize;
        }

        private void btnOnizle_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void btnYazdır_Click(object sender, EventArgs e)
        {
            DialogResult dr = printDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            int x = 100, y = 230;
            string satır = "";


            Font myFont = new Font("Arial", 25);
            Font myFont2 = new Font("Arial", 8);
            SolidBrush sb = new SolidBrush(Color.Black);
            Pen myPen = new Pen(Color.Yellow, 10);
            Pen myPen2 = new Pen(Color.LightSkyBlue, 10);
            Pen myPen3 = new Pen(Color.Black, 2);
            Pen myPen4 = new Pen(Color.Black, 1);

            e.Graphics.DrawString("Beykent Üniversitesi Kütüphane Otomasyonu", myFont, sb, 400, 100);
            e.Graphics.DrawString("Tarih: " + DateTime.Now.ToString(), myFont2, sb, 100, 180);
            //Tablo Yatay çizgileri
            e.Graphics.DrawLine(myPen4, 99, 243, 1440, 243);
            e.Graphics.DrawLine(myPen4, 99, 229, 1440, 229);
            e.Graphics.DrawLine(myPen4, 99, 1000, 1440, 1000);

            //Beykent Üniversitesi Renkleri
            e.Graphics.DrawLine(myPen, 100, 200, 1440, 200);
            e.Graphics.DrawLine(myPen2, 100, 210, 1440, 210);
            e.Graphics.DrawLine(myPen3, 100, 205, 1440, 205);

            e.Graphics.DrawLine(myPen, 100, 1050, 1440, 1050);
            e.Graphics.DrawLine(myPen2, 100, 1060, 1440, 1060);
            e.Graphics.DrawLine(myPen3, 100, 1055, 1440, 1055);

            //Tablo Dik Çizgileri
            e.Graphics.DrawLine(myPen4, 99, 229, 99, 1000);
            e.Graphics.DrawLine(myPen4, 174, 229, 174, 1000);
            e.Graphics.DrawLine(myPen4, 259, 229, 259, 1000);
            e.Graphics.DrawLine(myPen4, 359, 229, 359, 1000);
            e.Graphics.DrawLine(myPen4, 459, 229, 459, 1000);
            e.Graphics.DrawLine(myPen4, 519, 229, 519, 1000);
            e.Graphics.DrawLine(myPen4, 674, 229, 674, 1000);
            e.Graphics.DrawLine(myPen4, 774, 229, 774, 1000);
            e.Graphics.DrawLine(myPen4, 914, 229, 914, 1000);
            e.Graphics.DrawLine(myPen4, 1014, 229, 1014, 1000);
            e.Graphics.DrawLine(myPen4, 1114, 229, 1114, 1000);
            e.Graphics.DrawLine(myPen4, 1214, 229, 1214, 1000);
            e.Graphics.DrawLine(myPen4, 1369, 229, 1369, 1000);
            e.Graphics.DrawLine(myPen4, 1440, 229, 1440, 1000);

            for (int j = 1; j < dgvEmanet.Columns.Count; j++)
            {
                satır = dgvEmanet.Columns[j].Name;
                if (j == 1)
                {
                    e.Graphics.DrawString(satır, myFont2, sb, x, y);
                    x += 75;
                }
                else if (j == 2)
                {

                    e.Graphics.DrawString(satır, myFont2, sb, x, y);
                    x += 85;
                }
                else if (j == 5)
                {
                    e.Graphics.DrawString(satır, myFont2, sb, x, y);
                    x += 60;
                }
                else if (j == 6)
                {
                    e.Graphics.DrawString(satır, myFont2, sb, x, y);
                    x += 155;
                }
                else if (j == 8)
                {
                    e.Graphics.DrawString(satır, myFont2, sb, x, y);
                    x += 140;
                }
                else if (j == 12)
                {
                    e.Graphics.DrawString(satır, myFont2, sb, x, y);
                    x += 155;
                }
                else
                {
                    e.Graphics.DrawString(satır, myFont2, sb, x, y);
                    x += 100;
                }
            }
                satır = string.Empty;
                x = 100;
                y = 250;
                for (int i = 0; i < dgvEmanet.Rows.Count; i++)
                {
                    for (int j = 1; j < dgvEmanet.Columns.Count; j++)
                    {
                        if (j == 1)
                        {
                            satır = dgvEmanet.Rows[i].Cells[j].Value.ToString() + "  ";
                            e.Graphics.DrawString(satır, myFont2, sb, x, y);
                            x += 75;
                        }
                        else if (j == 2)
                        {
                            satır = dgvEmanet.Rows[i].Cells[j].Value.ToString() + "  ";
                            e.Graphics.DrawString(satır, myFont2, sb, x, y);
                            x += 85;
                        }
                        else if (j == 5)
                        {
                            satır = dgvEmanet.Rows[i].Cells[j].Value.ToString() + "  ";
                            e.Graphics.DrawString(satır, myFont2, sb, x, y);
                            x += 60;
                        }
                        else if (j == 6)
                        {
                            satır = dgvEmanet.Rows[i].Cells[j].Value.ToString() + "  ";
                            e.Graphics.DrawString(satır, myFont2, sb, x, y);
                            x += 155;
                        }
                    else if (j == 8)
                    {
                        satır = dgvEmanet.Rows[i].Cells[j].Value.ToString() + "  ";
                        e.Graphics.DrawString(satır, myFont2, sb, x, y);
                        x += 140;
                    }
                    else if (j == 12)
                        {
                            satır = dgvEmanet.Rows[i].Cells[j].Value.ToString() + "  ";
                            e.Graphics.DrawString(satır, myFont2, sb, x, y);
                            x += 155;
                        }
                        else
                        {
                            satır = dgvEmanet.Rows[i].Cells[j].Value.ToString() + "  ";
                            e.Graphics.DrawString(satır, myFont2, sb, x, y);
                            x += 100;
                        }

                    }

                    satır = string.Empty;
                    x = 100;
                    y += 20;
                }

            }

        

        private void timer_Tick(object sender, EventArgs e)
        {
            tsslTime8.Text = DateTime.Now.ToString();
        }

        private void cmsSiralaAd_Click(object sender, EventArgs e)
        {
            dgvEmanet.DataSource = db.tbl_Emanet.OrderBy(x => x.Üye_Adı).ToList();
        }

        private void cmsSiralaSoyad_Click(object sender, EventArgs e)
        {
            dgvEmanet.DataSource = db.tbl_Emanet.OrderBy(x => x.Üye_Soyadı).ToList();
        }

        private void cmsSiralaTC_Click(object sender, EventArgs e)
        {
            dgvEmanet.DataSource = db.tbl_Emanet.OrderBy(x => x.Üye_TC).ToList();
        }

        private void cmsSiralaTel_Click(object sender, EventArgs e)
        {
            dgvEmanet.DataSource = db.tbl_Emanet.OrderBy(x => x.Üye_Tel).ToList();
        }

        private void kitapAdınaGöreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvEmanet.DataSource = db.tbl_Emanet.OrderBy(x => x.Kitap_Adı).ToList();
        }

        private void yazarAdınaGöreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvEmanet.DataSource = db.tbl_Emanet.OrderBy(x => x.Yazar_Adı).ToList();
        }

        private void yayınevineGöreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvEmanet.DataSource = db.tbl_Emanet.OrderBy(x => x.Yayınevi).ToList();
        }

        private void durumaGöreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvEmanet.DataSource = db.tbl_Emanet.OrderBy(x => x.Durum).ToList();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            switch (cmsAramaCMB.SelectedIndex)
            {
                case 0:
                    var sonuc = db.tbl_Emanet.Where(x => x.Üye_Adı.StartsWith(cmsAramaTXT.Text)).OrderBy(x => x.Sıra).ToList();
                    if (sonuc.Count() != 0)
                    {
                        dgvEmanet.DataSource = sonuc;
                    }
                    else { MessageBox.Show("Böyle bir kayıt yoktur."); }
                    break;
                case 1:
                    sonuc = db.tbl_Emanet.Where(x => x.Üye_Soyadı.StartsWith(cmsAramaTXT.Text)).OrderBy(x => x.Sıra).ToList();
                    if (sonuc.Count() != 0)
                    {
                        dgvEmanet.DataSource = sonuc;
                    }
                    else { MessageBox.Show("Böyle bir kayıt yoktur."); }
                    break;
                case 2:
                    sonuc = db.tbl_Emanet.Where(x => x.Üye_TC.StartsWith(cmsAramaTXT.Text)).OrderBy(x => x.Sıra).ToList();
                    if (sonuc.Count() != 0)
                    {
                        dgvEmanet.DataSource = sonuc;
                    }
                    else { MessageBox.Show("Böyle bir kayıt yoktur."); }
                    break;
                case 3:
                    string tel = "(" + cmsAramaTXT.Text;
                    sonuc = db.tbl_Emanet.Where(x => x.Üye_Tel.StartsWith(tel)).OrderBy(x => x.Sıra).ToList();
                    if (sonuc.Count() != 0)
                    {
                        dgvEmanet.DataSource = sonuc;
                    }
                    else { MessageBox.Show("Böyle bir kayıt yoktur."); }
                    break;
                case 4:
                    sonuc = db.tbl_Emanet.Where(x => x.Kitap_Adı.StartsWith(cmsAramaTXT.Text)).OrderBy(x => x.Sıra).ToList();
                    if (sonuc.Count() != 0)
                    {
                        dgvEmanet.DataSource = sonuc;
                    }
                    else { MessageBox.Show("Böyle bir kayıt yoktur."); }
                    break;
                case 5:
                    sonuc = db.tbl_Emanet.Where(x => x.Yazar_Adı.StartsWith(cmsAramaTXT.Text)).OrderBy(x => x.Sıra).ToList();
                    if (sonuc.Count() != 0)
                    {
                        dgvEmanet.DataSource = sonuc;
                    }
                    else { MessageBox.Show("Böyle bir kayıt yoktur."); }
                    break;
                case 6:
                    sonuc = db.tbl_Emanet.Where(x => x.Yayınevi.StartsWith(cmsAramaTXT.Text)).OrderBy(x => x.Sıra).ToList();
                    if (sonuc.Count() != 0)
                    {
                        dgvEmanet.DataSource = sonuc;
                    }
                    else { MessageBox.Show("Böyle bir kayıt yoktur."); }
                    break;
                case 7:
                    sonuc = db.tbl_Emanet.Where(x => x.Durum.StartsWith(cmsAramaTXT.Text)).OrderBy(x => x.Sıra).ToList();
                    if (sonuc.Count() != 0)
                    {
                        dgvEmanet.DataSource = sonuc;
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

