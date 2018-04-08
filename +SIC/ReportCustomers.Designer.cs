namespace _SIC
{
    partial class ReportCustomers
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.CustomersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SICDbDataSet2 = new _SIC.SICDbDataSet2();
            this.rpwCustomer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.CustomersTableAdapter = new _SIC.SICDbDataSet2TableAdapters.CustomersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SICDbDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomersBindingSource
            // 
            this.CustomersBindingSource.DataMember = "Customers";
            this.CustomersBindingSource.DataSource = this.SICDbDataSet2;
            // 
            // SICDbDataSet2
            // 
            this.SICDbDataSet2.DataSetName = "SICDbDataSet2";
            this.SICDbDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rpwCustomer
            // 
            this.rpwCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetCustomer";
            reportDataSource1.Value = this.CustomersBindingSource;
            this.rpwCustomer.LocalReport.DataSources.Add(reportDataSource1);
            this.rpwCustomer.LocalReport.ReportEmbeddedResource = "";
            this.rpwCustomer.LocalReport.ReportPath = "C:\\Users\\Rafa\\source\\repos\\+SIC\\+SIC\\ReportCustomerTable.rdlc";
            this.rpwCustomer.Location = new System.Drawing.Point(0, 0);
            this.rpwCustomer.Name = "rpwCustomer";
            this.rpwCustomer.ServerReport.BearerToken = null;
            this.rpwCustomer.ServerReport.ReportPath = "C:\\Users\\Rafa\\source\\repos\\+SIC\\+SIC\\ReportCustomers.Designer.cs";
            this.rpwCustomer.Size = new System.Drawing.Size(734, 450);
            this.rpwCustomer.TabIndex = 1;
            // 
            // CustomersTableAdapter
            // 
            this.CustomersTableAdapter.ClearBeforeFill = true;
            // 
            // ReportCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 450);
            this.Controls.Add(this.rpwCustomer);
            this.MaximizeBox = false;
            this.Name = "ReportCustomers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportCustomers";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReportCustomers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CustomersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SICDbDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpwCustomer;
        private System.Windows.Forms.BindingSource CustomersBindingSource;
        private SICDbDataSet2 SICDbDataSet2;
        private SICDbDataSet2TableAdapters.CustomersTableAdapter CustomersTableAdapter;
    }
}