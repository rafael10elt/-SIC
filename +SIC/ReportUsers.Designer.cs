namespace _SIC
{
    partial class ReportUsers
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
            this.UsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SICDbDataSet = new _SIC.SICDbDataSet();
            this.rpwUsers = new Microsoft.Reporting.WinForms.ReportViewer();
            this.UsersTableAdapter = new _SIC.SICDbDataSetTableAdapters.UsersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.UsersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SICDbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // UsersBindingSource
            // 
            this.UsersBindingSource.DataMember = "Users";
            this.UsersBindingSource.DataSource = this.SICDbDataSet;
            // 
            // SICDbDataSet
            // 
            this.SICDbDataSet.DataSetName = "SICDbDataSet";
            this.SICDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rpwUsers
            // 
            this.rpwUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetUsers";
            reportDataSource1.Value = this.UsersBindingSource;
            this.rpwUsers.LocalReport.DataSources.Add(reportDataSource1);
            this.rpwUsers.LocalReport.ReportEmbeddedResource = "";
            this.rpwUsers.LocalReport.ReportPath = "C:\\Users\\Rafa\\source\\repos\\+SIC\\+SIC\\ReportUserTable.rdlc";
            this.rpwUsers.Location = new System.Drawing.Point(0, 0);
            this.rpwUsers.Name = "rpwUsers";
            this.rpwUsers.ServerReport.BearerToken = null;
            this.rpwUsers.ServerReport.ReportPath = "C:\\Users\\Rafa\\source\\repos\\+SIC\\+SIC\\ReportUsers.rdlc";
            this.rpwUsers.Size = new System.Drawing.Size(736, 471);
            this.rpwUsers.TabIndex = 1;
            // 
            // UsersTableAdapter
            // 
            this.UsersTableAdapter.ClearBeforeFill = true;
            // 
            // ReportUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 471);
            this.Controls.Add(this.rpwUsers);
            this.MaximizeBox = false;
            this.Name = "ReportUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportUsers";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReportUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UsersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SICDbDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpwUsers;
        private System.Windows.Forms.BindingSource UsersBindingSource;
        private SICDbDataSet SICDbDataSet;
        private SICDbDataSetTableAdapters.UsersTableAdapter UsersTableAdapter;
    }
}