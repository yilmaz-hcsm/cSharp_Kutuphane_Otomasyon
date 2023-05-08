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
    public partial class PersonelEkran : Form
    {
        public PersonelEkran()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-A4M35G5;Initial Catalog=KutuphaneOtomasyonuVT;Integrated Security=True");
        DataSet dset = new DataSet();

        private void PersonelGeriButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UyeEkleGuncelleButton_Click(object sender, EventArgs e)
        {
            KullaniciKayit KullaniciKayit = new KullaniciKayit();
            KullaniciKayit.Show();

        }

        private void UyeleriListeleButton_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlDataAdapter DA = new SqlDataAdapter("select *from Kullanici where Durum='Üye'", baglanti);
            DA.Fill(dset, "Kullanici");
            dataGridView1.DataSource = dset.Tables["Kullanici"];
            baglanti.Close();
        }

        private void KitapEkleGuncelleButton_Click(object sender, EventArgs e)
        {
            KitapEkle KitapEkle = new KitapEkle();
            KitapEkle.Show();
        }

        private void YoneticiTemizle_Click(object sender, EventArgs e)
        {
            dset.Tables["Kullanici"].Clear();
            dset.Tables["Kitap"].Clear();
        }

        private void KitapListeleButton_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlDataAdapter DA = new SqlDataAdapter("select *from Kitap", baglanti);
            DA.Fill(dset, "Kitap");
            dataGridView1.DataSource = dset.Tables["Kitap"];
            baglanti.Close();
        }

        private void PersonelEkran_Load(object sender, EventArgs e)
        {

        }
    }
}
