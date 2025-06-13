using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IEczacim
{
    public partial class Ilac_Stok_Yonetimi_Form : Form
    {
        SqlConnection conn = null;
        SqlCommand cmd;
        SqlDataReader reader;
        SqlDataAdapter adapter;
        DataTable dt;

        string Online_olan_Eczane = Eczane_Paneli_Home.Sistemde_girisi_Olan_Eczane;
        string Online_olan_Eczane_id = Eczane_Paneli_Home.Eczaci_Vergi_NO.ToString();
        string Stok_Miktari;
        public Ilac_Stok_Yonetimi_Form()
        {
            InitializeComponent();
        }
        int yeni_stok_miktari;
        string seciliVeri;

        // Eczanede mevcut olmayan ilaci eczaneye al
        public void Eczaneye_Ilac_Al(string Ilac_Id)
        {
            try
            {
                conn = new SqlConnection("Data Source=LAPTOP-5J9G4MFS\\SQLEXPRESS;Initial Catalog=IEczacim;Integrated Security=True");
                conn.Open();
                cmd = new SqlCommand("INSERT INTO Tbl_Eczane_Ilaclar (Ilac_ID, Eczane_Vergi_No, Stok_Miktari) VALUES (@Ilac_ID, @Eczane_Vergi_No, @Stok_Miktari)", conn);
                cmd.Parameters.AddWithValue("@Ilac_ID", Ilac_Id);
                cmd.Parameters.AddWithValue("@Eczane_Vergi_No", Online_olan_Eczane_id);
                cmd.Parameters.AddWithValue("@Stok_Miktari", TxtB_Ilac_Al.Text.ToString());
                int affectedRows = cmd.ExecuteNonQuery();

                if (affectedRows > 0)
                {
                    MessageBox.Show("Ilac basarili bir sekilde alindi");
                }
                else
                {
                    MessageBox.Show("Ilac alirken bir hata ile karsilasildi");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Verileri alirken bir hata ile karsilasildi" + ex.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        public void Eczanede_Bulunmayan_ComBox_Ilaclari_Getir(ComboBox comboBox)
        {
            try
            {
                conn = new SqlConnection("Data Source=LAPTOP-5J9G4MFS\\SQLEXPRESS;Initial Catalog=IEczacim;Integrated Security=True");
                conn.Open();
                cmd = new SqlCommand("SELECT Ilac_ID FROM Tbl_Ilaclar WHERE Ilac_ID NOT IN (SELECT Ilac_ID FROM Tbl_Eczane_Ilaclar WHERE Eczane_Vergi_No = @Eczane_Vergi_No)", conn);
                cmd.Parameters.AddWithValue("@Eczane_Vergi_No", Online_olan_Eczane_id);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    comboBox.Items.Add(reader["Ilac_ID"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Verileri cekerken bir hata ile karsilasildi" + ex.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        public void Stok_Miktari_Guncelle()
        {
            if (comboBox3.SelectedItem != null)
            {
                seciliVeri = comboBox3.SelectedItem.ToString();
                Stok_Miktari_Sorgula(seciliVeri);
                yeni_stok_miktari = Convert.ToInt32(Stok_Miktari) + Convert.ToInt32(TxtBStok_Adet.Text);
            }
            else
            {
                MessageBox.Show("Lütfen bir öğe seçin.");
            }
            try
            {
                conn = new SqlConnection("Data Source=LAPTOP-5J9G4MFS\\SQLEXPRESS;Initial Catalog=IEczacim;Integrated Security=True");
                conn.Open();
                cmd = new SqlCommand("UPDATE Tbl_Eczane_Ilaclar SET Stok_Miktari = @Stok_Miktari WHERE Eczane_Vergi_No = @Eczane_Vergi_No AND Ilac_ID = @Ilac_ID", conn);
                cmd.Parameters.AddWithValue("@Stok_Miktari", yeni_stok_miktari.ToString());
                cmd.Parameters.AddWithValue("@Eczane_Vergi_No", Online_olan_Eczane_id.ToString());
                cmd.Parameters.AddWithValue("@Ilac_ID", seciliVeri);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri tabanindan veri cekerken bir hata ile karsilsildi." + ex.Message); 
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
        public void ComBox_Ilaclari_Getir(ComboBox comboBox)
        {
            try
            {
                conn = new SqlConnection("Data Source=LAPTOP-5J9G4MFS\\SQLEXPRESS;Initial Catalog=IEczacim;Integrated Security=True");
                conn.Open();
                cmd = new SqlCommand("SELECT Ilac_ID FROM Tbl_Eczane_Ilaclar WHERE Eczane_Vergi_No = @Eczane_Vergi_No", conn);
                cmd.Parameters.AddWithValue("@Eczane_Vergi_No", Online_olan_Eczane_id);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    comboBox.Items.Add(reader["Ilac_ID"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sql Veri cekmede bir hata ile karsilasildi " + ex.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        // Stok Miktari Sorgula
        // BUrada fonksiyon kullanildi.
        public void Stok_Miktari_Sorgula(string SeciliVeri)
        {
            try
            {
                conn = new SqlConnection("Data Source=LAPTOP-5J9G4MFS\\SQLEXPRESS;Initial Catalog=IEczacim;Integrated Security=True");
                conn.Open();
                cmd = new SqlCommand("SELECT dbo.StokMiktariGetir(@Ilac_ID, @Eczane_Vergi_No) AS StokMiktari", conn);
                cmd.Parameters.AddWithValue("@Ilac_ID", SeciliVeri);
                cmd.Parameters.AddWithValue("@Eczane_Vergi_No", Online_olan_Eczane_id);
                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    Stok_Miktari = result.ToString();
                    MessageBox.Show("Eczanedeki ilac Miktari = " + Stok_Miktari.ToString());
                }
                else
                {
                    MessageBox.Show("Bir hata ile karsilasildi");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri tabani sorgusunda bir hata ile karsilasildi" + ex.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        // su anda eczanede bulunan ilaclari listele
        public void Eczanede_Bulunan_Ilaclari_DataGV_Getir()
        {
            try
            {
                conn = new SqlConnection("Data Source=LAPTOP-5J9G4MFS\\SQLEXPRESS;Initial Catalog=IEczacim;Integrated Security=True");
                conn.Open();
                // SP_Eczanedeki_Ilaclari_Listeler SP
                cmd = new SqlCommand("SP_Eczanedeki_Ilaclari_Listeler", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("EczaneVergiNo", SqlDbType.VarChar, 50).Value = Eczane_Paneli_Home.Eczaci_Vergi_NO.ToString();
                adapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                dataGridView2.DataSource = dt;
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri Tabanindan Veri Alirken bir hata ile karsilasildi" + ex.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        // ecza deposunda bulunan ilaclari data grid view' da listele
        public void Ecza_Deposunda_Bulunan_Ilaclari_DataGV_Getir()
        {
            try
            {
                conn = new SqlConnection("Data Source=LAPTOP-5J9G4MFS\\SQLEXPRESS;Initial Catalog=IEczacim;Integrated Security=True");
                conn.Open();
                adapter = new SqlDataAdapter("SELECT Ilac_ID AS [ILAC ID], Ilac_Name AS [ILAC ADI], Ilac_Price AS [ILAC FIYATI], Gunde_Kac_Defa AS [GUNDE KAC DEFA], Ac_Tok AS [AC/TOK], Kac_Gunde_BItecek AS [KAC GUNDE BITECEK] FROM Tbl_Ilaclar", conn);
                dt = new DataTable();
                dataGridView1.DataSource = dt;
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri Tabanindan Veri Alirken bir hata ile karsilasildi" + ex.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
        private void Ilac_Stok_Yonetimi_Form_Load(object sender, EventArgs e)
        {
            // Eczane ismini Getir
            Ilac_Stok_Eczane_Adi.Text = Online_olan_Eczane.ToString();
            // Ecza deposunda bulunan ilaclari datagridview' da listele icin kullanilan fonksiyon 
            Ecza_Deposunda_Bulunan_Ilaclari_DataGV_Getir();
            Eczanede_Bulunan_Ilaclari_DataGV_Getir();

            // Veri leri comBox listele
            ComBox_Ilaclari_Getir(comboBox1);
            ComBox_Ilaclari_Getir(comboBox3);
            Eczanede_Bulunmayan_ComBox_Ilaclari_Getir(comboBox2);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                string seciliVeri = comboBox1.SelectedItem.ToString();
                Stok_Miktari_Sorgula(seciliVeri);
            }
            else
            {
                MessageBox.Show("Lütfen bir öğe seçin.");
            }
        }

        // eczanede bulunan ilaci' tan satin almak icin
        private void button2_Click(object sender, EventArgs e)
        {
            Stok_Miktari_Guncelle();
            MessageBox.Show("Ilacin Fiyati basarili bir sekilde gincellendi");
            Eczanede_Bulunan_Ilaclari_DataGV_Getir();
        }


        // Eczanede olmayan ilaclari eczaneye almak icin
        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem != null && TxtB_Ilac_Al.Text != "")
            {
                string seciliVeri = comboBox2.SelectedItem.ToString();
                Eczaneye_Ilac_Al(seciliVeri);
                Eczanede_Bulunan_Ilaclari_DataGV_Getir();

                // Sayfayi Yenile
                this.Controls.Clear();
                this.InitializeComponent();

                // Eczane ismini Getir
                Ilac_Stok_Eczane_Adi.Text = Online_olan_Eczane.ToString();
                // Ecza deposunda bulunan ilaclari datagridview' da listele icin kullanilan fonksiyon 
                Ecza_Deposunda_Bulunan_Ilaclari_DataGV_Getir();
                Eczanede_Bulunan_Ilaclari_DataGV_Getir();

                // Veri leri comBox listele
                ComBox_Ilaclari_Getir(comboBox1);
                ComBox_Ilaclari_Getir(comboBox3);
                Eczanede_Bulunmayan_ComBox_Ilaclari_Getir(comboBox2);
            }
            else
            {
                MessageBox.Show("Lütfen bir öğe seçin.");
            }
        }
    }
}
