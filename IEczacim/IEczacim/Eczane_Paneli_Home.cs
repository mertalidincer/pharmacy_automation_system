using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IEczacim
{
    public partial class Eczane_Paneli_Home : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader reader;
        public Eczane_Paneli_Home()
        {
            InitializeComponent();
        }

        
        public static string Eczaci_Vergi_NO; // giris dogrulamak ve orurum acmak icin eczacidan alinacak olan verigi numarasi
        string Eczaci_Sifre;    // giris dogrulamak icin eczacidan alinacak olan sifre
        public static string Sistemde_girisi_Olan_Eczane; // Sistemde hangi eczanenin aktif oldugunu saptama icin
        int basarili; // giris kontrol
        public int Kullanic_kontrol()
        {
            conn = null;
            basarili = -1;
            try
            {
                // TextBox' lar daki verileri al
                Eczaci_Vergi_NO = Eczaci_Kullanici_Adi_TextBox.Text.ToString();
                Eczaci_Sifre = Eczaci_Sifre_TextBox.Text.ToString();

                conn = new SqlConnection("Data Source=LAPTOP-5J9G4MFS\\SQLEXPRESS;Initial Catalog=IEczacim;Integrated Security=True");
                conn.Open();
                cmd = new SqlCommand("SELECT Eczane_Vergi_No, Sifre, Eczane_Adi  FROM Tbl_Eczaneler", conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    // textbox' tan alinan verilerin karsilastirilmasi
                    if (Eczaci_Vergi_NO == reader["Eczane_Vergi_No"].ToString() && Eczaci_Sifre == reader["Sifre"].ToString())
                    {
                        Sistemde_girisi_Olan_Eczane = reader["Eczane_Adi"].ToString();    // sisteme giris yapan hastanin id bilgisi tutuldi
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
        public void button1_Click(object sender, EventArgs e)
        {

            // textbaoxlarin bos olup olmadigini kontrol et
            if (Eczaci_Kullanici_Adi_TextBox.Text != "" && Eczaci_Sifre_TextBox.Text != "")
            {
                // sifre ve kullanici adinin dogrulugunu kontrol et 
                if (Kullanic_kontrol() == 1)
                {
                    // sistem girisi basarili bunun soncunda yeni form ac
                    Eczane_Paneli_Home1_Form EczaneP_Home1_From = new Eczane_Paneli_Home1_Form();
                    EczaneP_Home1_From.Show();
                    // sisteme girisi olan eczanenin textbox sa ismini getir
                    EczaneP_Home1_From.Eczane_Name.Text = Sistemde_girisi_Olan_Eczane.ToString();

                    Ilac_Stok_Yonetimi_Form ılacS_Yonetimi_Form = new Ilac_Stok_Yonetimi_Form();
                    ılacS_Yonetimi_Form.Ilac_Stok_Eczane_Adi.Text = Sistemde_girisi_Olan_Eczane.ToString();
                }
                else
                {
                    MessageBox.Show("Sifre veya kullanici adi hatali.\nLutfen tekrar deneyiniz.");

                }
            }
            else
            {
                MessageBox.Show("Lufen bos bir alan birakmayiniz.");
            }
        }
        private void Eczane_Name_Label_Click(object sender, EventArgs e)
        {

        }

        private void Eczane_Paneli_Home_Load(object sender, EventArgs e)
        {

        }
    }
}
