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
    public partial class ManagerCustomers : Form
    {
        private void readCustomer()
        {
            SICDbEntities cust = new SICDbEntities();
            IEnumerable<Customer> list = from C in cust.Customers select C;
            dgvCustomerList.DataSource = list.ToList();

        }
        private void FindCustomer(int CustomerId)
        {
            SICDbEntities context = new SICDbEntities();
            Customer cust = context.Customers.First(u => u.CustomerId == CustomerId);   

            txtEmail.Text = cust.Email;
            txtCompanyName.Text = cust.CompanyName;
            txtBIN.Text = cust.BIN;
            txtAddress.Text = cust.Address;
            txtCity.Text = cust.City;
            txtPhone.Text = cust.Phone;
            txtPostalCode.Text = cust.PostalCode;
            cmbProvince.Text = cust.Province;
            txtCustomerId.Text = cust.CustomerId.ToString();
        }

        public ManagerCustomers()
        {
            InitializeComponent();
            readCustomer();
        }

        private void ManagerCustomers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sICDbDataSet2.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.sICDbDataSet2.Customers);

        }

        private void dgvCustomerList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            var m = MessageBox.Show("Do you really want to close Manager Customers Window?", "Confirm Action", MessageBoxButtons.YesNo);
            if (m.ToString() == "Yes")
            {
                Form.ActiveForm.Close();
            }
            else
            {
                readCustomer();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAddress.Text = "";
            txtBIN.Text = "";
            txtCity.Text = "";
            txtCompanyName.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
            txtPostalCode.Text = "";
            cmbProvince.Text = "";
            txtCustomerId.Text = "";
            txtSearch.Text = "";
        }

        private void dgvCustomerList_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            var CustomerId = Convert.ToInt32(dgvCustomerList.Rows[e.RowIndex].Cells[0].Value);
            FindCustomer(CustomerId);
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SICDbEntities context = new SICDbEntities();
            int CustomerId = Convert.ToInt32(txtCustomerId.Text);
            Customer user = context.Customers.First(u => u.CustomerId == CustomerId);
            var m = MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.YesNo);
            if (m.ToString() == "Yes")
            {
                context.Customers.Remove(user);
                context.SaveChanges();
            }
            else
            {
                readCustomer();
            }

            readCustomer();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SICDbEntities context = new SICDbEntities();
            int CustomerId = Convert.ToInt32(txtCustomerId.Text);
            Customer cust = context.Customers.First(u => u.CustomerId == CustomerId);

            cust.Email = txtEmail.Text;
            cust.CompanyName = txtCompanyName.Text;
            cust.Address = txtAddress.Text;
            cust.City = txtCity.Text;
            cust.BIN = txtBIN.Text;
            cust.PostalCode = txtPostalCode.Text;
            cust.CustomerId = Convert.ToInt32(txtCustomerId.Text);
            cust.Phone = txtPhone.Text;
            cust.Province = cmbProvince.Text;

            var m = MessageBox.Show("Are you sure?", "Update", MessageBoxButtons.YesNo);
            if (m.ToString() == "Yes")
            {
                context.SaveChanges();
                readCustomer();
            }
            else
            {
                readCustomer();
            }            
        }

        private void dgvCustomerList_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblCompanyName_Click(object sender, EventArgs e)
        {

        }

        private void txtCompanyName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBIN_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void lblBIN_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void txtPhone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            readCustomer();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
            SICDbEntities Cust = new SICDbEntities();
            IEnumerable<Customer> list = from c in Cust.Customers where c.CompanyName == txtSearch.Text || c.BIN == txtSearch.Text || c.Email == txtSearch.Text || c.Province == txtSearch.Text || c.City == txtSearch.Text select c;
            dgvCustomerList.DataSource = list.ToList();
        }
    }
}
