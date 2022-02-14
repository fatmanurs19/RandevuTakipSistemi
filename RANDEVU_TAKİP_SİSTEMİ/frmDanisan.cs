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
    public partial class frmDanisan : Form
    {
        public frmDanisan()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=192.168.2.160\\ATHENA;Initial Catalog=FRESHFIT;Integrated Security=True");
        void verilerigetir ()
        {
            SqlDataAdapter da = new SqlDataAdapter("select*from DanisanKayit", baglanti);
            DataSet ds = new DataSet();
            baglanti.Open();
            da.Fill(ds,"DanisanKayit");
            dgvDanisan.DataSource = ds.Tables["DanisanKayit"];
            baglanti.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
           

            baglanti.Open ();
            SqlCommand komut = new SqlCommand("insert into DanisanKayit (Ad,Soyad,TC,Cinsiyet,Telefon,BaslamaTarihi,Yas,Boy,Kilo,Aciklama) values('"+txtAd.Text+"','"+txtSoyad.Text+"','"+txtTc.Text+"','"+cmbCinsiyet.Text+"','"+txtTel.Text+"','"+dtpBaslama.Value.ToString("yyyy-MM-dd")+"','"+txtYas.Text+"','"+txtBoy.Text+"','"+txtKilo.Text+"','"+txtAciklama.Text+"')",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close ();
            MessageBox.Show("Kayıt Başarılı!");
            
        }

        private void frmDanisan_Load(object sender, EventArgs e)
        {
            verilerigetir ();
        }

        private void dgvDanisan_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtAd.Text = dgvDanisan.CurrentRow.Cells[0].Value.ToString();
            txtSoyad.Text = dgvDanisan.CurrentRow.Cells[1].Value.ToString();
            txtTc.Text = dgvDanisan.CurrentRow.Cells[2].Value.ToString();
            cmbCinsiyet.Text = dgvDanisan.CurrentRow.Cells[3].Value.ToString();
            txtTel.Text = dgvDanisan.CurrentRow.Cells[4].Value.ToString();
            dtpBaslama.Text = dgvDanisan.CurrentRow.Cells[5].Value.ToString();
            txtYas.Text = dgvDanisan.CurrentRow.Cells[6].Value.ToString();
            txtBoy.Text = dgvDanisan.CurrentRow.Cells[7].Value.ToString();
            txtKilo.Text = dgvDanisan.CurrentRow.Cells[8].Value.ToString();
            txtAciklama.Text = dgvDanisan.CurrentRow.Cells[9].Value.ToString();


        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtAd.Clear();
            txtSoyad.Clear();
            txtTc.Clear();
            cmbCinsiyet.Text = "";
            txtTel.Clear();
            dtpBaslama.Text = "";
            txtYas.Clear();
            txtBoy.Clear();
            txtKilo.Clear();
            txtAciklama.Clear();

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open ();
            SqlCommand komut = new SqlCommand("update  DanisanKayit set Ad='" + txtAd.Text + "',Soyad='" + txtSoyad.Text + "',TC='" + txtTc.Text + "',Cinsiyet='" + cmbCinsiyet.Text + "',Telefon='"+txtTel.Text+"',BaslamaTarihi='" + dtpBaslama.Value.ToString("yyyy-MM-dd") + "',Yas='" + txtYas.Text + "',Boy='" + txtBoy.Text + "',Kilo='" + txtKilo.Text + "',Aciklama='" + txtAciklama.Text + "'", baglanti);
            komut.ExecuteNonQuery ();
            baglanti.Close ();
            MessageBox.Show("İşlem Başarılı!");

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from DanisanKayit where Ad='" + txtAd.Text + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("İşlem Başarılı!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAnasayfa fr = new frmAnasayfa(); 
            fr.ShowDialog ();   
            this.Hide();
            this.Close();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            









            
        }
    }
}
