using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace IEczacim
{
    public partial class Yonetim_Paneli_Receteler_Form : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;
        DataSet ds;
        SqlDataReader reader;

        public Yonetim_Paneli_Receteler_Form()
        {
            InitializeComponent();
        }

        string Kaldirirlan_Recetenin_id;

        // VIEW KULLANILDI
        public void Receteleri_ComBox_Listele()
        {
            conn = null;
            try
            {
                conn = new SqlConnection("Data Source=LAPTOP-5J9G4MFS\\SQLEXPRESS;Initial Catalog=IEczacim;Integrated Security=True");
                conn.Open();
                cmd = new SqlCommand("SELECT * FROM VW_Receteleri_Combox_Getir", conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    comboBox1.Items.Add(reader["Recete_Id"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Verileri Veri tabanindan cekerkeb bir hata ile karsilasildi." + ex.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
        public void Hasta_Recetelerini_Listele(string Recete_id, DataGridView dataGridView)
        {
            conn = null;
            try
            {
                conn = new SqlConnection("Data Source=LAPTOP-5J9G4MFS\\SQLEXPRESS;Initial Catalog=IEczacim;Integrated Security=True");
                conn.Open();
                adapter = new SqlDataAdapter("SELECT Ilac_ID, Ilac_Adedi FROM Tbl_Hasta_Receteler WHERE Recete_Id = " + Recete_id + "", conn);
                dt = new DataTable();
                dataGridView.DataSource = dt;
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hesta rectelerini listelerken bir hata ile karsilasildi" + ex.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
        public void RecetedenIlacKaldir(string Recete_Id, string ilac_id)
        {
            conn = null;
            try
            {
                conn = new SqlConnection("Data Source=LAPTOP-5J9G4MFS\\SQLEXPRESS;Initial Catalog=IEczacim;Integrated Security=True");
                conn.Open();
                cmd = new SqlCommand("DELETE FROM Tbl_Hasta_Receteler WHERE Recete_Id = @Recete_Id AND Ilac_ID = @Ilac_ID", conn);
                cmd.Parameters.AddWithValue("@Ilac_ID", ilac_id);
                cmd.Parameters.AddWithValue("@Recete_Id", Recete_Id);
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Kayıt başarıyla silindi.");
                }
                else
                {
                    MessageBox.Show("Silme işlemi başarısız. Belirtilen kriterlere uygun kayıt bulunamadı.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Receteden ilac kaldirirken bit hata ile karsilasildi." + ex.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
        public void ReceteyeIlacEkle(string Recete_Id, string ilac_id, string Ilac_Adedi)
        {
            conn = null;
            try
            {
                conn = new SqlConnection("Data Source=LAPTOP-5J9G4MFS\\SQLEXPRESS;Initial Catalog=IEczacim;Integrated Security=True");
                conn.Open();
                cmd = new SqlCommand("INSERT INTO Tbl_Hasta_Receteler (Recete_Id, Ilac_ID, Ilac_Adedi) VALUES (@Recete_Id, @Ilac_ID, @Ilac_Adedi)", conn);
                cmd.Parameters.AddWithValue("@Recete_Id", Recete_Id);
                cmd.Parameters.AddWithValue("@Ilac_Id", ilac_id);
                cmd.Parameters.AddWithValue("@Ilac_Adedi", Ilac_Adedi);
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Ilac başarıyla Eklendi.");
                }
                else
                {
                    MessageBox.Show("Ekleme işlemi başarısız. Belirtilen kriterlere uygun kayıt bulunamadı.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Receteye Ilac Eklerken Bir Hata ile karsilasildi" + ex.Message);
            }
            finally 
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
        // Recetedeki ilaclari ve ilac adetlerini data gird view'a getirdik.
        public void LoadData(string Recete_id)
        {
            conn = null;
            try
            {
                conn = new SqlConnection("Data Source=LAPTOP-5J9G4MFS\\SQLEXPRESS;Initial Catalog=IEczacim;Integrated Security=True");
                conn.Open();
                adapter = new SqlDataAdapter("SELECT Ilac_ID, Ilac_Adedi FROM Tbl_Hasta_Receteler WHERE Recete_Id = " + Recete_id + "", conn);
                // Veri setini temizle
                ds = new DataSet();
                adapter.Fill(ds);
                // DataGridView'e verileri bağla
                dataGridView2.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dategridview'de verileri listelerken bir hata ile karsilasildi" + ex.Message);
            }
            finally
            {
                // Bağlantıyı kapat
                if (conn != null && conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
        public void Receteleri_LIstele(string Tbl_name, DataGridView dataGridView)
        {
            
            conn = null;
            try
            {
                conn = new SqlConnection("Data Source=LAPTOP-5J9G4MFS\\SQLEXPRESS;Initial Catalog=IEczacim;Integrated Security=True");
                conn.Open();
                adapter = new SqlDataAdapter("SELECT * FROM " + Tbl_name + "", conn);
                dt = new DataTable();
                dataGridView.DataSource = dt;
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Verileri listelerken bir hata cikti " + ex.ToString());
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
        private void Yonetim_Paneli_Receteler_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iEczacimDataSet13.Tbl_Receteler' table. You can move, or remove it, as needed.
            this.tbl_RecetelerTableAdapter1.Fill(this.iEczacimDataSet13.Tbl_Receteler);
            // TODO: This line of code loads data into the 'iEczacimDataSet11.Tbl_Ilaclar' table. You can move, or remove it, as needed.
            this.tbl_IlaclarTableAdapter.Fill(this.iEczacimDataSet11.Tbl_Ilaclar);
            // verlileri combox' a getir.
            Receteleri_ComBox_Listele();
            conn = null;
            try
            {
                conn = new SqlConnection("Data Source=LAPTOP-5J9G4MFS\\SQLEXPRESS;Initial Catalog=IEczacim;Integrated Security=True");
                conn.Open();
                adapter = new SqlDataAdapter("SELECT Ilac_ID, Ilac_Name FROM Tbl_Ilaclar", conn);
                // Veri setini temizle
                ds = new DataSet();
                adapter.Fill(ds);
                // DataGridView'e verileri bağla
                dataGridView3.DataSource = ds.Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show("ilac tablosunu datagridview3'e getirirken bir hata ile karsilasildi" + ex.Message);
            }
            finally
            {
                // Bağlantıyı kapat
                if (conn != null && conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
        public void Recete_Kaldir()
        {
            conn = null;
            try
            {
                conn = new SqlConnection("Data Source=LAPTOP-5J9G4MFS\\SQLEXPRESS;Initial Catalog=IEczacim;Integrated Security=True");
                conn.Open();
                cmd = new SqlCommand("DELETE FROM Tbl_Receteler WHERE Recete_Id = @Recete_Id", conn);
                cmd.Parameters.AddWithValue("@Recete_Id", Kaldirirlan_Recetenin_id);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("recete silerken bir hata ile karsilasildi" + ex.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
        public void Recete_Ekle()
        {
            conn = null;
            DateTime secilenTarih = dateTimePicker1.Value;
            string Recete_Durumu = "0";   // recete henuz eczaneye gitmedigi icin default olarak 0
            try
            {
                conn = new SqlConnection("Data Source=LAPTOP-5J9G4MFS\\SQLEXPRESS;Initial Catalog=IEczacim;Integrated Security=True");
                conn.Open();

                cmd = new SqlCommand("SP_Yonetim_Recete_Ek", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("Recete_Tarigi",SqlDbType.Date).Value = secilenTarih;
                cmd.Parameters.Add("Hasta_Tc_KimlikNo",SqlDbType.NChar, 11).Value =  REkle_Hasta_Tc_TxtB.Text.ToString();
                cmd.Parameters.Add("Eczane_Vergi_No",SqlDbType.NChar, 10).Value = REkle_EczaneVN_TxtB.Text.ToString();
                cmd.Parameters.Add("Recete_Durumu",SqlDbType.NChar, 2).Value = Recete_Durumu;

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Recete eklenirken bir hata ile karsilasildi" + ex.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        private void Btn_Recete_Ekle_Click(object sender, EventArgs e)
        {
            Recete_Ekle();
            MessageBox.Show("Recete Basarili bir sekilde Eklendi");
            Receteleri_LIstele("Tbl_Receteler", dataGridView1);
            Receteleri_ComBox_Listele();

            // sayfayi yenile
            this.Controls.Clear();
            this.InitializeComponent();

            // TODO: This line of code loads data into the 'iEczacimDataSet13.Tbl_Receteler' table. You can move, or remove it, as needed.
            this.tbl_RecetelerTableAdapter1.Fill(this.iEczacimDataSet13.Tbl_Receteler);
            // TODO: This line of code loads data into the 'iEczacimDataSet11.Tbl_Ilaclar' table. You can move, or remove it, as needed.
            this.tbl_IlaclarTableAdapter.Fill(this.iEczacimDataSet11.Tbl_Ilaclar);
            // verlileri combox' a getir.
            Receteleri_ComBox_Listele();

            conn = null;
            try
            {
                conn = new SqlConnection("Data Source=LAPTOP-5J9G4MFS\\SQLEXPRESS;Initial Catalog=IEczacim;Integrated Security=True");
                conn.Open();
                adapter = new SqlDataAdapter("SELECT Ilac_ID, Ilac_Name FROM Tbl_Ilaclar", conn);
                // Veri setini temizle
                ds = new DataSet();
                adapter.Fill(ds);
                // DataGridView'e verileri bağla
                dataGridView3.DataSource = ds.Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show("ilac tablosunu datagridview3'e getirirken bir hata ile karsilasildi" + ex.Message);
            }
            finally
            {
                // Bağlantıyı kapat
                if (conn != null && conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
        private void Btn_Receteye_ilac_ekle_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem != null && comboBox1.SelectedItem != null && IlacID_txtB.Text.ToString() != "")
            {
                string Recete_id = comboBox1.SelectedItem.ToString();
                string ilac_id = IlacID_txtB.Text;
                string Ilac_Adedi = comboBox2.SelectedItem.ToString();
                ReceteyeIlacEkle(Recete_id, ilac_id, Ilac_Adedi);
                Hasta_Recetelerini_Listele(Recete_id, dataGridView2);
            }
            else
            {
                MessageBox.Show("Lütfen bir öğe seçin.\n Ve bos bir alan birakmayiniz.");

            }
        }

        private void Btn_Recete_Getir_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                string seciliVeri = comboBox1.SelectedItem.ToString();
                LoadData(seciliVeri);
            }
            else
            {
                MessageBox.Show("Lütfen bir öğe seçin.");
            }
        }

        private void Btn_Receteden_Ilac_Kaldir_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null && IlacID_txtB.Text.ToString() != "")
            {
                string Recete_id = comboBox1.SelectedItem.ToString();
                string ilac_id = IlacID_txtB.Text.ToString();
                RecetedenIlacKaldir(Recete_id, ilac_id);
                Hasta_Recetelerini_Listele(Recete_id, dataGridView2);
            }
            

        }
        private void Btn_Recete_Kaldir_Click(object sender, EventArgs e)
        {
            Kaldirirlan_Recetenin_id = Recete_kaldir_ReceteId_txtb.Text.ToString();
            Recete_Kaldir();
            MessageBox.Show("Recete basarili bir sekilde kaldirildi");
            Receteleri_LIstele("Tbl_Receteler", dataGridView1);

            // sayfayi yenile
            this.Controls.Clear();
            this.InitializeComponent();

            // TODO: This line of code loads data into the 'iEczacimDataSet13.Tbl_Receteler' table. You can move, or remove it, as needed.
            this.tbl_RecetelerTableAdapter1.Fill(this.iEczacimDataSet13.Tbl_Receteler);
            // TODO: This line of code loads data into the 'iEczacimDataSet11.Tbl_Ilaclar' table. You can move, or remove it, as needed.
            this.tbl_IlaclarTableAdapter.Fill(this.iEczacimDataSet11.Tbl_Ilaclar);
            // verlileri combox' a getir.
            Receteleri_ComBox_Listele();

            // BURADA VIEW KULLANILDI
            conn = null;
            try
            {
                conn = new SqlConnection("Data Source=LAPTOP-5J9G4MFS\\SQLEXPRESS;Initial Catalog=IEczacim;Integrated Security=True");
                conn.Open();
                adapter = new SqlDataAdapter("SELECT * FROM VW_Eczadeposundaki_Ilaclari_listele", conn);
                // Veri setini temizle
                ds = new DataSet();
                adapter.Fill(ds);
                // DataGridView'e verileri bağla
                dataGridView3.DataSource = ds.Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show("ilac tablosunu datagridview3'e getirirken bir hata ile karsilasildi" + ex.Message);
            }
            finally
            {
                // Bağlantıyı kapat
                if (conn != null && conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
    }
}
