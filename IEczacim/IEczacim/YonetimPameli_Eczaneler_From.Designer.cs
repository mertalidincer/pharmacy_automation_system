namespace IEczacim
{
    partial class YonetimPameli_Eczaneler_From
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.eczaneVergiNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sifreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eczaneAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblEczanelerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iEczacimDataSet7 = new IEczacim.IEczacimDataSet7();
            this.tbl_EczanelerTableAdapter = new IEczacim.IEczacimDataSet7TableAdapters.Tbl_EczanelerTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TextBox_EczaneEkle_VergıNo = new System.Windows.Forms.TextBox();
            this.TextBox_Sıfre = new System.Windows.Forms.TextBox();
            this.TextBox_EczaneAdı = new System.Windows.Forms.TextBox();
            this.Btn_Eczane_Ekle = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.TextBox_EczaneKaldır_VergıNo = new System.Windows.Forms.TextBox();
            this.iEczacimDataSet8 = new IEczacim.IEczacimDataSet8();
            this.tblEczanelerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_EczanelerTableAdapter1 = new IEczacim.IEczacimDataSet8TableAdapters.Tbl_EczanelerTableAdapter();
            this.label7 = new System.Windows.Forms.Label();
            this.Btn_Eczane_Kaldir = new System.Windows.Forms.Button();
            this.TextBox_Eczane_Kaldir_Eczane_Adi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEczanelerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iEczacimDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iEczacimDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEczanelerBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 67);
            this.label1.TabIndex = 0;
            this.label1.Text = "IEczacim";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eczaneVergiNoDataGridViewTextBoxColumn,
            this.sifreDataGridViewTextBoxColumn,
            this.eczaneAdiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblEczanelerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(330, 361);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(425, 241);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // eczaneVergiNoDataGridViewTextBoxColumn
            // 
            this.eczaneVergiNoDataGridViewTextBoxColumn.DataPropertyName = "Eczane_Vergi_No";
            this.eczaneVergiNoDataGridViewTextBoxColumn.HeaderText = "Eczane_Vergi_No";
            this.eczaneVergiNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eczaneVergiNoDataGridViewTextBoxColumn.Name = "eczaneVergiNoDataGridViewTextBoxColumn";
            this.eczaneVergiNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sifreDataGridViewTextBoxColumn
            // 
            this.sifreDataGridViewTextBoxColumn.DataPropertyName = "Sifre";
            this.sifreDataGridViewTextBoxColumn.HeaderText = "Sifre";
            this.sifreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sifreDataGridViewTextBoxColumn.Name = "sifreDataGridViewTextBoxColumn";
            this.sifreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eczaneAdiDataGridViewTextBoxColumn
            // 
            this.eczaneAdiDataGridViewTextBoxColumn.DataPropertyName = "Eczane_Adi";
            this.eczaneAdiDataGridViewTextBoxColumn.HeaderText = "Eczane_Adi";
            this.eczaneAdiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eczaneAdiDataGridViewTextBoxColumn.Name = "eczaneAdiDataGridViewTextBoxColumn";
            this.eczaneAdiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tblEczanelerBindingSource
            // 
            this.tblEczanelerBindingSource.DataMember = "Tbl_Eczaneler";
            this.tblEczanelerBindingSource.DataSource = this.iEczacimDataSet7;
            // 
            // iEczacimDataSet7
            // 
            this.iEczacimDataSet7.DataSetName = "IEczacimDataSet7";
            this.iEczacimDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_EczanelerTableAdapter
            // 
            this.tbl_EczanelerTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Yeni Eczane Ekle";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Vergi No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Sifre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Eczane Adi";
            // 
            // TextBox_EczaneEkle_VergıNo
            // 
            this.TextBox_EczaneEkle_VergıNo.Location = new System.Drawing.Point(115, 160);
            this.TextBox_EczaneEkle_VergıNo.Name = "TextBox_EczaneEkle_VergıNo";
            this.TextBox_EczaneEkle_VergıNo.Size = new System.Drawing.Size(149, 22);
            this.TextBox_EczaneEkle_VergıNo.TabIndex = 6;
            // 
            // TextBox_Sıfre
            // 
            this.TextBox_Sıfre.Location = new System.Drawing.Point(115, 196);
            this.TextBox_Sıfre.Name = "TextBox_Sıfre";
            this.TextBox_Sıfre.Size = new System.Drawing.Size(149, 22);
            this.TextBox_Sıfre.TabIndex = 7;
            // 
            // TextBox_EczaneAdı
            // 
            this.TextBox_EczaneAdı.Location = new System.Drawing.Point(115, 232);
            this.TextBox_EczaneAdı.Name = "TextBox_EczaneAdı";
            this.TextBox_EczaneAdı.Size = new System.Drawing.Size(182, 22);
            this.TextBox_EczaneAdı.TabIndex = 8;
            // 
            // Btn_Eczane_Ekle
            // 
            this.Btn_Eczane_Ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Eczane_Ekle.Location = new System.Drawing.Point(158, 278);
            this.Btn_Eczane_Ekle.Name = "Btn_Eczane_Ekle";
            this.Btn_Eczane_Ekle.Size = new System.Drawing.Size(139, 41);
            this.Btn_Eczane_Ekle.TabIndex = 9;
            this.Btn_Eczane_Ekle.Text = "Ekle";
            this.Btn_Eczane_Ekle.UseVisualStyleBackColor = true;
            this.Btn_Eczane_Ekle.Click += new System.EventHandler(this.Btn_Eczane_Ekle_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(645, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 29);
            this.label6.TabIndex = 10;
            this.label6.Text = "Eczane Kaldir";
            // 
            // TextBox_EczaneKaldır_VergıNo
            // 
            this.TextBox_EczaneKaldır_VergıNo.Location = new System.Drawing.Point(741, 160);
            this.TextBox_EczaneKaldır_VergıNo.Name = "TextBox_EczaneKaldır_VergıNo";
            this.TextBox_EczaneKaldır_VergıNo.Size = new System.Drawing.Size(149, 22);
            this.TextBox_EczaneKaldır_VergıNo.TabIndex = 11;
            // 
            // iEczacimDataSet8
            // 
            this.iEczacimDataSet8.DataSetName = "IEczacimDataSet8";
            this.iEczacimDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblEczanelerBindingSource1
            // 
            this.tblEczanelerBindingSource1.DataMember = "Tbl_Eczaneler";
            this.tblEczanelerBindingSource1.DataSource = this.iEczacimDataSet8;
            // 
            // tbl_EczanelerTableAdapter1
            // 
            this.tbl_EczanelerTableAdapter1.ClearBeforeFill = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(647, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Vergi No";
            // 
            // Btn_Eczane_Kaldir
            // 
            this.Btn_Eczane_Kaldir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Eczane_Kaldir.Location = new System.Drawing.Point(751, 255);
            this.Btn_Eczane_Kaldir.Name = "Btn_Eczane_Kaldir";
            this.Btn_Eczane_Kaldir.Size = new System.Drawing.Size(139, 41);
            this.Btn_Eczane_Kaldir.TabIndex = 14;
            this.Btn_Eczane_Kaldir.Text = "Kaldir";
            this.Btn_Eczane_Kaldir.UseVisualStyleBackColor = true;
            this.Btn_Eczane_Kaldir.Click += new System.EventHandler(this.Btn_Eczane_Kaldir_Click);
            // 
            // TextBox_Eczane_Kaldir_Eczane_Adi
            // 
            this.TextBox_Eczane_Kaldir_Eczane_Adi.Location = new System.Drawing.Point(741, 199);
            this.TextBox_Eczane_Kaldir_Eczane_Adi.Name = "TextBox_Eczane_Kaldir_Eczane_Adi";
            this.TextBox_Eczane_Kaldir_Eczane_Adi.Size = new System.Drawing.Size(149, 22);
            this.TextBox_Eczane_Kaldir_Eczane_Adi.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(647, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Eczane Adi";
            // 
            // YonetimPameli_Eczaneler_From
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 639);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TextBox_Eczane_Kaldir_Eczane_Adi);
            this.Controls.Add(this.Btn_Eczane_Kaldir);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TextBox_EczaneKaldır_VergıNo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Btn_Eczane_Ekle);
            this.Controls.Add(this.TextBox_EczaneAdı);
            this.Controls.Add(this.TextBox_Sıfre);
            this.Controls.Add(this.TextBox_EczaneEkle_VergıNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "YonetimPameli_Eczaneler_From";
            this.Text = "YonetimPameli_Eczaneler_From";
            this.Load += new System.EventHandler(this.YonetimPameli_Eczaneler_From_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEczanelerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iEczacimDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iEczacimDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEczanelerBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private IEczacimDataSet7 iEczacimDataSet7;
        private System.Windows.Forms.BindingSource tblEczanelerBindingSource;
        private IEczacimDataSet7TableAdapters.Tbl_EczanelerTableAdapter tbl_EczanelerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn eczaneVergiNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eczaneAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TextBox_EczaneEkle_VergıNo;
        private System.Windows.Forms.TextBox TextBox_Sıfre;
        private System.Windows.Forms.TextBox TextBox_EczaneAdı;
        private System.Windows.Forms.Button Btn_Eczane_Ekle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TextBox_EczaneKaldır_VergıNo;
        private IEczacimDataSet8 iEczacimDataSet8;
        private System.Windows.Forms.BindingSource tblEczanelerBindingSource1;
        private IEczacimDataSet8TableAdapters.Tbl_EczanelerTableAdapter tbl_EczanelerTableAdapter1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Btn_Eczane_Kaldir;
        private System.Windows.Forms.TextBox TextBox_Eczane_Kaldir_Eczane_Adi;
        private System.Windows.Forms.Label label8;
    }
}