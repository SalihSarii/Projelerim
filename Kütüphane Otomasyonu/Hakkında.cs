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
    public partial class Hakkinda : Form
    {
        public Hakkinda()
        {
            InitializeComponent();
            
        }
        private Random rnd = new Random();           

        //Kısayollarla çıkış ve rastgele tuşlarla arkaplan rengi değişimi
        private void Hakkında_KeyDown(object sender, KeyEventArgs e)
        {//Alt+C ve Alt+S ile çıkış yapılması
            if ((e.KeyCode == Keys.S &&Control.ModifierKeys==Keys.Alt ) || (e.KeyCode == Keys.C && Control.ModifierKeys==Keys.Alt))
                this.Close();
            
            ///Rastgele tuşlara basılması ile rastgele arkaplan rengi değiştirme işlemi
            Color randomColor1 = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            BackColor = randomColor1;
            ssp4.BackColor = randomColor1;          
        }


        private void timer_4_Tick(object sender, EventArgs e)
        {
            tsslTime4.Text = DateTime.Now.ToString();
            //Her saniye Textbox'un forecolorunu rastgele bir renkle değiştiriyor
            rTxtHakkinda.ForeColor=Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
        }

        private void Hakkında_Load(object sender, EventArgs e)
        {
            timer_4.Start();
           
        }
        //Form hakkında bilgi
        private void tssbHelp_ButtonClick(object sender, EventArgs e)
        {
            MessageBox.Show("Bu Formun Amacı;\n\nBu programı oluşturan kişiler hakkında ve form özellikleri hakkında bilgi vermektir.\n\nHer saniye yazı rengi değişir\n\n" +
                "Herhangi bir tuşa bastığınızda arkaplan rengi değişir\n\n" +
                "Formdan çıkış yapmak için ALT+S ya da " +
                "ALT+C kombinasyonlarını kullanmalısınız.\n\n", "Yardım");
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
