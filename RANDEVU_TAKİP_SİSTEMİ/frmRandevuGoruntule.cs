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
    public partial class frmRandevuGoruntule : Form
    {
        public frmRandevuGoruntule()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=192.168.2.160\\ATHENA;Initial Catalog=FRESHFIT;Integrated Security=True");
        void verilerigetir()
        {
            SqlDataAdapter da = new SqlDataAdapter("select*from Randevular", baglanti);
            DataSet ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "Randevular");
            dataGridView1.DataSource = ds.Tables["Randevular"];
            baglanti.Close();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmRandevuGoruntule_Load(object sender, EventArgs e)
        {
            verilerigetir();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //DataTable yenile()
        //{
        //    baglanti.Open();
        //    SqlDataAdapter adtr = new SqlDataAdapter("select*from Randevular", baglanti);
        //    DataTable tablo = new DataTable();
        //    adtr.Fill(tablo);
        //    baglanti.Close();
        //    return tablo;
        //}

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            string AdSoyad, Cinsiyet,Telefon,Tarih,Saat, Seans, Cihaz;
           
            

            AdSoyad=dataGridView1.CurrentRow.Cells["AdSoyad"].Value.ToString();
            Cinsiyet = dataGridView1.CurrentRow.Cells["Cinsiyet"].Value.ToString();
            Telefon = dataGridView1.CurrentRow.Cells["Telefon"].Value.ToString();
            Tarih = dataGridView1.CurrentRow.Cells["Tarih"].Value.ToString();
            Saat = dataGridView1.CurrentRow.Cells["Saat"].Value.ToString();
            Seans = dataGridView1.CurrentRow.Cells["Seans"].Value.ToString();
            Cihaz = dataGridView1.CurrentRow.Cells["Cihaz"].Value.ToString();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update Randevular set AdSoyad='" + AdSoyad + "',Cinsiyet='" + Cinsiyet + "',Telefon='" + Telefon + "',Tarih='" + Tarih + "',Saat='" + Saat + "',Seans='" + Seans + "',Cihaz='" + Cihaz + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            //dataGridView1.DataSource = yenile();
            MessageBox.Show("İşlem Başarılı!");









        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            string AdSoyad, Cinsiyet, Telefon, Tarih, Saat, Seans, Cihaz;



            AdSoyad = dataGridView1.CurrentRow.Cells["AdSoyad"].Value.ToString();
            Cinsiyet = dataGridView1.CurrentRow.Cells["Cinsiyet"].Value.ToString();
            Telefon = dataGridView1.CurrentRow.Cells["Telefon"].Value.ToString();
            Tarih = dataGridView1.CurrentRow.Cells["Tarih"].Value.ToString();
            Saat = dataGridView1.CurrentRow.Cells["Saat"].Value.ToString();
            Seans = dataGridView1.CurrentRow.Cells["Seans"].Value.ToString();
            Cihaz = dataGridView1.CurrentRow.Cells["Cihaz"].Value.ToString();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from Randevular where AdSoyad='" + AdSoyad + "'",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            //dataGridView1.DataSource = yenile();
            MessageBox.Show("İşlem Başarılı!");

        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAnasayfa fr = new frmAnasayfa(); 
            fr.ShowDialog();    
            this.Hide();
            this.Close();
        }
    }
}
