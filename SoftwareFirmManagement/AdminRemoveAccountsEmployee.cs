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

    public partial class AdminRemoveAccountsEmployee : Form
    {

        void Fillcombo()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-BGFO52G;Initial Catalog=OOP2_Project;Persist Security Info=True;User ID=sa;Password=SAif@2000");
            con.Open();
            string query = "select * from employee  ; ";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader myReader;
            myReader = cmd.ExecuteReader();
            while (myReader.Read())
            {
                int sName = myReader.GetInt32("emp_id");
                comboBox1.Items.Add(sName);

            }
        }
        public AdminRemoveAccountsEmployee()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

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

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-BGFO52G;Initial Catalog=OOP2_Project;Persist Security Info=True;User ID=sa;Password=SAif@2000");
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete FROM employee where emp_id = @emp_id", con);
            cmd.Parameters.AddWithValue("@emp_id", comboBox1.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            comboBox1.Text = "";
            MessageBox.Show("Successfully Removed");
        }
        void showTextBox()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-BGFO52G;Initial Catalog=OOP2_Project;Persist Security Info=True;User ID=sa;Password=SAif@2000");
            con.Open();
            //
            SqlCommand cmd = new SqlCommand("SELECT emp_email FROM employee WHERE emp_id=@emp_id", con);

            cmd.Parameters.AddWithValue("@emp_id", comboBox1.Text);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    string desc = (string)reader["emp_email"];
                    textBox1.Text = desc;
                }
            }

            SqlCommand cmd1 = new SqlCommand("SELECT emp_nid FROM employee WHERE emp_id=@emp_id", con);

            cmd1.Parameters.AddWithValue("@emp_id", comboBox1.Text);
            using (SqlDataReader reader = cmd1.ExecuteReader())
            {
                while (reader.Read())
                {
                    string desc2 = (string)reader["emp_nid"];
                    textBox3.Text = desc2;
                }
            }

            SqlCommand cmd2 = new SqlCommand("SELECT emp_name FROM employee WHERE emp_id=@emp_id", con);

            cmd2.Parameters.AddWithValue("@emp_id", comboBox1.Text);
            using (SqlDataReader reader = cmd2.ExecuteReader())
            {
                while (reader.Read())
                {
                    string desc2 = (string)reader["emp_name"];
                    textBox2.Text = desc2;
                }
            }

            SqlCommand cmd3 = new SqlCommand("SELECT emp_role FROM employee WHERE emp_id=@emp_id", con);

            cmd3.Parameters.AddWithValue("@emp_id", comboBox1.Text);
            using (SqlDataReader reader = cmd3.ExecuteReader())
            {
                while (reader.Read())
                {
                    string desc2 = (string)reader["emp_role"];
                    textBox4.Text = desc2;
                }
            }


            //


            //textBox2.Text = dt1.Rows[desc1]["pm_id"].ToString();
            //textBox3.Text = dt1.Rows[desc1]["pm_nid"].ToString();
        }

        private void AdminRemoveAccountsEmployee_Load(object sender, EventArgs e)
        {
            Fillcombo();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            showTextBox();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-BGFO52G;Initial Catalog=OOP2_Project;Persist Security Info=True;User ID=sa;Password=SAif@2000");
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete FROM employee where emp_id = @emp_id", con);
            cmd.Parameters.AddWithValue("@emp_id", comboBox1.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            comboBox1.Text = "";
            MessageBox.Show("Successfully Removed");
        }
    }
}
