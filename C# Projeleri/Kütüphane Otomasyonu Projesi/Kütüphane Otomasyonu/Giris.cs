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
using System.Security.Cryptography;





namespace Kütüphane_Otomasyonu
{
    public partial class Giris : Form
    {
        //Hata sayaçlarının ve güvenlik kodunun tanımlanması
       static byte sayac = 0;
       static byte csayac = 0;
       string sCaptcha;
        public Giris()
        {
            InitializeComponent();
        }

        //veritabanı bağlantısı
        KutuphaneOtomasyonuEntities kdb = new KutuphaneOtomasyonuEntities();
        
        /*güvenlik kodu fonksiyonu
         * Karakterler dizisinden random olarak 6 karakter güvenlik kodu olarak seçilir ,
         * Güvenlik kodu image boxa aktarılır.
        */
        private void captcha()
        {   

            Random rnd = new Random();
            sCaptcha = "";
            string karakterler = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz123456789";
            for (int i=0; i < 6; i++)
            {
                sCaptcha += karakterler[rnd.Next(karakterler.Length)];
            }
            //captcha kodunu Picture Boxa Taşıma işlemi 
            var image = new Bitmap(this.picBoxCaptcha.Width, this.picBoxCaptcha.Height);
            var font = new Font("Arial", 25, FontStyle.Bold, GraphicsUnit.Pixel);
            var graphics = Graphics.FromImage(image);
            graphics.DrawString(sCaptcha,font,Brushes.Green,new Point(0,0));
            picBoxCaptcha.Image = image;

        }
        
        //Şifre Textboxuna girilen veri bu fonksiyonla şifrelenir
        string sifreleme (string text) //Şifreyi md5 ile şifreleme fonksiyonu
        {
            MD5CryptoServiceProvider mdd5 = new MD5CryptoServiceProvider();
            byte[] dizi = Encoding.UTF8.GetBytes(text);
            byte[] sonuc = mdd5.ComputeHash(dizi);
            return Convert.ToBase64String(sonuc);
            
        }


