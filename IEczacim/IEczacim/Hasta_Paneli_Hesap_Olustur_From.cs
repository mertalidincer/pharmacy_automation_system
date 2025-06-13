using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ComboBox = System.Windows.Forms.ComboBox;

namespace IEczacim
{
    public partial class Hasta_Paneli_Hesap_Olustur_From : Form
    {
        public Hasta_Paneli_Hesap_Olustur_From()
        {
            InitializeComponent();
        }
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader reader;
        
        // Sisteme girmis olan hastanin hesap id sini tut 
        public static string Hesap_Olustur_HastaHesap_Id;

        // sigorta id ve Sehir id tut
        string Sigorta_Id;
        string Sehir_Id;
        
        // Comb' ta Secilmis olan item degerini al
        public string cB_Secili_Veri_al(ComboBox comboBox)
        {
            string seciliVeri = comboBox.SelectedItem.ToString();
            return seciliVeri;
        }

        // Gelen tablo degerine ve combox' a gore gelerkli sehri ce sigorta bilgilerini combox'ta listele
        public void Verileri_ComB_Listeler(string Tablo, ComboBox comboBox)
        {
            conn = null;
            try
            {
                conn = new SqlConnection("Data Source=LAPTOP-5J9G4MFS\\SQLEXPRESS;Initial Catalog=IEczacim;Integrated Security=True");
                conn.Open();
                Kb_Sehir_ComboB.Items.Clear();
                cmd = new SqlCommand("SELECT * FROM " + Tablo + "", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    // Sehir veya sigorta isimlerini combox' ta listele
                    comboBox.Items.Add(reader[1].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ComboBox 'ta verileri listelerken bir hata ile karsilasildi." + ex.ToString());
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        // Form yuklendiginde sehir ve sigorta bilgilerini listelemek icin gerekli fonkisyonlari cagir.
        public void Hasta_Paneli_Hesap_Olustur_From_Load(object sender, EventArgs e)
        {
            string Tbl_Sehir = "Tbl_Sehirler";
            string Tbl_Sogorta = "Tbl_Sigorta_Durumu";
            Verileri_ComB_Listeler(Tbl_Sogorta, Kb_SigortaD_ComboB);
            Verileri_ComB_Listeler(Tbl_Sehir, Kb_Sehir_ComboB);
        }

        // comb' ta senilmis olan sigorta nin id' sini al
        public string Cb_Sigorta_id_al(string name)
        {
            conn = null;
            try
            {
                conn = new SqlConnection("Data Source=LAPTOP-5J9G4MFS\\SQLEXPRESS;Initial Catalog=IEczacim;Integrated Security=True");
                conn.Open();
                cmd = new SqlCommand("SELECT Sigorta_Id FROM Tbl_Sigorta_Durumu WHERE Sigorta_Name = @Sigorta_Name", conn);
                
                cmd.Parameters.AddWithValue("@Sigorta_Name", name.ToString());
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Sigorta_Id = reader[0].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sigorta id alirken bir hata ile karsilasildi" + ex.ToString());
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return Sigorta_Id;
        }

        // comb' larda senilmis olan sehirin id' sini al

        public string Cb_Sehir_id_al(string name)
        {

            conn = null;
            try
            {
                conn = new SqlConnection("Data Source=LAPTOP-5J9G4MFS\\SQLEXPRESS;Initial Catalog=IEczacim;Integrated Security=True");
                conn.Open();
                cmd = new SqlCommand("SELECT Sehir_ID FROM Tbl_Sehirler WHERE Sehir_Name = @Sehir_Name", conn);

                cmd.Parameters.AddWithValue("@Sehir_Name", name.ToString());
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Sehir_Id = reader[0].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sehir id alirken bir hata olutu" + ex.ToString());
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return Sehir_Id;
        }
        public void button1_Click(object sender, EventArgs e)
        {
            // boyle bir hesap olup olmadigini kontrol ettem icin sifemi unuttum formundaki hasta bilgisinin kontrolu gerceklestiriliyor
            Hasta_Paneli_Sifremi_Unuttum_Form hastaP_SifremiU_Form = new Hasta_Paneli_Sifremi_Unuttum_Form();
            conn = null;

            try
            {
                conn = new SqlConnection("Data Source=LAPTOP-5J9G4MFS\\SQLEXPRESS;Initial Catalog=IEczacim;Integrated Security=True");
                conn.Open();
                // GErekli alanlarin bos birakilmadigindan emin oluyoruz.
                if (Kullanici_Adi_TxtB.Text != "" && Sifremi_TxtB.Text != "" && SifreTekrar_TxtB.Text != "")
                {
                    // Boyle bir saba hsagip kullanici varmi olnu kontrol ediyoruz.
                    int KullaniciVarMi = hastaP_SifremiU_Form.Hastanin_Bilgisinin_Kontrolu(Kullanici_Adi_TxtB.Text);
                    if (KullaniciVarMi == 0)
                    {
                        // kullanicinin yeni girmis oldugu sifreleri karsilastiriyoruz.
                        if (Sifremi_TxtB.Text == SifreTekrar_TxtB.Text)
                        {
                            cmd = new SqlCommand("INSERT INTO Tbl_Hasta_Hesaplar (Hasta_TcNo, Sifre) VALUES(@Hasta_TcNo, @Sifre)", conn);
                            cmd.Parameters.AddWithValue("@Hasta_TcNo", Kullanici_Adi_TxtB.Text);
                            cmd.Parameters.AddWithValue("@Sifre", Sifremi_TxtB.Text);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Hesap Basarili bir sekilde olusturuldu.\nLutfen Kisisel bilgilerinide eksiksiz bir sekilde doldurunuz.");
                            cmd = new SqlCommand("SELECT Hesap_Id FROM Tbl_Hasta_Hesaplar WHERE Hasta_TcNo = @Hesap_id", conn);
                            cmd.Parameters.AddWithValue("@Hesap_id", Kullanici_Adi_TxtB.Text);
                            SqlDataReader reader = cmd.ExecuteReader();
                            while (reader.Read())
                            {
                                Hesap_Olustur_HastaHesap_Id = reader[0].ToString();
                            }

                            // hasta hesap bilgilerini gerceklestirdikten sonra 
                            // ozluk bilgilerini girmesi icin ozluk bilgilerinin bulundugu
                            // from elemanlari aktiflestiriliyor
                            Label_Ad.Enabled = true;
                            Label_Soyad.Enabled = true;
                            Label_DogumTarigi.Enabled = true;
                            Label_Sehir.Enabled = true;
                            Label_SigortaDurumu.Enabled = true;

                            Label_Baslik.Enabled = true;

                            KB_Ad_TxtB.Enabled = true;   
                            KB_Soyad_TxtB.Enabled = true;
                            Kb_SigortaD_ComboB.Enabled = true;
                            Kb_Sehir_ComboB.Enabled = true;
                            dateTimePicker1.Enabled = true;

                            Btn_Tamamla.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("sifreler uyusmuyor lutfen tekrar deneyiniz.");
                            Sifremi_TxtB.Text = "";
                            SifreTekrar_TxtB.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Zaten Bu bilgilere sahip bir kullanici var.\n Lutfen tekrar deneyiniz");
                        Kullanici_Adi_TxtB.Text = "";
                        Sifremi_TxtB.Text = "";
                        SifreTekrar_TxtB.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Lufen bos bir alan birakmayiniz.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hesap bilgilerinde bir hata cikti" + ex.ToString());
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
        // hastanin hesap olusturmayi tamamladigi yer
        // Ve Bunu Bir SP Yardimiyla Gerceklestiriyoruz 
        private void Btn_Tamamla_Click(object sender, EventArgs e)
        {
            // hastanin comb' ta secmis olgugu il ve o ilin id' si
            string Sehir_name = cB_Secili_Veri_al(Kb_Sehir_ComboB);
            string Sehir_id = Cb_Sehir_id_al(Sehir_name);

            // hastanin comb' ta secmis oldugu sigorta durumu ve sigorta durumunun id' si
            string Sigorta_name = cB_Secili_Veri_al(Kb_SigortaD_ComboB);
            string Sigorta_id = Cb_Sigorta_id_al(Sigorta_name);

            
            // Hastanin Secmis oldugu dogumtarigi bilgisini oku
            DateTime secilenTarih = dateTimePicker1.Value;

            conn = null;
            try
            {
                conn = new SqlConnection("Data Source=LAPTOP-5J9G4MFS\\SQLEXPRESS;Initial Catalog=IEczacim;Integrated Security=True");
                conn.Open();
                // Gerekli alanlarin dolduruldugundan emin ol
                if (KB_Ad_TxtB.Text != "" && KB_Soyad_TxtB.Text != "" && Kb_Sehir_ComboB.SelectedItem != null && Kb_SigortaD_ComboB.SelectedItem != null)
                {

                    // StoredProcedure HASTAYA HESAP OLUSTUR
                    cmd = new SqlCommand("SP_Hasta_Hesap_Olustur", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("hasta_tc_kimlikno", SqlDbType.NVarChar, 50).Value = Kullanici_Adi_TxtB.Text;
                    cmd.Parameters.Add("Hasta_Ad", SqlDbType.NVarChar, 50).Value =  KB_Ad_TxtB.Text;
                    cmd.Parameters.Add("hasta_soyad",SqlDbType.NVarChar, 50).Value =  KB_Soyad_TxtB.Text;
                    cmd.Parameters.Add("sehir_ıd",SqlDbType.NChar, 10).Value = Sehir_id.ToString();
                    cmd.Parameters.Add("dogum_tarigi", SqlDbType.Date).Value = secilenTarih;
                    cmd.Parameters.Add("Sigorta_Id", SqlDbType.NChar, 10).Value = Sigorta_id.ToString();
                    cmd.Parameters.Add("hesta_hesap_ıd",SqlDbType.NVarChar, 50).Value = Hesap_Olustur_HastaHesap_Id;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Hesap basarili bir sekilde olusturuldu.\nGiris sayfasina yonlendiriliyorsunuz.");
                    Hasta_Paneli_Home hasta_PaneliH = new Hasta_Paneli_Home();
                    this.Close();
                    hasta_PaneliH.Show();
                }
                else
                {
                    MessageBox.Show("Lutfen bos bir alan birakmayiniz.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("kisisel bilgileri eklerken bir hata cikti " + ex.ToString());
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
