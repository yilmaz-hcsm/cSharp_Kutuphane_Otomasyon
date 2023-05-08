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
    public partial class kutuphane : Form
    {
        public kutuphane()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-A4M35G5;Initial Catalog=KutuphaneOtomasyonuVT;Integrated Security=True");
       

        private void GirisSifreTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void GirisSifreTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void GirisSifreTextBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kutuphane_Load(object sender, EventArgs e)
        {
            GirisUserSifreTextBox.UseSystemPasswordChar = false;
        }

        private void GirisUserTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            GirisUserTextBox.Text = "";
        }

        private void GirisUserSifreTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            GirisUserSifreTextBox.Text = "";
           
           
        }

        private void KayitAdTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            KayitAdTextBox.Text = "";
        }

        private void KayitSoyadTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            KayitSoyadTextBox.Text = "";
        }

        private void KayitTelTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            KayitTelTextBox.Text = "";
        }

        KullaniciKayit KullaniciKayit = new KullaniciKayit();
        KullaniciEkran KullaniciEkran = new KullaniciEkran();
        Guncelleme Guncelleme = new Guncelleme();
        YoneticiEkran YoneticiEkran = new YoneticiEkran();
        KitapAlma FKitapAlma = new KitapAlma();
        PersonelEkran PersonelEkran = new PersonelEkran();

        private void GirisYapButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cnn = new SqlConnection("Data Source=DESKTOP-A4M35G5;Initial Catalog=KutuphaneOtomasyonuVT;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("select Durum from Kullanici where UserTC = @TC and UserSifre = @Sifre", cnn);
                cmd.Parameters.AddWithValue("@TC", GirisUserTextBox.Text);
                cmd.Parameters.AddWithValue("@Sifre", GirisUserSifreTextBox.Text);
                cmd.Connection.Open();
                SqlDataReader rd = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                if (rd.HasRows) // Girilen K.Adı ve K.Parola Dahilinde Gelen Data var ise 
                {
                    while (rd.Read()) // reader Okuyabiliyorsa
                    {
                        if (rd["Durum"].ToString() == "Admin") 
                        {
                            Global.KullaniciTC = GirisUserTextBox.Text;//hangi kullanıcının giriş yaptıığını tutan değişken.
                            YoneticiEkran admin = new YoneticiEkran();
                            admin.Show();
                            
                        }
                        else if(rd["Durum"].ToString()=="Personel")
                        {
                            Global.KullaniciTC = GirisUserTextBox.Text;//hangi kullanıcının giriş yaptıığını tutan değişken.
                            PersonelEkran.Show();
                        }
                        else
                        {
                            Global.KullaniciTC = GirisUserTextBox.Text;//hangi kullanıcının giriş yaptıığını tutan değişken.
                            // Kullanıcı Rolü  admin ve personel dışında ise Kullanıcı Ekranı Aç
                            KullaniciEkran kul = new KullaniciEkran();
                            kul.Show();
                            
                            
                        }
                    }
                }
                else /// Reader SATIR döndüremiyorsa K.Adı Parola Yanlış Demektir
                {
                    rd.Close();
                    MessageBox.Show("Kullanıcı Adı veya Parola Geçersizdir", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch // Bağlantı açamayıp Sorgu Çalıştıramıyorsa Veritabanına Ulaşamıyor Demektir
            {
                MessageBox.Show("DB ye ulaşılamadı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            
        }
       

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                GirisUserSifreTextBox.UseSystemPasswordChar = true;
                checkBox1.Text = "Şifreyi Gizle";
            }
            else
            {
                GirisUserSifreTextBox.UseSystemPasswordChar = false;
                checkBox1.Text = "Şifreyi Göster";
            }
        }

        private void BasvuruButton_Click(object sender, EventArgs e)
        {
            if (((KayitAdTextBox.Text) == "") || ((KayitAdTextBox.Text == "Adınız")) || ((KayitSoyadTextBox.Text == "") || ((KayitAdTextBox.Text == "Soyadınız")) || ((KayitTelTextBox.Text == "") || ((KayitTelTextBox.Text == "Telefon Numaranız")) )))
                
              MessageBox.Show("Lütfen Bilgilerinizi Tam Doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into YeniUyeForm(Adi,Soyadi,Tel) values(@Adi,@Soyadi,@Tel)", baglanti);
                komut.Parameters.AddWithValue("@Adi", KayitAdTextBox.Text);
                komut.Parameters.AddWithValue("@Soyadi", KayitSoyadTextBox.Text);
                komut.Parameters.AddWithValue("@Tel", KayitTelTextBox.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                
                MessageBox.Show("Formunuz gönderilmiştir, en fazla 1 hafta içerisinde size geri dönüş sağlanacaktır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
        }
        

        private void GirisUserSifreTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
       
    }
}
