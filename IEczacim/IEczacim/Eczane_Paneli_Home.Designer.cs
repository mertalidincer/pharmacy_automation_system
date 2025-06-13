namespace IEczacim
{
    partial class Eczane_Paneli_Home
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
            this.Eczane_Name_Label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Eczaci_Kullanici_Adi_TextBox = new System.Windows.Forms.TextBox();
            this.Eczaci_Sifre_TextBox = new System.Windows.Forms.TextBox();
            this.KullaniciAdi_label = new System.Windows.Forms.Label();
            this.Sifre_Label = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Eczane_Name_Label
            // 
            this.Eczane_Name_Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Eczane_Name_Label.Dock = System.Windows.Forms.DockStyle.Top;
            this.Eczane_Name_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eczane_Name_Label.Location = new System.Drawing.Point(0, 0);
            this.Eczane_Name_Label.Name = "Eczane_Name_Label";
            this.Eczane_Name_Label.Size = new System.Drawing.Size(944, 71);
            this.Eczane_Name_Label.TabIndex = 0;
            this.Eczane_Name_Label.Text = "IEczacim";
            this.Eczane_Name_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Eczane_Name_Label.Click += new System.EventHandler(this.Eczane_Name_Label_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(408, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Giris Yap";
            // 
            // Eczaci_Kullanici_Adi_TextBox
            // 
            this.Eczaci_Kullanici_Adi_TextBox.Location = new System.Drawing.Point(393, 193);
            this.Eczaci_Kullanici_Adi_TextBox.Name = "Eczaci_Kullanici_Adi_TextBox";
            this.Eczaci_Kullanici_Adi_TextBox.Size = new System.Drawing.Size(172, 22);
            this.Eczaci_Kullanici_Adi_TextBox.TabIndex = 2;
            // 
            // Eczaci_Sifre_TextBox
            // 
            this.Eczaci_Sifre_TextBox.Location = new System.Drawing.Point(393, 250);
            this.Eczaci_Sifre_TextBox.Name = "Eczaci_Sifre_TextBox";
            this.Eczaci_Sifre_TextBox.Size = new System.Drawing.Size(172, 22);
            this.Eczaci_Sifre_TextBox.TabIndex = 3;
            // 
            // KullaniciAdi_label
            // 
            this.KullaniciAdi_label.AutoSize = true;
            this.KullaniciAdi_label.Location = new System.Drawing.Point(309, 193);
            this.KullaniciAdi_label.Name = "KullaniciAdi_label";
            this.KullaniciAdi_label.Size = new System.Drawing.Size(79, 16);
            this.KullaniciAdi_label.TabIndex = 4;
            this.KullaniciAdi_label.Text = "Kullanici Adi";
            // 
            // Sifre_Label
            // 
            this.Sifre_Label.AutoSize = true;
            this.Sifre_Label.Location = new System.Drawing.Point(309, 253);
            this.Sifre_Label.Name = "Sifre_Label";
            this.Sifre_Label.Size = new System.Drawing.Size(34, 16);
            this.Sifre_Label.TabIndex = 5;
            this.Sifre_Label.Text = "Sifre";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(490, 294);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Giris";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Eczane_Paneli_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 473);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Sifre_Label);
            this.Controls.Add(this.KullaniciAdi_label);
            this.Controls.Add(this.Eczaci_Sifre_TextBox);
            this.Controls.Add(this.Eczaci_Kullanici_Adi_TextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Eczane_Name_Label);
            this.Name = "Eczane_Paneli_Home";
            this.Text = "Eczane_Paneli_Home";
            this.Load += new System.EventHandler(this.Eczane_Paneli_Home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Eczane_Name_Label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label KullaniciAdi_label;
        private System.Windows.Forms.Label Sifre_Label;
        public System.Windows.Forms.TextBox Eczaci_Kullanici_Adi_TextBox;
        public System.Windows.Forms.TextBox Eczaci_Sifre_TextBox;
        public System.Windows.Forms.Button button1;
    }
}