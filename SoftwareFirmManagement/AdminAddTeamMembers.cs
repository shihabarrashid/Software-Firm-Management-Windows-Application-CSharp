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
    public partial class AdminAddTeamMembers : Form
    {

        void Fillcombo()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-BGFO52G;Initial Catalog=OOP2_Project;Persist Security Info=True;User ID=sa;Password=SAif@2000");
            con.Open();
            string query = "select * from team  ; ";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader myReader;
            myReader = cmd.ExecuteReader();
            while (myReader.Read())
            {
                int sid = myReader.GetInt32("team_id");
                comboBox1.Items.Add(sid);

            }
        }

        void Fillcombo1()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-BGFO52G;Initial Catalog=OOP2_Project;Persist Security Info=True;User ID=sa;Password=SAif@2000");
            con.Open();
            string query = "select * from employee where team_id is NULL and emp_role = 'Junior Dev'  ; ";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader myReader;
            myReader = cmd.ExecuteReader();
            while (myReader.Read())
            {
                int sid = myReader.GetInt32("emp_id");
                comboBox2.Items.Add(sid);

            }
        }
        public AdminAddTeamMembers()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label6.Text = "";
            label7.Text = "";
            
            bool hasError = false;
            if (comboBox1.Text == "")
            {
                label6.Text = "*cannot be empty";
                hasError = true;

            }
            if (comboBox2.Text == "")
            {
                label7.Text = "*cannot be empty";
                hasError = true;

            }
            

            if (!hasError)
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-BGFO52G;Initial Catalog=OOP2_Project;Persist Security Info=True;User ID=sa;Password=SAif@2000");
                con.Open();
                
                SqlCommand cmd1 = new SqlCommand("Update employee set team_id = @team_id where emp_id = @emp_id", con);
                cmd1.Parameters.AddWithValue("@team_id", int.Parse(comboBox1.Text));
                cmd1.Parameters.AddWithValue("@emp_id", int.Parse(comboBox2.Text));
                cmd1.ExecuteNonQuery();
                con.Close();

                comboBox1.Text = "";
                comboBox2.Text = "";
                MessageBox.Show("Successfully Created");

                



            }
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            new AdminDashboard().Show();
            this.Hide();
        }

        private void btnAnalytics_Click(object sender, EventArgs e)
        {
            new AdminCreateTeam().Show();
            this.Hide();
        }

        private void btnSalary_Click(object sender, EventArgs e)
        {
            new AdminAddTeamMembers().Show();
            this.Hide();
        }

        private void btnMargin_Click(object sender, EventArgs e)
        {
            new AdminViewTeam().Show();
            this.Hide();
        }

        private void btnMessages_Click(object sender, EventArgs e)
        {
            
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

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AdminAddTeamMembers_Load(object sender, EventArgs e)
        {
            Fillcombo();
            Fillcombo1();
        }
    }
}
