namespace IEczacim
{
    partial class Yonetim_Paneli_Receteler_Form
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
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.receteIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receteTarigiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eczaneVergiNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eczaneyegidilenTarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receteDurumuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblRecetelerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.iEczacimDataSet13 = new IEczacim.IEczacimDataSet13();
            this.tblRecetelerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iEczacimDataSet10 = new IEczacim.IEczacimDataSet10();
            this.tbl_RecetelerTableAdapter = new IEczacim.IEczacimDataSet10TableAdapters.Tbl_RecetelerTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.REkle_Hasta_Tc_TxtB = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.REkle_EczaneVN_TxtB = new System.Windows.Forms.TextBox();
            this.Btn_Recete_Ekle = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.IlacID_txtB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Btn_Receteye_ilac_ekle = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Btn_Receteden_Ilac_Kaldir = new System.Windows.Forms.Button();
            this.Btn_Recete_Getir = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.iEczacimDataSet11 = new IEczacim.IEczacimDataSet11();
            this.tblIlaclarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_IlaclarTableAdapter = new IEczacim.IEczacimDataSet11TableAdapters.Tbl_IlaclarTableAdapter();
            this.Btn_Recete_Kaldir = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Recete_kaldir_ReceteId_txtb = new System.Windows.Forms.TextBox();
            this.tbl_RecetelerTableAdapter1 = new IEczacim.IEczacimDataSet13TableAdapters.Tbl_RecetelerTableAdapter();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRecetelerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iEczacimDataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRecetelerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iEczacimDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iEczacimDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblIlaclarBindingSource)).BeginInit();
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
            this.label2.Location = new System.Drawing.Point(20, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Recete Ekle";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.receteIdDataGridViewTextBoxColumn,
            this.receteTarigiDataGridViewTextBoxColumn,
            this.eczaneVergiNoDataGridViewTextBoxColumn,
            this.eczaneyegidilenTarihDataGridViewTextBoxColumn,
            this.receteDurumuDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblRecetelerBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(25, 495);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1121, 228);
            this.dataGridView1.TabIndex = 2;
            // 
            // receteIdDataGridViewTextBoxColumn
            // 
            this.receteIdDataGridViewTextBoxColumn.DataPropertyName = "Recete_Id";
            this.receteIdDataGridViewTextBoxColumn.HeaderText = "Recete_Id";
            this.receteIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.receteIdDataGridViewTextBoxColumn.Name = "receteIdDataGridViewTextBoxColumn";
            this.receteIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // receteTarigiDataGridViewTextBoxColumn
            // 
            this.receteTarigiDataGridViewTextBoxColumn.DataPropertyName = "Recete_Tarigi";
            this.receteTarigiDataGridViewTextBoxColumn.HeaderText = "Recete_Tarigi";
            this.receteTarigiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.receteTarigiDataGridViewTextBoxColumn.Name = "receteTarigiDataGridViewTextBoxColumn";
            this.receteTarigiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eczaneVergiNoDataGridViewTextBoxColumn
            // 
            this.eczaneVergiNoDataGridViewTextBoxColumn.DataPropertyName = "Eczane_Vergi_No";
            this.eczaneVergiNoDataGridViewTextBoxColumn.HeaderText = "Eczane_Vergi_No";
            this.eczaneVergiNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eczaneVergiNoDataGridViewTextBoxColumn.Name = "eczaneVergiNoDataGridViewTextBoxColumn";
            this.eczaneVergiNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eczaneyegidilenTarihDataGridViewTextBoxColumn
            // 
            this.eczaneyegidilenTarihDataGridViewTextBoxColumn.DataPropertyName = "Eczaneye_gidilen_Tarih";
            this.eczaneyegidilenTarihDataGridViewTextBoxColumn.HeaderText = "Eczaneye_gidilen_Tarih";
            this.eczaneyegidilenTarihDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eczaneyegidilenTarihDataGridViewTextBoxColumn.Name = "eczaneyegidilenTarihDataGridViewTextBoxColumn";
            this.eczaneyegidilenTarihDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // receteDurumuDataGridViewTextBoxColumn
            // 
            this.receteDurumuDataGridViewTextBoxColumn.DataPropertyName = "Recete_Durumu";
            this.receteDurumuDataGridViewTextBoxColumn.HeaderText = "Recete_Durumu";
            this.receteDurumuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.receteDurumuDataGridViewTextBoxColumn.Name = "receteDurumuDataGridViewTextBoxColumn";
            this.receteDurumuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tblRecetelerBindingSource1
            // 
            this.tblRecetelerBindingSource1.DataMember = "Tbl_Receteler";
            this.tblRecetelerBindingSource1.DataSource = this.iEczacimDataSet13;
            // 
            // iEczacimDataSet13
            // 
            this.iEczacimDataSet13.DataSetName = "IEczacimDataSet13";
            this.iEczacimDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblRecetelerBindingSource
            // 
            this.tblRecetelerBindingSource.DataMember = "Tbl_Receteler";
            this.tblRecetelerBindingSource.DataSource = this.iEczacimDataSet10;
            // 
            // iEczacimDataSet10
            // 
            this.iEczacimDataSet10.DataSetName = "IEczacimDataSet10";
            this.iEczacimDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_RecetelerTableAdapter
            // 
            this.tbl_RecetelerTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Recete Tarigi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Hasta Tc No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Eczane Vergi No";
            // 
            // REkle_Hasta_Tc_TxtB
            // 
            this.REkle_Hasta_Tc_TxtB.Location = new System.Drawing.Point(157, 214);
            this.REkle_Hasta_Tc_TxtB.Name = "REkle_Hasta_Tc_TxtB";
            this.REkle_Hasta_Tc_TxtB.Size = new System.Drawing.Size(151, 22);
            this.REkle_Hasta_Tc_TxtB.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(157, 177);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // REkle_EczaneVN_TxtB
            // 
            this.REkle_EczaneVN_TxtB.Location = new System.Drawing.Point(157, 254);
            this.REkle_EczaneVN_TxtB.Name = "REkle_EczaneVN_TxtB";
            this.REkle_EczaneVN_TxtB.Size = new System.Drawing.Size(151, 22);
            this.REkle_EczaneVN_TxtB.TabIndex = 8;
            // 
            // Btn_Recete_Ekle
            // 
            this.Btn_Recete_Ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Recete_Ekle.Location = new System.Drawing.Point(344, 235);
            this.Btn_Recete_Ekle.Name = "Btn_Recete_Ekle";
            this.Btn_Recete_Ekle.Size = new System.Drawing.Size(139, 41);
            this.Btn_Recete_Ekle.TabIndex = 9;
            this.Btn_Recete_Ekle.Text = "Ekle";
            this.Btn_Recete_Ekle.UseVisualStyleBackColor = true;
            this.Btn_Recete_Ekle.Click += new System.EventHandler(this.Btn_Recete_Ekle_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(521, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(302, 29);
            this.label8.TabIndex = 14;
            this.label8.Text = "Receteye Ilac Ekle/ Kaldir";
            // 
            // IlacID_txtB
            // 
            this.IlacID_txtB.Location = new System.Drawing.Point(605, 217);
            this.IlacID_txtB.Name = "IlacID_txtB";
            this.IlacID_txtB.Size = new System.Drawing.Size(115, 22);
            this.IlacID_txtB.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(523, 220);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "Ilac ID";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(911, 173);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(235, 296);
            this.dataGridView2.TabIndex = 17;
            // 
            // Btn_Receteye_ilac_ekle
            // 
            this.Btn_Receteye_ilac_ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Receteye_ilac_ekle.Location = new System.Drawing.Point(754, 232);
            this.Btn_Receteye_ilac_ekle.Name = "Btn_Receteye_ilac_ekle";
            this.Btn_Receteye_ilac_ekle.Size = new System.Drawing.Size(139, 41);
            this.Btn_Receteye_ilac_ekle.TabIndex = 18;
            this.Btn_Receteye_ilac_ekle.Text = "Ekle";
            this.Btn_Receteye_ilac_ekle.UseVisualStyleBackColor = true;
            this.Btn_Receteye_ilac_ekle.Click += new System.EventHandler(this.Btn_Receteye_ilac_ekle_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(523, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "Recete ID";
            // 
            // Btn_Receteden_Ilac_Kaldir
            // 
            this.Btn_Receteden_Ilac_Kaldir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Receteden_Ilac_Kaldir.Location = new System.Drawing.Point(754, 293);
            this.Btn_Receteden_Ilac_Kaldir.Name = "Btn_Receteden_Ilac_Kaldir";
            this.Btn_Receteden_Ilac_Kaldir.Size = new System.Drawing.Size(139, 41);
            this.Btn_Receteden_Ilac_Kaldir.TabIndex = 21;
            this.Btn_Receteden_Ilac_Kaldir.Text = "Kaldir";
            this.Btn_Receteden_Ilac_Kaldir.UseVisualStyleBackColor = true;
            this.Btn_Receteden_Ilac_Kaldir.Click += new System.EventHandler(this.Btn_Receteden_Ilac_Kaldir_Click);
            // 
            // Btn_Recete_Getir
            // 
            this.Btn_Recete_Getir.Location = new System.Drawing.Point(754, 173);
            this.Btn_Recete_Getir.Name = "Btn_Recete_Getir";
            this.Btn_Recete_Getir.Size = new System.Drawing.Size(139, 23);
            this.Btn_Recete_Getir.TabIndex = 22;
            this.Btn_Recete_Getir.Text = "Receteyi Getir";
            this.Btn_Recete_Getir.UseVisualStyleBackColor = true;
            this.Btn_Recete_Getir.Click += new System.EventHandler(this.Btn_Recete_Getir_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(1152, 173);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(420, 550);
            this.dataGridView3.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1147, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(275, 29);
            this.label7.TabIndex = 24;
            this.label7.Text = "Depoda Bulunan Ilaclar";
            // 
            // iEczacimDataSet11
            // 
            this.iEczacimDataSet11.DataSetName = "IEczacimDataSet11";
            this.iEczacimDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblIlaclarBindingSource
            // 
            this.tblIlaclarBindingSource.DataMember = "Tbl_Ilaclar";
            this.tblIlaclarBindingSource.DataSource = this.iEczacimDataSet11;
            // 
            // tbl_IlaclarTableAdapter
            // 
            this.tbl_IlaclarTableAdapter.ClearBeforeFill = true;
            // 
            // Btn_Recete_Kaldir
            // 
            this.Btn_Recete_Kaldir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Recete_Kaldir.Location = new System.Drawing.Point(344, 416);
            this.Btn_Recete_Kaldir.Name = "Btn_Recete_Kaldir";
            this.Btn_Recete_Kaldir.Size = new System.Drawing.Size(139, 41);
            this.Btn_Recete_Kaldir.TabIndex = 25;
            this.Btn_Recete_Kaldir.Text = "Kaldir";
            this.Btn_Recete_Kaldir.UseVisualStyleBackColor = true;
            this.Btn_Recete_Kaldir.Click += new System.EventHandler(this.Btn_Recete_Kaldir_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(20, 319);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(165, 29);
            this.label10.TabIndex = 26;
            this.label10.Text = "Recete Kaldir";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 384);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 16);
            this.label11.TabIndex = 27;
            this.label11.Text = "Recete ID";
            // 
            // Recete_kaldir_ReceteId_txtb
            // 
            this.Recete_kaldir_ReceteId_txtb.Location = new System.Drawing.Point(157, 381);
            this.Recete_kaldir_ReceteId_txtb.Name = "Recete_kaldir_ReceteId_txtb";
            this.Recete_kaldir_ReceteId_txtb.Size = new System.Drawing.Size(100, 22);
            this.Recete_kaldir_ReceteId_txtb.TabIndex = 28;
            // 
            // tbl_RecetelerTableAdapter1
            // 
            this.tbl_RecetelerTableAdapter1.ClearBeforeFill = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(523, 260);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 16);
            this.label12.TabIndex = 16;
            this.label12.Text = "Ilac Adedi";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(605, 176);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(115, 24);
            this.comboBox1.TabIndex = 30;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBox2.Location = new System.Drawing.Point(605, 254);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(115, 24);
            this.comboBox2.TabIndex = 31;
            // 
            // Yonetim_Paneli_Receteler_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1693, 748);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Recete_kaldir_ReceteId_txtb);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Btn_Recete_Kaldir);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.Btn_Recete_Getir);
            this.Controls.Add(this.Btn_Receteden_Ilac_Kaldir);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Btn_Receteye_ilac_ekle);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.IlacID_txtB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Btn_Recete_Ekle);
            this.Controls.Add(this.REkle_EczaneVN_TxtB);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.REkle_Hasta_Tc_TxtB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Yonetim_Paneli_Receteler_Form";
            this.Text = "Yonetim_Paneli_Receteler_Form";
            this.Load += new System.EventHandler(this.Yonetim_Paneli_Receteler_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRecetelerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iEczacimDataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRecetelerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iEczacimDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iEczacimDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblIlaclarBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private IEczacimDataSet10 iEczacimDataSet10;
        private System.Windows.Forms.BindingSource tblRecetelerBindingSource;
        private IEczacimDataSet10TableAdapters.Tbl_RecetelerTableAdapter tbl_RecetelerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn receteIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receteTarigiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eczaneVergiNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eczaneyegidilenTarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receteDurumuDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox REkle_Hasta_Tc_TxtB;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox REkle_EczaneVN_TxtB;
        private System.Windows.Forms.Button Btn_Recete_Ekle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox IlacID_txtB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button Btn_Receteye_ilac_ekle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Btn_Receteden_Ilac_Kaldir;
        private System.Windows.Forms.Button Btn_Recete_Getir;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label7;
        private IEczacimDataSet11 iEczacimDataSet11;
        private System.Windows.Forms.BindingSource tblIlaclarBindingSource;
        private IEczacimDataSet11TableAdapters.Tbl_IlaclarTableAdapter tbl_IlaclarTableAdapter;
        private System.Windows.Forms.Button Btn_Recete_Kaldir;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Recete_kaldir_ReceteId_txtb;
        private IEczacimDataSet13 iEczacimDataSet13;
        private System.Windows.Forms.BindingSource tblRecetelerBindingSource1;
        private IEczacimDataSet13TableAdapters.Tbl_RecetelerTableAdapter tbl_RecetelerTableAdapter1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}