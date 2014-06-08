namespace nPOSProj
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnSales = new System.Windows.Forms.Button();
            this.btnGenReports = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnGC = new System.Windows.Forms.Button();
            this.btnUserAccounts = new System.Windows.Forms.Button();
            this.btnConfig = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblAdlib = new System.Windows.Forms.Label();
            this.lblProgversion = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.greetings = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(700, 115);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLogout.Location = new System.Drawing.Point(638, 486);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(61, 74);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.Text = "&Log-out";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnSales
            // 
            this.btnSales.Enabled = false;
            this.btnSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSales.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSales.Image = ((System.Drawing.Image)(resources.GetObject("btnSales.Image")));
            this.btnSales.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSales.Location = new System.Drawing.Point(12, 133);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(164, 162);
            this.btnSales.TabIndex = 0;
            this.btnSales.Text = "Sales (F1)";
            this.btnSales.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSales.UseVisualStyleBackColor = true;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // btnGenReports
            // 
            this.btnGenReports.Enabled = false;
            this.btnGenReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenReports.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenReports.Image = ((System.Drawing.Image)(resources.GetObject("btnGenReports.Image")));
            this.btnGenReports.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGenReports.Location = new System.Drawing.Point(522, 133);
            this.btnGenReports.Name = "btnGenReports";
            this.btnGenReports.Size = new System.Drawing.Size(164, 162);
            this.btnGenReports.TabIndex = 4;
            this.btnGenReports.Text = "Reports (F4)";
            this.btnGenReports.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGenReports.UseVisualStyleBackColor = true;
            // 
            // btnCustomers
            // 
            this.btnCustomers.Enabled = false;
            this.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomers.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomers.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomers.Image")));
            this.btnCustomers.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCustomers.Location = new System.Drawing.Point(182, 133);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(164, 162);
            this.btnCustomers.TabIndex = 1;
            this.btnCustomers.Text = "Customers (F2)";
            this.btnCustomers.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCustomers.UseVisualStyleBackColor = true;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.Enabled = false;
            this.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventory.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventory.Image = ((System.Drawing.Image)(resources.GetObject("btnInventory.Image")));
            this.btnInventory.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnInventory.Location = new System.Drawing.Point(352, 133);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(164, 162);
            this.btnInventory.TabIndex = 3;
            this.btnInventory.Text = "Inventory (F3)";
            this.btnInventory.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnInventory.UseVisualStyleBackColor = true;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // btnGC
            // 
            this.btnGC.Enabled = false;
            this.btnGC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGC.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGC.Image = ((System.Drawing.Image)(resources.GetObject("btnGC.Image")));
            this.btnGC.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGC.Location = new System.Drawing.Point(96, 301);
            this.btnGC.Name = "btnGC";
            this.btnGC.Size = new System.Drawing.Size(164, 162);
            this.btnGC.TabIndex = 5;
            this.btnGC.Text = "Gift Cards (F5)";
            this.btnGC.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGC.UseVisualStyleBackColor = true;
            // 
            // btnUserAccounts
            // 
            this.btnUserAccounts.Enabled = false;
            this.btnUserAccounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserAccounts.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserAccounts.Image = ((System.Drawing.Image)(resources.GetObject("btnUserAccounts.Image")));
            this.btnUserAccounts.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUserAccounts.Location = new System.Drawing.Point(266, 301);
            this.btnUserAccounts.Name = "btnUserAccounts";
            this.btnUserAccounts.Size = new System.Drawing.Size(164, 162);
            this.btnUserAccounts.TabIndex = 6;
            this.btnUserAccounts.Text = "&User Accounts (F6)";
            this.btnUserAccounts.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUserAccounts.UseVisualStyleBackColor = true;
            this.btnUserAccounts.Click += new System.EventHandler(this.btnUserAccounts_Click);
            // 
            // btnConfig
            // 
            this.btnConfig.Enabled = false;
            this.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfig.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfig.Image = ((System.Drawing.Image)(resources.GetObject("btnConfig.Image")));
            this.btnConfig.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnConfig.Location = new System.Drawing.Point(436, 301);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(164, 162);
            this.btnConfig.TabIndex = 7;
            this.btnConfig.Text = "Configure (F7)";
            this.btnConfig.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.Image = ((System.Drawing.Image)(resources.GetObject("btnChangePassword.Image")));
            this.btnChangePassword.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnChangePassword.Location = new System.Drawing.Point(573, 486);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(63, 74);
            this.btnChangePassword.TabIndex = 8;
            this.btnChangePassword.Text = "Change &Password";
            this.btnChangePassword.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(7, 477);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(150, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // lblAdlib
            // 
            this.lblAdlib.AutoSize = true;
            this.lblAdlib.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdlib.ForeColor = System.Drawing.Color.Black;
            this.lblAdlib.Location = new System.Drawing.Point(4, 543);
            this.lblAdlib.Name = "lblAdlib";
            this.lblAdlib.Size = new System.Drawing.Size(17, 15);
            this.lblAdlib.TabIndex = 12;
            this.lblAdlib.Text = "__";
            // 
            // lblProgversion
            // 
            this.lblProgversion.AutoSize = true;
            this.lblProgversion.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgversion.ForeColor = System.Drawing.Color.Black;
            this.lblProgversion.Location = new System.Drawing.Point(5, 531);
            this.lblProgversion.Name = "lblProgversion";
            this.lblProgversion.Size = new System.Drawing.Size(108, 15);
            this.lblProgversion.TabIndex = 11;
            this.lblProgversion.Text = "nPOS System vX.x.x.x";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(5, 519);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Creative Software Solutions";
            // 
            // greetings
            // 
            this.greetings.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greetings.ForeColor = System.Drawing.Color.Black;
            this.greetings.Location = new System.Drawing.Point(311, 523);
            this.greetings.Name = "greetings";
            this.greetings.Size = new System.Drawing.Size(254, 21);
            this.greetings.TabIndex = 13;
            this.greetings.Text = "Good ___________";
            this.greetings.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.Black;
            this.lblTime.Location = new System.Drawing.Point(308, 541);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(15, 16);
            this.lblTime.TabIndex = 14;
            this.lblTime.Text = "_";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(701, 561);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.greetings);
            this.Controls.Add(this.lblAdlib);
            this.Controls.Add(this.lblProgversion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.btnConfig);
            this.Controls.Add(this.btnUserAccounts);
            this.Controls.Add(this.btnGC);
            this.Controls.Add(this.btnInventory);
            this.Controls.Add(this.btnCustomers);
            this.Controls.Add(this.btnGenReports);
            this.Controls.Add(this.btnSales);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMenu_FormClosing);
            this.Load += new System.EventHandler(this.frmMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Button btnGenReports;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnGC;
        private System.Windows.Forms.Button btnUserAccounts;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblAdlib;
        private System.Windows.Forms.Label lblProgversion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label greetings;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer1;
    }
}

