using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * kitap kapakları ve yazar biyografisi kitap detay a eklenecek /Belki loglanabilir
 * 
 */
namespace Kütüphane_Otomasyonu
{
    public partial class EmanetIslemleri : Form
    {
        public EmanetIslemleri()
        {
            InitializeComponent();
        }

        private void btnKitapDetay_Click(object sender, EventArgs e)
        {
            Goster();
            KitapDetay kitaplar = new KitapDetay();
            kitaplar.Show();

        }
        KutuphaneOtomasyonuEntities db = new KutuphaneOtomasyonuEntities();
        void Goster()
        {
            dgvUye.DataSource = db.tbl_Uyeler.Where(x => x.TC != null).Select(x => new { x.Ad, x.Soyad, x.Tel }).OrderBy(x => x.Ad).ToList(); // ad soyad tel
            dgvKitap.DataSource = db.tbl_Kitaplar.Where(x => x.ID >= 0).Select(x => new { x.ID, x.Kitap_Adı, x.Yazar_Adı }).OrderBy(x => x.Kitap_Adı).ToList();// id kitap adı yazar adı
            dgvEmanet.DataSource = db.tbl_Emanet.Where(x=>x.Sıra>=0).Select(x => new {x.Sıra,x.Üye_Adı,x.Üye_Soyadı,x.Üye_Tel,x.Kitap_İd,x.Kitap_Adı,x.Durum,x.Ceza}).ToList();//üye adı,soyadı,tel - kitap adı - durum - ceza(yoksa 0)
            dgvKitap.ClearSelection();
            dgvUye.ClearSelection();
            dgvEmanet.ClearSelection();
        }

        decimal Ceza (int t)
        {
            if(t <= 0)
            {
                return 0;
            }
            else if (t > 0 && t < 30)
            {
                decimal gunCarpani = 0.50M;
                return t * gunCarpani;
            }
            else 
            {
                decimal gunCarpani = 0.50M;
                decimal ayCarpani = 5;
                int toplamAy = t / 30;
                return ayCarpani * toplamAy + gunCarpani*t;

            }
            
        }

        private void EmanetIslemleri_Load(object sender, EventArgs e)
        {
            Goster();
            timer_2.Start();
            sspTime2.BackColor = Color.FromArgb(0, 0, 0, 0);
            cmbDurum.SelectedIndex = 1;
            
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            FileStream akim = new FileStream("log.txt", FileMode.Append, FileAccess.Write, FileShare.None);
            StreamWriter writer = new StreamWriter(akim);
            
            tbl_Emanet eklenen = new tbl_Emanet();

            try
            {
                /*Try catchte yapay hata oluşturup loglanmasını sağlama
                  int[] a = new int[2];
                 for (int i = 0; i < 3; i++)
                 {
                     a[i] = i;
                 }
                */

                if (cmbDurum.Text == "Verildi")
                {
                    int id = Convert.ToInt32(dgvKitap.CurrentRow.Cells[0].Value);
                    var sonuc = db.tbl_Kitaplar.Where(x => x.ID == id).FirstOrDefault();
                    if (sonuc.Miktar == 0)
                    {
                        System.Media.SystemSounds.Hand.Play();
                        MessageBox.Show("Stoklarda yok", "Uyarı");
                    }
                    else if (sonuc.Miktar != 0)
                    {
                        
                        eklenen.Üye_Adı = dgvUye.CurrentRow.Cells[0].Value.ToString();
                        eklenen.Üye_Soyadı = dgvUye.CurrentRow.Cells[1].Value.ToString();
                        string tel = dgvUye.CurrentRow.Cells[2].Value.ToString();
                        string tc = db.tbl_Uyeler.Where(x => x.Tel == tel).Select(x => x.TC).FirstOrDefault();
                        eklenen.Üye_TC = tc;
                        eklenen.Üye_Tel = tel;
                        eklenen.Kitap_İd = id;
                        eklenen.Kitap_Adı = dgvKitap.CurrentRow.Cells[1].Value.ToString();
                        eklenen.Yazar_Adı = dgvKitap.CurrentRow.Cells[2].Value.ToString();
                        eklenen.Yayınevi = db.tbl_Kitaplar.Where(x => x.ID == id).Select(x => x.Yayınevi).FirstOrDefault();
                        eklenen.Verilme_Tarihi = dtpEmanet.Text;
                        eklenen.İade_Tarihi = dtpIade.Text;
                        eklenen.Teslim_Tarihi = null;
                        eklenen.Durum = "Verildi";
                        eklenen.Ceza = null;
                        db.tbl_Emanet.Add(eklenen);
                        sonuc.Miktar = Convert.ToInt16(sonuc.Miktar - 1);
                        db.SaveChanges();
                        Goster();

                        //Log
                        writer.WriteLine("++ Kitap Başarılı Şekilde Emanet Verildi - Tarih:" + DateTime.Now.ToString() +" Üye TC:"+eklenen.Üye_TC+" Kitap ID:"+eklenen.Kitap_İd+"\n") ;
                        writer.Flush();
                        writer.Close();

                    }
                }
                else if (cmbDurum.Text == "Alındı" && dgvEmanet.CurrentRow != null && dgvEmanet.Rows.Count > 0)
                {
                    int iade = Convert.ToInt16(dgvEmanet.CurrentRow.Cells[0].Value);
                    int id = Convert.ToInt32(dgvEmanet.CurrentRow.Cells[4].Value);
                    var snc = db.tbl_Kitaplar.Where(x => x.ID == id).FirstOrDefault();
                    var sonuc = db.tbl_Emanet.Where(x => x.Sıra == iade).FirstOrDefault();
                    DateTime verilmeT, alinmaT;
                    verilmeT = dtpEmanet.Value;
                    alinmaT = Convert.ToDateTime(sonuc.İade_Tarihi);
                    System.TimeSpan zaman;
                    zaman = verilmeT.Subtract(alinmaT);
                    int toplamgun = Convert.ToInt32(Math.Floor(zaman.TotalDays));
                    //Kitap zamanında geldi mi kontrolü
                    if ((toplamgun < 0 && sonuc.Ceza != null) || (toplamgun >= 0 && sonuc.Ceza != null))
                    {
                        System.Media.SystemSounds.Hand.Play();
                        MessageBox.Show("İade edilen kitap durumu tekrar değiştirilemez.");
                    }
                    while (sonuc.Teslim_Tarihi == null)
                    {
                        if (toplamgun > 0)
                        {
                            sonuc.Teslim_Tarihi = dtpEmanet.Text;
                            sonuc.Durum = "Geç iade elidi";
                            sonuc.Ceza = Ceza(toplamgun).ToString();
                            
                            //LOG
                            writer.WriteLine("++ Kitap Başarılı Şekilde Alındı- Geç İade Edildi - Tarih:" + DateTime.Now.ToString() + " Üye TC:" + sonuc.Üye_TC + " Kitap ID:" + sonuc.Kitap_İd + "\n");
                            writer.Flush();
                            writer.Close();
                        }
                        else if (toplamgun <= 0)
                        {
                            sonuc.Teslim_Tarihi = dtpEmanet.Text;
                            sonuc.Durum = "Zamanında iade edildi";
                            sonuc.Ceza = "0";
                           
                            //LOG
                            writer.WriteLine("++ Kitap Başarılı Şekilde Alındı- Zamanında İade Edildi - Tarih:" + DateTime.Now.ToString() + " Üye TC:" + sonuc.Üye_TC + " Kitap ID:" + sonuc.Kitap_İd + "\n");
                            writer.Flush();
                            writer.Close();
                        }
                        snc.Miktar = Convert.ToInt16(snc.Miktar + 1);
                        db.SaveChanges();
                        Goster();
                    }


                }
                else if (cmbDurum.Text == "")
                {
                    System.Media.SystemSounds.Hand.Play();
                    MessageBox.Show("Lutfen Durum Seciniz!", "Uyarı!");
                }

                else if (dgvEmanet.Rows.Count <= 0)
                {
                    System.Media.SystemSounds.Hand.Play();
                    MessageBox.Show("Emanet listesi boş", "Uyarı");
                }


            }
            catch (Exception ex)
            {
                writer.WriteLine("@Hata Tarih:" + DateTime.Now.ToString() + " Hata Türü:" + ex.Message + "Hata Dizini:" + ex.StackTrace + "\n");
                writer.Flush();
                writer.Close();
                System.Media.SystemSounds.Hand.Play();
                MessageBox.Show("Lütfen IT Bölümü İle Görüşünüz !", "Sistem Hatası!");
            }


        }

