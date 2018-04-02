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
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void addNewOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form OrderRelease = new OrderRelease();
            OrderRelease.Show();
        }

        private void viewReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void manageOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ManagerOrder = new ManagerOrders();
            ManagerOrder.Show();
        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // SICDbEntities context = new SICDbEntities();
           // String Email = lblEmailUserLogonText.Text;
           //// User user = context.Users.First(u => u.UserId == Email);
           // var m = MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.YesNo);
           // if (user.ADM == "Yes")
           // {
           //     Form NewUser = new UserRegistration();
           //     NewUser.Show();
           // }
           // else
           // {
           //     MessageBox.Show("You are not an Adminstrator!", "Warning", MessageBoxButtons.OK);
           // }
                        
        }

        private void manageUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ManagerUser = new ManagerUsers();
            ManagerUser.Show();
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sorry, it is not done yet!", "About", MessageBoxButtons.OK);
        }
    }
}
