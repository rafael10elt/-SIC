namespace _SIC
{
    partial class SearchCustomer
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
            this.dgvSearchCustomer = new System.Windows.Forms.DataGridView();
            this.grbSearchCustomer = new System.Windows.Forms.GroupBox();
            this.sICDbDataSet3 = new _SIC.SICDbDataSet3();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter = new _SIC.SICDbDataSet3TableAdapters.CustomersTableAdapter();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.lblCustomerId = new System.Windows.Forms.Label();
            this.sICDbDataSet4 = new _SIC.SICDbDataSet4();
            this.customersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter1 = new _SIC.SICDbDataSet4TableAdapters.CustomersTableAdapter();
            this.sICDbDataSet5 = new _SIC.SICDbDataSet5();
            this.customersBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter2 = new _SIC.SICDbDataSet5TableAdapters.CustomersTableAdapter();
            this.customerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bINDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.provinceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postalCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchCustomer)).BeginInit();
            this.grbSearchCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sICDbDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sICDbDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sICDbDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSearchCustomer
            // 
            this.dgvSearchCustomer.AutoGenerateColumns = false;
            this.dgvSearchCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerIdDataGridViewTextBoxColumn,
            this.companyNameDataGridViewTextBoxColumn,
            this.bINDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.provinceDataGridViewTextBoxColumn,
            this.postalCodeDataGridViewTextBoxColumn});
            this.dgvSearchCustomer.DataSource = this.customersBindingSource2;
            this.dgvSearchCustomer.Location = new System.Drawing.Point(6, 19);
            this.dgvSearchCustomer.Name = "dgvSearchCustomer";
            this.dgvSearchCustomer.Size = new System.Drawing.Size(703, 242);
            this.dgvSearchCustomer.TabIndex = 0;
            this.dgvSearchCustomer.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // grbSearchCustomer
            // 
            this.grbSearchCustomer.Controls.Add(this.lblCustomerId);
            this.grbSearchCustomer.Controls.Add(this.lblCompanyName);
            this.grbSearchCustomer.Controls.Add(this.txtCompanyName);
            this.grbSearchCustomer.Controls.Add(this.txtCustomerId);
            this.grbSearchCustomer.Controls.Add(this.btnCancel);
            this.grbSearchCustomer.Controls.Add(this.btnOK);
            this.grbSearchCustomer.Controls.Add(this.dgvSearchCustomer);
            this.grbSearchCustomer.Location = new System.Drawing.Point(12, 12);
            this.grbSearchCustomer.Name = "grbSearchCustomer";
            this.grbSearchCustomer.Size = new System.Drawing.Size(720, 348);
            this.grbSearchCustomer.TabIndex = 1;
            this.grbSearchCustomer.TabStop = false;
            this.grbSearchCustomer.Text = "Search Customer";
            // 
            // sICDbDataSet3
            // 
            this.sICDbDataSet3.DataSetName = "SICDbDataSet3";
            this.sICDbDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.sICDbDataSet3;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(456, 303);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(570, 303);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.Location = new System.Drawing.Point(96, 306);
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.ReadOnly = true;
            this.txtCustomerId.Size = new System.Drawing.Size(54, 20);
            this.txtCustomerId.TabIndex = 3;
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(270, 305);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.ReadOnly = true;
            this.txtCompanyName.Size = new System.Drawing.Size(171, 20);
            this.txtCompanyName.TabIndex = 4;
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyName.Location = new System.Drawing.Point(156, 306);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(108, 15);
            this.lblCompanyName.TabIndex = 5;
            this.lblCompanyName.Text = "Company Name";
            // 
            // lblCustomerId
            // 
            this.lblCustomerId.AutoSize = true;
            this.lblCustomerId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerId.Location = new System.Drawing.Point(6, 307);
            this.lblCustomerId.Name = "lblCustomerId";
            this.lblCustomerId.Size = new System.Drawing.Size(84, 15);
            this.lblCustomerId.TabIndex = 6;
            this.lblCustomerId.Text = "Customer Id";
            // 
            // sICDbDataSet4
            // 
            this.sICDbDataSet4.DataSetName = "SICDbDataSet4";
            this.sICDbDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersBindingSource1
            // 
            this.customersBindingSource1.DataMember = "Customers";
            this.customersBindingSource1.DataSource = this.sICDbDataSet4;
            // 
            // customersTableAdapter1
            // 
            this.customersTableAdapter1.ClearBeforeFill = true;
            // 
            // sICDbDataSet5
            // 
            this.sICDbDataSet5.DataSetName = "SICDbDataSet5";
            this.sICDbDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersBindingSource2
            // 
            this.customersBindingSource2.DataMember = "Customers";
            this.customersBindingSource2.DataSource = this.sICDbDataSet5;
            // 
            // customersTableAdapter2
            // 
            this.customersTableAdapter2.ClearBeforeFill = true;
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
            // SearchCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 372);
            this.Controls.Add(this.grbSearchCustomer);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchCustomer";
            this.Load += new System.EventHandler(this.SearchCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchCustomer)).EndInit();
            this.grbSearchCustomer.ResumeLayout(false);
            this.grbSearchCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sICDbDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sICDbDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sICDbDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSearchCustomer;
        private System.Windows.Forms.GroupBox grbSearchCustomer;
        private SICDbDataSet3 sICDbDataSet3;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private SICDbDataSet3TableAdapters.CustomersTableAdapter customersTableAdapter;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblCustomerId;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.TextBox txtCustomerId;
        private SICDbDataSet4 sICDbDataSet4;
        private System.Windows.Forms.BindingSource customersBindingSource1;
        private SICDbDataSet4TableAdapters.CustomersTableAdapter customersTableAdapter1;
        private SICDbDataSet5 sICDbDataSet5;
        private System.Windows.Forms.BindingSource customersBindingSource2;
        private SICDbDataSet5TableAdapters.CustomersTableAdapter customersTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bINDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn provinceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postalCodeDataGridViewTextBoxColumn;
    }
}