        private void cmbDurum_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDurum.Text == "Alındı") {
                
                lblTarih.Text = "Alınma Tarihi:";
                lblTarih2.Visible = false;
                dtpIade.Visible = false;
                btnKayit.Text = "Güncelle";
            }
            else if (cmbDurum.Text == "Verildi")
            {
                             
                lblTarih.Text = "Verilme Tarihi:";
                lblTarih2.Text = "İade Tarihi:";
                lblTarih2.Visible = true;
                dtpIade.Visible = true;
                btnKayit.Text = "Kaydet";

            }
                
        }

        private void btnUyeDetay_Click(object sender, EventArgs e)
        {
            Goster();
            UyeDetay uyeler = new UyeDetay();
            uyeler.Show();
        }

        private void timer_2_Tick(object sender, EventArgs e)
        {
            tsslTime2.Text = DateTime.Now.ToString();
        }

        private void tssbHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Eğer kitap EMANET VERİLECEKSE;\n\nÜye listesinden emaneti vereceğiniz üyeyi, Kitap listesinden emanet verilecek kitabı seçiniz.\n\nSon olarak emanet verilen ve iade edilmesi gereken tarihleri giriniz ve kaydet butonuna basınız. " +
                "\n\nEmanet verilen kitap TESLİM ALINACAKSA;\n\nEmanet listesinden iade alınacak kitabı seçiniz.\n\nSon olarak iade aldığınız tarihi girip güncelle butonuna basınız.", "Yardım");
            MessageBox.Show("Üye Detay butonu ile üyelerin detaylı bilgisine;\n\n" +
                            "Kitap Detay butonu ile kitapların detaylı bilgisine\n\n" +
                            "Emanet Detay butonu ile emanetlerin detaylı bilgisine ulaşabilirsiniz.","Yardım");
        }

        private void tssbHelp_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void tssbHelp_MouseLeave(object sender, EventArgs e)
        {
            Cursor=Cursors.Default;
        }

        private void btnEmanetDetay_Click(object sender, EventArgs e)
        {
            Goster();
            EmanetDetay frm = new EmanetDetay();
            frm.Show();
        }

        private void dgvEmanet_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            cmbDurum.SelectedIndex = 0;
            dgvKitap.ClearSelection();
            dgvUye.ClearSelection();
        }

        private void dgvUye_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            cmbDurum.SelectedIndex = 1;
            dgvEmanet.ClearSelection();
        }

        private void dgvKitap_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            cmbDurum.SelectedIndex = 1;
            dgvEmanet.ClearSelection();
        }
    }
}
