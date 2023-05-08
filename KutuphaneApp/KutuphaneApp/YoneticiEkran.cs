using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace KutuphaneApp
{
    public partial class YoneticiEkran : Form
    {
        public YoneticiEkran()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-A4M35G5;Initial Catalog=KutuphaneOtomasyonuVT;Integrated Security=True");
        Guncelleme Guncelleme = new Guncelleme();
        KitapEkle KitapEkle = new KitapEkle();
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void YoneticiGeriButton_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Çıkış yapmaya emmin misin?","Çıkış Yapma", MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
               
            }


        }

        private void UyeEkleGuncelleButton_Click(object sender, EventArgs e)
        {
            Guncelleme.Show();
        }

        private void PersonelEkleGuncelleButton_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlDataAdapter DA = new SqlDataAdapter("select *from YeniUyeForm", baglanti);
            DA.Fill(dset, "YeniUyeForm");
            dataGridView1.DataSource = dset.Tables["YeniUyeForm"];
            baglanti.Close();

        }
        DataSet dset = new DataSet();
        private void UyeleriListeleButton_Click(object sender, EventArgs e)
        {

           
            baglanti.Open();
            SqlDataAdapter DA = new SqlDataAdapter("select *from Kullanici where Durum='Üye'", baglanti);
            DA.Fill(dset, "Kullanici");
            dataGridView1.DataSource = dset.Tables["Kullanici"];
            baglanti.Close();
        }

        private void CalisanlariListeleButton_Click(object sender, EventArgs e)
        {
            
            baglanti.Open();
            SqlDataAdapter DA = new SqlDataAdapter("select *from Kullanici where Durum='Personel'", baglanti);
            DA.Fill(dset, "Kullanici");
            dataGridView1.DataSource = dset.Tables["Kullanici"];
            baglanti.Close();
        }

        private void YoneticiTemizle_Click(object sender, EventArgs e)
        {
            dset.Tables["YeniUyeForm"].Clear();
            dset.Tables["Kullanici"].Clear();
            dset.Tables["Kitap"].Clear();
        }

        private void KitapEkleGuncelleButton_Click(object sender, EventArgs e)
        {
            KitapEkle.Show();
        }

        private void KitapListeleButton_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlDataAdapter DA = new SqlDataAdapter("select *from Kitap", baglanti);
            DA.Fill(dset, "Kitap");
            dataGridView1.DataSource = dset.Tables["Kitap"];
            baglanti.Close();
        }

        private void YoneticiEkran_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
