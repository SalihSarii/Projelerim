using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
/*
 * Update id primary key eklenecek
 * tc nin aynı olması engellenecek(tc ile eşleşen tc olursa uyarı verecek)
 */

namespace Kütüphane_Otomasyonu
{
    public partial class UyeIslemleri : Form
    {
        public UyeIslemleri()
        {
            InitializeComponent();
        }
        KutuphaneOtomasyonuEntities db = new KutuphaneOtomasyonuEntities();
        
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            FileStream akim = new FileStream("log.txt",FileMode.Append,FileAccess.Write,FileShare.None);
            StreamWriter writer = new StreamWriter(akim);

            try
            {
             /*Try catchte yapay hata oluşturup loglanmasını sağlama
              * int[] a = new int[2];
                for (int i = 0; i < 3; i++)
                {
                    a[i] = i;
                }
             */
               
                string tc = txtTC.Text;
                int kontrol = db.tbl_Uyeler.Where(x=>x.TC == tc).Count();

                if (kontrol > 0)
                {
                    txtTC.ForeColor = Color.Red;
                }
                else
                {
                    
                    tbl_Uyeler eklenen = new tbl_Uyeler();
                    eklenen.Ad = txtAd.Text;
                    eklenen.Soyad = txtSoyad.Text;
                    eklenen.TC = txtTC.Text;
                    eklenen.Tel = mtxtTel.Text.ToString();
                    if (rdbErkek.Checked)
                    {
                        eklenen.Cinsiyet = "Erkek";
                    }
                    else if (rdbKadin.Checked)
                    {
                        eklenen.Cinsiyet = "Kadın";
                    }
                    //tüm formların dolu olup olmadığının kontrolü
                    if (txtAd.Text.Length <= 0 || txtSoyad.Text.Length <= 0 || txtTC.Text.Length <= 0 || mtxtTel.Text.Length <= 0 || (rdbErkek.Checked || rdbKadin.Checked) == false)
                    {
                        System.Media.SystemSounds.Hand.Play();
                        MessageBox.Show("Lütfen tüm bilgileri giriniz.", "Uyarı");
                    }
                    //TC nin 11 hane olduğunun ve telefon numarasının 10 hane olduğunun kontrolü
                    else if (txtTC.Text.Length < 11 || mtxtTel.Text.Length < 10)
                    {
                        if (txtTC.Text.Length < 11)
                        {
                            System.Media.SystemSounds.Hand.Play();
                            MessageBox.Show("TC Kimlik Numarası 11 Haneden Küçük Olamaz", "Uyarı");
                            txtTC.Focus();
                        }
                        if (mtxtTel.Text.Length < 10)
                        {
                            System.Media.SystemSounds.Hand.Play();
                            MessageBox.Show("Telefon Numarası 10 Haneden Küçük Olamaz", "Uyarı");
                            mtxtTel.Focus();
                        }
                    }
                    else
                    {
                        db.tbl_Uyeler.Add(eklenen);
                        db.SaveChanges();
                        dgvUyeler.DataSource = db.tbl_Uyeler.ToList();
                        //Log
                        writer.WriteLine("++ Üye Başarıyla Eklendi - Tarih:" + DateTime.Now.ToString() + " Üye Adı:" + eklenen.Ad + " Üye TC:" + eklenen.TC + "\n");
                        writer.Flush();
                        writer.Close();

                        //veri eklendikten sonra tüm textboxların ve radio buttonların sıfırlanması
                        foreach (Control c in grbUye.Controls)
                        {
                            if (c is TextBox)
                            {
                                c.Text = "";
                            }
                        }
                        mtxtTel.Text = String.Empty;
                        rdbErkek.Checked = false;
                        rdbErkek.ForeColor = Color.Black;
                        rdbKadin.Checked = false;
                        rdbKadin.ForeColor = Color.Black;
                    }
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
            akim.Close();
            
           
        }

        private void timer_8_Tick(object sender, EventArgs e)
        {
            tsslTime8.Text = DateTime.Now.ToString();
        }

        private void UyeIslemleri_Load(object sender, EventArgs e)
        {
            timer_8.Start();
            //maximum girilebilecek karakter sayısı 
            // TC için 11 telefon numarası için 10
            txtTC.MaxLength = 11;
            sspTime8.BackColor = Color.FromArgb(0, 0, 0, 0);
            dgvUyeler.DataSource = db.tbl_Uyeler.ToList();
            btnKaydet.Enabled = true;
            btnUpdate.Enabled = false;

        }

        //Ad ve soyad bölümlerine sadece harf girilmesi kontrolü
        private void txtAd_KeyPress(object sender, KeyPressEventArgs e)
        {            
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && (int)e.KeyChar != 32)
            {
                System.Media.SystemSounds.Hand.Play();
                e.Handled = true;
            }
        }

