using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

/*
 * Class maili atılacak.
 */
namespace Kütüphane_Otomasyonu
{
    public partial class KitapIslemleri : Form
    {
        public KitapIslemleri()
        {
            InitializeComponent();
        }
        KutuphaneOtomasyonuEntities db = new KutuphaneOtomasyonuEntities();
        string idGenerate() //id numarasını rastgele atayan fonksiyon
        {
            Random numara = new Random();
            var sayi = String.Empty;
            for (int i = 0; i <= 6; i++)
            {
                sayi += numara.Next(0, 10);

            }
            return sayi;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            FileStream akim = new FileStream("log.txt", FileMode.Append, FileAccess.Write, FileShare.None);
            StreamWriter writer = new StreamWriter(akim);
            try
            {/* Try catchte yapay hata oluşturup loglanmasını sağlama
              * 
                int[] a = new int[2];
                 for (int i = 0; i < 3; i++)
                {
                    a[i] = i;
                }*/
                
                int idno = Convert.ToInt32(idGenerate());
                //id numarasının eşsiz olduğunun kontrolü
                var sonuc = db.tbl_Kitaplar.Where(x => x.ID == idno).FirstOrDefault();
                while (sonuc != null)
                {
                    idno = Convert.ToInt32(idGenerate());
                }
                //tüm bilgilerin girilip girilmediğinin kontrolü
                if (lblAd.Text == "Tür adı: ")
                { 
                    tbl_Turler eklenenTur = new tbl_Turler();
                    eklenenTur.Tür_Adı = txtAd.Text;
                    db.tbl_Turler.Add(eklenenTur);
                    db.SaveChanges();
                    lblAd.Text = "";

                }
                else if (txtAd.Text.Length <= 0 || txtYazar.Text.Length <= 0 || cmbTur.SelectedIndex == -1 || txtSayfa.Text.Length <= 0 || txtYayin.Text.Length <= 0 || numericMiktar.Value <= 0)
                {
                    System.Media.SystemSounds.Hand.Play();
                    MessageBox.Show("Lütfen tüm bilgileri giriniz.", "Uyarı");
                }
                else //kaydın veritabanına eklenmesi
                {
                    tbl_Kitaplar eklenen = new tbl_Kitaplar();
                    eklenen.ID = Convert.ToInt32(idno);
                    eklenen.Kitap_Adı = txtAd.Text;
                    eklenen.Yazar_Adı = txtYazar.Text;
                    eklenen.Kitap_Türü = cmbTur.Text;
                    eklenen.Sayfa_Sayısı = Convert.ToInt16(txtSayfa.Text);
                    eklenen.Yayınevi = txtYayin.Text;
                    eklenen.Miktar = Convert.ToInt16(numericMiktar.Value);
                    db.tbl_Kitaplar.Add(eklenen);
                    db.SaveChanges();
                    dgvKitap.DataSource = db.tbl_Kitaplar.ToList();
                    //Log
                    writer.WriteLine("++ Kitap Başarıyla Eklendi - Tarih:" + DateTime.Now.ToString() + " Kitap ID:" + eklenen.ID + " Kitap Adı:" + eklenen.Kitap_Adı+"\n");
                    writer.Flush();
                    writer.Close();
                }
                foreach (Control x in grbKitap.Controls)
                {
                    if (x is TextBox)
                    {
                        x.Text = String.Empty;
                    }

                }
                numericMiktar.Value = 0;
                cmbTur.SelectedIndex = -1;
            }
            catch(Exception ex)
            {
                writer.WriteLine("@Hata Tarih:" + DateTime.Now.ToString() + " Hata Türü:" + ex.Message+" Hata Dizini:"+ex.StackTrace +"\n");
                writer.Flush();
                writer.Close();
                System.Media.SystemSounds.Hand.Play();
                MessageBox.Show("Lütfen IT Bölümü İle Görüşünüz !", "Sistem Hatası!");
            }

            akim.Close();

        }

        private void timer_6_Tick(object sender, EventArgs e)
        {
            tsslTime6.Text = DateTime.Now.ToString();
        }

