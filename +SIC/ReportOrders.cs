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
    public partial class ReportOrders : Form
    {
        public ReportOrders()
        {
            InitializeComponent();
        }

        private void ReportOrders_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'SICDbDataSet6.Orders' table. You can move, or remove it, as needed.
            this.OrdersTableAdapter.Fill(this.SICDbDataSet6.Orders);

            SICDbEntities Ord = new SICDbEntities();
            IEnumerable<Order> list = from o in Ord.Orders select o;
            ReportOrders.LocalReport.ReportEmbeddedResource = "ReportOrders.rdlc";
            Microsoft.Reporting.WinForms.ReportDataSource rds = new Microsoft.Reporting.WinForms.ReportDataSource("DataSetOrders", list);
            rds.Name = "DataSetOrders";
            rds.Value = list;
            ReportOrders.LocalReport.DataSources.Add(rds);
            ReportOrders.RefreshReport();

            

        }
    }
}
