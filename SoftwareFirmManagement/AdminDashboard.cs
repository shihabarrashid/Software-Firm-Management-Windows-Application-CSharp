using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP2Project
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void btnAnalytics_Click(object sender, EventArgs e)
        {
            
                new AdminViewAllEmployees().Show();
            this.Hide();
        }

        private void details_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            new AdminMessages().Show();
            this.Hide();
        }

        private void btnSalary_Click(object sender, EventArgs e)
        {
            new AdminProjectManagers().Show();
            this.Hide();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {

        }

        private void btnMargin_Click(object sender, EventArgs e)
        {

        }

        private void btnMessages_Click(object sender, EventArgs e)
        {
            new AdminAddNewAccounts().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            new AdminCreateTeam().Show();
            this.Hide();
        }
    }
}
