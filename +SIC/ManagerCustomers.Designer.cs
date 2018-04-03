namespace _SIC
{
    partial class ManagerCustomers
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
            this.grbCustomerList = new System.Windows.Forms.GroupBox();
            this.dgvCustomerList = new System.Windows.Forms.DataGridView();
            this.customerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bINDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.provinceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postalCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sICDbDataSet2 = new _SIC.SICDbDataSet2();
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
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.grbRegisterCustomer = new System.Windows.Forms.GroupBox();
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.lblCustomerId = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.customersTableAdapter = new _SIC.SICDbDataSet2TableAdapters.CustomersTableAdapter();
            this.grbCustomerList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sICDbDataSet2)).BeginInit();
            this.grbRegisterCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbCustomerList
            // 
            this.grbCustomerList.Controls.Add(this.dgvCustomerList);
            this.grbCustomerList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCustomerList.Location = new System.Drawing.Point(12, 12);
            this.grbCustomerList.Name = "grbCustomerList";
            this.grbCustomerList.Size = new System.Drawing.Size(733, 221);
            this.grbCustomerList.TabIndex = 22;
            this.grbCustomerList.TabStop = false;
            this.grbCustomerList.Text = "Customers List";
            // 
            // dgvCustomerList
            // 
            this.dgvCustomerList.AutoGenerateColumns = false;
            this.dgvCustomerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomerList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerIdDataGridViewTextBoxColumn,
            this.companyNameDataGridViewTextBoxColumn,
            this.bINDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.provinceDataGridViewTextBoxColumn,
            this.postalCodeDataGridViewTextBoxColumn});
            this.dgvCustomerList.DataSource = this.customersBindingSource;
            this.dgvCustomerList.Location = new System.Drawing.Point(6, 19);
            this.dgvCustomerList.Name = "dgvCustomerList";
            this.dgvCustomerList.Size = new System.Drawing.Size(714, 191);
            this.dgvCustomerList.TabIndex = 20;
            this.dgvCustomerList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomerList_CellContentClick_2);
            this.dgvCustomerList.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomerList_CellContentClick_1);
            // 
            // customerIdDataGridViewTextBoxColumn
            // 
            this.customerIdDataGridViewTextBoxColumn.DataPropertyName = "CustomerId";
            this.customerIdDataGridViewTextBoxColumn.HeaderText = "CustomerId";
            this.customerIdDataGridViewTextBoxColumn.Name = "customerIdDataGridViewTextBoxColumn";
            this.customerIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // companyNameDataGridViewTextBoxColumn
            // 
            this.companyNameDataGridViewTextBoxColumn.DataPropertyName = "CompanyName";
            this.companyNameDataGridViewTextBoxColumn.HeaderText = "CompanyName";
            this.companyNameDataGridViewTextBoxColumn.Name = "companyNameDataGridViewTextBoxColumn";
            // 
            // bINDataGridViewTextBoxColumn
            // 
            this.bINDataGridViewTextBoxColumn.DataPropertyName = "BIN";
            this.bINDataGridViewTextBoxColumn.HeaderText = "BIN";
            this.bINDataGridViewTextBoxColumn.Name = "bINDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            // 
            // provinceDataGridViewTextBoxColumn
            // 
            this.provinceDataGridViewTextBoxColumn.DataPropertyName = "Province";
            this.provinceDataGridViewTextBoxColumn.HeaderText = "Province";
            this.provinceDataGridViewTextBoxColumn.Name = "provinceDataGridViewTextBoxColumn";
            // 
            // postalCodeDataGridViewTextBoxColumn
            // 
            this.postalCodeDataGridViewTextBoxColumn.DataPropertyName = "PostalCode";
            this.postalCodeDataGridViewTextBoxColumn.HeaderText = "PostalCode";
            this.postalCodeDataGridViewTextBoxColumn.Name = "postalCodeDataGridViewTextBoxColumn";
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.sICDbDataSet2;
            // 
            // sICDbDataSet2
            // 
            this.sICDbDataSet2.DataSetName = "SICDbDataSet2";
            this.sICDbDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.Location = new System.Drawing.Point(312, 136);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(154, 21);
            this.txtPostalCode.TabIndex = 45;
            // 
            // lblPostalCode
            // 
            this.lblPostalCode.AutoSize = true;
            this.lblPostalCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostalCode.Location = new System.Drawing.Point(213, 137);
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
            this.cmbProvince.Size = new System.Drawing.Size(123, 23);
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
            // grbRegisterCustomer
            // 
            this.grbRegisterCustomer.Controls.Add(this.txtCustomerId);
            this.grbRegisterCustomer.Controls.Add(this.lblCustomerId);
            this.grbRegisterCustomer.Controls.Add(this.btnClear);
            this.grbRegisterCustomer.Controls.Add(this.btnClose);
            this.grbRegisterCustomer.Controls.Add(this.btnDelete);
            this.grbRegisterCustomer.Controls.Add(this.btnUpdate);
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
            this.grbRegisterCustomer.Controls.Add(this.txtCity);
            this.grbRegisterCustomer.Controls.Add(this.lblCity);
            this.grbRegisterCustomer.Controls.Add(this.txtEmail);
            this.grbRegisterCustomer.Controls.Add(this.txtAddress);
            this.grbRegisterCustomer.Controls.Add(this.lblEmail);
            this.grbRegisterCustomer.Controls.Add(this.lblAddress);
            this.grbRegisterCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbRegisterCustomer.Location = new System.Drawing.Point(18, 256);
            this.grbRegisterCustomer.Name = "grbRegisterCustomer";
            this.grbRegisterCustomer.Size = new System.Drawing.Size(727, 233);
            this.grbRegisterCustomer.TabIndex = 23;
            this.grbRegisterCustomer.TabStop = false;
            this.grbRegisterCustomer.Text = "Register Customer";
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.Location = new System.Drawing.Point(568, 31);
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.ReadOnly = true;
            this.txtCustomerId.Size = new System.Drawing.Size(72, 21);
            this.txtCustomerId.TabIndex = 51;
            // 
            // lblCustomerId
            // 
            this.lblCustomerId.AutoSize = true;
            this.lblCustomerId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerId.Location = new System.Drawing.Point(472, 34);
            this.lblCustomerId.Name = "lblCustomerId";
            this.lblCustomerId.Size = new System.Drawing.Size(90, 16);
            this.lblCustomerId.TabIndex = 50;
            this.lblCustomerId.Text = "Customer Id";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(368, 188);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(64, 30);
            this.btnClear.TabIndex = 49;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(456, 188);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(64, 30);
            this.btnClose.TabIndex = 48;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(285, 188);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(64, 30);
            this.btnDelete.TabIndex = 47;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(183, 188);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(82, 30);
            this.btnUpdate.TabIndex = 46;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // ManagerCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 492);
            this.Controls.Add(this.grbRegisterCustomer);
            this.Controls.Add(this.grbCustomerList);
            this.Name = "ManagerCustomers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManagerCustomers";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ManagerCustomers_Load);
            this.grbCustomerList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sICDbDataSet2)).EndInit();
            this.grbRegisterCustomer.ResumeLayout(false);
            this.grbRegisterCustomer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbCustomerList;
        private System.Windows.Forms.DataGridView dgvCustomerList;
        private System.Windows.Forms.TextBox txtPostalCode;
        private System.Windows.Forms.Label lblPostalCode;
        private System.Windows.Forms.ComboBox cmbProvince;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblProvince;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.TextBox txtBIN;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.Label lblBIN;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.GroupBox grbRegisterCustomer;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private SICDbDataSet2 sICDbDataSet2;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private SICDbDataSet2TableAdapters.CustomersTableAdapter customersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bINDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn provinceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postalCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.Label lblCustomerId;
    }
}