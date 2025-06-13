namespace IEczacim
{
    partial class Form1
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
            this.Btn_From_Hasta_Panlei = new System.Windows.Forms.Button();
            this.Btn_From_Eczane_Paneli = new System.Windows.Forms.Button();
            this.Btn_From_Yonetim_Paneli = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(905, 88);
            this.label1.TabIndex = 9;
            this.label1.Text = "IEczacim";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Btn_From_Hasta_Panlei
            // 
            this.Btn_From_Hasta_Panlei.AutoSize = true;
            this.Btn_From_Hasta_Panlei.BackgroundImage = global::IEczacim.Properties.Resources.Home_BackP;
            this.Btn_From_Hasta_Panlei.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_From_Hasta_Panlei.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_From_Hasta_Panlei.Location = new System.Drawing.Point(321, 399);
            this.Btn_From_Hasta_Panlei.Name = "Btn_From_Hasta_Panlei";
            this.Btn_From_Hasta_Panlei.Size = new System.Drawing.Size(234, 161);
            this.Btn_From_Hasta_Panlei.TabIndex = 8;
            this.Btn_From_Hasta_Panlei.Text = "Hasta_Paneli";
            this.Btn_From_Hasta_Panlei.UseVisualStyleBackColor = true;
            this.Btn_From_Hasta_Panlei.Click += new System.EventHandler(this.Btn_From_Hasta_Panlei_Click);
            // 
            // Btn_From_Eczane_Paneli
            // 
            this.Btn_From_Eczane_Paneli.AutoSize = true;
            this.Btn_From_Eczane_Paneli.BackgroundImage = global::IEczacim.Properties.Resources.Home_BackP;
            this.Btn_From_Eczane_Paneli.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_From_Eczane_Paneli.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_From_Eczane_Paneli.Location = new System.Drawing.Point(563, 188);
            this.Btn_From_Eczane_Paneli.Name = "Btn_From_Eczane_Paneli";
            this.Btn_From_Eczane_Paneli.Size = new System.Drawing.Size(234, 161);
            this.Btn_From_Eczane_Paneli.TabIndex = 7;
            this.Btn_From_Eczane_Paneli.Text = "Eczane_Paneli";
            this.Btn_From_Eczane_Paneli.UseVisualStyleBackColor = true;
            this.Btn_From_Eczane_Paneli.Click += new System.EventHandler(this.Btn_From_Eczane_Paneli_Click);
            // 
            // Btn_From_Yonetim_Paneli
            // 
            this.Btn_From_Yonetim_Paneli.AutoSize = true;
            this.Btn_From_Yonetim_Paneli.BackgroundImage = global::IEczacim.Properties.Resources.Home_BackP;
            this.Btn_From_Yonetim_Paneli.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_From_Yonetim_Paneli.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_From_Yonetim_Paneli.Location = new System.Drawing.Point(76, 188);
            this.Btn_From_Yonetim_Paneli.Name = "Btn_From_Yonetim_Paneli";
            this.Btn_From_Yonetim_Paneli.Size = new System.Drawing.Size(234, 161);
            this.Btn_From_Yonetim_Paneli.TabIndex = 6;
            this.Btn_From_Yonetim_Paneli.Text = "Yoentim_Paneli";
            this.Btn_From_Yonetim_Paneli.UseVisualStyleBackColor = true;
            this.Btn_From_Yonetim_Paneli.Click += new System.EventHandler(this.Btn_From_Yonetim_Paneli_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(905, 595);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_From_Hasta_Panlei);
            this.Controls.Add(this.Btn_From_Eczane_Paneli);
            this.Controls.Add(this.Btn_From_Yonetim_Paneli);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Btn_From_Yonetim_Paneli;
        private System.Windows.Forms.Button Btn_From_Eczane_Paneli;
        private System.Windows.Forms.Button Btn_From_Hasta_Panlei;
        private System.Windows.Forms.Label label1;
    }
}

