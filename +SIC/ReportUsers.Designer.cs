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
            this.rpwUsers = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SICDbDataSet = new _SIC.SICDbDataSet();
            this.UsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.UsersTableAdapter = new _SIC.SICDbDataSetTableAdapters.UsersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SICDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rpwUsers
            // 
            this.rpwUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetUsers";
            reportDataSource1.Value = this.UsersBindingSource;
            this.rpwUsers.LocalReport.DataSources.Add(reportDataSource1);
            this.rpwUsers.LocalReport.ReportEmbeddedResource = "_SIC.ReportUsers.rdlc";
            this.rpwUsers.LocalReport.ReportPath = "C:\\Users\\Rafa\\source\\repos\\WindowsForms\\project1\\CarReport.rdlc";
            this.rpwUsers.Location = new System.Drawing.Point(0, 0);
            this.rpwUsers.Name = "rpwUsers";
            this.rpwUsers.ServerReport.BearerToken = null;
            this.rpwUsers.ServerReport.ReportPath = "C:\\Users\\Rafa\\source\\repos\\+SIC\\+SIC\\ReportUsers.rdlc";
            this.rpwUsers.Size = new System.Drawing.Size(736, 471);
            this.rpwUsers.TabIndex = 1;
            // 
            // SICDbDataSet
            // 
            this.SICDbDataSet.DataSetName = "SICDbDataSet";
            this.SICDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // UsersBindingSource
            // 
            this.UsersBindingSource.DataMember = "Users";
            this.UsersBindingSource.DataSource = this.SICDbDataSet;
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
            this.Name = "ReportUsers";
            this.Text = "ReportUsers";
            this.Load += new System.EventHandler(this.ReportUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SICDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpwUsers;
        private System.Windows.Forms.BindingSource UsersBindingSource;
        private SICDbDataSet SICDbDataSet;
        private SICDbDataSetTableAdapters.UsersTableAdapter UsersTableAdapter;
    }
}