using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RANDEVU_TAKİP_SİSTEMİ
{
    public partial class frmAnasayfa : Form
    {
        public frmAnasayfa()
        {
            InitializeComponent();
        }

        private void frmAnasayfa_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongDateString();
            label3.Text = DateTime.Now.ToLongTimeString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmDanisan fr = new frmDanisan();   
            fr.ShowDialog();    
            this.Hide();  
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmRandevu fr = new frmRandevu();   
            fr.ShowDialog();
            this.Hide();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmRandevuGoruntule fr=new frmRandevuGoruntule();
            fr.ShowDialog();
            this.Hide();
            this.Close();
        }
    }
}
