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
 *Buranın logları ve try cathi yapılacak
 *Boyutlar ve düzenlemeler yapılacak
 *Butonlara simge eklenecek
 */
namespace Kütüphane_Otomasyonu
{
    public partial class TurDuzenleme : Form
    {
        public TurDuzenleme()
        {
            InitializeComponent();
        }
        KutuphaneOtomasyonuEntities db = new KutuphaneOtomasyonuEntities();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            FileStream akim = new FileStream("log.txt", FileMode.Append, FileAccess.Write, FileShare.None);
            StreamWriter writer = new StreamWriter(akim);

            try {
                
                if (txtAd.Text == "")
                {
                    System.Media.SystemSounds.Hand.Play();
                    MessageBox.Show("Tür adı bölümü boş olamaz.", "Uyarı");
                }
                else if (txtAd.Text != "")
                {
                   
                    tbl_Turler eklenen = new tbl_Turler();
                    eklenen.Tür_Adı = txtAd.Text;
                    db.tbl_Turler.Add(eklenen);
                    db.SaveChanges();
                    dgvTurler.DataSource = db.tbl_Turler.ToList();
                    txtAd.Text = String.Empty;

                    writer.WriteLine("++ Tür Başarıyla Eklendi - Tarih:" + DateTime.Now.ToString() + "Tür Adı:" + eklenen.Tür_Adı + "\n");
                    writer.Flush();
                    writer.Close();

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

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            FileStream akim = new FileStream("log.txt", FileMode.Append, FileAccess.Write, FileShare.None);
            StreamWriter writer = new StreamWriter(akim);

            try {
                if (txtAd.Text == "")
                {
                    System.Media.SystemSounds.Hand.Play();
                    MessageBox.Show("Tür adı bölümü buş olamaz.", "Uyarı");
                }

                else
                {
                    int update = Convert.ToInt32(dgvTurler.CurrentRow.Cells[0].Value);
                    var sonuc = db.tbl_Turler.Where(x => x.id == update).FirstOrDefault();
                    sonuc.Tür_Adı = txtAd.Text;
                    db.SaveChanges();
                    dgvTurler.DataSource = db.tbl_Turler.ToList();
                    txtAd.Text = String.Empty;
                    btnGuncelle.Enabled = false;
                    btnEkle.Enabled = true;
                    //LOG
                    writer.WriteLine("+/ Tür Başarıyla Güncellendi - Tarih:" + DateTime.Now.ToString() + "Tür Adı:" + sonuc.Tür_Adı + "\n");
                    writer.Flush();
                    writer.Close();
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

        private void btnSil_Click(object sender, EventArgs e)
        {

            FileStream akim = new FileStream("log.txt", FileMode.Append, FileAccess.Write, FileShare.None);
            StreamWriter writer = new StreamWriter(akim);

            try
            {
                int kontrol = db.tbl_Turler.Where(x => x.id <= 0).Count();
                if (kontrol == 0)
                {
                    System.Media.SystemSounds.Hand.Play();
                    MessageBox.Show("Tür listesi boş.", "Uyarı");
                }
                else
                {
                    int update = Convert.ToInt32(dgvTurler.CurrentRow.Cells[0].Value);
                    var sonuc = db.tbl_Turler.Where(x => x.id == update).FirstOrDefault();
                    //LOG
                    writer.WriteLine("+- Tür Başarıyla Silindi - Tarih:" + DateTime.Now.ToString() + "Tür Adı:" + sonuc.Tür_Adı  + "\n");
                    writer.Flush();
                    writer.Close();

                    
                    db.tbl_Turler.Remove(sonuc);
                    db.SaveChanges();
                    dgvTurler.DataSource = db.tbl_Turler.ToList();
                    
                    
                }
            }
            catch(Exception ex)
            {
                writer.WriteLine("@Hata Tarih:" + DateTime.Now.ToString() + " Hata Türü:" + ex.Message + " Hata Dizini:" + ex.StackTrace + "\n");
                writer.Flush();
                writer.Close();
                System.Media.SystemSounds.Hand.Play();
                MessageBox.Show("Lütfen IT Bölümü İle Görüşünüz !", "Sistem Hatası!");
            }
            akim.Close();
        }

        private void dgvTurler_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = Convert.ToInt32(dgvTurler.CurrentRow.Cells[0].Value);
            var sonuc = db.tbl_Turler.Where(x => x.id == id).FirstOrDefault();
            txtAd.Text = sonuc.Tür_Adı.ToString();
            btnEkle.Enabled = false;
            btnGuncelle.Enabled = true;
        }

        private void TurDuzenleme_Load(object sender, EventArgs e)
        {
            timer1.Start();
            dgvTurler.DataSource=db.tbl_Turler.ToList();
            btnGuncelle.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tsslTime9.Text = DateTime.Now.ToString();
        }

        private void tssbHelp_ButtonClick(object sender, EventArgs e)
        {
            MessageBox.Show("Bu formda:\n\n" +
                            "Tür EKLEMEK için;\n\n" +
                            "Kutuya tür adı yazılır ve Ekle butonuna basılır.\n\n Tür DÜZENLEMEK için;\n\n" +
                            "Aşağıdaki listeden güncellenecek türe çift tıklanır ve tür bilgileri kutuya aktarılır.\n\n" +
                            "Tür SİLMEK için;\n\n" +
                            "Aşağıdaki listeden silinecek türe tıklanır ve sil butonuna basılır.");
        }
    }
}
