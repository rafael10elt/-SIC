namespace _SIC
{
    partial class CustomerRegistration
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
            this.grbRegisterCustomer = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.lblPostalCode = new System.Windows.Forms.Label();
            this.cmbProvince = new System.Windows.Forms.ComboBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblProvince = new System.Windows.Forms.Label();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.txtBIN = new System.Windows.Forms.TextBox();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.lblBIN = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.grbRegisterCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbRegisterCustomer
            // 
            this.grbRegisterCustomer.Controls.Add(this.btnClear);
            this.grbRegisterCustomer.Controls.Add(this.txtPostalCode);
            this.grbRegisterCustomer.Controls.Add(this.lblPostalCode);
            this.grbRegisterCustomer.Controls.Add(this.cmbProvince);
            this.grbRegisterCustomer.Controls.Add(this.txtPhone);
            this.grbRegisterCustomer.Controls.Add(this.lblPhone);
            this.grbRegisterCustomer.Controls.Add(this.lblProvince);
            this.grbRegisterCustomer.Controls.Add(this.txtCompanyName);
            this.grbRegisterCustomer.Controls.Add(this.txtBIN);
            this.grbRegisterCustomer.Controls.Add(this.lblCompanyName);
            this.grbRegisterCustomer.Controls.Add(this.lblBIN);
            this.grbRegisterCustomer.Controls.Add(this.btnCancel);
            this.grbRegisterCustomer.Controls.Add(this.txtCity);
            this.grbRegisterCustomer.Controls.Add(this.lblCity);
            this.grbRegisterCustomer.Controls.Add(this.btnSave);
            this.grbRegisterCustomer.Controls.Add(this.txtEmail);
            this.grbRegisterCustomer.Controls.Add(this.txtAddress);
            this.grbRegisterCustomer.Controls.Add(this.lblEmail);
            this.grbRegisterCustomer.Controls.Add(this.lblAddress);
            this.grbRegisterCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbRegisterCustomer.Location = new System.Drawing.Point(12, 12);
            this.grbRegisterCustomer.Name = "grbRegisterCustomer";
            this.grbRegisterCustomer.Size = new System.Drawing.Size(484, 244);
            this.grbRegisterCustomer.TabIndex = 11;
            this.grbRegisterCustomer.TabStop = false;
            this.grbRegisterCustomer.Text = "Register Customer";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(199, 195);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(64, 30);
            this.btnClear.TabIndex = 50;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.Location = new System.Drawing.Point(343, 133);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(122, 21);
            this.txtPostalCode.TabIndex = 45;
            // 
            // lblPostalCode
            // 
            this.lblPostalCode.AutoSize = true;
            this.lblPostalCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostalCode.Location = new System.Drawing.Point(244, 138);
            this.lblPostalCode.Name = "lblPostalCode";
            this.lblPostalCode.Size = new System.Drawing.Size(93, 16);
            this.lblPostalCode.TabIndex = 44;
            this.lblPostalCode.Text = "Postal Code";
            // 
            // cmbProvince
            // 
            this.cmbProvince.FormattingEnabled = true;
            this.cmbProvince.Items.AddRange(new object[] {
            "",
            "Alberta",
            "British Columbia",
            "Manitoba",
            "New Brunswick",
            "Newfoundland and Labrador",
            "Northwest Territories",
            "Nova Scotia",
            "Nunavut",
            "Ontario",
            "Prince Edward Island",
            "Quebec",
            "Saskatchewan",
            "Yukon"});
            this.cmbProvince.Location = new System.Drawing.Point(84, 134);
            this.cmbProvince.Name = "cmbProvince";
            this.cmbProvince.Size = new System.Drawing.Size(154, 23);
            this.cmbProvince.TabIndex = 43;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(70, 67);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(154, 21);
            this.txtPhone.TabIndex = 19;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(12, 72);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(52, 16);
            this.lblPhone.TabIndex = 18;
            this.lblPhone.Text = "Phone";
            // 
            // lblProvince
            // 
            this.lblProvince.AutoSize = true;
            this.lblProvince.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvince.Location = new System.Drawing.Point(12, 137);
            this.lblProvince.Name = "lblProvince";
            this.lblProvince.Size = new System.Drawing.Size(69, 16);
            this.lblProvince.TabIndex = 16;
            this.lblProvince.Text = "Province";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(136, 31);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(154, 21);
            this.txtCompanyName.TabIndex = 14;
            // 
            // txtBIN
            // 
            this.txtBIN.Location = new System.Drawing.Point(338, 31);
            this.txtBIN.Name = "txtBIN";
            this.txtBIN.Size = new System.Drawing.Size(128, 21);
            this.txtBIN.TabIndex = 15;
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyName.Location = new System.Drawing.Point(12, 34);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(118, 16);
            this.lblCompanyName.TabIndex = 12;
            this.lblCompanyName.Text = "Company Name";
            this.lblCompanyName.Click += new System.EventHandler(this.lblCompanyName_Click);
            // 
            // lblBIN
            // 
            this.lblBIN.AutoSize = true;
            this.lblBIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBIN.Location = new System.Drawing.Point(299, 34);
            this.lblBIN.Name = "lblBIN";
            this.lblBIN.Size = new System.Drawing.Size(33, 16);
            this.lblBIN.TabIndex = 13;
            this.lblBIN.Text = "BIN";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(269, 195);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(64, 30);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(286, 101);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(154, 21);
            this.txtCity.TabIndex = 10;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(244, 101);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(34, 16);
            this.lblCity.TabIndex = 9;
            this.lblCity.Text = "City";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(127, 195);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(66, 30);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(286, 64);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(179, 21);
            this.txtEmail.TabIndex = 5;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(84, 101);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(154, 21);
            this.txtAddress.TabIndex = 6;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(233, 67);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(47, 16);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(12, 104);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(66, 16);
            this.lblAddress.TabIndex = 3;
            this.lblAddress.Text = "Address";
            // 
            // CustomerRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(509, 271);
            this.Controls.Add(this.grbRegisterCustomer);
            this.Name = "CustomerRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerRegistration";
            this.Load += new System.EventHandler(this.CustomerRegistration_Load);
            this.grbRegisterCustomer.ResumeLayout(false);
            this.grbRegisterCustomer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbRegisterCustomer;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblProvince;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.TextBox txtBIN;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.Label lblBIN;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtPostalCode;
        private System.Windows.Forms.Label lblPostalCode;
        private System.Windows.Forms.ComboBox cmbProvince;
        private System.Windows.Forms.Button btnClear;
    }
}