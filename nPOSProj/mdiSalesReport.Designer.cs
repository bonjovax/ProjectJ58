namespace nPOSProj
{
    partial class mdiSalesReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mdiSalesReport));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnPrintX = new System.Windows.Forms.Button();
            this.cBTerminalX = new System.Windows.Forms.ComboBox();
            this.lblX = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtX = new System.Windows.Forms.DateTimePicker();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnPrintZ = new System.Windows.Forms.Button();
            this.cBTerminalZ = new System.Windows.Forms.ComboBox();
            this.lblZ = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtZ = new System.Windows.Forms.DateTimePicker();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnPrintSummarySR = new System.Windows.Forms.Button();
            this.cBTerminalSR = new System.Windows.Forms.ComboBox();
            this.lblSR = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtSR = new System.Windows.Forms.DateTimePicker();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnPrintSummarySDR = new System.Windows.Forms.Button();
            this.cBTerminalSDR = new System.Windows.Forms.ComboBox();
            this.lblSDR = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtSDR = new System.Windows.Forms.DateTimePicker();
            this.printX = new System.Drawing.Printing.PrintDocument();
            this.printZ = new System.Drawing.Printing.PrintDocument();
            this.btnPrintKits = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(747, 457);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(151)))));
            this.tabPage1.Controls.Add(this.btnPrintX);
            this.tabPage1.Controls.Add(this.cBTerminalX);
            this.tabPage1.Controls.Add(this.lblX);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dtX);
            this.tabPage1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(739, 420);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "X  Report";
            // 
            // btnPrintX
            // 
            this.btnPrintX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(56)))), ((int)(((byte)(120)))));
            this.btnPrintX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrintX.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(151)))));
            this.btnPrintX.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnPrintX.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(151)))));
            this.btnPrintX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintX.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintX.ForeColor = System.Drawing.Color.White;
            this.btnPrintX.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintX.Image")));
            this.btnPrintX.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrintX.Location = new System.Drawing.Point(266, 254);
            this.btnPrintX.Name = "btnPrintX";
            this.btnPrintX.Size = new System.Drawing.Size(194, 69);
            this.btnPrintX.TabIndex = 4;
            this.btnPrintX.Text = "Print Ticket";
            this.btnPrintX.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrintX.UseVisualStyleBackColor = false;
            this.btnPrintX.Click += new System.EventHandler(this.btnPrintX_Click);
            // 
            // cBTerminalX
            // 
            this.cBTerminalX.BackColor = System.Drawing.Color.Gainsboro;
            this.cBTerminalX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cBTerminalX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBTerminalX.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cBTerminalX.FormattingEnabled = true;
            this.cBTerminalX.Location = new System.Drawing.Point(238, 205);
            this.cBTerminalX.Name = "cBTerminalX";
            this.cBTerminalX.Size = new System.Drawing.Size(251, 33);
            this.cBTerminalX.TabIndex = 3;
            this.cBTerminalX.Visible = false;
            this.cBTerminalX.SelectedIndexChanged += new System.EventHandler(this.cBTerminalX_SelectedIndexChanged);
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX.ForeColor = System.Drawing.Color.White;
            this.lblX.Location = new System.Drawing.Point(244, 177);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(245, 25);
            this.lblX.TabIndex = 2;
            this.lblX.Text = "Select Terminal for Reading";
            this.lblX.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(261, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Date for Reading";
            // 
            // dtX
            // 
            this.dtX.CalendarTitleBackColor = System.Drawing.Color.AliceBlue;
            this.dtX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtX.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtX.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtX.Location = new System.Drawing.Point(238, 123);
            this.dtX.Name = "dtX";
            this.dtX.Size = new System.Drawing.Size(251, 33);
            this.dtX.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(113)))), ((int)(((byte)(69)))));
            this.tabPage2.Controls.Add(this.btnPrintZ);
            this.tabPage2.Controls.Add(this.cBTerminalZ);
            this.tabPage2.Controls.Add(this.lblZ);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.dtZ);
            this.tabPage2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(739, 420);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Z Report";
            // 
            // btnPrintZ
            // 
            this.btnPrintZ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(56)))), ((int)(((byte)(120)))));
            this.btnPrintZ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrintZ.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(113)))), ((int)(((byte)(69)))));
            this.btnPrintZ.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnPrintZ.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(113)))), ((int)(((byte)(69)))));
            this.btnPrintZ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintZ.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintZ.ForeColor = System.Drawing.Color.White;
            this.btnPrintZ.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintZ.Image")));
            this.btnPrintZ.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrintZ.Location = new System.Drawing.Point(266, 254);
            this.btnPrintZ.Name = "btnPrintZ";
            this.btnPrintZ.Size = new System.Drawing.Size(194, 69);
            this.btnPrintZ.TabIndex = 9;
            this.btnPrintZ.Text = "Print Ticket";
            this.btnPrintZ.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrintZ.UseVisualStyleBackColor = false;
            this.btnPrintZ.Click += new System.EventHandler(this.btnPrintZ_Click);
            // 
            // cBTerminalZ
            // 
            this.cBTerminalZ.BackColor = System.Drawing.Color.Gainsboro;
            this.cBTerminalZ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cBTerminalZ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBTerminalZ.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cBTerminalZ.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.cBTerminalZ.FormattingEnabled = true;
            this.cBTerminalZ.Location = new System.Drawing.Point(238, 205);
            this.cBTerminalZ.Name = "cBTerminalZ";
            this.cBTerminalZ.Size = new System.Drawing.Size(251, 33);
            this.cBTerminalZ.TabIndex = 8;
            this.cBTerminalZ.Visible = false;
            this.cBTerminalZ.SelectedIndexChanged += new System.EventHandler(this.cBTerminalZ_SelectedIndexChanged);
            // 
            // lblZ
            // 
            this.lblZ.AutoSize = true;
            this.lblZ.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZ.ForeColor = System.Drawing.Color.White;
            this.lblZ.Location = new System.Drawing.Point(244, 177);
            this.lblZ.Name = "lblZ";
            this.lblZ.Size = new System.Drawing.Size(245, 25);
            this.lblZ.TabIndex = 7;
            this.lblZ.Text = "Select Terminal for Reading";
            this.lblZ.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(261, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Select Date for Reading";
            // 
            // dtZ
            // 
            this.dtZ.CalendarFont = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtZ.CalendarTitleBackColor = System.Drawing.Color.AliceBlue;
            this.dtZ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtZ.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtZ.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtZ.Location = new System.Drawing.Point(238, 123);
            this.dtZ.Name = "dtZ";
            this.dtZ.Size = new System.Drawing.Size(251, 33);
            this.dtZ.TabIndex = 5;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(83)))), ((int)(((byte)(44)))));
            this.tabPage3.Controls.Add(this.btnPrintSummarySR);
            this.tabPage3.Controls.Add(this.cBTerminalSR);
            this.tabPage3.Controls.Add(this.lblSR);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.dtSR);
            this.tabPage3.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.tabPage3.Location = new System.Drawing.Point(4, 33);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(739, 420);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Summary Report";
            // 
            // btnPrintSummarySR
            // 
            this.btnPrintSummarySR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(56)))), ((int)(((byte)(120)))));
            this.btnPrintSummarySR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrintSummarySR.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(83)))), ((int)(((byte)(44)))));
            this.btnPrintSummarySR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnPrintSummarySR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(83)))), ((int)(((byte)(44)))));
            this.btnPrintSummarySR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintSummarySR.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintSummarySR.ForeColor = System.Drawing.Color.White;
            this.btnPrintSummarySR.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintSummarySR.Image")));
            this.btnPrintSummarySR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrintSummarySR.Location = new System.Drawing.Point(246, 254);
            this.btnPrintSummarySR.Name = "btnPrintSummarySR";
            this.btnPrintSummarySR.Size = new System.Drawing.Size(233, 69);
            this.btnPrintSummarySR.TabIndex = 12;
            this.btnPrintSummarySR.Text = "Print Summary";
            this.btnPrintSummarySR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrintSummarySR.UseVisualStyleBackColor = false;
            this.btnPrintSummarySR.Click += new System.EventHandler(this.btnPrintSummarySR_Click);
            // 
            // cBTerminalSR
            // 
            this.cBTerminalSR.BackColor = System.Drawing.Color.Gainsboro;
            this.cBTerminalSR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cBTerminalSR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBTerminalSR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cBTerminalSR.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.cBTerminalSR.FormattingEnabled = true;
            this.cBTerminalSR.Location = new System.Drawing.Point(238, 205);
            this.cBTerminalSR.Name = "cBTerminalSR";
            this.cBTerminalSR.Size = new System.Drawing.Size(251, 33);
            this.cBTerminalSR.TabIndex = 11;
            this.cBTerminalSR.Visible = false;
            this.cBTerminalSR.SelectedIndexChanged += new System.EventHandler(this.cBTerminalSR_SelectedIndexChanged);
            // 
            // lblSR
            // 
            this.lblSR.AutoSize = true;
            this.lblSR.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSR.ForeColor = System.Drawing.Color.White;
            this.lblSR.Location = new System.Drawing.Point(244, 177);
            this.lblSR.Name = "lblSR";
            this.lblSR.Size = new System.Drawing.Size(245, 25);
            this.lblSR.TabIndex = 10;
            this.lblSR.Text = "Select Terminal for Reading";
            this.lblSR.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(261, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Select Date for Reading";
            // 
            // dtSR
            // 
            this.dtSR.CalendarFont = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtSR.CalendarTitleBackColor = System.Drawing.Color.AliceBlue;
            this.dtSR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtSR.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtSR.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtSR.Location = new System.Drawing.Point(238, 123);
            this.dtSR.Name = "dtSR";
            this.dtSR.Size = new System.Drawing.Size(251, 33);
            this.dtSR.TabIndex = 7;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(29)))), ((int)(((byte)(71)))));
            this.tabPage4.Controls.Add(this.btnPrintKits);
            this.tabPage4.Controls.Add(this.btnPrintSummarySDR);
            this.tabPage4.Controls.Add(this.cBTerminalSDR);
            this.tabPage4.Controls.Add(this.lblSDR);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.dtSDR);
            this.tabPage4.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.tabPage4.Location = new System.Drawing.Point(4, 33);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(739, 420);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Summary Details Report";
            // 
            // btnPrintSummarySDR
            // 
            this.btnPrintSummarySDR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(56)))), ((int)(((byte)(120)))));
            this.btnPrintSummarySDR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrintSummarySDR.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(29)))), ((int)(((byte)(71)))));
            this.btnPrintSummarySDR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnPrintSummarySDR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(29)))), ((int)(((byte)(71)))));
            this.btnPrintSummarySDR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintSummarySDR.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintSummarySDR.ForeColor = System.Drawing.Color.White;
            this.btnPrintSummarySDR.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintSummarySDR.Image")));
            this.btnPrintSummarySDR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrintSummarySDR.Location = new System.Drawing.Point(246, 254);
            this.btnPrintSummarySDR.Name = "btnPrintSummarySDR";
            this.btnPrintSummarySDR.Size = new System.Drawing.Size(233, 69);
            this.btnPrintSummarySDR.TabIndex = 17;
            this.btnPrintSummarySDR.Text = "Print Summary";
            this.btnPrintSummarySDR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrintSummarySDR.UseVisualStyleBackColor = false;
            this.btnPrintSummarySDR.Click += new System.EventHandler(this.btnPrintSummarySDR_Click);
            // 
            // cBTerminalSDR
            // 
            this.cBTerminalSDR.BackColor = System.Drawing.Color.Gainsboro;
            this.cBTerminalSDR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cBTerminalSDR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBTerminalSDR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cBTerminalSDR.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.cBTerminalSDR.FormattingEnabled = true;
            this.cBTerminalSDR.Location = new System.Drawing.Point(238, 205);
            this.cBTerminalSDR.Name = "cBTerminalSDR";
            this.cBTerminalSDR.Size = new System.Drawing.Size(251, 33);
            this.cBTerminalSDR.TabIndex = 16;
            this.cBTerminalSDR.Visible = false;
            this.cBTerminalSDR.SelectedIndexChanged += new System.EventHandler(this.cBTerminalSDR_SelectedIndexChanged);
            // 
            // lblSDR
            // 
            this.lblSDR.AutoSize = true;
            this.lblSDR.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSDR.ForeColor = System.Drawing.Color.White;
            this.lblSDR.Location = new System.Drawing.Point(244, 177);
            this.lblSDR.Name = "lblSDR";
            this.lblSDR.Size = new System.Drawing.Size(245, 25);
            this.lblSDR.TabIndex = 15;
            this.lblSDR.Text = "Select Terminal for Reading";
            this.lblSDR.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(261, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(213, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Select Date for Reading";
            // 
            // dtSDR
            // 
            this.dtSDR.CalendarFont = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtSDR.CalendarTitleBackColor = System.Drawing.Color.AliceBlue;
            this.dtSDR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtSDR.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtSDR.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtSDR.Location = new System.Drawing.Point(238, 123);
            this.dtSDR.Name = "dtSDR";
            this.dtSDR.Size = new System.Drawing.Size(251, 33);
            this.dtSDR.TabIndex = 13;
            // 
            // btnPrintKits
            // 
            this.btnPrintKits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(56)))), ((int)(((byte)(120)))));
            this.btnPrintKits.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrintKits.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(29)))), ((int)(((byte)(71)))));
            this.btnPrintKits.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnPrintKits.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(29)))), ((int)(((byte)(71)))));
            this.btnPrintKits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintKits.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintKits.ForeColor = System.Drawing.Color.White;
            this.btnPrintKits.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintKits.Image")));
            this.btnPrintKits.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrintKits.Location = new System.Drawing.Point(199, 329);
            this.btnPrintKits.Name = "btnPrintKits";
            this.btnPrintKits.Size = new System.Drawing.Size(322, 69);
            this.btnPrintKits.TabIndex = 18;
            this.btnPrintKits.Text = "Print Summary Kits";
            this.btnPrintKits.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrintKits.UseVisualStyleBackColor = false;
            this.btnPrintKits.Click += new System.EventHandler(this.btnPrintKits_Click);
            // 
            // mdiSalesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(747, 457);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "mdiSalesReport";
            this.Text = "Sales Report";
            this.Load += new System.EventHandler(this.mdiSalesReport_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DateTimePicker dtX;
        private System.Windows.Forms.Button btnPrintX;
        private System.Windows.Forms.ComboBox cBTerminalX;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrintZ;
        private System.Windows.Forms.ComboBox cBTerminalZ;
        private System.Windows.Forms.Label lblZ;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtZ;
        private System.Drawing.Printing.PrintDocument printX;
        private System.Drawing.Printing.PrintDocument printZ;
        private System.Windows.Forms.Button btnPrintSummarySR;
        private System.Windows.Forms.ComboBox cBTerminalSR;
        private System.Windows.Forms.Label lblSR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtSR;
        private System.Windows.Forms.Button btnPrintSummarySDR;
        private System.Windows.Forms.ComboBox cBTerminalSDR;
        private System.Windows.Forms.Label lblSDR;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtSDR;
        private System.Windows.Forms.Button btnPrintKits;
    }
}