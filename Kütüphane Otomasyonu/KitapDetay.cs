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
    public partial class KitapDetay : Form
    {
        public KitapDetay()
        {
            InitializeComponent();
        }
        KutuphaneOtomasyonuEntities db = new KutuphaneOtomasyonuEntities();
        private void KitapDetay_Load(object sender, EventArgs e)
        {
            timer_5.Start();
            sspTime5.BackColor = Color.FromArgb(0, 0, 0, 0);
            dgvKitapDetay.DataSource = db.tbl_Kitaplar.OrderBy(x=>x.Kitap_Adı).ToList();


        }

        

        private void timer_5_Tick(object sender, EventArgs e)
        {
            tsslTime5.Text = DateTime.Now.ToString();
        }

        private void btnYazdır_Click(object sender, EventArgs e)
        {
            DialogResult dr = printDialog1.ShowDialog();
            if (dr==DialogResult.OK)
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
            int x = 100, y = 230;
            string satır = "";


            Font myFont = new Font("Arial",25);
            Font myFont2 = new Font("Arial", 8);
            SolidBrush sb = new SolidBrush(Color.Black);
            Pen myPen = new Pen(Color.Yellow,10);
            Pen myPen2 = new Pen(Color.LightSkyBlue,10);
            Pen myPen3 = new Pen(Color.Black,2);
            Pen myPen4 = new Pen(Color.Black, 1);

            e.Graphics.DrawString("Beykent Üniversitesi Kütüphane Otomasyonu",myFont,sb,70,100);
            e.Graphics.DrawString("Tarih: " + DateTime.Now.ToString(),myFont2, sb, 100, 180);
            
            for(int i = 0; i < dgvKitapDetay.Columns.Count; i++)
            {
                satır = dgvKitapDetay.Columns[i].Name;
                if (i == 0)
                {                   
                    e.Graphics.DrawString(satır, myFont2, sb, x, y);
                    x += 55;            
                }
                else if (i == 1)
                {
                    e.Graphics.DrawString(satır, myFont2, sb, x, y);
                    x += 155;
                }
                else {
                    e.Graphics.DrawString(satır, myFont2, sb, x, y);
                    x += 100;
                } 
            }
            y = 250;
            x = 100;
            //Tablo Yatay çizgileri
            e.Graphics.DrawLine(myPen4, 100, 243, 750, 243);
            e.Graphics.DrawLine(myPen4, 99, 229, 750, 229);
            e.Graphics.DrawLine(myPen4, 99, 1000, 750, 1000);
            
            //Beykent Üniversitesi Renkleri
            e.Graphics.DrawLine(myPen,100,200,750,200);
            e.Graphics.DrawLine(myPen2,100,210,750,210);
            e.Graphics.DrawLine(myPen3,100,205,750,205);

            e.Graphics.DrawLine(myPen, 100, 1050, 750, 1050);
            e.Graphics.DrawLine(myPen2, 100, 1060, 750, 1060);
            e.Graphics.DrawLine(myPen3, 100, 1055, 750, 1055);

            //Tablo Dik Çizgileri
            e.Graphics.DrawLine(myPen4, 99, 229, 99, 1000);
            e.Graphics.DrawLine(myPen4, 154, 229, 154, 1000);
            e.Graphics.DrawLine(myPen4, 309, 229, 309, 1000);
            e.Graphics.DrawLine(myPen4, 409, 229, 409, 1000);
            e.Graphics.DrawLine(myPen4, 509, 229, 509, 1000);
            e.Graphics.DrawLine(myPen4, 609, 229, 609, 1000);
            e.Graphics.DrawLine(myPen4, 709, 229, 709, 1000);
            e.Graphics.DrawLine(myPen4, 750, 229, 750, 1000);

            for (int i = 0; i < dgvKitapDetay.Rows.Count; i++)
            {
               for(int j = 0; j < dgvKitapDetay.Columns.Count; j++)
                {
                    if (j == 0)
                    {
                        satır = dgvKitapDetay.Rows[i].Cells[j].Value.ToString() + "  ";
                        e.Graphics.DrawString(satır, myFont2, sb, x, y);
                        x += 55;
                    }
                    else if (j == 1)
                    {
                        satır = dgvKitapDetay.Rows[i].Cells[j].Value.ToString() + "  ";
                         e.Graphics.DrawString(satır, myFont2, sb, x, y);
                        x += 155;
                    }
                    else {
                        satır = dgvKitapDetay.Rows[i].Cells[j].Value.ToString() + "  ";
                        e.Graphics.DrawString(satır, myFont2, sb, x, y);
                        x += 100;
                    } 
                   
                }
                
                satır = string.Empty;
                x = 100;
                y += 20;
            }
               
            

        }

        private void cmsSiralaAd_Click(object sender, EventArgs e)
        {
            dgvKitapDetay.DataSource = db.tbl_Kitaplar.OrderBy(x => x.Kitap_Adı).ToList();
        }

        private void cmsSiralaYazar_Click(object sender, EventArgs e)
        {
            dgvKitapDetay.DataSource = db.tbl_Kitaplar.OrderBy(x => x.Yazar_Adı).ToList();
        }

        private void cmsSiralaTur_Click(object sender, EventArgs e)
        {
            dgvKitapDetay.DataSource = db.tbl_Kitaplar.OrderBy(x => x.Kitap_Türü).ToList();
        }

        private void cmsSiralaYayin_Click(object sender, EventArgs e)
        {
            dgvKitapDetay.DataSource = db.tbl_Kitaplar.OrderBy(x => x.Yayınevi).ToList();
        }

        private void araToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch (cmsAramaCMB.SelectedIndex)
            {
                case 0:
                    var sonuc = db.tbl_Kitaplar.Where(x => x.Kitap_Adı.StartsWith(cmsAramaTXT.Text)).OrderBy(x => x.ID).ToList();
                    if (sonuc.Count() != 0)
                    {
                        dgvKitapDetay.DataSource = sonuc;
                    }
                    else { MessageBox.Show("Böyle bir kayıt yoktur."); }
                    break;
                case 1:
                    sonuc = db.tbl_Kitaplar.Where(x => x.Yazar_Adı.StartsWith(cmsAramaTXT.Text)).OrderBy(x => x.ID).ToList();
                    if (sonuc.Count() != 0)
                    {
                        dgvKitapDetay.DataSource = sonuc;
                    }
                    else { MessageBox.Show("Böyle bir kayıt yoktur."); }
                    break;
                case 2:
                    sonuc = db.tbl_Kitaplar.Where(x => x.Kitap_Türü.StartsWith(cmsAramaTXT.Text)).OrderBy(x => x.ID).ToList();
                    if (sonuc.Count() != 0)
                    {
                        dgvKitapDetay.DataSource = sonuc;
                    }
                    else { MessageBox.Show("Böyle bir kayıt yoktur."); }
                    break;
                case 3:
                    sonuc = db.tbl_Kitaplar.Where(x => x.Yayınevi.StartsWith(cmsAramaTXT.Text)).OrderBy(x => x.ID).ToList();
                    if (sonuc.Count() != 0)
                    {
                        dgvKitapDetay.DataSource = sonuc;
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
