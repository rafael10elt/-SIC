namespace _SIC
{
    partial class ReportOrders
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.OrdersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SICDbDataSet6 = new _SIC.SICDbDataSet6();
            this.rpwOrders = new Microsoft.Reporting.WinForms.ReportViewer();
            this.OrdersTableAdapter = new _SIC.SICDbDataSet6TableAdapters.OrdersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SICDbDataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // OrdersBindingSource
            // 
            this.OrdersBindingSource.DataMember = "Orders";
            this.OrdersBindingSource.DataSource = this.SICDbDataSet6;
            // 
            // SICDbDataSet6
            // 
            this.SICDbDataSet6.DataSetName = "SICDbDataSet6";
            this.SICDbDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rpwOrders
            // 
            this.rpwOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSetOrders";
            reportDataSource2.Value = this.OrdersBindingSource;
            this.rpwOrders.LocalReport.DataSources.Add(reportDataSource2);
            this.rpwOrders.LocalReport.ReportEmbeddedResource = "";
            this.rpwOrders.LocalReport.ReportPath = "C:\\Users\\Rafa\\source\\repos\\+SIC\\+SIC\\ReportOrdersTable.rdlc";
            this.rpwOrders.Location = new System.Drawing.Point(0, 0);
            this.rpwOrders.Name = "rpwOrders";
            this.rpwOrders.ServerReport.BearerToken = null;
            this.rpwOrders.Size = new System.Drawing.Size(732, 487);
            this.rpwOrders.TabIndex = 2;
            // 
            // OrdersTableAdapter
            // 
            this.OrdersTableAdapter.ClearBeforeFill = true;
            // 
            // ReportOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 487);
            this.Controls.Add(this.rpwOrders);
            this.MaximizeBox = false;
            this.Name = "ReportOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportOrders";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReportOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrdersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SICDbDataSet6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpwOrders;
        private System.Windows.Forms.BindingSource OrdersBindingSource;
        private SICDbDataSet6 SICDbDataSet6;
        private SICDbDataSet6TableAdapters.OrdersTableAdapter OrdersTableAdapter;
    }
}