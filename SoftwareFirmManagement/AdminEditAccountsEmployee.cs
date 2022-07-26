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
    public partial class AdminEditAccountsEmployee : Form
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
        public AdminEditAccountsEmployee()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label11.Text = "";//used this
            label12.Text = "";
            label13.Text = "";
            label14.Text = "";
            label15.Text = "";
            label16.Text = "";
            bool hasError = false;
            if (textBox1.Text == "")
            {
                hasError = true;
                label11.Text = "*error";


            }
            if (!hasError)
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-BGFO52G;Initial Catalog=OOP2_Project;Persist Security Info=True;User ID=sa;Password=SAif@2000");
                con.Open();
                SqlCommand cmd = new SqlCommand("Update employee set emp_password = @emp_password where emp_id = @emp_id", con);
                cmd.Parameters.AddWithValue("@emp_password", textBox1.Text);
                cmd.Parameters.AddWithValue("@emp_id", comboBox1.Text);
                cmd.ExecuteNonQuery();
                con.Close();

                textBox1.Text = "";

                MessageBox.Show("Successfully updated");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label11.Text = "";
            label12.Text = "";//used this
            label13.Text = "";
            label14.Text = "";
            label15.Text = "";
            label16.Text = "";
            bool hasError = false;
            if (textBox2.Text == "")
            {
                hasError = true;
                label12.Text = "*error";


            }
            if (!hasError)
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-BGFO52G;Initial Catalog=OOP2_Project;Persist Security Info=True;User ID=sa;Password=SAif@2000");
                con.Open();
                SqlCommand cmd = new SqlCommand("Update employee set pm_nid = @emp_nid where emp_id = @emp_id", con);
                cmd.Parameters.AddWithValue("@emp_nid", textBox2.Text);
                cmd.Parameters.AddWithValue("@emp_id", comboBox1.Text);
                cmd.ExecuteNonQuery();
                con.Close();

                textBox2.Text = "";

                MessageBox.Show("Successfully updated");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label11.Text = "";
            label12.Text = "";
            label13.Text = "";//used this
            label14.Text = "";
            label15.Text = "";
            label16.Text = "";
            bool hasError = false;
            if (textBox3.Text == "")
            {
                hasError = true;
                label13.Text = "*error";


            }
            if (!hasError)
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-BGFO52G;Initial Catalog=OOP2_Project;Persist Security Info=True;User ID=sa;Password=SAif@2000");
                con.Open();
                SqlCommand cmd = new SqlCommand("Update employee set emp_email = @emp_email where emp_id = @emp_id", con);
                cmd.Parameters.AddWithValue("@emp_email", textBox3.Text);
                cmd.Parameters.AddWithValue("@emp_id", comboBox1.Text);
                cmd.ExecuteNonQuery();
                con.Close();

                textBox3.Text = "";

                MessageBox.Show("Successfully updated");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label11.Text = "";
            label12.Text = "";
            label13.Text = "";
            label14.Text = "";//used this
            label15.Text = "";
            label16.Text = "";
            bool hasError = false;
            if (textBox4.Text == "")
            {
                hasError = true;
                label14.Text = "*error";


            }
            if (!hasError)
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-BGFO52G;Initial Catalog=OOP2_Project;Persist Security Info=True;User ID=sa;Password=SAif@2000");
                con.Open();
                SqlCommand cmd = new SqlCommand("Update employee set emp_blood_group = @emp_blood_group where emp_id = @emp_id", con);
                cmd.Parameters.AddWithValue("@emp_blood_group", textBox4.Text);
                cmd.Parameters.AddWithValue("@emp_id", comboBox1.Text);
                cmd.ExecuteNonQuery();
                con.Close();

                textBox4.Text = "";

                MessageBox.Show("Successfully updated");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label11.Text = "";
            label12.Text = "";
            label13.Text = "";
            label14.Text = "";
            label15.Text = "";//used this
            label16.Text = "";
            bool hasError = false;
            if (textBox5.Text == "")
            {
                hasError = true;
                label15.Text = "*error";


            }
            if (!hasError)
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-BGFO52G;Initial Catalog=OOP2_Project;Persist Security Info=True;User ID=sa;Password=SAif@2000");
                con.Open();
                SqlCommand cmd = new SqlCommand("Update employee set emp_dob = @emp_dob where emp_id = @emp_id", con);
                cmd.Parameters.AddWithValue("@emp_dob", textBox5.Text);
                cmd.Parameters.AddWithValue("@emp_id", comboBox1.Text);
                cmd.ExecuteNonQuery();
                con.Close();

                textBox5.Text = "";

                MessageBox.Show("Successfully updated");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label11.Text = "";
            label12.Text = "";
            label13.Text = "";
            label14.Text = "";
            label15.Text = "";
            label16.Text = "";//used this
            bool hasError = false;
            if (textBox6.Text == "")
            {
                hasError = true;
                label16.Text = "*error";


            }
            if (!hasError)
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-BGFO52G;Initial Catalog=OOP2_Project;Persist Security Info=True;User ID=sa;Password=SAif@2000");
                con.Open();
                SqlCommand cmd = new SqlCommand("Update employee set emp_phone_number = @emp_phone_number where emp_id = @emp_id", con);
                cmd.Parameters.AddWithValue("@emp_phone_number", textBox6.Text);
                cmd.Parameters.AddWithValue("@emp_id", comboBox1.Text);
                cmd.ExecuteNonQuery();
                con.Close();

                textBox6.Text = "";

                MessageBox.Show("Successfully updated");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label11.Text = "";
            label12.Text = "";
            label13.Text = "";
            label14.Text = "";
            label15.Text = "";
            label16.Text = "";
            label18.Text = "";//used this
            bool hasError = false;
            if (textBox7.Text == "")
            {
                hasError = true;
                label18.Text = "*error";


            }
            if (!hasError)
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-BGFO52G;Initial Catalog=OOP2_Project;Persist Security Info=True;User ID=sa;Password=SAif@2000");
                con.Open();
                SqlCommand cmd = new SqlCommand("Update employee set emp_role = @emp_role where emp_id = @emp_id", con);
                cmd.Parameters.AddWithValue("@emp_role", textBox7.Text);
                cmd.Parameters.AddWithValue("@emp_id", comboBox1.Text);
                cmd.ExecuteNonQuery();
                con.Close();

                textBox7.Text = "";

                MessageBox.Show("Successfully updated");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AdminEditAccountsEmployee_Load(object sender, EventArgs e)
        {
            Fillcombo();
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
    }
}
