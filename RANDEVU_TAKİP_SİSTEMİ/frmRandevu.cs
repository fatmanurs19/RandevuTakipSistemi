using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace RANDEVU_TAKİP_SİSTEMİ
{
    public partial class frmRandevu : Form
    {
        public frmRandevu()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=192.168.2.160\\ATHENA;Initial Catalog=FRESHFIT;Integrated Security=True");
        
        private void button1_Click(object sender, EventArgs e)
        {
            txtSaat.Text = button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtSaat.Text=button2.Text;  
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtSaat.Text = button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtSaat.Text = button4.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtSaat.Text=button6.Text;  
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtSaat.Text = button5.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtSaat.Text = button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtSaat.Text = button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtSaat.Text= button9.Text; 
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtSaat.Text=button10.Text;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Randevular (AdSoyad,Cinsiyet,Telefon,Tarih,Saat,Seans,Cihaz) values('" + txtAdSoyad.Text + "','" + cmbCinsiyeti.Text + "','" + txtTelefon.Text + "','" + dtpTarih.Value.ToString("yyyy-MM-dd") + "','" + txtSaat.Text + "','" + txtSeans.Text + "','" + cmbCihaz.Text + "')",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Başarılı!");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            frmRandevuGoruntule fr = new frmRandevuGoruntule();
            fr.ShowDialog();    
            this.Hide();
            this.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            frmAnasayfa fr = new frmAnasayfa();
            fr.ShowDialog();
            this.Hide();
            this.Close();
        }
    }
}
