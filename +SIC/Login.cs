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
    public partial class Login : Form
    {
       
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        public void btnLogin_Click_1(object sender, EventArgs e)
        {
            
            using (var db = new SICDbEntities())
            {
                var EmailResult =
                    (from em in db.Users
                     where em.Email == txtEmail.Text
                     select em.Email).SingleOrDefault();

                var PasswordResult =
                    (from en in db.Users
                     where en.Email == txtEmail.Text
                     select en.Password).SingleOrDefault();

                if (EmailResult != txtEmail.Text)
                {
                    MessageBox.Show("Email incorrect or no registered!", "Login Error", MessageBoxButtons.OK);
                }
                else if (PasswordResult != txtPassword.Text)
                {
                    MessageBox.Show("Password incorrect or no registered!", "Login Error", MessageBoxButtons.OK);
                }
                else
                {
                     if (Application.OpenForms["Main"] == null)
                        {
                            string email = txtEmail.Text;

                            Main NewMain = new Main(email);
                            NewMain.Show();
                            //txtEmail.Text = "";
                            txtPassword.Text = "";
                        }
                    else { 
                    
                        MessageBox.Show("You must click on Logout to allow opening as another User!", "Warning", MessageBoxButtons.OK);
                    }                
                    
                }
            }
        }
        
        private void btnLogout_Click(object sender, EventArgs e)
        {
            var m = MessageBox.Show("Do you really want to close?", "Confirm Action", MessageBoxButtons.YesNo);
            if (m.ToString() == "Yes")
            {
                //txtEmail.Text = "";
                txtPassword.Text = "";

                Environment.Exit(0);

            }
            else
            {
                //readOrders();
            }
        }
    }
}
