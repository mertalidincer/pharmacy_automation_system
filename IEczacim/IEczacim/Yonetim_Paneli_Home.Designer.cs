namespace IEczacim
{
    partial class Yonetim_Paneli_Home
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Kullanici_Adi_Text = new System.Windows.Forms.TextBox();
            this.Sifre_Text = new System.Windows.Forms.TextBox();
            this.Btn_YonetimP_Giris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 67);
            this.label1.TabIndex = 0;
            this.label1.Text = "IEczacim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(299, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kullanici Adi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(299, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Sifre";
            // 
            // Kullanici_Adi_Text
            // 
            this.Kullanici_Adi_Text.Location = new System.Drawing.Point(425, 168);
            this.Kullanici_Adi_Text.Name = "Kullanici_Adi_Text";
            this.Kullanici_Adi_Text.Size = new System.Drawing.Size(139, 22);
            this.Kullanici_Adi_Text.TabIndex = 2;
            // 
            // Sifre_Text
            // 
            this.Sifre_Text.Location = new System.Drawing.Point(425, 213);
            this.Sifre_Text.Name = "Sifre_Text";
            this.Sifre_Text.Size = new System.Drawing.Size(139, 22);
            this.Sifre_Text.TabIndex = 3;
            // 
            // Btn_YonetimP_Giris
            // 
            this.Btn_YonetimP_Giris.Location = new System.Drawing.Point(489, 262);
            this.Btn_YonetimP_Giris.Name = "Btn_YonetimP_Giris";
            this.Btn_YonetimP_Giris.Size = new System.Drawing.Size(75, 23);
            this.Btn_YonetimP_Giris.TabIndex = 4;
            this.Btn_YonetimP_Giris.Text = "Giris";
            this.Btn_YonetimP_Giris.UseVisualStyleBackColor = true;
            this.Btn_YonetimP_Giris.Click += new System.EventHandler(this.Btn_YonetimP_Giris_Click);
            // 
            // Yonetim_Paneli_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 481);
            this.Controls.Add(this.Btn_YonetimP_Giris);
            this.Controls.Add(this.Sifre_Text);
            this.Controls.Add(this.Kullanici_Adi_Text);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Yonetim_Paneli_Home";
            this.Text = "Yonetim_Paneli_Home";
            this.Load += new System.EventHandler(this.Yonetim_Paneli_Home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox Kullanici_Adi_Text;
        public System.Windows.Forms.TextBox Sifre_Text;
        public System.Windows.Forms.Button Btn_YonetimP_Giris;
    }
}