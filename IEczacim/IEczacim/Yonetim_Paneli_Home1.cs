using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IEczacim
{
    public partial class Yonetim_Paneli_Home1 : Form
    {   
        
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader reader;
        public Yonetim_Paneli_Home1()
        {
            InitializeComponent();
        }
        public void Sifre_Degistir()
        {
            conn = null;
            try
            {
                conn = new SqlConnection("Data Source=LAPTOP-5J9G4MFS\\SQLEXPRESS;Initial Catalog=IEczacim;Integrated Security=True");
                conn.Open();
                string Kayit = "UPDATE Tbl_Yonetim_Paneli_Giris SET Sifre=@Sifre WHERE Kullanici_Adi='" + DegistirK_TxtBox.Text + "'";
                SqlCommand Guncelle = new SqlCommand(Kayit, conn);
                Guncelle.Parameters.AddWithValue("@Sifre", DegistirST_TxtBox.Text);
                Guncelle.ExecuteNonQuery();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sifre Degistieme hatasi" + ex.ToString());
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
        private void Btn_Yonetim_Paneli_Sifre_Kullanici_Adi_Degistirme_Click(object sender, EventArgs e)
        {
            if (DegistirS_TxtBox.Text == DegistirST_TxtBox.Text)
            {
                if (DegistirS_TxtBox.Text != "" && DegistirST_TxtBox.Text != "")
                {
                    Sifre_Degistir();
                    MessageBox.Show("Sifre basarili bir sekilde degistirildi.");
                }
                else
                {
                    MessageBox.Show("Alanlari Bos Birakmayi lutfen unutmayin");
                }
            }
            else
            {
                MessageBox.Show("Sifre Eslesmiyor lutfen tekrar deneyiniz.");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Yonetim_Paneli_Home1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Yonetim_Panlei_Ilaclar_Listesi_Form YonetimP_Ilaclar_Listesi = new Yonetim_Panlei_Ilaclar_Listesi_Form();
            YonetimP_Ilaclar_Listesi.Show();
        }

        private void Btn_YonetimPanleli_Eczaneler_Click(object sender, EventArgs e)
        {
            YonetimPameli_Eczaneler_From YonetimPaneliEczaneler = new YonetimPameli_Eczaneler_From();
            YonetimPaneliEczaneler.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Yonetim_Paneli_Receteler_Form yonetimP_Receteler = new Yonetim_Paneli_Receteler_Form();
            yonetimP_Receteler.Show();
        }
    }
}
