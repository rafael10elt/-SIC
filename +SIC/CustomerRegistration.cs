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
    public partial class CustomerRegistration : Form
    {
        public CustomerRegistration()
        {
            InitializeComponent();
        }

        private void lblCompanyName_Click(object sender, EventArgs e)
        {

        }

        private void CustomerRegistration_Load(object sender, EventArgs e)
        {

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
            if (txtCompanyName.Text == "" || txtEmail.Text == "")
            {
                MessageBox.Show("The fields Company Name and Email must be filled!", "Warning", MessageBoxButtons.OK);
            }
            else
            {

                using (var db = new SICDbEntities())
                    {
                        var cust = new Customer();
                        cust.CompanyName = txtCompanyName.Text;
                        cust.BIN = txtBIN.Text;
                        cust.Email = txtEmail.Text;
                        cust.Address = txtAddress.Text;
                        cust.Phone = txtPhone.Text;
                        cust.City = txtCity.Text;
                        cust.PostalCode = txtPostalCode.Text;
                        cust.Province = Convert.ToString(cmbProvince.SelectedItem);

                    db.Customers.Add(cust);
                    db.SaveChanges();

                    }
                MessageBox.Show("User added sucessfully!", "New User Info", MessageBoxButtons.OK);
                var m = MessageBox.Show("Do you want add more Users now?", "Warning", MessageBoxButtons.YesNo);
                if (m.ToString() == "Yes")
                {
                    txtAddress.Text = "";
                    txtBIN.Text = "";
                    txtCity.Text = "";
                    txtCompanyName.Text = "";
                    txtEmail.Text = "";
                    txtPhone.Text = "";
                    txtPostalCode.Text = "";
                    cmbProvince.Text = "";
                }
                else
                {
                    Form.ActiveForm.Close();
                }
                MessageBox.Show("Customer added sucessfully!", "New Customer Info", MessageBoxButtons.OK);
                    Form.ActiveForm.Close();
                }
            }
        }
        
    }
