namespace IEczacim
{
    partial class Eczane_Paneli_Home1_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Eczane_Name = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_Ilac_Stok_Yonetimi = new System.Windows.Forms.Button();
            this.Btn_Hasta_Kabul = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Eczane_Name
            // 
            this.Eczane_Name.AutoSize = true;
            this.Eczane_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eczane_Name.Location = new System.Drawing.Point(986, 53);
            this.Eczane_Name.Name = "Eczane_Name";
            this.Eczane_Name.Size = new System.Drawing.Size(79, 29);
            this.Eczane_Name.TabIndex = 0;
            this.Eczane_Name.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(269, 67);
            this.label2.TabIndex = 1;
            this.label2.Text = "IEczacim";
            // 
            // Btn_Ilac_Stok_Yonetimi
            // 
            this.Btn_Ilac_Stok_Yonetimi.BackgroundImage = global::IEczacim.Properties.Resources.Home_BackP;
            this.Btn_Ilac_Stok_Yonetimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Ilac_Stok_Yonetimi.ForeColor = System.Drawing.Color.White;
            this.Btn_Ilac_Stok_Yonetimi.Location = new System.Drawing.Point(135, 200);
            this.Btn_Ilac_Stok_Yonetimi.Name = "Btn_Ilac_Stok_Yonetimi";
            this.Btn_Ilac_Stok_Yonetimi.Size = new System.Drawing.Size(297, 258);
            this.Btn_Ilac_Stok_Yonetimi.TabIndex = 2;
            this.Btn_Ilac_Stok_Yonetimi.Text = "Ilac Stok Yonetimi";
            this.Btn_Ilac_Stok_Yonetimi.UseVisualStyleBackColor = true;
            this.Btn_Ilac_Stok_Yonetimi.Click += new System.EventHandler(this.Btn_Ilac_Stok_Yonetimi_Click);
            // 
            // Btn_Hasta_Kabul
            // 
            this.Btn_Hasta_Kabul.BackgroundImage = global::IEczacim.Properties.Resources.Home_BackP;
            this.Btn_Hasta_Kabul.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Hasta_Kabul.ForeColor = System.Drawing.Color.White;
            this.Btn_Hasta_Kabul.Location = new System.Drawing.Point(678, 200);
            this.Btn_Hasta_Kabul.Name = "Btn_Hasta_Kabul";
            this.Btn_Hasta_Kabul.Size = new System.Drawing.Size(297, 258);
            this.Btn_Hasta_Kabul.TabIndex = 3;
            this.Btn_Hasta_Kabul.Text = "Hasta Kabul";
            this.Btn_Hasta_Kabul.UseVisualStyleBackColor = true;
            this.Btn_Hasta_Kabul.Click += new System.EventHandler(this.Btn_Hasta_Kabul_Click);
            // 
            // Eczane_Paneli_Home1_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 612);
            this.Controls.Add(this.Btn_Hasta_Kabul);
            this.Controls.Add(this.Btn_Ilac_Stok_Yonetimi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Eczane_Name);
            this.Name = "Eczane_Paneli_Home1_Form";
            this.Text = "Eczane_Paneli_Home1_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label Eczane_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_Ilac_Stok_Yonetimi;
        private System.Windows.Forms.Button Btn_Hasta_Kabul;
    }
}