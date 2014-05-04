namespace nPOSProj
{
    partial class mdiSupplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mdiSupplier));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.inventorysupplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.npos_dbDataSet = new nPOSProj.npos_dbDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.rdSC = new System.Windows.Forms.TextBox();
            this.txtBoxCPosition = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBoxCPerson = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBoxContactNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBoxZipPos = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoxCountry = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxCityMun = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxNameComp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mCode = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.inventory_supplierTableAdapter = new nPOSProj.npos_dbDataSetTableAdapters.inventory_supplierTableAdapter();
            this.supplier_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplier_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplier_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplier_city_mun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplier_country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplier_postalcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplier_contactno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplier_contact_person = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplier_position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventorysupplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npos_dbDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.supplier_code,
            this.supplier_name,
            this.supplier_address,
            this.supplier_city_mun,
            this.supplier_country,
            this.supplier_postalcode,
            this.supplier_contactno,
            this.supplier_contact_person,
            this.supplier_position});
            this.dataGridView1.DataSource = this.inventorysupplierBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Turquoise;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(883, 248);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // inventorysupplierBindingSource
            // 
            this.inventorysupplierBindingSource.DataMember = "inventory_supplier";
            this.inventorysupplierBindingSource.DataSource = this.npos_dbDataSet;
            // 
            // npos_dbDataSet
            // 
            this.npos_dbDataSet.DataSetName = "npos_dbDataSet";
            this.npos_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.rdSC);
            this.groupBox1.Controls.Add(this.txtBoxCPosition);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtBoxCPerson);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtBoxContactNo);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtBoxZipPos);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtBoxCountry);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtBoxCityMun);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtBoxAddress);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtBoxNameComp);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.mCode);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(5, 257);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(817, 170);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Supplier Details";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(744, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 16);
            this.label11.TabIndex = 23;
            this.label11.Text = "Required";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Khaki;
            this.panel1.Location = new System.Drawing.Point(726, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(17, 19);
            this.panel1.TabIndex = 22;
            // 
            // btnClear
            // 
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClear.Location = new System.Drawing.Point(719, 96);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(48, 71);
            this.btnClear.TabIndex = 20;
            this.btnClear.Text = "Clear";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(767, 96);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(47, 71);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(158, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "-";
            // 
            // rdSC
            // 
            this.rdSC.BackColor = System.Drawing.Color.Khaki;
            this.rdSC.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdSC.Location = new System.Drawing.Point(112, 22);
            this.rdSC.MaxLength = 4;
            this.rdSC.Name = "rdSC";
            this.rdSC.ReadOnly = true;
            this.rdSC.Size = new System.Drawing.Size(44, 23);
            this.rdSC.TabIndex = 18;
            this.rdSC.Text = "2013";
            this.rdSC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.rdSC.TextChanged += new System.EventHandler(this.rdSC_TextChanged);
            // 
            // txtBoxCPosition
            // 
            this.txtBoxCPosition.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCPosition.Location = new System.Drawing.Point(550, 142);
            this.txtBoxCPosition.MaxLength = 50;
            this.txtBoxCPosition.Name = "txtBoxCPosition";
            this.txtBoxCPosition.Size = new System.Drawing.Size(167, 23);
            this.txtBoxCPosition.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(445, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "Contact Position";
            // 
            // txtBoxCPerson
            // 
            this.txtBoxCPerson.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCPerson.Location = new System.Drawing.Point(550, 118);
            this.txtBoxCPerson.MaxLength = 50;
            this.txtBoxCPerson.Name = "txtBoxCPerson";
            this.txtBoxCPerson.Size = new System.Drawing.Size(167, 23);
            this.txtBoxCPerson.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(445, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Contact Person";
            // 
            // txtBoxContactNo
            // 
            this.txtBoxContactNo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxContactNo.Location = new System.Drawing.Point(550, 94);
            this.txtBoxContactNo.MaxLength = 50;
            this.txtBoxContactNo.Name = "txtBoxContactNo";
            this.txtBoxContactNo.Size = new System.Drawing.Size(117, 23);
            this.txtBoxContactNo.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(445, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Contact No.";
            // 
            // txtBoxZipPos
            // 
            this.txtBoxZipPos.BackColor = System.Drawing.Color.Khaki;
            this.txtBoxZipPos.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxZipPos.Location = new System.Drawing.Point(550, 70);
            this.txtBoxZipPos.MaxLength = 5;
            this.txtBoxZipPos.Name = "txtBoxZipPos";
            this.txtBoxZipPos.Size = new System.Drawing.Size(68, 23);
            this.txtBoxZipPos.TabIndex = 11;
            this.txtBoxZipPos.TextChanged += new System.EventHandler(this.txtBoxZipPos_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(445, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Zip/Postal Code";
            // 
            // txtBoxCountry
            // 
            this.txtBoxCountry.BackColor = System.Drawing.Color.Khaki;
            this.txtBoxCountry.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCountry.Location = new System.Drawing.Point(550, 46);
            this.txtBoxCountry.MaxLength = 50;
            this.txtBoxCountry.Name = "txtBoxCountry";
            this.txtBoxCountry.Size = new System.Drawing.Size(148, 23);
            this.txtBoxCountry.TabIndex = 9;
            this.txtBoxCountry.TextChanged += new System.EventHandler(this.txtBoxCountry_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(445, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Country";
            // 
            // txtBoxCityMun
            // 
            this.txtBoxCityMun.BackColor = System.Drawing.Color.Khaki;
            this.txtBoxCityMun.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCityMun.Location = new System.Drawing.Point(550, 22);
            this.txtBoxCityMun.MaxLength = 50;
            this.txtBoxCityMun.Name = "txtBoxCityMun";
            this.txtBoxCityMun.Size = new System.Drawing.Size(117, 23);
            this.txtBoxCityMun.TabIndex = 7;
            this.txtBoxCityMun.TextChanged += new System.EventHandler(this.txtBoxCityMun_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(445, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "City/Municipality";
            // 
            // txtBoxAddress
            // 
            this.txtBoxAddress.BackColor = System.Drawing.Color.Khaki;
            this.txtBoxAddress.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxAddress.Location = new System.Drawing.Point(112, 70);
            this.txtBoxAddress.MaxLength = 100;
            this.txtBoxAddress.Multiline = true;
            this.txtBoxAddress.Name = "txtBoxAddress";
            this.txtBoxAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxAddress.Size = new System.Drawing.Size(326, 92);
            this.txtBoxAddress.TabIndex = 5;
            this.txtBoxAddress.TextChanged += new System.EventHandler(this.txtBoxAddress_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Address";
            // 
            // txtBoxNameComp
            // 
            this.txtBoxNameComp.BackColor = System.Drawing.Color.Khaki;
            this.txtBoxNameComp.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNameComp.Location = new System.Drawing.Point(112, 46);
            this.txtBoxNameComp.MaxLength = 100;
            this.txtBoxNameComp.Name = "txtBoxNameComp";
            this.txtBoxNameComp.Size = new System.Drawing.Size(326, 23);
            this.txtBoxNameComp.TabIndex = 3;
            this.txtBoxNameComp.TextChanged += new System.EventHandler(this.txtBoxNameComp_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name/Company";
            // 
            // mCode
            // 
            this.mCode.BackColor = System.Drawing.Color.Khaki;
            this.mCode.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mCode.Location = new System.Drawing.Point(172, 22);
            this.mCode.Mask = "AAAA";
            this.mCode.Name = "mCode";
            this.mCode.Size = new System.Drawing.Size(42, 23);
            this.mCode.TabIndex = 1;
            this.mCode.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mCode_MaskInputRejected);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Supplier Code";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnUpdate);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(828, 250);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(57, 76);
            this.groupBox3.TabIndex = 64;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Update";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUpdate.Location = new System.Drawing.Point(3, 15);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(50, 57);
            this.btnUpdate.TabIndex = 62;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(828, 328);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(57, 76);
            this.groupBox2.TabIndex = 65;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Delete";
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDelete.Location = new System.Drawing.Point(3, 15);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(50, 57);
            this.btnDelete.TabIndex = 62;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // inventory_supplierTableAdapter
            // 
            this.inventory_supplierTableAdapter.ClearBeforeFill = true;
            // 
            // supplier_code
            // 
            this.supplier_code.DataPropertyName = "supplier_code";
            this.supplier_code.HeaderText = "Supplier Code";
            this.supplier_code.Name = "supplier_code";
            this.supplier_code.ReadOnly = true;
            // 
            // supplier_name
            // 
            this.supplier_name.DataPropertyName = "supplier_name";
            this.supplier_name.HeaderText = "Name/Company";
            this.supplier_name.Name = "supplier_name";
            this.supplier_name.Width = 250;
            // 
            // supplier_address
            // 
            this.supplier_address.DataPropertyName = "supplier_address";
            this.supplier_address.HeaderText = "Address";
            this.supplier_address.Name = "supplier_address";
            this.supplier_address.Width = 350;
            // 
            // supplier_city_mun
            // 
            this.supplier_city_mun.DataPropertyName = "supplier_city_municipality";
            this.supplier_city_mun.HeaderText = "City/Municipality";
            this.supplier_city_mun.Name = "supplier_city_mun";
            this.supplier_city_mun.Width = 130;
            // 
            // supplier_country
            // 
            this.supplier_country.DataPropertyName = "supplier_country";
            this.supplier_country.HeaderText = "Country";
            this.supplier_country.Name = "supplier_country";
            this.supplier_country.Width = 130;
            // 
            // supplier_postalcode
            // 
            this.supplier_postalcode.DataPropertyName = "supplier_zipcode";
            this.supplier_postalcode.HeaderText = "Postal Code";
            this.supplier_postalcode.Name = "supplier_postalcode";
            // 
            // supplier_contactno
            // 
            this.supplier_contactno.DataPropertyName = "supplier_contact";
            this.supplier_contactno.HeaderText = "Contact No";
            this.supplier_contactno.Name = "supplier_contactno";
            this.supplier_contactno.Width = 250;
            // 
            // supplier_contact_person
            // 
            this.supplier_contact_person.DataPropertyName = "supplier_contact_person";
            this.supplier_contact_person.HeaderText = "Contact Person";
            this.supplier_contact_person.Name = "supplier_contact_person";
            this.supplier_contact_person.Width = 300;
            // 
            // supplier_position
            // 
            this.supplier_position.DataPropertyName = "supplier_cperson_position";
            this.supplier_position.HeaderText = "Position";
            this.supplier_position.Name = "supplier_position";
            this.supplier_position.Width = 250;
            // 
            // mdiSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 431);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "mdiSupplier";
            this.Text = "Supplier";
            this.Load += new System.EventHandler(this.mdiSupplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventorysupplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npos_dbDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBoxAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxNameComp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxCPosition;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBoxCPerson;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBoxContactNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBoxZipPos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBoxCountry;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxCityMun;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox rdSC;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private npos_dbDataSet npos_dbDataSet;
        private System.Windows.Forms.BindingSource inventorysupplierBindingSource;
        private npos_dbDataSetTableAdapters.inventory_supplierTableAdapter inventory_supplierTableAdapter;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplier_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplier_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplier_address;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplier_city_mun;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplier_country;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplier_postalcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplier_contactno;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplier_contact_person;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplier_position;
    }
}