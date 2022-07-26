using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP2Project
{
    public partial class AdminViewAllAccounts : Form
    {
        public void BindData()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-BGFO52G;Initial Catalog=OOP2_Project;Persist Security Info=True;User ID=sa;Password=SAif@2000");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * from employee", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }
        public AdminViewAllAccounts()
        {
            InitializeComponent();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            new AdminDashboard().Show();
            this.Hide();
        }

        private void btnAnalytics_Click(object sender, EventArgs e)
        {
            new AdminAddNewAccounts().Show();
            this.Hide();
        }

        private void btnSalary_Click(object sender, EventArgs e)
        {
            new AdminViewAllAccounts().Show();
            this.Hide();
        }

        private void btnMargin_Click(object sender, EventArgs e)
        {
            new AdminRemoveAccountsEmployee().Show();
            this.Hide();
        }

        private void btnMessages_Click(object sender, EventArgs e)
        {
            new AdminEditAccountsEmployee().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new AdminMessages().Show();
            this.Hide();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AdminViewAllAccounts_Load(object sender, EventArgs e)
        {
            BindData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
