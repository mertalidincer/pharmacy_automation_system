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
    public partial class Hasta_Kabul_Form : Form
    {
        public Hasta_Kabul_Form()
        {
            InitializeComponent();
        }
        SqlConnection conn = null;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;
        SqlDataReader reader;

        // sisteme girisi olan eczane burada tekrardan cagiriliyor
        string Sisteme_Girisi_Eczane_Name = Eczane_Paneli_Home.Sistemde_girisi_Olan_Eczane.ToString();
        // sisteme girisi olan eczane burada gerekli sql sorgularini gerceklestirmek icin gloabl olarak bir degiskene ataniyor
        string sisteme_Girisi_Eczane_id = Eczane_Paneli_Home.Eczaci_Vergi_NO.ToString();
        string Mevcut_para; // su anda eczanenin Elde ettigi Para global olarak bir degiskende tutuluyor
        // BURAYI ES GECMISSSIN 


        // Hasta ilac alimini gerceklestirdikten sonra eczanedeki ilgili ilaclardan stok dus.
        public void Stok_Guncelle()
        {
            try
            {
                conn = new SqlConnection("Data Source=LAPTOP-5J9G4MFS\\SQLEXPRESS;Initial Catalog=IEczacim;Integrated Security=True");
                conn.Open();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        // hastadan odeme alindikran sonra kastanin islemi tamamladigi alinir ve
        // recete durumu 1' e cevrilir.
        public void Hasta_islemini_Tamamla()
        {
            // su andaki sistem zamanini al
            DateTime suAnkiZaman = DateTime.Now;
            try
            {
                conn = new SqlConnection("Data Source=LAPTOP-5J9G4MFS\\SQLEXPRESS;Initial Catalog=IEczacim;Integrated Security=True");
                conn.Open();
                cmd = new SqlCommand("UPDATE Tbl_Receteler SET Eczaneye_gidilen_Tarih = @Eczaneye_gidilen_Tarih, Recete_Durumu = 1 WHERE Recete_Id = " + Odeme_Recete_Id_txtB.Text.ToString() + "", conn);
                cmd.Parameters.AddWithValue("@Eczaneye_gidilen_Tarih", suAnkiZaman);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hasta islemlerini tamamlarken bir hata ile karsilasildi" + ex.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
        
        // Hastadan odeme alinmasi sonucunda eczanenin cirosuna bu eklenecektir.
        public void Yeni_para_Guncelle()
        {
            // Eczanenin mevcut cirosu ile hastanin ilaclarinin bedelini topla
            string Yeni_Para = (Convert.ToInt32(Mevcut_para) + Convert.ToInt32(Label_Fiyat.Text)).ToString();
            try
            {
                conn = new SqlConnection("Data Source=LAPTOP-5J9G4MFS\\SQLEXPRESS;Initial Catalog=IEczacim;Integrated Security=True");
                conn.Open();
                // hesaplanan yeni miktari eski miktar ile guncelle
                cmd = new SqlCommand("UPDATE Tbl_Eczaneler SET Satis_Miktari = @satis_miktari WHERE Eczane_Vergi_No = " + sisteme_Girisi_Eczane_id + "", conn);
                cmd.Parameters.AddWithValue("@satis_miktari", Yeni_Para);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Yeni Para guncellerken bir hata ile karsilasildi" + ex.Message);
            }
            finally
            {
                if (conn != null) 
                {
                    conn.Close();
                }
            }
        }
        
        // su anda eczanenin mevcut cirosunu al
        public string Mevcut_Kazanilan_para()
        {
            try
            {
                conn = new SqlConnection("Data Source=LAPTOP-5J9G4MFS\\SQLEXPRESS;Initial Catalog=IEczacim;Integrated Security=True");
                conn.Open();
                cmd = new SqlCommand("SELECT Satis_Miktari AS CIRO FROM Tbl_Eczaneler WHERE Eczane_Vergi_No=" + sisteme_Girisi_Eczane_id + "", conn);
                reader = cmd.ExecuteReader();
                while (reader.Read()) 
                {
                    // mevcut paraya bir global degiskende sakla
                    Mevcut_para = reader["CIRO"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mervcut paraya alirken bir hata ile karsilasildi" + ex.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return Mevcut_para;
        }

        // hastanin recete id' si girildigine hastanin ozluk bilgilerini getir
        // Ve bunu bir SP yardimiyla getir
        public void Hasta_Bilgilerini_Getir()
        {

            try
            {
                // Hastanin recete id' sini bir degiskende tut
                string Hasta_Recete_id = Recete_Id_txtB.Text.ToString();
                conn = new SqlConnection("Data Source=LAPTOP-5J9G4MFS\\SQLEXPRESS;Initial Catalog=IEczacim;Integrated Security=True");
                conn.Open();

                // StoredProcedure HASTANIN OZLUK BILGILERINI LABLE DEGISKENLERINE GETIR
                cmd = new SqlCommand("SP_Hasta_Bilgilerini_Getir", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("Recete_Id", SqlDbType.Int).Value = Hasta_Recete_id;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    // Ilgili lablerllere hastanin ozluk bilgilerini getir
                    label15.Text = reader["TC"].ToString();
                    label14.Text = reader["AD"].ToString();
                    label13.Text = reader["SOYAD"].ToString();
                    label12.Text = reader["SEHIR"].ToString();
                    label11.Text = reader["TARIH"].ToString();
                    label10.Text = reader["SIGORTA"].ToString();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri tabanindan veri alirken bir hata ile karsilasildi" + ex.Message);
            }
            finally
            {
                // eger conn null' dan farkli ise baglnatiyi kapat
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        // Eczanede mevcut bulunan ilaclari listele
        // Ve bunu bir SP yardimiyla gerceklestir
        public void Eczanedeki_Ilaclari_Listele()
        {
            try
            {
                conn = new SqlConnection("Data Source=LAPTOP-5J9G4MFS\\SQLEXPRESS;Initial Catalog=IEczacim;Integrated Security=True");
                conn.Open();

                // StoredProcedure ECZANEDE BULUNAN ILACLARI LISTELE
                cmd = new SqlCommand("SP_Eczanedeki_Ilaclari_Listeler", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("EczaneVergiNo", SqlDbType.NVarChar, 50).Value = sisteme_Girisi_Eczane_id;
                adapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                dataGridView2.DataSource = dt;
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Verilei datagridview' e getirirken bir hata ile karsilasildi" + ex.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
        public void Hasta_Gecmis_listele()
        {
            string Hasta_Tc_No = Hasta_Tc_No_txtB.Text.ToString();
            try
            {
                // Eger textBox bos degilse sorguyu gerceklestir
                if (Hasta_Tc_No != "")
                {
                    conn = new SqlConnection("Data Source=LAPTOP-5J9G4MFS\\SQLEXPRESS;Initial Catalog=IEczacim;Integrated Security=True");
                    conn.Open();
                    adapter = new SqlDataAdapter("SELECT * FROM Tbl_Receteler WHERE Eczane_Vergi_No = " + sisteme_Girisi_Eczane_id + " AND Hasta_Tc_KimlikNo = " + Hasta_Tc_No + "", conn);
                    dt = new DataTable();
                    dataGridView3.DataSource = dt;
                    adapter.Fill(dt);
                }
                else
                {
                    MessageBox.Show("Lutfen bos bir alan birakmayiniz.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Verileri getirirken bir hata ile karsilasildi" + ex.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
        // burada bir sikinti var su anlik es geciyorum 
        public void Odenecek_Fiyat()
        {
            // Hastanin Recete Id' sini tut
            string recete_id = Odeme_Recete_Id_txtB.Text;
            int receteIdValue;
            try
            {
                // TryParse yardimiyla degiskeni int. cevir
                // Ve receteid degerin out olarak al
                if (int.TryParse(recete_id, out receteIdValue))
                {
                    conn = new SqlConnection("Data Source=LAPTOP-5J9G4MFS\\SQLEXPRESS;Initial Catalog=IEczacim;Integrated Security=True");
                    conn.Open();
                    cmd = new SqlCommand("SELECT dbo.FUNC_Odenecek_Fiyat(@ReceteId) AS TotalCost", conn);
                    cmd.Parameters.Add("@ReceteId", SqlDbType.Int).Value = receteIdValue;
                    reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        Label_Fiyat.Text = reader["TotalCost"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Odenecek Miktar Alinirken Bir Hata Ile Karsilasildi" + ex.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
        // Ecza deposundaki ilaclar ilac kullanim talimatlarini dataGW' a getir
        public void Ilac_Kullanim_Talimati()
        {
            string Ilac_id = Ilac_KullanimTalimati_IlacId_TxtB.Text.ToString();
            try
            {
                conn = new SqlConnection("Data Source=LAPTOP-5J9G4MFS\\SQLEXPRESS;Initial Catalog=IEczacim;Integrated Security=True");
                conn.Open();
                adapter = new SqlDataAdapter("SELECT * FROM Tbl_Ilaclar WHERE Ilac_ID = " + Ilac_id + "", conn);
                dt = new DataTable();
                dataGridView2.DataSource = dt;
                adapter.Fill(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Verileri getirirken bir hata ile karsilasildi" + ex.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
        private void Hasta_Kabul_Form_Load(object sender, EventArgs e)
        {
            // From yuklendigine Ecza deposundaki ilaclari dataGW' a getir
            Eczanedeki_Ilaclari_Listele();
            // sisteme giris yapan eczanenin ismlini label' da listele
            Label_Eczane_Name.Text = Sisteme_Girisi_Eczane_Name;
        }

        // Burada hastanin Recetesindeki ilaclari dataGW' a getiren fonksiyonu cagirdik
        public void Hasta_Recetesini_Listele()
        {
            // Hastanin Recete ID' sini textB' tan oku Ve bir degiskene ata
            string Hasta_Recete_id = Recete_Id_txtB.Text.ToString();
            try
            {
                conn = new SqlConnection("Data Source=LAPTOP-5J9G4MFS\\SQLEXPRESS;Initial Catalog=IEczacim;Integrated Security=True");
                conn.Open();
                
                // fonksiyonu cagir
                cmd = new SqlCommand("SELECT * FROM FUNC_Hasta_Recetesini_Listele(@Recete_ID)", conn);
                cmd.Parameters.Add("@Recete_ID", SqlDbType.Int).Value = Convert.ToInt32(Hasta_Recete_id);
                adapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                dataGridView1.DataSource = dt;
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Verileri DataGridView' e getirirken bir hata ile karsilasildi" + ex.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
        // button aktiflestiginde gerekli fonksiyonlari cagir
        private void Btn_Hastayi_Getir_Click(object sender, EventArgs e)
        {
            Hasta_Recetesini_Listele();
            Hasta_Bilgilerini_Getir();
        }

        // button aktiflestiginde gerekli fonksiyonlari cagir
        private void Btn_Recete_Sorgula_Click(object sender, EventArgs e)
        {
            Hasta_Gecmis_listele();
        }

        // button aktiflestiginde gerekli fonksiyonlari cagir
        private void Btn_Fiyat_sorgula_Click(object sender, EventArgs e)
        {
            if (Odeme_Recete_Id_txtB.Text != null)
            {
                Odenecek_Fiyat();
            }
            else
            {
                MessageBox.Show("Lutfen Bos Bir alan Birakmayiniz");
            }
        }

        // button aktiflestiginde gerekli fonksiyonlari cagir
        private void Btn_Ilac_Kullanim_Talimati_Click(object sender, EventArgs e)
        {
            if (Ilac_KullanimTalimati_IlacId_TxtB.Text != "")
            {
                Ilac_Kullanim_Talimati();
            }
            else
            {
                MessageBox.Show("Lutfen Bos bir alan Birakmayiniz");
            }
        }

        // button aktiflestiginde gerekli fonksiyonlari cagir
        private void Tbl_Odeme_Click(object sender, EventArgs e)
        {
            // TextB' tanki verinin doldurulup doldurulmadigini kontrol et
            if (Odeme_Recete_Id_txtB.Text != "")
            {
                // mevcut paranin degerini global bir degiskende tut
                Mevcut_para = Mevcut_Kazanilan_para();
                Yeni_para_Guncelle();
                Hasta_islemini_Tamamla();
                MessageBox.Show("Odeme Basarili bir sekilde tamamlandi.\nSaglikli Gunler.");

                // form' mu yeniden yukle
                this.Controls.Clear();
                this.InitializeComponent();

                // From yuklendigine Ecza deposundaki ilaclari dataGW' a getir
                Eczanedeki_Ilaclari_Listele();
                // sisteme giris yapan eczanenin ismlini label' da listele
                Label_Eczane_Name.Text = Sisteme_Girisi_Eczane_Name;
            }
            else
            {
                MessageBox.Show("Lutfen Bos Bir alan Birikmayiniz");
            }
        }
    }
}
