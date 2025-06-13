using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IEczacim
{
    public partial class Hasta_Paneli_Eczanelerim_Form : Form
    {
        public Hasta_Paneli_Eczanelerim_Form()
        {
            InitializeComponent();
        }
        SqlConnection conn = null;
        SqlDataAdapter adapter;
        SqlCommand cmd;
        DataTable dt;
        SqlDataReader reader;

        // Burada SP yardimi ile ilac bilgilerini dataGW' da listeledik
        public void Ilac_Bilgilerini_listele()
        {
            // Comb' ta secili olan veriyi sakla
            string selectedItem = comboBox1.SelectedItem.ToString();
            try
            {
                conn = new SqlConnection("Data Source=LAPTOP-5J9G4MFS\\SQLEXPRESS;Initial Catalog=IEczacim;Integrated Security=True");
                conn.Open();

                // SP' yi cagir
                cmd = new SqlCommand("SP_Ilac_Bilgilerini_Listele", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                // ComB' tan okudugun veriyi prametre olarak ver
                cmd.Parameters.Add("RECETE_ID", SqlDbType.Int).Value = Convert.ToInt32(selectedItem);
                // cmd' yi sqldataAdapter' a cevir
                adapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                dataGridView2.DataSource = dt;
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("sql sorgusunda bir hata ile karsilasildi" + ex.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        // Hastanin Recetesinde bulunan ilacari DataGW da listele
        public void Receteyi_Listele()
        {
            // Comb' ta secili olan veriyi bir degiskene ata
            string selectedItem = comboBox1.SelectedItem.ToString();
            try
            {
                conn = new SqlConnection("Data Source=LAPTOP-5J9G4MFS\\SQLEXPRESS;Initial Catalog=IEczacim;Integrated Security=True");
                conn.Open();
                adapter = new SqlDataAdapter("SELECT Ilac_ID AS [Ilac ID], Ilac_Adedi AS [Ilac Adedi] FROM Tbl_Hasta_Receteler WHERE Recete_Id = " + selectedItem + "", conn);
                dt = new DataTable();
                dataGridView3.DataSource = dt;
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("sql sorgusunda bir hata ile karsilasidi" + ex.Message);
            }
            finally
            { 
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        // Sisteme giris yapan hastanin adina tanimlanmis olan receteleri comb' a getir
        // Ve Bunu Bir SP yardimiyla gerceklestir
        public void Combox_Receteyi_Getir()
        {
            try
            {
                conn = new SqlConnection("Data Source=LAPTOP-5J9G4MFS\\SQLEXPRESS;Initial Catalog=IEczacim;Integrated Security=True");
                conn.Open();

                // StoredProcedure HASTANIN RECETELERINI COMBOBOX'A GETIR
                cmd = new SqlCommand("SP_HASTA_PANELI", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("HESAP_ID", SqlDbType.NVarChar, 50).Value = Hasta_Paneli_Home.Sistemde_girisi_olan_hasta_Id.ToString();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    comboBox1.Items.Add(reader["RECETELER"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sql sorgusunda bir hata ile karsilasildi" + ex.Message);
            }
            finally
            {
                if (conn != null) 
                {
                    conn.Close();
                }
            }
        }

        // Hastanin Eski Recetelerini dataGW' Da listele
        // Ve Bunu bir SP yardimiyla gerceklesitir.
        public void Eski_Recetelerimi_Listele()
        {
            string online = Hasta_Paneli_Home.Sistemde_girisi_olan_hasta_Id.ToString();
            try
            {
                conn = new SqlConnection("Data Source=LAPTOP-5J9G4MFS\\SQLEXPRESS;Initial Catalog=IEczacim;Integrated Security=True");
                conn.Open();

                // StoredProcedure HASTANIN ESKI RECETELERINI LISTELE
                cmd = new SqlCommand("SP_Eski_Recetelerini_Listele", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("hesap_id", SqlDbType.Int).Value = online.ToString();
                adapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("sql sorgusunda bir hata ile karsilasildi" + ex.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        // Fonk yuklendiginde gerekli fonksiyonlari cagir
        private void Hasta_Paneli_Eczanelerim_Form_Load(object sender, EventArgs e)
        {
            // burada sisteme girisi olan hastanin ismini from icindeki label' da yazdirdik.
            Label_Name_Login.Text = Hasta_Paneli_Home.Sistemde_girisi_olan_hasta_name.ToString();
            Eski_Recetelerimi_Listele();
            Combox_Receteyi_Getir();
        }

        // Hasta nin Comb' tan secmis oldugu ilac recete id sine gore
        // hastanin recetedeki ilaclar getirilecek
        // Ve Buna Ek olarak o ilaclarin kullanim talimatlarida olacaktir.
        private void Btn_Recete_Getir_Click(object sender, EventArgs e)
        {
            // ComboBox'ta secili bir oge var mı kontrol etme
            if (comboBox1.SelectedIndex != -1)
            {
                Receteyi_Listele();
                Ilac_Bilgilerini_listele();
            }
            else
            {
                MessageBox.Show("Lütfen bir seçenek seçin.");
            }
        }
    }
}
