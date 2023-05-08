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
    public partial class Guncelleme : Form
    {
        public Guncelleme()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-A4M35G5;Initial Catalog=KutuphaneOtomasyonuVT;Integrated Security=True");
        SqlDataAdapter adtr;
        SqlCommand komut;
        SqlCommand komut2;
        DataTable tablo = new DataTable();
            
        private void label1_Click(object sender, EventArgs e)
        {

        }

        void KayitGosterUye()
        {
            adtr = new SqlDataAdapter("sp_Yazdirma", baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }
        void KayitGosterPersonel()
        {
            adtr = new SqlDataAdapter("sp_YazdirmaPersonel", baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }
     

        private void Guncelleme_Load(object sender, EventArgs e)
        {

        }

        private void GuncellemeSifre_TextChanged(object sender, EventArgs e)
        {

        }
        DataSet dset = new DataSet();
        string secilen;
        private void GuncellemeCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            secilen = GuncellemeCombobox.SelectedItem.ToString();
            if (secilen == "Üye")
            {
                   
                KayitGosterUye();
            
            }
            else
            {
                KayitGosterPersonel();
            }
        }

        private void GuncelleTemizleButton_Click(object sender, EventArgs e)
        {
            GuncellemeAd.Text = "";
            GuncellemeSoyad.Text = "";
            GuncellemeTel.Text = "";
            GuncellemeMail.Text = "";
            GuncellemeTC.Text = "";
            GuncellemeSifre.Text = "";
            tablo.Clear();



        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            GuncellemeID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            GuncellemeAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            GuncellemeSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            GuncellemeMail.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            GuncellemeTel.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            GuncellemeTC.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            GuncellemeSifre.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();

        }

        private void GuncellemeSilmeButton_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            komut = new SqlCommand("sp_Silme", baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@UserID", GuncellemeID.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Silme İşlemi Başarılı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);



        }

        private void GuncellemeButton_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            komut = new SqlCommand("sp_Guncelleme", baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@UserID", GuncellemeID.Text);
            komut.Parameters.AddWithValue("@UserName", GuncellemeAd.Text);
            komut.Parameters.AddWithValue("@UserLastName", GuncellemeSoyad.Text);
            komut.Parameters.AddWithValue("@UserEmail", GuncellemeMail.Text);
            komut.Parameters.AddWithValue("@UserTel", GuncellemeTel.Text);
            komut.Parameters.AddWithValue("@UserTC", GuncellemeTC.Text);
            komut.Parameters.AddWithValue("@UserSifre", GuncellemeSifre.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            
            MessageBox.Show("Güncelleme Başarılı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GuncelleKayitEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            komut2 = new SqlCommand("sp_KayitEklemePersonel", baglanti);
            komut2.CommandType = CommandType.StoredProcedure;
            komut2.Parameters.AddWithValue("@UserName", GuncellemeAd.Text);
            komut2.Parameters.AddWithValue("@UserLastName", GuncellemeSoyad.Text);
            komut2.Parameters.AddWithValue("@UserEmail", GuncellemeMail.Text);
            komut2.Parameters.AddWithValue("@UserTel", GuncellemeTel.Text);
            komut2.Parameters.AddWithValue("@UserTC", GuncellemeTC.Text);
            komut2.Parameters.AddWithValue("@UserSifre", GuncellemeSifre.Text);
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Oluşturuldu.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
