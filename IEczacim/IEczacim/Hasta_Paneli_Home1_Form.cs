using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IEczacim
{
    public partial class Hasta_Paneli_Home1_Form : Form
    {
        public Hasta_Paneli_Home1_Form()
        {
            InitializeComponent();
        }

        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader reader;
        
        // SP yardimiyla hastanin kisisel bilgilerinin lable' lara getirilmesi
        private void Hasta_Paneli_Home1_Form_Load(object sender, EventArgs e)
        {
            conn = null;
            try
            {
                conn = new SqlConnection("Data Source=LAPTOP-5J9G4MFS\\SQLEXPRESS;Initial Catalog=IEczacim;Integrated Security=True");
                conn.Open();

                // StoredProcedure HASTA BILGILERINI HASTA HOME PANLINE GETIR
                cmd = new SqlCommand("SP_Hasta_Paneli_Hasta_Bilgileri", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("Hesta_Hesap_Id", SqlDbType.NVarChar, 50).Value = Hasta_Paneli_Home.Sistemde_girisi_olan_hasta_Id;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Label_Ad.Text = reader["AD"].ToString();
                    Label_Tc_kimlik_No.Text = reader["TC"].ToString();
                    Label_Soyad.Text = reader["SOYAD"].ToString();
                    Label_Dogum_yeri.Text = reader["SEHIR"].ToString();
                    Label_Dogum_Tarigi.Text = reader["TARIH"].ToString();
                    Label_Sigorta_Durumu.Text = reader["SIGORTA"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hasta bilgilerini alirken bir hata ile karsilasildi." + ex.ToString());
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Hasta_Paneli_Eczanelerim_Form hastaPaneliEczanelerim = new Hasta_Paneli_Eczanelerim_Form();
            hastaPaneliEczanelerim.Show();
        }
    }
}
