namespace IEczacim
{
    partial class Hasta_Paneli_Sifremi_Unuttum_Form
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.HastaP_SifremiU_Tc_TxtB = new System.Windows.Forms.TextBox();
            this.HastaP_SifremiU_YeniS_TxtB = new System.Windows.Forms.TextBox();
            this.HastaP_SifremiU_YeniSTekrar_TxtB = new System.Windows.Forms.TextBox();
            this.Btn_Sifremi_Unuttum = new System.Windows.Forms.Button();
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
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(302, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sifremi Unuttum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(242, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tc Kimlik No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(242, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Yeni Sifre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(242, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Yeni Sifre Tekrar";
            // 
            // HastaP_SifremiU_Tc_TxtB
            // 
            this.HastaP_SifremiU_Tc_TxtB.Location = new System.Drawing.Point(364, 220);
            this.HastaP_SifremiU_Tc_TxtB.Name = "HastaP_SifremiU_Tc_TxtB";
            this.HastaP_SifremiU_Tc_TxtB.Size = new System.Drawing.Size(134, 22);
            this.HastaP_SifremiU_Tc_TxtB.TabIndex = 5;
            // 
            // HastaP_SifremiU_YeniS_TxtB
            // 
            this.HastaP_SifremiU_YeniS_TxtB.Location = new System.Drawing.Point(364, 256);
            this.HastaP_SifremiU_YeniS_TxtB.Name = "HastaP_SifremiU_YeniS_TxtB";
            this.HastaP_SifremiU_YeniS_TxtB.Size = new System.Drawing.Size(134, 22);
            this.HastaP_SifremiU_YeniS_TxtB.TabIndex = 6;
            // 
            // HastaP_SifremiU_YeniSTekrar_TxtB
            // 
            this.HastaP_SifremiU_YeniSTekrar_TxtB.Location = new System.Drawing.Point(364, 292);
            this.HastaP_SifremiU_YeniSTekrar_TxtB.Name = "HastaP_SifremiU_YeniSTekrar_TxtB";
            this.HastaP_SifremiU_YeniSTekrar_TxtB.Size = new System.Drawing.Size(134, 22);
            this.HastaP_SifremiU_YeniSTekrar_TxtB.TabIndex = 7;
            // 
            // Btn_Sifremi_Unuttum
            // 
            this.Btn_Sifremi_Unuttum.Location = new System.Drawing.Point(423, 335);
            this.Btn_Sifremi_Unuttum.Name = "Btn_Sifremi_Unuttum";
            this.Btn_Sifremi_Unuttum.Size = new System.Drawing.Size(75, 23);
            this.Btn_Sifremi_Unuttum.TabIndex = 8;
            this.Btn_Sifremi_Unuttum.Text = "Tamamla";
            this.Btn_Sifremi_Unuttum.UseVisualStyleBackColor = true;
            this.Btn_Sifremi_Unuttum.Click += new System.EventHandler(this.Btn_Sifremi_Unuttum_Click);
            // 
            // Hasta_Paneli_Sifremi_Unuttum_Formcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_Sifremi_Unuttum);
            this.Controls.Add(this.HastaP_SifremiU_YeniSTekrar_TxtB);
            this.Controls.Add(this.HastaP_SifremiU_YeniS_TxtB);
            this.Controls.Add(this.HastaP_SifremiU_Tc_TxtB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Hasta_Paneli_Sifremi_Unuttum_Formcs";
            this.Text = "Hasta_Paneli_Sifremi_Unuttum_Formcs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox HastaP_SifremiU_Tc_TxtB;
        private System.Windows.Forms.TextBox HastaP_SifremiU_YeniS_TxtB;
        private System.Windows.Forms.TextBox HastaP_SifremiU_YeniSTekrar_TxtB;
        private System.Windows.Forms.Button Btn_Sifremi_Unuttum;
    }
}