﻿namespace nPOSProj
{
    partial class frmDlgRefund
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDlgRefund));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxOR = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cBTerminal = new System.Windows.Forms.ComboBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRefund = new System.Windows.Forms.Button();
            this.txtBoxQty = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.closeDlg = new System.Windows.Forms.Button();
            this.eanCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalamount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaxType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "OR No";
            // 
            // txtBoxOR
            // 
            this.txtBoxOR.BackColor = System.Drawing.Color.Snow;
            this.txtBoxOR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxOR.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxOR.Location = new System.Drawing.Point(70, 18);
            this.txtBoxOR.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxOR.MaxLength = 20;
            this.txtBoxOR.Name = "txtBoxOR";
            this.txtBoxOR.Size = new System.Drawing.Size(107, 22);
            this.txtBoxOR.TabIndex = 1;
            this.txtBoxOR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxOR.TextChanged += new System.EventHandler(this.txtBoxOR_TextChanged);
            this.txtBoxOR.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBoxOR_KeyDown);
            this.txtBoxOR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxOR_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cBTerminal);
            this.groupBox1.Controls.Add(this.lbl1);
            this.groupBox1.Controls.Add(this.txtBoxOR);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 3);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(415, 49);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Controller";
            // 
            // cBTerminal
            // 
            this.cBTerminal.BackColor = System.Drawing.Color.Snow;
            this.cBTerminal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBTerminal.Enabled = false;
            this.cBTerminal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBTerminal.FormattingEnabled = true;
            this.cBTerminal.Location = new System.Drawing.Point(283, 15);
            this.cBTerminal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cBTerminal.Name = "cBTerminal";
            this.cBTerminal.Size = new System.Drawing.Size(120, 25);
            this.cBTerminal.TabIndex = 3;
            this.cBTerminal.Visible = false;
            this.cBTerminal.SelectedIndexChanged += new System.EventHandler(this.cBTerminal_SelectedIndexChanged);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(184, 20);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(96, 17);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "Select Terminal";
            this.lbl1.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(151)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eanCode,
            this.qty,
            this.description,
            this.price,
            this.discount,
            this.totalamount,
            this.TaxType});
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(9, 58);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(986, 452);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox2.Controls.Add(this.btnRefund);
            this.groupBox2.Controls.Add(this.txtBoxQty);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(6, 520);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(271, 60);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Refund Controller";
            // 
            // btnRefund
            // 
            this.btnRefund.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnRefund.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefund.Enabled = false;
            this.btnRefund.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(151)))));
            this.btnRefund.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(151)))));
            this.btnRefund.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(151)))));
            this.btnRefund.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefund.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefund.ForeColor = System.Drawing.Color.White;
            this.btnRefund.Image = ((System.Drawing.Image)(resources.GetObject("btnRefund.Image")));
            this.btnRefund.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefund.Location = new System.Drawing.Point(164, 15);
            this.btnRefund.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRefund.Name = "btnRefund";
            this.btnRefund.Size = new System.Drawing.Size(102, 40);
            this.btnRefund.TabIndex = 2;
            this.btnRefund.Text = "&Refund";
            this.btnRefund.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefund.UseVisualStyleBackColor = false;
            this.btnRefund.Click += new System.EventHandler(this.btnRefund_Click);
            // 
            // txtBoxQty
            // 
            this.txtBoxQty.BackColor = System.Drawing.Color.Snow;
            this.txtBoxQty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxQty.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxQty.Location = new System.Drawing.Point(47, 25);
            this.txtBoxQty.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxQty.MaxLength = 20;
            this.txtBoxQty.Name = "txtBoxQty";
            this.txtBoxQty.ReadOnly = true;
            this.txtBoxQty.Size = new System.Drawing.Size(107, 22);
            this.txtBoxQty.TabIndex = 1;
            this.txtBoxQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxQty.TextChanged += new System.EventHandler(this.txtBoxQty_TextChanged);
            this.txtBoxQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxQty_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Qty";
            // 
            // closeDlg
            // 
            this.closeDlg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(151)))));
            this.closeDlg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeDlg.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(151)))));
            this.closeDlg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(151)))));
            this.closeDlg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(131)))));
            this.closeDlg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeDlg.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeDlg.ForeColor = System.Drawing.Color.White;
            this.closeDlg.Image = ((System.Drawing.Image)(resources.GetObject("closeDlg.Image")));
            this.closeDlg.Location = new System.Drawing.Point(944, 3);
            this.closeDlg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.closeDlg.Name = "closeDlg";
            this.closeDlg.Size = new System.Drawing.Size(51, 47);
            this.closeDlg.TabIndex = 5;
            this.closeDlg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.closeDlg.UseVisualStyleBackColor = false;
            this.closeDlg.Click += new System.EventHandler(this.closeDlg_Click);
            // 
            // eanCode
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eanCode.DefaultCellStyle = dataGridViewCellStyle1;
            this.eanCode.HeaderText = "EAN";
            this.eanCode.Name = "eanCode";
            this.eanCode.ReadOnly = true;
            this.eanCode.Width = 130;
            // 
            // qty
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.qty.DefaultCellStyle = dataGridViewCellStyle2;
            this.qty.HeaderText = "Qty";
            this.qty.Name = "qty";
            this.qty.ReadOnly = true;
            this.qty.Width = 75;
            // 
            // description
            // 
            this.description.HeaderText = "Description";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.Width = 300;
            // 
            // price
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.price.DefaultCellStyle = dataGridViewCellStyle3;
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Width = 150;
            // 
            // discount
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.discount.DefaultCellStyle = dataGridViewCellStyle4;
            this.discount.HeaderText = "Discount";
            this.discount.Name = "discount";
            this.discount.ReadOnly = true;
            this.discount.Width = 150;
            // 
            // totalamount
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            this.totalamount.DefaultCellStyle = dataGridViewCellStyle5;
            this.totalamount.HeaderText = "Total";
            this.totalamount.Name = "totalamount";
            this.totalamount.ReadOnly = true;
            // 
            // TaxType
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.TaxType.DefaultCellStyle = dataGridViewCellStyle6;
            this.TaxType.HeaderText = "*";
            this.TaxType.Name = "TaxType";
            this.TaxType.ReadOnly = true;
            this.TaxType.Width = 40;
            // 
            // frmDlgRefund
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(151)))));
            this.ClientSize = new System.Drawing.Size(1002, 590);
            this.ControlBox = false;
            this.Controls.Add(this.closeDlg);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDlgRefund";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Refund";
            this.Load += new System.EventHandler(this.frmDlgRefund_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxOR;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cBTerminal;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtBoxQty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRefund;
        private System.Windows.Forms.Button closeDlg;
        private System.Windows.Forms.DataGridViewTextBoxColumn eanCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalamount;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaxType;
    }
}