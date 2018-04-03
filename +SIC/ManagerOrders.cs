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
    public partial class ManagerOrders : Form
    {
        private void readOrder()
        {
            SICDbEntities ord = new SICDbEntities();
            IEnumerable<Order> list = from o in ord.Orders select o;
            dgvOrdersList.DataSource = list.ToList();

        }
        private void FindOrder(int OrderId)
            // private void FindOrder(int OrderId, int CustomerId)
        {
            SICDbEntities context = new SICDbEntities();
            Order ord = context.Orders.First(o => o.OrderId == OrderId);
            //Order cust = context.Customers.First(c => c.CustomerId == CustomerId);

            var cust = new Customer();
            txtCustomerId.Text = cust.CustomerId.ToString();
            txtCustomerName.Text = cust.CompanyName;
            txtProductName.Text = ord.ProductName;
            txtBrand.Text = ord.Brand;
            txtSpecification.Text = ord.Specification;
            cmbCurrency.Text = ord.Currency;
            txtPrice.Text = ord.Price;
            cmbWarehouse.Text = ord.Warehouse;
            cmbRoom.Text = ord.Room;
            cmbAisle.Text = ord.Aisle;
            cmbProductType.Text = ord.ProductType;
            cmbShelf.Text = ord.Shelf;
            txtQuantity.Text = ord.Quantity;
            txtOrderId.Text = ord.OrderId.ToString();

        }
            public ManagerOrders()
        {
            InitializeComponent();
        }

        private void ManagerOrders_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sICDbDataSet6.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter1.Fill(this.sICDbDataSet6.Orders);
            // TODO: This line of code loads data into the 'sICDbDataSet1.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.sICDbDataSet1.Orders);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            var m = MessageBox.Show("Do you really want to close Manager Orders Window?", "Confirm Action", MessageBoxButtons.YesNo);
            if (m.ToString() == "Yes")
            {
                Form.ActiveForm.Close();
            }
            else
            {
                readOrder();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBrand.Text = "";
            txtPrice.Text = "";
            txtProductName.Text = "";
            txtQuantity.Text = "";
            txtSpecification.Text = "";
            cmbAisle.Text = "";
            cmbProductType.Text = "";
            cmbRoom.Text = "";
            cmbShelf.Text = "";
            cmbWarehouse.Text = "";
            txtOrderId.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SICDbEntities context = new SICDbEntities();
            int OrderId = Convert.ToInt32(txtOrderId.Text);
            Order ord = context.Orders.First(u => u.OrderId == OrderId);
            var m = MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.YesNo);
            if (m.ToString() == "Yes")
            {
                context.Orders.Remove(ord);
                context.SaveChanges();
            }
            else
            {
                readOrder();
            }

            readOrder();
        }

        private void dgvOrdersList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var OrderId = Convert.ToInt32(dgvOrdersList.Rows[e.RowIndex].Cells[0].Value);
            var CustomerId = Convert.ToInt32(dgvOrdersList.Rows[e.RowIndex].Cells[0].Value);
            FindOrder(OrderId);
           // FindOrder(OrderId,CustomerId);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SICDbEntities context = new SICDbEntities();
            int OrderId = Convert.ToInt32(txtOrderId.Text);
            Order ord = context.Orders.First(o => o.OrderId == OrderId);

            ord.ProductName = txtProductName.Text;
            ord.Brand  = txtBrand.Text;
            ord.Specification = txtSpecification.Text;
            ord.Currency = cmbCurrency.Text;
            ord.Price = txtPrice.Text;
            ord.Warehouse = cmbWarehouse.Text;
            ord.Room = cmbRoom.Text;
            ord.Aisle = cmbAisle.Text;
            ord.ProductType = cmbProductType.Text;
            ord.Shelf = cmbShelf.Text;
            ord.Quantity = txtQuantity.Text;
            ord.OrderId = Convert.ToInt32(txtOrderId.Text);

            var m = MessageBox.Show("Are you sure?", "Update", MessageBoxButtons.YesNo);
            if (m.ToString() == "Yes")
            {
                context.SaveChanges();
                readOrder();
            }
            else
            {
                readOrder();
            }

        }

        private void grbOrdersList_Enter(object sender, EventArgs e)
        {

        }
    }
}
