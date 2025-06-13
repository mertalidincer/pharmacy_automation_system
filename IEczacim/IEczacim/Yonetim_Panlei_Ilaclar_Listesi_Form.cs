using System;
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
    public partial class Yonetim_Panlei_Ilaclar_Listesi_Form : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;
        

        public void Ilac_Kaldir()
        {
            conn = null;
            
            try 
            {
                conn = new SqlConnection("Data Source=LAPTOP-5J9G4MFS\\SQLEXPRESS;Initial Catalog=IEczacim;Integrated Security=True");
                conn.Open();
                cmd = new SqlCommand("DELETE FROM Tbl_Ilaclar WHERE Ilac_ID=@Ilac_ID", conn);
                cmd.Parameters.AddWithValue("@Ilac_ID", TextBox_ilacKladir_Ilac_Id.Text);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex) 
            {
                MessageBox.Show("Ilac kaldirirken bir hata ile karsilasildi." + ex.ToString());
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
        public void Ilac_Fiyati_Guncelle()
        {
            conn = null;
            try
            {
                conn = new SqlConnection("Data Source=LAPTOP-5J9G4MFS\\SQLEXPRESS;Initial Catalog=IEczacim;Integrated Security=True");
                conn.Open();
                cmd = new SqlCommand("UPDATE Tbl_Ilaclar SET Ilac_Price=@ilac_Price WHERE Ilac_ID=@Ilac_ID", conn);
                cmd.Parameters.AddWithValue("@ilac_Price", TextBox_FiyatDegistir_YeniFiyat.Text);
                cmd.Parameters.AddWithValue("@Ilac_ID", TextB_FiyatDegistir_IlacID.Text);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Fiyatlari guncellestirirken bir hata cikri" + ex.ToString());
            }
            finally 
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
        public void Ilac_Ekle()
        {
            conn = null;
            
            try
            {
                conn = new SqlConnection("Data Source=LAPTOP-5J9G4MFS\\SQLEXPRESS;Initial Catalog=IEczacim;Integrated Security=True");
                conn.Open();
                cmd = new SqlCommand("INSERT INTO Tbl_Ilaclar(Ilac_Name, Ilac_Price, Gunde_Kac_Defa, Ac_Tok, Kac_Gunde_BItecek) VALUES (@Ilac_Name, @Ilac_Price, @Gunde_Kac_Defa, @Ac_Tok, @Kac_Gunde_BItecek)", conn);
                cmd.Parameters.AddWithValue("@Ilac_Name", TextBox_Ilacin_Adi.Text);
                cmd.Parameters.AddWithValue("@Ilac_Price", TextBox_Ilacin_Fiyati.Text);
                cmd.Parameters.AddWithValue("@Gunde_Kac_Defa", TextBox_KullanimS.Text);
                cmd.Parameters.AddWithValue("@Ac_Tok", TextBox_AcTok.Text);
                cmd.Parameters.AddWithValue("@Kac_Gunde_BItecek", TextBox_KacGundeB.Text);
                cmd.ExecuteNonQuery();
               

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ilac ekleme islmi yapraken bir sorun ile karsilasildi" + ex.ToString());
            }
            finally 
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
        public void Ilaclari_LIstele()
        {
            conn = null;
    
            try
            {
                conn = new SqlConnection("Data Source=LAPTOP-5J9G4MFS\\SQLEXPRESS;Initial Catalog=IEczacim;Integrated Security=True");
                conn.Open();
                adapter = new SqlDataAdapter("SELECT * FROM Tbl_Ilaclar", conn);
                dt = new DataTable();
                dataGridView1.DataSource = dt;
                adapter.Fill(dt);

            }
            catch (Exception ex)
            {   
                MessageBox.Show ("Verileri listelerken bir hata cikti " + ex.ToString());
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
        public Yonetim_Panlei_Ilaclar_Listesi_Form()
        {
            InitializeComponent();
        }

        private void Yonetim_Panlei_Ilaclar_Listesi_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iEczacimDataSet6.Tbl_Ilaclar' table. You can move, or remove it, as needed.
            this.tbl_IlaclarTableAdapter4.Fill(this.iEczacimDataSet6.Tbl_Ilaclar);

        }

        
        private void Btn_Ilac_Ekle_Click(object sender, EventArgs e)
        {

            if (TextBox_Ilacin_Adi.Text != "" && TextBox_AcTok.Text != "" && TextBox_Ilacin_Fiyati.Text != "" && TextBox_KacGundeB.Text != "" && TextBox_KullanimS.Text != "")
            {
                Ilac_Ekle();
                Ilaclari_LIstele();
                MessageBox.Show("Ilac Basarili bir sekilde eklendi");
                TextBox_Ilacin_Adi.Text = "";
                TextBox_AcTok.Text = "";
                TextBox_Ilacin_Fiyati.Text = "";
                TextBox_KacGundeB.Text = "";
                TextBox_KullanimS.Text = "";
            }
            else
            {
                MessageBox.Show("Lufen bos bir alan birakmayiniz.");
            }
        }

        private void Btn_Fiyat_Guncelle_Click(object sender, EventArgs e)
        {
            if (TextB_FiyatDegistir_IlacID.Text != "" && TextBox_FiyatDegistir_YeniFiyat.Text != "")
            {
                Ilac_Fiyati_Guncelle();
                Ilaclari_LIstele();
                MessageBox.Show("Fiyat basarili bir sekilde guncellestirildi.");
                TextB_FiyatDegistir_IlacID.Text = "";
                TextBox_FiyatDegistir_YeniFiyat.Text = "";
            }
            else
            {
                MessageBox.Show("Lutfen bos bir alan birakmayiniz.");
            }
        }

        private void dataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            TextB_FiyatDegistir_IlacID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            TextBox_ilacKladir_Ilac_Id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void Btn_Ilac_Kaldir_Click(object sender, EventArgs e)
        {
            if (TextBox_ilacKladir_Ilac_Id.Text != "")
            {
                Ilac_Kaldir();
                Ilaclari_LIstele();
                MessageBox.Show("Ilac Basarili bir sekilde kaldirildi.");
                TextBox_ilacKladir_Ilac_Id.Text = "";
            }
            else
            {
                MessageBox.Show("Lutfen gerekli yerleri doldurunuz.");
            }
        }
    }
}
