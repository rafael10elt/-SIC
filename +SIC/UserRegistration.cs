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
    public partial class UserRegistration : Form
    {
        public UserRegistration()
        {
            InitializeComponent();
        }

        private void UserRegistration_Load(object sender, EventArgs e)
        {

        }

        private void grbLogin_Enter(object sender, EventArgs e)
        {

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
            if (txtEmail.Text == "" || txtEmployeeId.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("The fields Email,Password and EmployeeId must be filled!", "Warning", MessageBoxButtons.OK);
            }
            else
            {

                if (txtPassword.Text != txtRetypePassword.Text)
                {
                    lblWrongPassword.Visible = true;
                }
                else
                {
                    var option = "";
                    if (rdbYES.Checked)
                    {
                        option = "YES";
                    }
                    else if (rdbNO.Checked)
                    {
                        option = "NO";
                    }
                    else
                    {
                        MessageBox.Show("Error", "Warning", MessageBoxButtons.OK);
                    }
                    using (var db = new SICDbEntities())
                    {
                        var user = new User();
                        user.FirstName = txtFirstName.Text;
                        user.LastName = txtLastName.Text;
                        user.Email = txtEmail.Text;
                        user.JobTitle = txtJobTitle.Text;
                        user.EmployeeId = txtEmployeeId.Text;
                        user.Password = txtPassword.Text;
                        user.ADM = option;

                        db.Users.Add(user);
                        db.SaveChanges();

                    }

                    lblWrongPassword.Visible = false;
                    MessageBox.Show("User added sucessfully!", "New User Info", MessageBoxButtons.OK);
                    var m= MessageBox.Show("Do you want add more Users now?", "Warning", MessageBoxButtons.YesNo);
                    if (m.ToString() == "Yes")
                    {
                        txtFirstName.Text = "";
                        txtEmail.Text = "";
                        txtEmployeeId.Text = "";
                        txtJobTitle.Text = "";
                        txtLastName.Text = "";
                        txtPassword.Text = "";
                        txtRetypePassword.Text = "";
                        rdbNO.Checked = true;
                        rdbYES.Checked = false;
                        lblWrongPassword.Visible = false;
                    }
                    else
                    {
                        Form.ActiveForm.Close();
                    }
                }
            }
        }

        private void txtRetypePass_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblRetypePass_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFirstName.Text = "";
            txtEmail.Text = "";
            txtEmployeeId.Text = "";            
            txtJobTitle.Text = "";
            txtLastName.Text = "";
            txtPassword.Text = "";
            txtRetypePassword.Text = "";
            rdbNO.Checked = true;
            rdbYES.Checked = false;
            lblWrongPassword.Visible = false;
        }

        private void rdbNO_CheckedChanged(object sender, EventArgs e)
        {
           
        }
    }
}