        private void KitapIslemleri_Load(object sender, EventArgs e)
        {
            timer_6.Start();
            sspTime6.BackColor = Color.FromArgb(0, 0, 0, 0);
            dgvKitap.DataSource= db.tbl_Kitaplar.ToList();
            var turler = db.tbl_Turler.Where(x => x.id >= 0).Select(x => x.Tür_Adı).ToList();
            cmbTur.DataSource = turler;
            

        }

        //basılan tuşun rakam olduğunun kontrolü
        private void txtSayfa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                System.Media.SystemSounds.Hand.Play();
                e.Handled = true;
            }

            if ((e.KeyChar == '.'))
            {
                System.Media.SystemSounds.Hand.Play();
                e.Handled = true;
            }
        }

 


        //yazar ve kitap adlarının sadece harf olduğunun kontrolü
        private void txtAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && (int)e.KeyChar != 32 && !char.IsDigit(e.KeyChar))
            {
                System.Media.SystemSounds.Hand.Play();
                e.Handled = true;
            }
                
            
        }

        private void txtYazar_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && (int)e.KeyChar != 32)
            {
                System.Media.SystemSounds.Hand.Play();
                e.Handled = true;
            }
        }

        private void tsslHelp_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void tsslHelp_MouseLeave(object sender, EventArgs e)
        {
            Cursor= Cursors.Default;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            FileStream akim = new FileStream("log.txt",FileMode.Append,FileAccess.Write,FileShare.None);
            StreamWriter writer = new StreamWriter(akim);
            try
            {
                /* Try catchte yapay hata oluşturup loglanmasını sağlama
                 * int[] a = new int[2];
                for (int i = 0; i < 3; i++)
                {
                    a[i] = i;
                }
                */
                if(lblAd.Text=="Türün adı:")
                {
                    int size = cmbTur.Items.Count+1;
                    
                }
                int silme = Convert.ToInt32(dgvKitap.CurrentRow.Cells[0].Value);
                var sonuc = db.tbl_Kitaplar.Where(x => x.ID == silme).FirstOrDefault();
                if (sonuc != null)
                {
                    DialogResult uyari = MessageBox.Show(sonuc.Kitap_Adı + " kİtabını silmek istiyor musunuz?", "Uyarı",MessageBoxButtons.YesNo);
                    if(uyari == DialogResult.Yes)
                    {
                       //Log
                        writer.WriteLine("+- Kitap Başarıyla Silindi - Tarih:" + DateTime.Now.ToString() + "Kitap ID:" + sonuc.ID + " Kitap Ad:" + sonuc.Kitap_Adı + "\n");
                        writer.Flush();
                        writer.Close();
                        db.tbl_Kitaplar.Remove(sonuc);
                        db.SaveChanges();
                        dgvKitap.DataSource = db.tbl_Kitaplar.ToList();
                    }
                    else if(uyari == DialogResult.No)
                    {
                        MessageBox.Show("Silme işlemini iptal ettiniz");
                        btnEkle.Enabled = true;
                        btnUpdate.Enabled = false;

                        foreach (Control x in grbKitap.Controls)
                        {
                            if (x is TextBox)
                            {
                                x.Text = String.Empty;
                            }

                        }
                        numericMiktar.Value = 0;
                        cmbTur.SelectedIndex = -1;
                        dgvKitap.Enabled = true;
                    }
                }
                else
                {
                    MessageBox.Show("Böyle bir kayıt yok.");
                }
            }
            catch(Exception ex)
            {
                writer.WriteLine("@Hata Tarih:" + DateTime.Now.ToString() + " Hata Türü:" + ex.Message + "Hata Dizini:" + ex.StackTrace + "\n");
                writer.Flush();
                writer.Close();
                System.Media.SystemSounds.Hand.Play();
                MessageBox.Show("Lütfen IT Bölümü İle Görüşünüz !", "Sistem Hatası!");
            }

            akim.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FileStream akim = new FileStream("log.txt",FileMode.Append,FileAccess.Write,FileShare.None);
            StreamWriter writer = new StreamWriter(akim);

            try
            {
                /* Try catchte yapay hata oluşturup loglanmasını sağlama
                 * int[] a = new int[2];
                 for (int i = 0; i < 3; i++)
                 {
                     a[i] = i;
                 }
                */
                int update = Convert.ToInt32(dgvKitap.CurrentRow.Cells[0].Value);
                var sonuc = db.tbl_Kitaplar.Where(x => x.ID == update).FirstOrDefault();
                if (sonuc != null)
                {
                    if (txtAd.Text.Length <= 0 || txtYazar.Text.Length <= 0 || cmbTur.SelectedIndex == -1 || txtSayfa.Text.Length <= 0 || txtYayin.Text.Length <= 0 || numericMiktar.Value <= 0)
                    {
                        System.Media.SystemSounds.Hand.Play();
                        MessageBox.Show("Lütfen tüm bilgileri giriniz.", "Uyarı");
                    }
                    else
                    {
                        sonuc.Kitap_Adı = txtAd.Text;
                        sonuc.Yazar_Adı = txtYazar.Text;
                        sonuc.Kitap_Türü = cmbTur.Text;
                        sonuc.Sayfa_Sayısı = Convert.ToInt16(txtSayfa.Text);
                        sonuc.Yayınevi = txtYayin.Text;
                        sonuc.Miktar = Convert.ToInt16(numericMiktar.Value);
                        db.SaveChanges();
                        dgvKitap.DataSource = db.tbl_Kitaplar.ToList();

                        //log
                        writer.WriteLine("+/ Kitap Bilgileri Başarıyla Güncellendi - Tarih:" + DateTime.Now.ToString() + "Kitap ID:" + sonuc.ID + " Kitap Ad:" + sonuc.Kitap_Adı + "\n");
                        writer.Flush();
                        writer.Close();
                    }
                }
                foreach (Control x in grbKitap.Controls)
                {
                    if (x is TextBox)
                    {
                        x.Text = String.Empty;
                    }

                }
                numericMiktar.Value = 0;
                cmbTur.SelectedIndex = -1;
                btnEkle.Enabled = true;
                btnUpdate.Enabled = false;
            }
            catch (Exception ex)
            {
                writer.WriteLine("@Hata Tarih:" + DateTime.Now.ToString() + " Hata Türü:" + ex.Message + "Hata Dizini:" + ex.StackTrace + "\n");
                writer.Flush();
                writer.Close();
                System.Media.SystemSounds.Hand.Play();
                MessageBox.Show("Lütfen IT Bölümü İle Görüşünüz !", "Sistem Hatası!");
            }
            dgvKitap.Enabled = true;
            akim.Close();
            
        }

        private void dgvKitap_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int update = Convert.ToInt32(dgvKitap.CurrentRow.Cells[0].Value);
            var sonuc = db.tbl_Kitaplar.Where(x => x.ID == update).FirstOrDefault();
            if (sonuc != null)
            {
                txtAd.Text = sonuc.Kitap_Adı;
                txtYazar.Text = sonuc.Yazar_Adı;
                cmbTur.Text = sonuc.Kitap_Türü;
                txtSayfa.Text =sonuc.Sayfa_Sayısı.ToString();
                txtYayin.Text = sonuc.Yayınevi;
                numericMiktar.Value = Convert.ToInt32(sonuc.Miktar);
                btnUpdate.Enabled = true;
                btnEkle.Enabled = false;
                
            }
            dgvKitap.Enabled = false;
        }
        //Sıralama özelliği
        private void cmsSiralaAd_Click(object sender, EventArgs e)
        {
            dgvKitap.DataSource = db.tbl_Kitaplar.OrderBy(x => x.Kitap_Adı).ToList();
            
        }

        private void cmsSiralaYazar_Click(object sender, EventArgs e)
        {
            dgvKitap.DataSource = db.tbl_Kitaplar.OrderBy(x => x.Yazar_Adı).ToList();
        }

        private void cmsSiralaTur_Click(object sender, EventArgs e)
        {
            dgvKitap.DataSource = db.tbl_Kitaplar.OrderBy(x => x.Kitap_Türü).ToList();
        }

        private void cmsSiralaYayin_Click(object sender, EventArgs e)
        {
            dgvKitap.DataSource = db.tbl_Kitaplar.OrderBy(x => x.Yayınevi).ToList();
        }

        private void cmsAramaTXT_Click(object sender, EventArgs e)
        {
            cmsAramaTXT.Text = string.Empty;
        }

        //Arama özelliği
        private void araToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch (cmsAramaCMB.SelectedIndex)
            {
                case 0:
                    var sonuc = db.tbl_Kitaplar.Where(x => x.Kitap_Adı.StartsWith(cmsAramaTXT.Text)).OrderBy(x => x.ID).ToList();
                    if (sonuc.Count() != 0)
                    {
                        dgvKitap.DataSource = sonuc;
                    }
                    else { MessageBox.Show("Böyle bir kayıt yoktur."); }
                    break;
                case 1:
                    sonuc = db.tbl_Kitaplar.Where(x => x.Yazar_Adı.StartsWith(cmsAramaTXT.Text)).OrderBy(x => x.ID).ToList();
                    if (sonuc.Count() != 0)
                    {
                        dgvKitap.DataSource = sonuc;
                    }
                    else { MessageBox.Show("Böyle bir kayıt yoktur."); }
                    break;
                case 2:
                    sonuc = db.tbl_Kitaplar.Where(x => x.Kitap_Türü.StartsWith(cmsAramaTXT.Text)).OrderBy(x => x.ID).ToList();
                    if (sonuc.Count() != 0)
                    {
                        dgvKitap.DataSource = sonuc;
                    }
                    else { MessageBox.Show("Böyle bir kayıt yoktur."); }
                    break;
                case 3:
                    sonuc = db.tbl_Kitaplar.Where(x => x.Yayınevi.StartsWith(cmsAramaTXT.Text)).OrderBy(x => x.ID).ToList();
                    if (sonuc.Count() != 0)
                    {
                        dgvKitap.DataSource = sonuc;
                    }
                    else { MessageBox.Show("Böyle bir kayıt yoktur."); }
                    break;
                default:
                    MessageBox.Show("Lütfen aramak istediğiniz kriteri seçiniz.");
                    break;
            }
        }

        private void lblTurDuzenleme_MouseEnter(object sender, EventArgs e)
        {
            lblTurDuzenleme.Cursor = Cursors.Hand;
            lblTurDuzenleme.Font = new Font("Microsoft Sans Serif",8,FontStyle.Underline);
        }

        private void lblTurDuzenleme_MouseLeave(object sender, EventArgs e)
        {
            lblTurDuzenleme.Cursor=Cursors.Default;
            lblTurDuzenleme.Font = DefaultFont;
        }

        private void lblTurDuzenleme_MouseClick(object sender, MouseEventArgs e)
        {
            TurDuzenleme turler = new TurDuzenleme();
            turler.ShowDialog();
            turler = null;
            cmbTur.DataSource = db.tbl_Turler.Where(x => x.id >= 0).Select(x => x.Tür_Adı).ToList();
        }

        private void tsslHelp_ButtonClick(object sender, EventArgs e)
        {
            MessageBox.Show("Bu Formda:\n\n" +
                            "Kitap EKLEMEK için; \n\nTüm kutular doldurulmalı ve Ekle butonuna basılmalı.\n\n" +
                            "Ekle butonuna basıldıktan sonra üye eklenir ve sağdaki listede görünür.\n\n", "Yardım");
            MessageBox.Show("Kitap GÜNCELLEMEK için;\n\n" +
                            "Sağdaki listeden güncellenecek kitaba çift tıklanır ve kitap bilgileri kutulara aktarılır.\n\n" +
                            "Burada yapılmak istenen değişiklikler yapılır ve güncelle butonuna basılır.\n\n", "Yardım");
            MessageBox.Show("Kitap SİLMEK için;\n\n" +
                            "Sağdaki listeden silinecek kitaba tıklanır ve sil butonuna basılır.\n\n" +
                            "Kitap ARAMAK için;\n\n" +
                            "Tabloya sağ tıklanır ve hangi özellikle aranacağı seçilir , kelime yazılır ve ara butonuna basılır.\n\n" +
                            "Tür DÜZENLEMEK için;\n\nTür Düzenleme yazısına tıklanarak tür Ekleme ve Silme işlemlerine giden bir pencere açılır.", "Yardım");
            
        }
    }
}
