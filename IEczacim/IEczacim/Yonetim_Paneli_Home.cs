using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IEczacim
{
    public partial class Yonetim_Paneli_Home : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader reader;
        public Yonetim_Paneli_Home()
        {
            InitializeComponent();
        }

        private void Yonetim_Paneli_Home_Load(object sender, EventArgs e)
        {

        }

        public void Btn_YonetimP_Giris_Click(object sender, EventArgs e)
        {

            conn = null;

            try
            { 
                int Kullanici_Adi = Convert.ToInt32(Kullanici_Adi_Text.Text);
                int sifre = Convert.ToInt32(Sifre_Text.Text);

                conn = new SqlConnection("Data Source=LAPTOP-5J9G4MFS\\SQLEXPRESS;Initial Catalog=IEczacim;Integrated Security=True");
                conn.Open();
                cmd = new SqlCommand("SELECT Kullanici_Adi, Sifre FROM Tbl_Yonetim_Paneli_Giris", conn);
                reader = cmd.ExecuteReader();
                
                while (reader.Read())
                {

                    if (Kullanici_Adi == Convert.ToInt32(reader[0]) && sifre == Convert.ToInt32(reader[1].ToString()))
                    {
                        Yonetim_Paneli_Home1 yonetimP_Home1 = new Yonetim_Paneli_Home1();
                        yonetimP_Home1.Show();
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Kulanic Adi veya Sifre Yanlis");
                        break;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("gecersiz Karakter" + ex.ToString());
            }
            finally 
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
    }
    
}