        private void txtSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {            
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                System.Media.SystemSounds.Hand.Play();
                e.Handled = true;
            }
        }

        //basılan tuşun rakam olduğunun kontrolü
        private void txtTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                System.Media.SystemSounds.Hand.Play();
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
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
            Cursor = Cursors.Default;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            FileStream akim = new FileStream("log.txt", FileMode.Append, FileAccess.Write, FileShare.None);
            StreamWriter writer = new StreamWriter(akim);

            int silme =Convert.ToInt16(dgvUyeler.CurrentRow.Cells[5].Value);
            var sonuc = db.tbl_Uyeler.Where(x => x.ID == silme).FirstOrDefault();
            try {
                /*Try catchte yapay hata oluşturup loglanmasını sağlama
                 * int[] a = new int[2];
                 for (int i = 0; i < 3; i++)
                 {
                     a[i] = i;
                 }*/


                 if (sonuc != null)
                 {
                  
                    DialogResult uyari = MessageBox.Show(sonuc.Ad + " üyesini silmek istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo);
                    if (uyari == DialogResult.Yes)
                    {
                        //Log
                        writer.WriteLine("+- Üye Başarıyla Silindi - Tarih:" + DateTime.Now.ToString() + "Üye Ad:" + sonuc.Ad + " Üye TC:" + sonuc.TC + "\n");
                        writer.Flush();
                        writer.Close();
                        db.tbl_Uyeler.Remove(sonuc);
                        db.SaveChanges();
                        dgvUyeler.DataSource = db.tbl_Uyeler.ToList();
                    }
                    else if (uyari == DialogResult.No)
                    {
                        MessageBox.Show("Silme işlemini iptal ettiniz.");
                        btnUpdate.Enabled = false;
                        btnKaydet.Enabled = true;

                        foreach (Control c in grbUye.Controls)
                        {
                            if (c is TextBox)
                            {
                                c.Text = "";
                            }
                        }
                        mtxtTel.Text = String.Empty;
                        rdbErkek.Checked = false;
                        rdbErkek.ForeColor = Color.Black;
                        rdbKadin.Checked = false;
                        rdbKadin.ForeColor = Color.Black;
                        dgvUyeler.Enabled = true;

                    }

                 }
                 else
                 {
                     MessageBox.Show("Böyle bir kayıt yok.");
                 }
             }
             catch (Exception ex)
             {
                 writer.WriteLine("@Hata Tarih:" + DateTime.Now.ToString() + " Hata Türü:" + ex.Message + " Hata Dizini:" + ex.StackTrace + "\n");
                 writer.Flush();
                 writer.Close();
                 System.Media.SystemSounds.Hand.Play();
                 MessageBox.Show("Lütfen IT Bölümü İle Görüşünüz !", "Sistem Hatası!");
             }
            akim.Close();

         }

         private void dgvUyeler_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
         {
             string update =dgvUyeler.CurrentRow.Cells[2].Value.ToString();
             var sonuc = db.tbl_Uyeler.Where(x => x.TC == update).FirstOrDefault();
             if (sonuc != null)
             {
                 btnUpdate.Enabled = true;
                 btnKaydet.Enabled = false;
                 txtAd.Text = sonuc.Ad;
                 txtSoyad.Text = sonuc.Soyad;
                 txtTC.Text = sonuc.TC;
                 mtxtTel.Text = sonuc.Tel;
                 if (sonuc.Cinsiyet == rdbErkek.Text)
                 {
                     rdbErkek.Checked = true;
                 }
                 else if(sonuc.Cinsiyet==rdbKadin.Text)
                 {
                     rdbKadin.Checked = true;
                 }
             }
            dgvUyeler.Enabled = false;
         }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FileStream akim = new FileStream("log.txt", FileMode.Append, FileAccess.Write, FileShare.None);
            StreamWriter writer = new StreamWriter(akim);

