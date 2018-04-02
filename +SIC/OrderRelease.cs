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
    public partial class OrderRelease : Form
    {
        public OrderRelease()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void OrderRelease_Load(object sender, EventArgs e)
        {

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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var m = MessageBox.Show("Do you really want to close this window?", "Confirm Action", MessageBoxButtons.YesNo);
            if (m.ToString() == "Yes")
            {
                Form.ActiveForm.Close();
            }
            else
            {
                //readCustomers();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtProductName.Text == "")
            {
                MessageBox.Show("The fields Product Name must be filled!", "Warning", MessageBoxButtons.OK);
            }
            else
            {

                using (var db = new SICDbEntities())
                {
                    var ord = new Order();
                    var cust = new Customer();                    
                    cust.CompanyName = txtCustomerName.Text;
                    ord.ProductName = txtProductName.Text;
                    ord.Brand = txtBrand.Text;
                    ord.Specification = txtSpecification.Text;
                    ord.Currency = Convert.ToString(cmbCurrency.SelectedItem);
                    ord.Price = txtPrice.Text;
                    ord.Warehouse = Convert.ToString(cmbWarehouse.SelectedItem);
                    ord.Room = Convert.ToString(cmbRoom.SelectedItem);
                    ord.Aisle = Convert.ToString(cmbAisle.SelectedItem);
                    ord.ProductType = Convert.ToString(cmbProductType.SelectedItem);
                    ord.Shelf = Convert.ToString(cmbShelf.SelectedItem);
                    ord.Quantity = txtQuantity.Text;


                    db.Orders.Add(ord);
                    db.SaveChanges();

                }

                MessageBox.Show("Order released sucessfully!", "Order Release Info", MessageBoxButtons.OK);
                txtBrand.Text = "";
                txtPrice.Text = "";
                txtProductName.Text = "";
                txtQuantity.Text = "";
                txtSpecification.Text = "";
                cmbProductType.Text = "";
                
            }
        }
    }

}       