        private void btnGiris_Click(object sender, EventArgs e)
        {

            //Şifre Textboxuna girilen veri şifreleme fonksiyonuna gönderilir
            string decsifre = sifreleme(txtSifre.Text);            
            
            //Log dosyası yoksa oluşturuluyor varsa açılıyor
            FileStream akim = new FileStream("log.txt", FileMode.Append, FileAccess.Write, FileShare.None);
            StreamWriter writer = new StreamWriter(akim);
        
           
            

            try
                {
                /* Try catchte yapay hata oluşturup loglanmasını sağlama
                 * 
                 * int[] a = new int[2];
                 * for(int i = 0; i < 3; i++)
                {
                    a[i] = i;
                }*/

                //Kullanıcı adı ve şifrenin veritabanında kontrolü
                var sonuc = kdb.tbl_Giris.Where(x => x.Kullanıcı_Adı == txtKulAd.Text && x.Şifre == decsifre).FirstOrDefault();
               
                
                // İlk olarak captchanın doğruluğu kontrol edilir
                if (txtCaptcha.Text==sCaptcha)
                {
                    //Şifre doğru girilirse
                    if (sonuc != null)
                    {
                        //Anasayfada giris yapan kullanıcının adı görünür
                        Anasayfa anasayfa = new Anasayfa(sonuc.Kullanıcı_Adı);

                        //Doğru girişin loglanması
                        writer.WriteLine("++ Kullanıcı: "+txtKulAd.Text+" Tarih: "+DateTime.Now.ToString()+" başarılı bir giriş yaptı\n");
                        writer.Flush();
                        writer.Close();
                        
                        //Giriş sayfasını gizleyip anasayfayı açar. Geri dönülmesine izin verir.
                        this.Hide();
                        anasayfa.ShowDialog();
                        anasayfa = null;
                        this.Show();
                   
                    } 
                    //şifre yanlış girildiyse
                    else
                    {
                        sayac++;//yanlış deneme sayısını tutan sayaç
                        //Yanlış girişin loglanması
                        writer.WriteLine("-- Kullanıcı: " + txtKulAd.Text + " Sifre:" + txtSifre.Text + " ile Tarih: " + DateTime.Now.ToString() 
                            + " Hatalı deneme sayısı:"+sayac + " hatalı bir giriş yaptı\n");
                        
                        writer.Flush();
                        writer.Close();

                        //yanlış deneme sayılarının ekranda gösterilmesi

                        
                        lblSayac.Visible = true;
                        lblSayac.ResetText();
                        lblSayac.Text += "Yanlış deneme sayısı: " + sayac.ToString();
                        txtSifre.ResetText();
                        captcha();
                        //yanlış deneme sayısı 3 olursa giriş butonunun kapanması
                        if (sayac == 3)
                        {
                            lblSayac.ResetText();
                            lblSayac.Text = "Çok fazla yanlış giriş yaptınız.";
                            btnGiris.Enabled = false;
                            txtKulAd.ResetText();
                            txtSifre.ResetText();
                        }
                    }
                


                }
                else
                {
                    

                    //Güvenlik kodunun yanlış girilmesi
                    
                    if (csayac < 2)
                    {
                        csayac++;
                        //Log işlemi
                        string text = "-- Kullanıcı:" + txtKulAd.Text + " Tarih:" + DateTime.Now.ToString() + " Güvenlik Kodu " + csayac + " kere yanlış girildi.\n";
                        writer.WriteLine(text);
                        writer.Flush();
                        writer.Close();

                        //uyarı mesajları
                        if (txtCaptcha.Text == string.Empty)
                        {

                            System.Media.SystemSounds.Hand.Play();

                            lblCaptcha.Text = "Güvenlik Kodu\nBoş Bırakılamaz!";
                            

                        }
                        else if (txtCaptcha.Text != sCaptcha)
                        {
                            System.Media.SystemSounds.Hand.Play();
                            lblCaptcha.Text = "Güvenlik Kodu Yanlış!";
                            captcha();
                        }
                    }
                    //Güvenlik kodu 3 kere yanlış girilirse  program kilitleniyor
                    else
                    {
                        csayac++;
                        //Log işlemi
                        writer.WriteLine("-- Kullanıcı:" + txtKulAd.Text + " Tarih:" + DateTime.Now.ToString() + " Güvenlik Kodu " + csayac + " kere yanlış girildi. Program Kilitlendi.\n");
                        writer.Flush();
                        writer.Close();

                        btnGiris.Enabled = false;
                        txtCaptcha.Enabled = false;
                        lblCaptcha.Text = "Çok fazla yanlış giriş yaptınız!";                     
                       
                    }

                }
            }
            //Öngörülemeyen bir hata oluşması durumunda loglama ve uyarı mesajı
                catch (Exception ex)
                {

                writer.WriteLine("@Hata Tarih:" + DateTime.Now.ToString() + " Hata Türü:" + ex.Message+" Hata Dizini:"+ex.StackTrace+"\n");
                writer.Flush();
                writer.Close();
                System.Media.SystemSounds.Hand.Play();                    
                MessageBox.Show("Lütfen IT Bölümü İle Görüşünüz !","Sistem Hatası!");
                
                
                }

        }

