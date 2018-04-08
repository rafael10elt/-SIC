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
    public partial class ReportCustomers : Form
    {
        public ReportCustomers()
        {
            InitializeComponent();
        }

        private void ReportCustomers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'SICDbDataSet2.Customers' table. You can move, or remove it, as needed.
            this.CustomersTableAdapter.Fill(this.SICDbDataSet2.Customers);

            SICDbEntities Cust = new SICDbEntities();
            IEnumerable<Customer> list = from c in Cust.Customers select c;
            rpwCustomer.LocalReport.ReportEmbeddedResource = "ReportCustomer.rdlc";
            Microsoft.Reporting.WinForms.ReportDataSource rds = new Microsoft.Reporting.WinForms.ReportDataSource("DataSetCustomer", list);
            rds.Name = "DataSetCustomers";
            rds.Value = list;
            rpwCustomer.LocalReport.DataSources.Add(rds);
            rpwCustomer.RefreshReport();

            

        }
    }
}
