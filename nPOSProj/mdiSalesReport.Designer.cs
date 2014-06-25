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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dtX = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.cBTerminalX = new System.Windows.Forms.ComboBox();
            this.btnPrintX = new System.Windows.Forms.Button();
            this.btnPrintZ = new System.Windows.Forms.Button();
            this.cBTerminalZ = new System.Windows.Forms.ComboBox();
            this.lblZ = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtZ = new System.Windows.Forms.DateTimePicker();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
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
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(83)))), ((int)(((byte)(44)))));
            this.tabPage3.Location = new System.Drawing.Point(4, 33);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(844, 420);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Summary Report";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(29)))), ((int)(((byte)(71)))));
            this.tabPage4.Location = new System.Drawing.Point(4, 33);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(844, 420);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Summary Details Report";
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
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
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
    }
}