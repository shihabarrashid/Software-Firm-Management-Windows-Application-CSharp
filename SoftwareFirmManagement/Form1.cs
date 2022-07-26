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

    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "admin" && txtPassword.Text == "12345")
            {
                new AdminDashboard().Show();
                this.Hide();
            }
            else if (txtUsername.Text == "manager" && txtPassword.Text == "12345") {
                new ManagerDashboard().Show();
                this.Hide();
            }
            else if (txtUsername.Text == "accounts" && txtPassword.Text == "12345")
            {
                new AccountsDashboard().Show();
                this.Hide();
            }
            else if (txtUsername.Text == "project" && txtPassword.Text == "12345")
            {
                new ProjectDashboard().Show();
                this.Hide();
            }
            else if (txtUsername.Text == "employee" && txtPassword.Text == "12345")
            {
                //new EmployeeDashboard().Show();
                this.Hide();
            } //Add Project Leader
            else {
                MessageBox.Show("The username or password is incorrect, try again");
                txtPassword.Clear();
                txtUsername.Clear();
                txtUsername.Focus();

            }
        }

        

        private void label2_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
