using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IEczacim
{
    public partial class Hasta_Paneli_Sifremi_Unuttum_Form : Form
    {
        public Hasta_Paneli_Sifremi_Unuttum_Form()
        {
            InitializeComponent();
        }

        SqlConnection conn;
        SqlCommand cmd;

        // girilen tc kimlik numarasinin tabloda olup olmadigini kontrol ettik
        public int Hastanin_Bilgisinin_Kontrolu(String Tc_Kimlik)
        {

            conn = new SqlConnection("Data Source=LAPTOP-5J9G4MFS\\SQLEXPRESS;Initial Catalog=IEczacim;Integrated Security=True");
            conn.Open();
            int hasta_mevcut;
            cmd = new SqlCommand("SELECT COUNT(*) FROM Tbl_Hasta_Hesaplar WHERE Hasta_TcNo=@Hasta_TcNo", conn);
            cmd.Parameters.AddWithValue("@Hasta_TcNo", Tc_Kimlik.ToString());
            int rowCount = (int)cmd.ExecuteScalar();
            if (rowCount > 0)
            {
                return hasta_mevcut = 1;
            }
            else
            {
                return hasta_mevcut = 0;
            }
                
        }
        private void Btn_Sifremi_Unuttum_Click(object sender, EventArgs e)
        {
            conn = null;
            try
            {
                conn = new SqlConnection("Data Source=LAPTOP-5J9G4MFS\\SQLEXPRESS;Initial Catalog=IEczacim;Integrated Security=True");
                conn.Open();

                if (HastaP_SifremiU_Tc_TxtB.Text != "" && HastaP_SifremiU_YeniSTekrar_TxtB.Text != "" && HastaP_SifremiU_YeniS_TxtB.Text != "")
                {
                    int Bu_Kullanici_Varmi = Hastanin_Bilgisinin_Kontrolu(HastaP_SifremiU_Tc_TxtB.Text.ToString());
                    if (Bu_Kullanici_Varmi==1)  // hasta mevcut
                    {
                        if (HastaP_SifremiU_YeniS_TxtB.Text == HastaP_SifremiU_YeniSTekrar_TxtB.Text)
                        {
                            cmd = new SqlCommand("UPDATE Tbl_Hasta_Hesaplar SET Sifre = @Sifre WHERE Hasta_TcNo = @Hasta_TcNo", conn);
                            cmd.Parameters.AddWithValue("@Sifre", HastaP_SifremiU_YeniS_TxtB.Text);
                            cmd.Parameters.AddWithValue("@Hasta_TcNo", HastaP_SifremiU_Tc_TxtB.Text);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Sifre Basarili bir sekilde guncellendi");
                        }
                        else
                        {
                            MessageBox.Show("Sifreler uyusmamakta Lutfen tekrar deneyiniz.");
                            HastaP_SifremiU_YeniSTekrar_TxtB.Text = "";
                            HastaP_SifremiU_YeniS_TxtB.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Boyle bir Hasta bununmamakta Lutfen Tekrar deneyiniz.");
                        HastaP_SifremiU_Tc_TxtB.Text = "";
                        HastaP_SifremiU_YeniSTekrar_TxtB.Text = "";
                        HastaP_SifremiU_YeniS_TxtB.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Lutfen bos bir alan birakmayiniz");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sifre degistirirken Bir hata ile karsilasildi." + ex.ToString());
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
