using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IEczacim
{
    public partial class YonetimPameli_Eczaneler_From : Form
    {

        public YonetimPameli_Eczaneler_From()
        {
            InitializeComponent();
        }
        SqlConnection conn;
        SqlCommand cmd;
        DataTable dt;
        SqlDataAdapter adapter;

        public void Verileri_Listele()
        {
            conn = null;
            try
            {
                conn = new SqlConnection("Data Source=LAPTOP-5J9G4MFS\\SQLEXPRESS;Initial Catalog=IEczacim;Integrated Security=True");
                conn.Open();
                adapter = new SqlDataAdapter("SELECT * FROM Tbl_Eczaneler", conn);
                dt = new DataTable();
                dataGridView1.DataSource = dt;
                adapter.Fill(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Verileri listelerken bir hata cikti" + ex.ToString());
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
        public void Eczane_Kaldir()
        {
            conn = null;
            try
            {
                conn = new SqlConnection("Data Source=LAPTOP-5J9G4MFS\\SQLEXPRESS;Initial Catalog=IEczacim;Integrated Security=True");
                conn.Open();
                cmd = new SqlCommand("DELETE FROM Tbl_Eczaneler WHERE Eczane_Vergi_No=@Eczane_Vergi_No", conn);
                cmd.Parameters.AddWithValue("@Eczane_Vergi_No", TextBox_EczaneKaldır_VergıNo.Text);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("eczane Kaldiriken bir hata olustu." + ex.ToString());

            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
        public void Eczane_Ekle()
        {
            conn = null;
            try
            {
                conn = new SqlConnection("Data Source=LAPTOP-5J9G4MFS\\SQLEXPRESS;Initial Catalog=IEczacim;Integrated Security=True");
                conn.Open();
                cmd = new SqlCommand("INSERT INTO Tbl_Eczaneler(Eczane_Vergi_No, Sifre, Eczane_Adi, Satis_Miktari) VALUES (@Eczane_Vergi_No, @Sifre, @Eczane_Adi, 0)", conn);
                cmd.Parameters.AddWithValue("@Eczane_Vergi_No", TextBox_EczaneEkle_VergıNo.Text);
                cmd.Parameters.AddWithValue("@Sifre", TextBox_Sıfre.Text);
                cmd.Parameters.AddWithValue("@Eczane_Adi", TextBox_EczaneAdı.Text);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eczane eklerken bir hata ile karsilasildi." + ex.ToString());
            }
            finally
            {
                if (conn != null){
                    conn.Close();
                }
            }
        }
        private void YonetimPameli_Eczaneler_From_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iEczacimDataSet8.Tbl_Eczaneler' table. You can move, or remove it, as needed.
            this.tbl_EczanelerTableAdapter1.Fill(this.iEczacimDataSet8.Tbl_Eczaneler);
            // TODO: This line of code loads data into the 'iEczacimDataSet7.Tbl_Eczaneler' table. You can move, or remove it, as needed.
            this.tbl_EczanelerTableAdapter.Fill(this.iEczacimDataSet7.Tbl_Eczaneler);

        }

        private void Btn_Eczane_Ekle_Click(object sender, EventArgs e)
        {
            

            if (TextBox_EczaneEkle_VergıNo.Text != "" && TextBox_EczaneAdı.Text != "" && TextBox_Sıfre.Text != "")
            {
                Eczane_Ekle();
                Verileri_Listele();
                
                TextBox_EczaneEkle_VergıNo.Text = "";
                TextBox_EczaneAdı.Text = "";
                TextBox_Sıfre.Text = "";
                
                MessageBox.Show("Eczane basarili bir sekilde eklendi");
            }
            else
            {
                MessageBox.Show("Lufren Bos Bir alan birakmayiniz");
            }
        }

        private void Btn_Eczane_Kaldir_Click(object sender, EventArgs e)
        {
            if (TextBox_Eczane_Kaldir_Eczane_Adi.Text != "" && TextBox_EczaneKaldır_VergıNo.Text != "")
            {
                Eczane_Kaldir();
                Verileri_Listele();
                MessageBox.Show("Eczane basari bir sekilde kaldirildi");
                
            }
            else
            {
                MessageBox.Show("Lutfen bos bir alan birakmayiniz.");
            }
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
