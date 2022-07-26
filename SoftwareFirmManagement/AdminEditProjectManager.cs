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
    public partial class AdminEditProjectManager : Form
    {

        void Fillcombo()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-BGFO52G;Initial Catalog=OOP2_Project;Persist Security Info=True;User ID=sa;Password=SAif@2000");
            con.Open();
            string query = "select * from project_management  ; ";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader myReader;
            myReader = cmd.ExecuteReader();
            while (myReader.Read())
            {
                string sName = myReader.GetString("pm_name");
                comboBox1.Items.Add(sName);

            }
        }
        public AdminEditProjectManager()
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
            new AdminProjectManagers().Show();
            this.Hide();
        }

        private void btnSalary_Click(object sender, EventArgs e)
        {
            new AdminViewAll().Show();
            this.Hide();
        }

        private void btnMargin_Click(object sender, EventArgs e)
        {
            new AdminRemoveProjectManagers().Show();
            this.Hide();
        }

        private void btnMessages_Click(object sender, EventArgs e)
        {
            new AdminEditProjectManager().Show();
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

        private void button2_Click(object sender, EventArgs e)
        {
            new AdminMessages().Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AdminEditProjectManager_Load(object sender, EventArgs e)
        {
            Fillcombo();
        }

        private void label10_Click(object sender, EventArgs e)
        {

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
                SqlCommand cmd = new SqlCommand("Update project_management set pm_password = @pm_password where pm_name = @pm_name", con);
                cmd.Parameters.AddWithValue("@pm_password", textBox1.Text);
                cmd.Parameters.AddWithValue("@pm_name", comboBox1.Text);
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
                SqlCommand cmd = new SqlCommand("Update project_management set pm_nid = @pm_nid where pm_name = @pm_name", con);
                cmd.Parameters.AddWithValue("@pm_nid", textBox2.Text);
                cmd.Parameters.AddWithValue("@pm_name", comboBox1.Text);
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
                SqlCommand cmd = new SqlCommand("Update project_management set pm_email = @pm_email where pm_name = @pm_name", con);
                cmd.Parameters.AddWithValue("@pm_email", textBox3.Text);
                cmd.Parameters.AddWithValue("@pm_name", comboBox1.Text);
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
                SqlCommand cmd = new SqlCommand("Update project_management set pm_blood_group = @pm_blood_group where pm_name = @pm_name", con);
                cmd.Parameters.AddWithValue("@pm_blood_group", textBox4.Text);
                cmd.Parameters.AddWithValue("@pm_name", comboBox1.Text);
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
                SqlCommand cmd = new SqlCommand("Update project_management set pm_dob = @pm_dob where pm_name = @pm_name", con);
                cmd.Parameters.AddWithValue("@pm_dob", textBox5.Text);
                cmd.Parameters.AddWithValue("@pm_name", comboBox1.Text);
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
                SqlCommand cmd = new SqlCommand("Update project_management set pm_phone_number = @pm_phone_number where pm_name = @pm_name", con);
                cmd.Parameters.AddWithValue("@pm_phone_number", textBox6.Text);
                cmd.Parameters.AddWithValue("@pm_name", comboBox1.Text);
                cmd.ExecuteNonQuery();
                con.Close();

                textBox6.Text = "";

                MessageBox.Show("Successfully updated");
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
