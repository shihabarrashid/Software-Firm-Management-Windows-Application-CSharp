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
    public partial class AdminCreateTeam : Form
    {

        void Fillcombo()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-BGFO52G;Initial Catalog=OOP2_Project;Persist Security Info=True;User ID=sa;Password=SAif@2000");
            con.Open();
            string query = "select * from project_management where team_id is NULL  ; ";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader myReader;
            myReader = cmd.ExecuteReader();
            while (myReader.Read())
            {
                int sid = myReader.GetInt32("pm_id");
                comboBox1.Items.Add(sid);

            }
        }

        void Fillcombo2()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-BGFO52G;Initial Catalog=OOP2_Project;Persist Security Info=True;User ID=sa;Password=SAif@2000");
            con.Open();
            string query = "select * from employee where emp_role = 'Junior Dev'; ";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader myReader;
            myReader = cmd.ExecuteReader();
            while (myReader.Read())
            {
                int sid = myReader.GetInt32("emp_id");
                comboBox2.Items.Add(sid);

            }
        }
        public AdminCreateTeam()
        {
            InitializeComponent();
        }

        private void AdminCreateTeam_Load(object sender, EventArgs e)
        {
            Fillcombo();
            Fillcombo2();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            new AdminDashboard().Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            label8.Text = "";
            label9.Text = "";
            label10.Text = "";
            label11.Text = "";
            label12.Text = "";
            

            bool hasError = false;
            if (textBox1.Text == "")
            {
                label8.Text = "*cannot be empty";
                hasError = true;

            }
            if (comboBox1.Text == "")
            {
                label9.Text = "*cannot be empty";
                hasError = true;

            }
            if (comboBox2.Text == "")
            {
                label10.Text = "*cannot be empty";
                hasError = true;

            }
            if (textBox2.Text == "")
            {
                label11.Text = "*cannot be empty";
                hasError = true;

            }
            if (textBox3.Text == "")
            {
                label12.Text = "*cannot be empty";
                hasError = true;

            }
            
            if (!hasError)
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-BGFO52G;Initial Catalog=OOP2_Project;Persist Security Info=True;User ID=sa;Password=SAif@2000");
                con.Open();
                SqlCommand cmd = new SqlCommand("Insert into team(team_id,team_type,project_manager_id,project_leader_id,number_of_members) VALUES(@team_id, @team_type, @project_manager_id, @project_leader_id, @number_of_members)", con);
                cmd.Parameters.AddWithValue("@team_id", int.Parse(textBox2.Text));
                cmd.Parameters.AddWithValue("@team_type", textBox1.Text);
                cmd.Parameters.AddWithValue("@project_manager_id", comboBox1.Text);
                cmd.Parameters.AddWithValue("@project_leader_id", comboBox2.Text);
                cmd.Parameters.AddWithValue("@number_of_members", textBox3.Text);
                cmd.ExecuteNonQuery();

                
                
                
                SqlCommand cmd1 = new SqlCommand("Update project_management set team_id = @team_id where pm_id = @project_manager_id", con);
                cmd1.Parameters.AddWithValue("@team_id", int.Parse(textBox2.Text));
                cmd1.Parameters.AddWithValue("@project_manager_id", int.Parse(comboBox1.Text));
                cmd1.ExecuteNonQuery();
                
                SqlCommand cmd2 = new SqlCommand("Update employee set emp_role = 'Project Leader' where emp_id = @project_leader_id", con);
                cmd2.Parameters.AddWithValue("@project_leader_id", Convert.ToInt32(comboBox2.Text));
                cmd2.ExecuteNonQuery();
                
                SqlCommand cmd3 = new SqlCommand("Update employee set team_id = @team_id where emp_id = @project_leader_id", con);
                cmd3.Parameters.AddWithValue("@team_id", int.Parse(textBox2.Text));
                cmd3.Parameters.AddWithValue("@project_leader_id", int.Parse(comboBox2.Text));
                cmd3.ExecuteNonQuery();
                con.Close();

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                comboBox1.Text = "";
                comboBox2.Text = "";
                MessageBox.Show("Successfully Created");




            }
        }

        private void btnAnalytics_Click(object sender, EventArgs e)
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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMargin_Click(object sender, EventArgs e)
        {
            new AdminViewTeam().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new AdminRemoveTeam().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new AdminMessages().Show();
            this.Hide();
        }

        private void btnSalary_Click(object sender, EventArgs e)
        {
            new AdminAddTeamMembers().Show();
            this.Hide();
        }
    }
}
