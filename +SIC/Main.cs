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
    public partial class Main : Form
    {
        public Main(string email)
        {
            InitializeComponent();
            lblEmailUserLogonText.Text = email;
        }
          
        public void Main_Load(object sender, EventArgs e)
        {
            
        }

        public void addNewOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            string CustomerId = "";
            string CustomerName = "";
            OrderRelease WindowOR = new OrderRelease(CustomerId, CustomerName);
            WindowOR.Show();
        }

        private void viewReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form NewCustomer = new CustomerRegistration();
            NewCustomer.Show();
        }

        private void manageOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ManagerOrder = new ManagerOrders();
            ManagerOrder.Show();
        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SICDbEntities context = new SICDbEntities();
            String Email = lblEmailUserLogonText.Text;
            User user = context.Users.First(u => u.Email == Email);
            
            if (user.ADM == "YES")
            {
                Form NewUser = new UserRegistration();
                NewUser.Show();
            }
            else
            {
                MessageBox.Show("You are not an Adminstrator!", "Warning", MessageBoxButtons.OK);
            }

        }

        private void manageUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SICDbEntities context = new SICDbEntities();
            String Email = lblEmailUserLogonText.Text;
            User user = context.Users.First(u => u.Email == Email);
            
            if (user.ADM == "YES")
            {
                Form ManagerUser = new ManagerUsers();
                ManagerUser.Show();
            }
            else
            {
                MessageBox.Show("You are not an Adminstrator!", "Warning", MessageBoxButtons.OK);
            }

            
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sorry, it is not done yet!", "About", MessageBoxButtons.OK);
        }

        private void manageReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ManagerCustomer = new ManagerCustomers();
            ManagerCustomer.Show();
        }

        private void linklblLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var m = MessageBox.Show("Do you really want to Logout?", "Confirm Action", MessageBoxButtons.YesNo);
            if (m.ToString() == "Yes")
            {
                Form.ActiveForm.Close();

            }
            else
            {
                //readOrders();
            }
            
        }

        private void lblStart_Click(object sender, EventArgs e)
        {

        }

        private void lblStartLogon_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTimeActual.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void customersReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SICDbEntities context = new SICDbEntities();
            String Email = lblEmailUserLogonText.Text;
            User user = context.Users.First(u => u.Email == Email);
            
            if (user.ADM == "YES")
            {
                ReportCustomers newRC = new ReportCustomers();
                newRC.Show();
            }
            else
            {
                MessageBox.Show("You are not an Adminstrator!", "Warning", MessageBoxButtons.OK);
            }

          
        }

        private void ordersReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SICDbEntities context = new SICDbEntities();
            String Email = lblEmailUserLogonText.Text;
            User user = context.Users.First(u => u.Email == Email);
            
            if (user.ADM == "YES")
            {
                ReportOrders newRO = new ReportOrders();
                newRO.Show();
            }
            else
            {
                MessageBox.Show("You are not an Adminstrator!", "Warning", MessageBoxButtons.OK);
            }

            
        }

        private void usersReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SICDbEntities context = new SICDbEntities();
            String Email = lblEmailUserLogonText.Text;
            User user = context.Users.First(u => u.Email == Email);
          
            if (user.ADM == "YES")
            {
                ReportUsers newRU = new ReportUsers();
                newRU.Show();
            }
            else
            {
                MessageBox.Show("You are not an Adminstrator!", "Warning", MessageBoxButtons.OK);
            }

            
        }
    }
}
