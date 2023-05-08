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
    public partial class KitapEkle : Form
    {
        public KitapEkle()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-A4M35G5;Initial Catalog=KutuphaneOtomasyonuVT;Integrated Security=True");
        SqlDataAdapter adtr;
        SqlCommand komut;
        DataTable tablo = new DataTable();

        private void KitapEkle_Load(object sender, EventArgs e)
        {
            KayitGosterKitap();
        }
        void KayitGosterKitap()
        {
            adtr = new SqlDataAdapter("sp_KitapYazdirma", baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }

        private void KitapAdiBox_MouseClick(object sender, MouseEventArgs e)
        {
            KitapAdiBox.Text = "";
        }

        private void KitapTuruBox_MouseClick(object sender, MouseEventArgs e)
        {
            KitapTuruBox.Text = "";
        }

        private void KitapYazariBox_MouseClick(object sender, MouseEventArgs e)
        {
            KitapYazariBox.Text = "";
        }

        private void KitapSayfaBox_MouseClick(object sender, MouseEventArgs e)
        {
            KitapSayfaBox.Text = "";
        }

        private void KitapYayinBox_MouseClick(object sender, MouseEventArgs e)
        {
            KitapYayinBox.Text = "";
        }

        private void KitapStokBox_MouseClick(object sender, MouseEventArgs e)
        {
            KitapStokBox.Text = "";
        }

        private void KitapEkleButton_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            komut = new SqlCommand("sp_KitapEkleme", baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@KitapAD", KitapAdiBox.Text);
            komut.Parameters.AddWithValue("@KitapTur", KitapTuruBox.Text);
            komut.Parameters.AddWithValue("@KitapYazar", KitapYazariBox.Text);
            komut.Parameters.AddWithValue("@KitapSayfa", KitapSayfaBox.Text);
            komut.Parameters.AddWithValue("@KitapYayinEvi", KitapYayinBox.Text);
            komut.Parameters.AddWithValue("@KitapStok", KitapStokBox.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            
            MessageBox.Show("Kitap Kaydı Oluşturuldu.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void YeniUyeGeriButton_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            KitapID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            KitapAdiBox.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            KitapTuruBox.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            KitapYazariBox.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            KitapSayfaBox.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            KitapYayinBox.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            KitapStokBox.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
        }

        private void KitapTemizleButton_Click(object sender, EventArgs e)
        {
            KitapID.Text = "";
            KitapAdiBox.Text = "";
            KitapTuruBox.Text = "";
            KitapYazariBox.Text = "";
            KitapSayfaBox.Text = "";
            KitapYayinBox.Text = "";
            KitapStokBox.Text = "";
            tablo.Clear();
            KayitGosterKitap();
        }

        private void KitapSilButton_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            komut = new SqlCommand("sp_KitapSilme", baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@KitapID", KitapID.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt başarıyla silinmiştir.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void KitapGuncelleButton_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            komut = new SqlCommand("sp_KitapGuncelleme", baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@KitapID", KitapID.Text);
            komut.Parameters.AddWithValue("@KitapAD",KitapAdiBox.Text);
            komut.Parameters.AddWithValue("@KitapTur", KitapTuruBox.Text);
            komut.Parameters.AddWithValue("@KitapYazar", KitapYazariBox.Text);
            komut.Parameters.AddWithValue("@KitapSayfa", KitapSayfaBox.Text);
            komut.Parameters.AddWithValue("@KitapYayinEvi", KitapYayinBox.Text);
            komut.Parameters.AddWithValue("@KitapStok", KitapStokBox.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncelleme Başarıyla Gerçekleşmiştir.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
