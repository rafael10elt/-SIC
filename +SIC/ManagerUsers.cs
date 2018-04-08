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
    public partial class ManagerUsers : Form
    {
        private void readUsers()
        {
            SICDbEntities use = new SICDbEntities();
            IEnumerable<User> list = from U in use.Users select U;
            dgvUsersList.DataSource = list.ToList();

        }
        private void FindUsers(int UserId)
        {
            SICDbEntities context = new SICDbEntities();
            User user = context.Users.First(u => u.UserId == UserId);

            if (user.ADM == "YES")
            {
                rdbYES.Checked = true;
            }
            else
            {
                rdbNO.Checked = true;
            }

            txtEmail.Text = user.Email;
            txtFirstName.Text = user.FirstName;
            txtLastName.Text = user.LastName;
            txtEmployeeId.Text = user.EmployeeId;
            txtJobTitle.Text = user.JobTitle;
            txtPassword.Text = user.Password;
            txtRetypePassword.Text = user.Password;
            txtUserId.Text = user.UserId.ToString();
        }

        public ManagerUsers()
        {
            InitializeComponent();
            readUsers();
        }
                private void ManagerUsers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sICDbDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.sICDbDataSet.Users);

        }

        private void dgvUsersList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
           var m = MessageBox.Show("Do you really want to close Manager Users Window?", "Confirm Action", MessageBoxButtons.YesNo);
            if(m.ToString() == "Yes")
            {
                Form.ActiveForm.Close();
            }
            else
            {
                readUsers();
            }
           
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEmail.Text = "";
            txtEmployeeId.Text = "";
            txtFirstName.Text = "";
            txtJobTitle.Text = "";
            txtLastName.Text = "";
            txtPassword.Text = "";
            txtRetypePassword.Text = "";
            txtUserId.Text = "";
            rdbNO.Checked = true;
            rdbYES.Checked = false;
            lblWrongPassword.Visible = false;
            txtSearch.Text = "";
        }

        private void dgvUsersList_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            var UserId = Convert.ToInt32(dgvUsersList.Rows[e.RowIndex].Cells[0].Value);
            FindUsers(UserId);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text != txtRetypePassword.Text)
            {
                lblWrongPassword.Visible = true;
            }
            else
            {
                var option = "";
                if (rdbYES.Checked == true)
                {
                    option = "YES";
                }
                else if (rdbNO.Checked == true)
                {
                    option = "NO";
                }
                SICDbEntities context = new SICDbEntities();
                int UserId = Convert.ToInt32(txtUserId.Text);
                User user = context.Users.First(u => u.UserId == UserId);

                user.Email = txtEmail.Text;
                user.FirstName = txtFirstName.Text;
                user.LastName = txtLastName.Text;
                user.EmployeeId = txtEmployeeId.Text;
                user.JobTitle = txtJobTitle.Text;
                user.Password = txtPassword.Text;
                user.UserId = Convert.ToInt32(txtUserId.Text);
                user.ADM = option;

                var m = MessageBox.Show("Are you sure?", "Update", MessageBoxButtons.YesNo);
                if (m.ToString() == "Yes")
                {
                    context.SaveChanges();
                    readUsers();
                    lblWrongPassword.Visible = false;
                }
                else
                {
                    readUsers();
                }


                
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SICDbEntities context = new SICDbEntities();
            int UserId = Convert.ToInt32(txtUserId.Text);
            User user = context.Users.First(u => u.UserId == UserId);
            var m = MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.YesNo);
            if (m.ToString() == "Yes")
            {
                context.Users.Remove(user);
                context.SaveChanges();
            }
            else
            {
                readUsers();
            }

            readUsers();
        }

        private void dgvUsersList_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SICDbEntities User = new SICDbEntities();
            IEnumerable<User> list = from u in User.Users where u.FirstName == txtSearch.Text || u.LastName == txtSearch.Text || u.JobTitle == txtSearch.Text || u.EmployeeId == txtSearch.Text || u.Email == txtSearch.Text || u.ADM == txtSearch.Text select u;
            dgvUsersList.DataSource = list.ToList();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            readUsers();
        }
    }
    }

