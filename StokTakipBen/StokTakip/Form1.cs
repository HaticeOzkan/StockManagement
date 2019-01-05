using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakip
{
    //resouche de string kısmına 
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void markalarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Markalar f = new Markalar();
            f.MdiParent = this;
            f.Show();
           // new Markalar().Show();
        }

        private void telefonlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Phones P = new Phones();
            P.MdiParent = this;
            P.Show();
            
        }

        private void türkçeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // bölge tarih ayarlarına kültür deniyor  tr-TR de yazılabilir adına türkçe türkiye gibi

            Setting.ChangeLanguage(Languages.tr);
            this.Controls.Clear();
            InitializeComponent();

        }
        private void ingilizceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Setting.ChangeLanguage(Languages.en);
            //(bunlarda oluşturulabilir.)CultureInfo.CurrentCulture.DateTimeFormat=""
            this.Controls.Clear();
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {         
                ingilizceToolStripMenuItem_Click(sender, e);
        }

        private void kılıflarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PhoneCaseManage pcM = new PhoneCaseManage();
            pcM.MdiParent = this;
            pcM.Show();
        }

        private void satışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sales s = new Sales();
            s.MdiParent = this;
            s.Show();
        }
    }
}
