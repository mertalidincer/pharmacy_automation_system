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
    public partial class Form1 : Form
    {
        SqlConnection conn;      // conn
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Btn_From_Yonetim_Paneli_Click(object sender, EventArgs e)
        {
            // button aktiflestigine gerekli form' a git
            Yonetim_Paneli_Home YonetimP_Home_Form = new Yonetim_Paneli_Home();
            YonetimP_Home_Form.ShowDialog(); // ana form dan yonetici paneli formu acildi
        }

        private void Btn_From_Eczane_Paneli_Click(object sender, EventArgs e)
        {
            // button aktflestiginede gerekli from' a git
            Eczane_Paneli_Home EczaneP_Home_From = new Eczane_Paneli_Home();
            EczaneP_Home_From.ShowDialog(); // ana form'dan eczaci formu acildi
        }

        private void Btn_From_Hasta_Panlei_Click(object sender, EventArgs e)
        {
            // button aktiflestiginde gerekli form' a git
            Hasta_Paneli_Home HastaP_Home_From = new Hasta_Paneli_Home();
            HastaP_Home_From .ShowDialog(); // ana form'dan hasta formu acildi
        }
    }
}
