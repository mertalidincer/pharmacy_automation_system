using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IEczacim
{
    public partial class Eczane_Paneli_Home1_Form : Form
    {
        public Eczane_Paneli_Home1_Form()
        {
            InitializeComponent();
        }
        private void Btn_Ilac_Stok_Yonetimi_Click(object sender, EventArgs e)
        {
            // buton aktiflestigine yeni from' a git
            Ilac_Stok_Yonetimi_Form ılac_Stok_Yonetimi = new Ilac_Stok_Yonetimi_Form();
            ılac_Stok_Yonetimi.Show();
        }

        private void Btn_Hasta_Kabul_Click(object sender, EventArgs e)
        {
            // button aktiflestiginde yeni from' a git
            Hasta_Kabul_Form HastaK_Form = new Hasta_Kabul_Form();
            HastaK_Form.Show();
        }
    }
}
