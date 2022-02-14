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
    public partial class frmKullaniciGiris : Form
    {
        public frmKullaniciGiris()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=192.168.2.160\\ATHENA;Initial Catalog=FRESHFIT;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select*from KullaniciGiris where KullaniciAdi = '"+textBox1.Text+"' AND Sifre='"+textBox2.Text+"'",baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                MessageBox.Show("Başarılı Giriş!");
                frmAnasayfa fr = new frmAnasayfa(); 
                fr.ShowDialog();    
                this.Hide();
                this.Close();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifreyi Kontrol Edip Tekrar Deneyiniz.");
            }
            baglanti.Close();

        }
    }
}
