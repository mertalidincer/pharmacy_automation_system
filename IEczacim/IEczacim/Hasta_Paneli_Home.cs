using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IEczacim
{
    public partial class Hasta_Paneli_Home : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader reader;
        public Hasta_Paneli_Home()
        {
            InitializeComponent();
        }
        string Hasta_TcNo; // Hastanin tc kimlik numrasini bir degiskene ata
        string Sifre;      // hastanin sifre bilgisini bir degiskene ata

        public static string Sistemde_girisi_olan_hasta_Id;     // sistemde aktif olan hastanin id'si tutulacak
        public static string Sistemde_girisi_olan_hasta_name;   // sistemde aktif olan hastanin name'si tutulacak
        string name;
        int basarili;
        private void Hasta_Paneli_Home_Load(object sender, EventArgs e)
        {
            // baslangicta text box lari bosalt
            TextBox_Hasta_KullaniciAdi.Text = "";
            TextBox_Hasta_Sifre.Text = "";
        }

        // Boyle bir Hastanin olup olmasiginin kontrolu
        public int Kullanic_kontrol()
        {
            conn = null;
            basarili = -1;
            try
            {
                // TextBox' lar daki verileri al
                Hasta_TcNo = TextBox_Hasta_KullaniciAdi.Text.ToString();
                Sifre = TextBox_Hasta_Sifre.Text.ToString();

                conn = new SqlConnection("Data Source=LAPTOP-5J9G4MFS\\SQLEXPRESS;Initial Catalog=IEczacim;Integrated Security=True");
                conn.Open();
                cmd = new SqlCommand("SELECT Hesap_Id, Hasta_TcNo, Sifre FROM Tbl_Hasta_Hesaplar", conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    // textbox' tan alinan verilerin karsilastirilmasi
                    if (Hasta_TcNo == reader["Hasta_TcNo"].ToString() && Sifre == reader["Sifre"].ToString())
                    {
                        Sistemde_girisi_olan_hasta_Id = reader["Hesap_Id"].ToString();    // sisteme giris yapan hastanin id bilgisi tutuldi
                        basarili = 1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("sorgu calisrirken bir hata ile karsilasildi" + ex.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return basarili;
        }
        private void Btn_Hasta_Giris_Click(object sender, EventArgs e)
        {
            // textboxlarin bos olma durumunu kotrol et
            if (TextBox_Hasta_KullaniciAdi.Text != "" && TextBox_Hasta_Sifre.Text != "") 
            {
                // boeyle bir kullanici var ise islemi talamal ver froma git
                if (Kullanic_kontrol() == 1)
                {
                    Sistemde_girisi_olan_hasta_name = Hasta_name_al(Sistemde_girisi_olan_hasta_Id);
                    Hasta_Paneli_Home1_Form hasta_Paneli_Home1 = new Hasta_Paneli_Home1_Form();
                    hasta_Paneli_Home1.Show();
                    hasta_Paneli_Home1.Hasta_Name.Text = Sistemde_girisi_olan_hasta_name.ToString();
                }
                else
                {
                    MessageBox.Show("boyle bir kullanici bulunmamakta lutfen tekrar deneyiniz");
                }
            }
            else
            {
                MessageBox.Show("Lutfen bis bir alan birakmayiniz.");
            }


        }

        // Digre formlardaki label' larda gostermek icin sisteme giris yapmis olan hastan isim bilgisi aliyoruz
        public string Hasta_name_al(string id) 
        {
            conn = null;
            try
            {
                conn = new SqlConnection("Data Source=LAPTOP-5J9G4MFS\\SQLEXPRESS;Initial Catalog=IEczacim;Integrated Security=True");
                conn.Open();
                cmd = new SqlCommand("SELECT Hasta_Ad FROM Tbl_Hasta_Bilgileri WHERE Hesta_Hesap_Id = @Hesta_Hesap_Id", conn);
                cmd.Parameters.AddWithValue("@Hesta_Hesap_Id", id);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    name = reader["Hasta_Ad"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hasta Name alirken bir hata ile karsilasildi" + ex.ToString());
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return name;
        }
        private void Btn_Kullanici_Hesap_SifremiU_Click(object sender, EventArgs e)
        {
            Hasta_Paneli_Sifremi_Unuttum_Form hasta_Paneli_SifremiU = new Hasta_Paneli_Sifremi_Unuttum_Form();
            hasta_Paneli_SifremiU.Show();
        }
        private void Btn_Kullanici_Hesap_HesapO_Click(object sender, EventArgs e)
        {
            Hasta_Paneli_Hesap_Olustur_From hasta_Paneli_HesapO = new Hasta_Paneli_Hesap_Olustur_From();
            hasta_Paneli_HesapO.Show();
        }
    }
}