        //Şifrenin görünür hale gelmesi
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chbSifre.Checked)
                txtSifre.PasswordChar = '\0';
            else
                txtSifre.PasswordChar = '*';
        }

        private void Giris_Load(object sender, EventArgs e)
        {
            captcha(); //Captcha yükleniyor
            timer_3.Start(); //Tarih 
            txtSifre.Enabled = false; // şifre textboxu kapalı
            chbSifre.BackColor = Color.FromArgb(80, 0, 0, 0);//Transparan renk kodu
            lblKulAd.BackColor = Color.FromArgb(80, 0, 0, 0);
            lblSifre.BackColor = Color.FromArgb(80, 0, 0, 0);
            lblSayac.BackColor = Color.FromArgb(80, 0, 0, 0);
            lblSayac.ForeColor = Color.White;            
            picBoxGiris.BackColor = Color.FromArgb(0, 0, 0, 0);
            sspTime3.BackColor = Color.FromArgb(0,0,0,0);
            tsslTime3.BackColor = Color.FromArgb(80,0,0,0);
            //picBoxCaptcha.BackColor = Color.FromArgb(80, 0, 0, 0);
            grbCaptcha.BackColor = Color.FromArgb(80, 0, 0, 0);
            
        }

        private void Giris_KeyDown(object sender, KeyEventArgs e)
        {
            string a = "Admin";
           
            //Alt+G kombinasyonu ile şifresiz giriş

            if (e.KeyCode == Keys.G && Control.ModifierKeys == Keys.Alt)
            {
                this.Hide();
                Anasayfa anasayfa = new Anasayfa(a);
                anasayfa.ShowDialog();                
                anasayfa = null;                
                this.Show();
            }
                
            

        }

        private void timer_3_Tick(object sender, EventArgs e)
        {
            tsslTime3.Text = DateTime.Now.ToString();
        }

        private void txtKulAd_TextChanged_1(object sender, EventArgs e)
        {
            //kullanıcı adı bölümü boşken şifre bölümünün kapalı olması
            if (txtKulAd.Text != null && sayac==0)
            {
                txtSifre.Enabled = true;
            }
            else if(sayac==3)
            {
                txtSifre.Enabled = false;
            }
        }

        //textbox'ların üstüne gelince rengi değişir
        private void txtKulAd_MouseEnter(object sender, EventArgs e)
        {
            txtKulAd.ForeColor = Color.DeepSkyBlue;
            txtKulAd.BackColor = Color.Yellow;
        }

        private void txtKulAd_MouseLeave(object sender, EventArgs e)
        {
            txtKulAd.ForeColor = Color.Black;
            txtKulAd.BackColor = Color.White;
        }

        private void txtSifre_MouseEnter(object sender, EventArgs e)
        {
            txtSifre.ForeColor = Color.White;
            txtSifre.BackColor = Color.DeepSkyBlue;
        }

        private void txtSifre_MouseLeave(object sender, EventArgs e)
        {
            txtSifre.ForeColor = Color.Black;
            txtSifre.BackColor = Color.White;
        }

       
        //Proje hakkında bilgi formuna geçiş
        private void tsslbInfo_Click(object sender, EventArgs e)
        {
            Hakkinda info = new Hakkinda();
            info.ShowDialog();
        }

        private void tsslbInfo_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void tsslbInfo_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;

        }

        //Formdan çıkışta soru
        private void Giris_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Çıkış yapmak istediğinizden emin misiniz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void tssbHelp_ButtonClick(object sender, EventArgs e)
        {
            MessageBox.Show("Geçerli Kullanıcı Adı ve Şifrelere Proje Dosyasından Erişebilirsiniz","Yardım");
        }

        private void tssbHelp_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void tssbHelp_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        //Güvenlik kodu yenilenmesi
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            captcha();
        }

        private void txtCaptcha_TextChanged(object sender, EventArgs e)
        {
            lblCaptcha.Text = "";
        }

        //Form kapatıldığında loglanması
        private void Giris_FormClosed(object sender, FormClosedEventArgs e)
        {
            FileStream akim = new FileStream("log.txt", FileMode.Append, FileAccess.Write, FileShare.None);
            StreamWriter writer = new StreamWriter(akim);
            string a = "-----------------------------------------------------------------------------------";
            writer.WriteLine("Program Kapatıldı Tarih: " + DateTime.Now.ToString()+"\n"+a+"\n");
            
            writer.Flush();
            writer.Close();
        }
    }
}
