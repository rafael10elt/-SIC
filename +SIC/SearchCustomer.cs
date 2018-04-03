using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace _SIC
{
    public partial class SearchCustomer : Form
    {
        private void readCustomer()
        {
            SICDbEntities cust = new SICDbEntities();
            IEnumerable<Customer> list = from C in cust.Customers select C;
            dgvSearchCustomer.DataSource = list.ToList();

        }
        private void FindCustomer(int CustomerId)
        {
            SICDbEntities context = new SICDbEntities();
            Customer cust = context.Customers.First(u => u.CustomerId == CustomerId);

            txtCompanyName.Text = cust.CompanyName;
            txtCustomerId.Text = cust.CustomerId.ToString();
        }
        public SearchCustomer()
        {
            InitializeComponent();
        }

        private void SearchCustomer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sICDbDataSet5.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter2.Fill(this.sICDbDataSet5.Customers);
            // TODO: This line of code loads data into the 'sICDbDataSet4.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter1.Fill(this.sICDbDataSet4.Customers);
            // TODO: This line of code loads data into the 'sICDbDataSet3.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.sICDbDataSet3.Customers);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var CustomerId = Convert.ToInt32(dgvSearchCustomer.Rows[e.RowIndex].Cells[0].Value);
            FindCustomer(CustomerId);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
            string CustomerId = txtCustomerId.Text;
            string CustomerName= txtCompanyName.Text;
            OrderRelease WindowOR = new OrderRelease(CustomerId, CustomerName);
            WindowOR.Show();
                     

        }
    }
}
