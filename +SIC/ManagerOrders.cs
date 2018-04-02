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
        {
            SICDbEntities context = new SICDbEntities();
            Order ord = context.Orders.First(u => u.OrderId == OrderId);

            //var cust = new customer();
            //txtCustomerId.Text = cust.CustomerId.ToString;
            //txtCustomerName.Text = cust.CompanyName;
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

        private void dgvOrdersList_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