            int update = Convert.ToInt16(dgvUyeler.CurrentRow.Cells[5].Value);
            string tc = txtTC.Text;
            int kontrol = db.tbl_Uyeler.Where(x => x.TC == tc).Count();
            var sonuc = db.tbl_Uyeler.Where(x => x.ID == update).FirstOrDefault();
            try
            {
                /*Try catchte yapay hata oluşturup loglanmasını sağlama
                 * int[] a = new int[2];
                 for (int i = 0; i < 3; i++)
                 {
                     a[i] = i;
                 }*/

                if (sonuc != null)
                {
                    if (txtAd.Text.Length <= 0 || txtSoyad.Text.Length <= 0 || txtTC.Text.Length <= 0 || mtxtTel.Text.Length <= 0 || (rdbErkek.Checked || rdbKadin.Checked) == false)
                    {
                        System.Media.SystemSounds.Hand.Play();
                        MessageBox.Show("Lütfen tüm bilgileri giriniz.", "Uyarı");
                    }
                    //TC nin 11 hane olduğunun ve telefon numarasının 10 hane olduğunun kontrolü
                    else if (txtTC.Text.Length < 11 || mtxtTel.Text.Length < 10)
                    {
                        if (txtTC.Text.Length < 11)
                        {
                            System.Media.SystemSounds.Hand.Play();
                            MessageBox.Show("TC Kimlik Numarası 11 Haneden Küçük Olamaz", "Uyarı");
                            txtTC.Focus();
                        }
                        if (mtxtTel.Text.Length < 10)
                        {
                            System.Media.SystemSounds.Hand.Play();
                            MessageBox.Show("Telefon Numarası 10 Haneden Küçük Olamaz", "Uyarı");
                            mtxtTel.Focus();
                        }
                    }
                    else
                    {

                        if (kontrol > 0)
                        {
                            txtTC.ForeColor = Color.Red;
                        }
                        else
                        {
                            sonuc.Ad = txtAd.Text;
                            sonuc.Soyad = txtSoyad.Text;
                            sonuc.TC = tc;
                            sonuc.Tel = mtxtTel.Text;
                            if (rdbErkek.Checked == true)
                            {
                                sonuc.Cinsiyet = rdbErkek.Text;
                            }
                            else if (rdbKadin.Checked == true)
                            {
                                sonuc.Cinsiyet = rdbKadin.Text;
                            }
                            db.SaveChanges();
                        }
                        //Log
                        writer.WriteLine("+/ Üye Bilgileri Başarıyla Güncellendi - Tarih:" + DateTime.Now.ToString() + "Üye Adı:" + sonuc.Ad + " Üye TC:" + sonuc.TC + "\n");
                        writer.Flush();
                        writer.Close();
                    }
                    foreach (Control c in grbUye.Controls)
                    {
                        if (c is TextBox)
                        {
                            c.Text = "";
                        }
                    }
                    mtxtTel.Text = String.Empty;
                    rdbErkek.Checked = false;
                    rdbKadin.Checked = false;
                    rdbErkek.ForeColor = Color.Black;
                    rdbKadin.ForeColor = Color.Black;
                }
                dgvUyeler.Enabled = true;
                btnUpdate.Enabled = false;
                btnKaydet.Enabled = true;
            }
            catch (Exception ex)
            {
                writer.WriteLine("@Hata Tarih:" + DateTime.Now.ToString() + " Hata Türü:" + ex.Message + " Hata Dizini:" + ex.StackTrace + "\n");
                writer.Flush();
                writer.Close();
                System.Media.SystemSounds.Hand.Play();
                MessageBox.Show("Lütfen IT Bölümü İle Görüşünüz !", "Sistem Hatası!");
            }
            akim.Close();
        }

        private void cmsSiralaAd_Click(object sender, EventArgs e)
        {
            dgvUyeler.DataSource = db.tbl_Uyeler.OrderBy(x => x.Ad).ToList();
        }

        private void cmsSiralaSoyad_Click(object sender, EventArgs e)
        {
            dgvUyeler.DataSource = db.tbl_Uyeler.OrderBy(x => x.Soyad).ToList();
        }

        private void cmsSiralaTC_Click(object sender, EventArgs e)
        {
            dgvUyeler.DataSource = db.tbl_Uyeler.OrderBy(x => x.TC).ToList();
        }

        private void cmsSiralaTel_Click(object sender, EventArgs e)
        {
            dgvUyeler.DataSource = db.tbl_Uyeler.OrderBy(x => x.Tel).ToList();
        }

        private void cinsiyeteGöreToolStripMenuItem_Click(object sender, EventArgs e)////
        {
            dgvUyeler.DataSource = db.tbl_Uyeler.OrderBy(x => x.Cinsiyet).ToList();
        }

        private void araToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch (cmsAramaCMB.SelectedIndex)
            {
                case 0:
                    var sonuc = db.tbl_Uyeler.Where(x => x.Ad.StartsWith(cmsAramaTXT.Text)).OrderBy(x => x.TC).ToList();
                    if (sonuc.Count() != 0)
                    {
                        dgvUyeler.DataSource = sonuc;
                    }
                    else { MessageBox.Show("Böyle bir kayıt yoktur."); }
                    break;
                case 1:
                    sonuc = db.tbl_Uyeler.Where(x => x.Soyad.StartsWith(cmsAramaTXT.Text)).OrderBy(x => x.TC).ToList();
                    if (sonuc.Count() != 0)
                    {
                        dgvUyeler.DataSource = sonuc;
                    }
                    else { MessageBox.Show("Böyle bir kayıt yoktur."); }
                    break;
                case 2:
                    sonuc = db.tbl_Uyeler.Where(x => x.TC.StartsWith(cmsAramaTXT.Text)).OrderBy(x => x.TC).ToList();
                    if (sonuc.Count() != 0)
                    {
                        dgvUyeler.DataSource = sonuc;
                    }
                    else { MessageBox.Show("Böyle bir kayıt yoktur."); }
                    break;
                case 3:
                    string tel = "(" + cmsAramaTXT.Text;
                    sonuc = db.tbl_Uyeler.Where(x => x.Tel.StartsWith(tel)).OrderBy(x => x.TC).ToList();
                    if (sonuc.Count() != 0)
                    {
                        dgvUyeler.DataSource = sonuc;
                    }
                    else { MessageBox.Show("Böyle bir kayıt yoktur."); }
                    break;
                case 4:
                    sonuc = db.tbl_Uyeler.Where(x => x.Cinsiyet.StartsWith(cmsAramaTXT.Text)).OrderBy(x => x.TC).ToList();
                    if (sonuc.Count() != 0)
                    {
                        dgvUyeler.DataSource = sonuc;
                    }
                    else { MessageBox.Show("Böyle bir kayıt yoktur."); }
                    break;
                default:
                    MessageBox.Show("Lütfen aramak istediğiniz kriteri seçiniz.");
                    break;
            }
        }

        private void cmsAramaTXT_Click(object sender, EventArgs e)
        {
            cmsAramaTXT.Text = string.Empty;
        }

        private void txtTC_TextChanged(object sender, EventArgs e)
        {
            txtTC.ForeColor = Color.Black;
        }

        private void rdbErkek_CheckedChanged(object sender, EventArgs e)
        {
            rdbErkek.ForeColor = Color.Blue;
            rdbKadin.ForeColor = Color.Black;
        }

        private void rdbKadin_CheckedChanged(object sender, EventArgs e)
        {
            rdbErkek.ForeColor = Color.Black;
            rdbKadin.ForeColor = Color.DeepPink;
        }

        private void tsslHelp_ButtonClick(object sender, EventArgs e)
        {
            MessageBox.Show("Bu Formda:\n\n" +
                            "Üye EKLEMEK için; \n\nTüm kutular doldurulmalı ve Kaydet butonuna basılmalı.\n\n" +
                            "Kaydet butonuna basıldıktan sonra üye eklenir ve sağdaki listede görünür.\n\n" +
                            "T.C. 11 hane, Telefon No 10 hane olmalıdır.\n\n","Yardım");
            MessageBox.Show("Üye GÜNCELLEMEK için;\n\n" +
                            "Sağdaki listeden güncellenecek üyeye çift tıklanır ve üye bilgileri kutulara aktarılır.\n\n" +
                            "Burada yapılmak istenen değişiklikler yapılır ve güncelle butonuna basılır.\n\n", "Yardım");
            MessageBox.Show("Üye SİLMEK için;\n\n" +
                            "Sağdaki listeden silinecek üyeye tıklanır ve sil butonuna basılır.\n\n" +
                            "Üye ARAMAK için;\n\n" +
                            "Tabloya sağ tıklanır ve hangi özellikle aranacağı seçilir , kelime yazılır ve ara butonuna basılır.","Yardım");
        }
    }
}
