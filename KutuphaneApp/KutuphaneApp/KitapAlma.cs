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
    public partial class KitapAlma : Form
    {
        public KitapAlma()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-A4M35G5;Initial Catalog=KutuphaneOtomasyonuVT;Integrated Security=True");
        DataSet dset = new DataSet();
        public static string KullaniciTC="";


        private void KitapAlma_Load(object sender, EventArgs e)
        {
            KitapAlmaTC.Text = Global.KullaniciTC;
            AlinanKitaplarListele();
        }

        private void AlinanKitaplarListele()
        {
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("select*from AlinanKitaplar", baglanti);
            da.Fill(dset, "AlinanKitaplar");
            dataGridView1.DataSource = dset.Tables["AlinanKitaplar"];
            baglanti.Close();


        }
        private void SecilenKitapSayisi()
        {
            baglanti.Open();
            SqlCommand komut_2 = new SqlCommand("select sum(KitapAdet) from AlinanKitaplar", baglanti);
            ToplamKitapSayisi.Text = komut_2.ExecuteScalar().ToString();
            baglanti.Close();
        }

        private void KitapEkleButton_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into AlinanKitaplar(KitapID,KitapAd,KitapTur,KitapYazar,KitapSayfa,KitapYayinEvi,KitapAdet,VermeTarihi,TeslimTarihi) values(@KitapID,@KitapAd,@KitapTur,@KitapYazar,@KitapSayfa,@KitapYayinEvi,@KitapAdet,@VermeTarihi,@TeslimTarihi)", baglanti);
            komut.Parameters.AddWithValue("@KitapID", KitapID.Text);
            komut.Parameters.AddWithValue("@KitapAd", KitapAdiBox.Text);
            komut.Parameters.AddWithValue("@KitapTur", KitapTuruBox.Text);
            komut.Parameters.AddWithValue("@KitapYazar", KitapYazariBox.Text);
            komut.Parameters.AddWithValue("@KitapSayfa", KitapSayfaBox.Text);
            komut.Parameters.AddWithValue("@KitapYayinEvi", KitapYayinBox.Text);
            komut.Parameters.AddWithValue("@KitapAdet", KitapStokBox.Text);
            komut.Parameters.AddWithValue("@VermeTarihi", dateTimePicker1.Text);
            komut.Parameters.AddWithValue("@TeslimTarihi", dateTimePicker2.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
           
            MessageBox.Show("Kitaplar Eklendi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dset.Tables["AlinanKitaplar"].Clear();
            KayitliKitapSayisi.Text = "";
            ToplamKitapSayisi.Text = "";
            AlinanKitaplarListele();
            SecilenKitapSayisi();

            foreach(Control item in KitapGrupBox.Controls)
            {
                if(item is TextBox)
                {
                    if (item != KitapStokBox) 
                    {
                        item.Text = "";
                    }
                          
                }
            }
        }

        private void KitapAlmaTC_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
    }

        private void KitapAlmaTC_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select*from  Kullanici where UserTC like '" + KitapAlmaTC.Text + "'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                KitapAlmaUyeID.Text = oku["UserID"].ToString();
                KitapAlmaAd.Text = oku["UserName"].ToString();
                KitapAlmaSoyad.Text = oku["UserLastName"].ToString();
                KitapAlmaMail.Text = oku["UserEmail"].ToString();


            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut_2 = new SqlCommand("select sum(KitapSayisi) from OduncKitap", baglanti);
            KayitliKitapSayisi.Text = komut_2.ExecuteScalar().ToString();
            baglanti.Close();



        }

        private void KitapID_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select*from  Kitap where KitapID like '" + KitapID.Text + "'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                KitapAdiBox.Text = oku["KitapAd"].ToString();
                KitapTuruBox.Text = oku["KitapTur"].ToString();
                KitapYazariBox.Text = oku["KitapYazar"].ToString();
                KitapSayfaBox.Text = oku["KitapSayfa"].ToString();
                KitapYayinBox.Text = oku["KitapYayinEvi"].ToString();
                KitapStokBox.Text = oku["KitapStok"].ToString();
                


            }
            baglanti.Close();
        }

        private void KitapSilButton_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from AlinanKitaplar where KitapID ='" + dataGridView1.CurrentRow.Cells["KitapID"].Value.ToString()+"'",baglanti) ;
            komut.ExecuteNonQuery();
            baglanti.Close();
         
            MessageBox.Show("Secilen Kitaplar silindi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            dset.Tables["AlinanKitaplar"].Clear();
            KayitliKitapSayisi.Text = "";
            ToplamKitapSayisi.Text = "";
            AlinanKitaplarListele();
            SecilenKitapSayisi();


        }

        private void KitaplariOnaylaButton_Click(object sender, EventArgs e)
        {
            if (ToplamKitapSayisi.Text != "")
            {

                if (KayitliKitapSayisi.Text == "" && int.Parse(ToplamKitapSayisi.Text) <= 5 || KayitliKitapSayisi.Text != "" && int.Parse(ToplamKitapSayisi.Text) <= 5)
                {

                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {


                        baglanti.Open();
                        SqlCommand komut = new SqlCommand("insert into OduncKitap(UserTC,UserName,UserLastName,KitapID,KitapAd,KitapSayisi,VermeTarihi,TeslimTarihi) values(@UserTC,@UserName,@UserLastName,@KitapID,@KitapAd,@KitapSayisi,@VermeTarihi,@TeslimTarihi)", baglanti);
                        komut.Parameters.AddWithValue("@UserTC", KitapAlmaTC.Text);
                        komut.Parameters.AddWithValue("@UserName", KitapAlmaAd.Text);
                        komut.Parameters.AddWithValue("@UserLastName", KitapAlmaSoyad.Text);
                        komut.Parameters.AddWithValue("@KitapID", dataGridView1.Rows[i].Cells["KitapID"].Value.ToString());
                        komut.Parameters.AddWithValue("@KitapAd", dataGridView1.Rows[i].Cells["KitapAd"].Value.ToString());
                        komut.Parameters.AddWithValue("@KitapSayisi", int.Parse(dataGridView1.Rows[i].Cells["KitapAdet"].Value.ToString()));
                        komut.Parameters.AddWithValue("@VermeTarihi", dataGridView1.Rows[i].Cells["VermeTarihi"].Value.ToString());
                        komut.Parameters.AddWithValue("@TeslimTarihi", dataGridView1.Rows[i].Cells["TeslimTarihi"].Value.ToString());
                        komut.ExecuteNonQuery();
                        baglanti.Close();

                        baglanti.Open();
                        SqlCommand komut_2 = new SqlCommand("update Kitap set KitapStok=KitapStok-'" + int.Parse(dataGridView1.Rows[i].Cells["KitapAdet"].Value.ToString()) + "'where KitapID='" + dataGridView1.Rows[i].Cells["KitapID"].Value.ToString() + "'", baglanti);
                        komut_2.ExecuteNonQuery();
                        baglanti.Close();
                    }





                    ToplamKitapSayisi.Text = "";
                        SecilenKitapSayisi();
                    MessageBox.Show("Kitabınız Alinmıştır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    
                    MessageBox.Show("5 den fazla kitap alamazsınız.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Lütfen Kitap Ekleyiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
