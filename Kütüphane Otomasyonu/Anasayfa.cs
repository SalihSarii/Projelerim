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
    public partial class Anasayfa : Form
    {
        //Veritabanı bağlantı
        KutuphaneOtomasyonuEntities db = new KutuphaneOtomasyonuEntities();

        //Anasayfaya giriş yapan kullanıcının adıyla hoşgeldin yazısı
        public Anasayfa(string user)
        {
            InitializeComponent();
            tsslUser.Text ="Hosgeldin "+user;
        }
       
        private void Anasayfa_Load(object sender, EventArgs e)
        {
            timer_1.Start();//Zaman
            
        }
        
        //Üye işlemlerine geçiş
        private void tsmiUye_Click(object sender, EventArgs e)
        {
            UyeIslemleri uyeler = new UyeIslemleri();
            uyeler.ShowDialog();
            uyeler.StartPosition = FormStartPosition.CenterParent;
        }
        
        //Kitap İşlemlerine geçiş
        private void tsmiKitap_Click(object sender, EventArgs e)
        {
            KitapIslemleri ktpis = new KitapIslemleri();
            ktpis.ShowDialog();
        }
         

      //Geçiş yapılacak formun imagenin altta görünmesi

        private void tsmiUye_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            picBoxLogo.Image = Properties.Resources.Beykent_Universitesi_Logo_Yeni;
        }

        private void tsmiKitap_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            picBoxLogo.Image = Properties.Resources.Beykent_Universitesi_Logo_Yeni;

        }

        private void tsmiEmanet_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            picBoxLogo.Image = Properties.Resources.Beykent_Universitesi_Logo_Yeni;

        }


        //Emanet işlemlerine geçiş
        private void tsmiEmanet_Click(object sender, EventArgs e)
        {
            EmanetIslemleri emanet = new EmanetIslemleri();
            emanet.ShowDialog();
        }

       
        //Toplam kitap ve üye sayısı , zaman
        private void timer_1_Tick(object sender, EventArgs e)
        {
            tsslTime1.Text = DateTime.Now.ToString();
            lblKitap.Text = "Toplam Kitap Sayısı:" + db.tbl_Kitaplar.Count();
            lblUye.Text="Toplam Üye Sayısı:"+db.tbl_Uyeler.Count();
        }

        //Hakkında formuna geçiş yapılıyor

        private void tssbInfo_Click(object sender, EventArgs e)
        {
            Hakkinda info = new Hakkinda();
            info.Show();
        }
         
        // form geçiş labellarına gelindiğinde cursorların hand olması ve imagelerinin alttaki picture boxta görünümü
        private void tssbInfo_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void tssbInfo_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void tsmiUye_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
            picBoxLogo.Image = Properties.Resources.add_user;
            
        }

        private void tsmiKitap_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
            picBoxLogo.Image = Properties.Resources.Add_book;
        }

        private void tsmiEmanet_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
            picBoxLogo.Image = Properties.Resources.borrow_book;
           
        }
        //Form Hakkında bilgi 
        private void tssbHelp_ButtonClick(object sender, EventArgs e)
        {
            MessageBox.Show("Bu Formda;\n\nÜye işlemleri butonu ile Üye Ekleme ve Listeleme \n\nKitap İşlemleri butonu ile Kitap Ekleme ve Listeleme\n\n" +
                "Emanet İşlemleri butonu ile Emanet Kitap Ödünç Verme ve Teslim Alma\n\n" +
                "Kullanıcı İşlemleri butonu ile Kullanıcı Ekleme ve Listeleme\n\n"+
                "İşlemleri yapabilirsiniz.","Yardım");
        }

        //Çıkış yapmak istedğinizden emin misiniz?
        private void Anasayfa_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Çıkış yapmak istediğinizden emin misiniz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }


        private void tssbHelp_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void tssbHelp_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        //Kullanıcı işlemleri formuna geçiş
        private void tsmiKullanici_Click(object sender, EventArgs e)
        {
            KullanıcıIslemleri kulis = new KullanıcıIslemleri();
            kulis.ShowDialog();
        }

        private void tsmiKullanici_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
            picBoxLogo.Image = Properties.Resources.manager;
        }

        private void tsmiKullanici_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            picBoxLogo.Image = Properties.Resources.Beykent_Universitesi_Logo_Yeni;
        }
    }
}
