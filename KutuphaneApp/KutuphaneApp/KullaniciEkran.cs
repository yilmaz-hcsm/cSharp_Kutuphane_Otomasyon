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
    public partial class KullaniciEkran : Form
    {
        public KullaniciEkran()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-A4M35G5;Initial Catalog=KutuphaneOtomasyonuVT;Integrated Security=True");
        DataSet dset = new DataSet();

        private void KitapListeleButton_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlDataAdapter DA = new SqlDataAdapter("select *from OduncKitap where UserTC= '" + Global.KullaniciTC + "'", baglanti);
            DA.Fill(dset, "OduncKitap");
            ListeleDataGrind.DataSource = dset.Tables["OduncKitap"];
            baglanti.Close();
        }

        private void KitapIadeButton_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from OduncKitap where KitapID ='" + ListeleDataGrind.CurrentRow.Cells["KitapID"].Value.ToString() + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
         
            MessageBox.Show("Seçilen Kitaplar silindi..");
        }

        private void KullaniciEkranGeriButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void KitapAlButton_Click(object sender, EventArgs e)
        {
            KitapAlma kitapAlma = new KitapAlma();
            kitapAlma.Show();
        }
    }
}
