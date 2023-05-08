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

    public partial class KullaniciKayit : Form
    {
        public KullaniciKayit()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-A4M35G5;Initial Catalog=KutuphaneOtomasyonuVT;Integrated Security=True");
        SqlCommand komut;
      
        private void button1_Click(object sender, EventArgs e)
        {
           
            Close();
        }

        private void UyeAdTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            UyeAdTextBox.Text = "";
        }

        private void UyeSoyadTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void UyeSoyadTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            UyeSoyadTextBox.Text = "";
        }

        private void UyeMailTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            UyeMailTextBox.Text = "";
        }

        private void UyeTelBox_MouseClick(object sender, MouseEventArgs e)
        {
            UyeTelBox.Text = "";
        }

        private void UyeTCBox_MouseClick(object sender, MouseEventArgs e)
        {
            UyeTCBox.Text = "";
        }

        private void UyeSifreTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            UyeSifreTextBox.Text = "";
        }

        private void UyeSifreTekrarTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            UyeSifreTekrarTextBox.Text = "";
        }

        private void UyeAdTextBox_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void UyeAdTextBox_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void UyeAdTextBox_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void UyeGiris_Click(object sender, EventArgs e) // uye kayit button
        {
           

            if ((UyeAdTextBox.Text == "") || (UyeSoyadTextBox.Text == "") || (UyeMailTextBox.Text == "") || (UyeTelBox.Text == "") || (UyeTCBox.Text == "") || (UyeSifreTextBox.Text == "") || (UyeSifreTekrarTextBox.Text == ""))
            {
                MessageBox.Show("lutfen bos birakmayin");
                    
            }
            else
            {
                if ((UyeSifreTextBox.Text) == (UyeSifreTekrarTextBox.Text))
                {

                    baglanti.Open();
                    komut = new SqlCommand("sp_KayitEkleme", baglanti);
                    komut.CommandType = CommandType.StoredProcedure;
                    komut.Parameters.AddWithValue("@UserName", UyeAdTextBox.Text);
                    komut.Parameters.AddWithValue("@UserLastName", UyeSoyadTextBox.Text);
                    komut.Parameters.AddWithValue("@UserEmail", UyeMailTextBox.Text);
                    komut.Parameters.AddWithValue("@UserDogum", UyeDogumBox.Text);
                    komut.Parameters.AddWithValue("@UserTel", UyeTelBox.Text);
                    komut.Parameters.AddWithValue("@UserTC", UyeTCBox.Text);
                    komut.Parameters.AddWithValue("@UserSifre", UyeSifreTextBox.Text);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Kayıt Başarıyla Oluşturulmuştur.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                else
                {
                    MessageBox.Show("Şifreniz Uyuşmuyor", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
               
            }
            
        }

        private void KullaniciKayit_Load(object sender, EventArgs e)
        {

        }
    }
}
