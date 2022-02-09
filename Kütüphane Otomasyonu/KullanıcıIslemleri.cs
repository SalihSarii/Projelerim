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
using System.Security.Cryptography;


namespace Kütüphane_Otomasyonu
{
    public partial class KullanıcıIslemleri : Form
    {
        public KullanıcıIslemleri()
        {
            InitializeComponent();
        }

        //Veritabanı bağlantısı
        KutuphaneOtomasyonuEntities db = new KutuphaneOtomasyonuEntities();

        //Veritabanındaki verilerin tabloda listelenmesi fonksiyonu
        void goster()
        {
            dgv_Kul.DataSource = db.tbl_Giris.Where(x => x.Kullanıcı_Adı != null).Select(x => new { x.Ad, x.Soyad, x.Kullanıcı_Adı }).OrderBy(x => x.Ad).ToList();
            dgv_Kul.ClearSelection();

        }
        string sifreleme(string text) //Textboxa girilen şifreyi md5 ile şifreleme fonksiyonu
        {
            MD5CryptoServiceProvider mdd5 = new MD5CryptoServiceProvider();
            byte[] dizi = Encoding.UTF8.GetBytes(text);
            byte[] sonuc = mdd5.ComputeHash(dizi);
            return Convert.ToBase64String(sonuc);

        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            //Log dosyası yoksa oluşturuluyor varsa açılıyor
            FileStream akim = new FileStream("log.txt", FileMode.Append,FileAccess.Write,FileShare.None) ;
            StreamWriter writer = new StreamWriter(akim);

            //Şifre Textboxuna girilen veri şifreleme fonksiyonuna gönderilir

            string decsifre = sifreleme(txtSifre.Text);

            try
            {
                /*Try catchte yapay hata oluşturup loglanmasını sağlama
             * int[] a = new int[2];
               for (int i = 0; i < 3; i++)
               {
                   a[i] = i;
               }
            */
                tbl_Giris eklenen = new tbl_Giris();
                
                //Textboxa girilen verilerin nesneye atanması
                eklenen.Ad  = txtAd.Text ;
                eklenen.Soyad = txtSoyad.Text;
                eklenen.Şifre = decsifre;
                eklenen.Kullanıcı_Adı = txtKulad.Text;
                //Uyarı kutuları
               if(txtAd.Text.Length <= 0 || txtSoyad.Text.Length <= 0 || txtSifre.Text.Length <= 0 || txtRsifre.Text.Length <= 0|| txtKulad.Text.Length < 3|| txtSifre.Text != txtRsifre.Text)
                {
                    if (txtAd.Text.Length <= 0 || txtSoyad.Text.Length <= 0 || txtSifre.Text.Length <= 0 || txtRsifre.Text.Length <= 0)
                    {
                        System.Media.SystemSounds.Hand.Play();
                        MessageBox.Show("Lütfen tüm bilgileri giriniz.", "Uyarı");
                    }

                    if (txtKulad.Text.Length < 3)
                    {
                        System.Media.SystemSounds.Hand.Play();
                        MessageBox.Show("Kullanıcı adı 3 karakterden küçük olamaz");
                    }
                    if (txtSifre.Text != txtRsifre.Text)
                    {
                        System.Media.SystemSounds.Hand.Play();
                        MessageBox.Show("Şifreler Aynı Olmalıdır");
                    }
                }
             

                else
                {
                    //Verilerin veritabanına eklenmesi ve kaydedilmesi
                    db.tbl_Giris.Add(eklenen);
                    db.SaveChanges();
                    

                    //LOG
                    writer.WriteLine("++ Kullanıcı Başarıyla Eklendi - Tarih:" + DateTime.Now.ToString() + " Kullanıcı Adı:" + eklenen.Ad + " Kullanıcı Soyadı:" + eklenen.Soyad + "\n");
                    writer.Flush();
                    writer.Close();
                    
                    //textboxların sıfırlanması ve tabloda listelenmesi
                    foreach (Control c in grbKul.Controls)
                    {
                        if(c is TextBox)
                        {
                            c.Text = string.Empty;
                        }
                    }
                    goster();
                }

            }
            //Öngörülemeyen hataların loglanması ve hata mesajı
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Log dosyası varsa aılır yoksa oluşturulur
            FileStream akim = new FileStream("log.txt", FileMode.Append, FileAccess.Write, FileShare.None);
            StreamWriter writer = new StreamWriter(akim);

            //Şifre Textboxuna girilen veri şifreleme fonksiyonuna gönderilir
            string decsifre = sifreleme(txtSifre.Text);
            string kulAdi=txtKulad.Text;
            
            //Tablodan seçilen kişinin bilgilerinin veritabanından çekilmesi
            string update = dgv_Kul.CurrentRow.Cells[0].Value.ToString();
            var sonuc = db.tbl_Giris.Where(x => x.Kullanıcı_Adı == update).FirstOrDefault();
            try
            {
                /*Try catchte yapay hata oluşturup loglanmasını sağlama
                * int[] a = new int[2];
                for (int i = 0; i < 3; i++)
                {
                    a[i] = i;
                }*/
                //Uyarı mesajları
                if (txtAd.Text.Length <= 0 || txtSoyad.Text.Length <= 0 || txtSifre.Text.Length <= 0 || txtRsifre.Text.Length <= 0 || txtKulad.Text.Length < 3 || txtSifre.Text != txtRsifre.Text)
                {
                    if (txtAd.Text.Length <= 0 || txtSoyad.Text.Length <= 0 || txtSifre.Text.Length <= 0 || txtRsifre.Text.Length <= 0)
                    {
                        System.Media.SystemSounds.Hand.Play();
                        MessageBox.Show("Lütfen tüm bilgileri giriniz.", "Uyarı");
                    }

                    if (txtKulad.Text.Length < 3)
                    {
                        System.Media.SystemSounds.Hand.Play();
                        MessageBox.Show("Kullanıcı adı 3 karakterden küçük olamaz");
                    }
                    if (txtSifre.Text != txtRsifre.Text)
                    {
                        System.Media.SystemSounds.Hand.Play();
                        MessageBox.Show("Şifreler Aynı Olmalıdır");
                    }
                }
                //Herhangi bir uyarı alınmazsa ve tablodan veriler düzgün şekilde çekildiyse 
                else if (sonuc != null)
                {
                    sonuc.Ad = txtAd.Text;
                    sonuc.Soyad = txtSoyad.Text;
                    sonuc.Kullanıcı_Adı = txtKulad.Text;
                    sonuc.Şifre = decsifre;
                    //Veriler veritabanına kaydedilir
                    db.SaveChanges();
                    
                    //LOG
                    writer.WriteLine("++ Kullanıcı Başarıyla Eklendi - Tarih:" + DateTime.Now.ToString() + " Kullanıcı Adı:" + sonuc.Ad + " Kullanıcı Soyadı:" + sonuc.Soyad + "\n");
                    writer.Flush();
                    writer.Close();
                    //Listeleme ve textboxların sıfırlanması
                    goster();

                    foreach (Control c in grbKul.Controls)
                    {
                        if(c is TextBox)
                        {
                            c.Text = string.Empty;
                        }
                    }
                }
                
                dgv_Kul.Enabled = true;
                btnUpdate.Enabled = false;
                btnEkle.Enabled = true;


            }
            //Öngörülemeyen hatanın loglanması
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

        private void KullanıcıIslemleri_Load(object sender, EventArgs e)
        {
            timer1.Start();//Zaman 
            goster();//Tablonun listelenmesi
            btnUpdate.Enabled = false;//Güncelleme butonunun inaktif olması
            lblIptal.Visible = false;
        }
        //Çift tıklama işlemiyle tablodaki verilerin güncelleme işlemi için textboxlara aktarılması
        private void dgv_Kul_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string update = dgv_Kul.CurrentRow.Cells[2].Value.ToString();
            var sonuc = db.tbl_Giris.Where(x => x.Kullanıcı_Adı == update).FirstOrDefault();
            if (sonuc != null)
            {
                btnUpdate.Enabled = true;
                btnEkle.Enabled = false;
                txtAd.Text = sonuc.Ad;
                txtSoyad.Text = sonuc.Soyad;
                txtKulad.Text = sonuc.Kullanıcı_Adı;
                txtSifre.Text = sonuc.Şifre;
                txtRsifre.Text = sonuc.Şifre;
                
            }
            dgv_Kul.Enabled = false;
            lblIptal.Visible = true;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {

            //Log dosyası varsa aç yoksa oluştur
            FileStream akim = new FileStream("log.txt", FileMode.Append, FileAccess.Write, FileShare.None);
            StreamWriter writer = new StreamWriter(akim);

            //Tabloda seçilen verinin veritabanıyla uygunluğu kontrolü
            string silme = dgv_Kul.CurrentRow.Cells[2].Value.ToString();
            var sonuc = db.tbl_Giris.Where(x => x.Kullanıcı_Adı== silme).FirstOrDefault();

            try
            {
                /*Try catchte yapay hata oluşturup loglanmasını sağlama
                 * int[] a = new int[2];
                 for (int i = 0; i < 3; i++)
                 {
                     a[i] = i;
                 }*/

                //Veriler uygunsa
                if (sonuc != null)
                {
                    DialogResult uyari = MessageBox.Show(sonuc.Ad + " üyesini silmek istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo);
                    if (uyari == DialogResult.Yes)//Silme işlemi , silinen halin listelenmesi ve database kaydedilmesi
                    {
                        //Log
                        writer.WriteLine("+- Kullanıcı Başarıyla Silindi - Tarih:" + DateTime.Now.ToString() + "Kullanıcı Ad:" + sonuc.Ad + " Üye TC:" + sonuc.Soyad + "\n");
                        writer.Flush();
                        writer.Close();

                        db.tbl_Giris.Remove(sonuc);
                        db.SaveChanges();
                        goster();
                        //Textboxların boşaltılması
                        foreach(Control c in grbKul.Controls)
                        {
                            if(c is TextBox)
                            {
                                c.Text = String.Empty;
                            }
                        }
                        dgv_Kul.Enabled = true;
                        btnUpdate.Enabled = false;
                        btnEkle.Enabled = true;
                        lblIptal.Visible = false;
                    }
                    else if (uyari == DialogResult.No)
                    {
                        MessageBox.Show("Silme işlemini iptal ettiniz.");
                    }


                }
                else
                {
                    MessageBox.Show("Böyle bir kayıt yok.");
                }
            }
            //Öngörülemeyen hataların loglanması
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

        //Tablo çift tıklandığında update işlemi açılır bunun iptali için
        private void lblIptal_Click(object sender, EventArgs e)
        {
            foreach (Control c in grbKul.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = string.Empty;
                }
            }
            btnUpdate.Enabled = false;
            lblIptal.Visible = false;
            dgv_Kul.Enabled = true;
            btnEkle.Enabled = true;
        }

        //şifrenin görünürlüğü
        private void chbSifre1_CheckedChanged(object sender, EventArgs e)
        {
            if (chbSifre1.Checked)
                txtSifre.PasswordChar = '\0';
            else
                txtSifre.PasswordChar = '*';
        }

        private void chbSifre2_CheckedChanged(object sender, EventArgs e)
        {
            if (chbSifre2.Checked)
                txtRsifre.PasswordChar = '\0';
            else
                txtRsifre.PasswordChar = '*';
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tsslTime10.Text = DateTime.Now.ToString();
        }

        //Formun kullanımı hakkında bilgi
        private void tssbHelp_ButtonClick(object sender, EventArgs e)
        {
            MessageBox.Show("Bu formda:\n\n" +
                            "Kullanıcı EKLEMEK için;\n\nTüm kutular doldurulur ve Ekle butonuna basılır.Eklenen kullanıcı sağdaki tabloda listelenir.\n\n" +
                            "Kullanıcı DÜZENLEMEK için;\n\nSağdaki tablodan düzenlenecek kullanıcıya çift tıklanır ve istenilen şekilde veriler değiştilip güncelle butonuna basılır.\n\n" +
                            "Kullanıcı SİLMEK için;\n\nSağdaki listeden kullanıcı seçilir ve sil butonuna basılır.","Yardım");
        }

        private void tssbHelp_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void tssbHelp_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }
    }
}
