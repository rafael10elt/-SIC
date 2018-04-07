using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _SIC
{
    public partial class ReportUsers : Form
    {
        public ReportUsers()
        {
            InitializeComponent();
        }

        private void ReportUsers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'SICDbDataSet.Users' table. You can move, or remove it, as needed.
            this.UsersTableAdapter.Fill(this.SICDbDataSet.Users);

            SICDbEntities User = new SICDbEntities();
            IEnumerable<User> list = from u in User.Users select u;
            ReportUsers.LocalReport.ReportEmbeddedResource = "ReportUsers.rdlc";
            Microsoft.Reporting.WinForms.ReportDataSource rds = new Microsoft.Reporting.WinForms.ReportDataSource("DataSetUsers", list);
            rds.Name = "DataSetUsers";
            rds.Value = list;
            ReportUsers.LocalReport.DataSources.Add(rds);
            ReportUsers.RefreshReport();
                        

        }
    }
}
