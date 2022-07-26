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
    public partial class AdminRemoveProjectManagers : Form
    {

        void Fillcombo() {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-BGFO52G;Initial Catalog=OOP2_Project;Persist Security Info=True;User ID=sa;Password=SAif@2000");
            con.Open();
            string query = "select * from project_management  ; ";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader myReader;
            myReader = cmd.ExecuteReader();
            while (myReader.Read()) {
                int sid = myReader.GetInt32("pm_id");
                comboBox1.Items.Add(sid);
            
            }
        }

        public AdminRemoveProjectManagers()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-BGFO52G;Initial Catalog=OOP2_Project;Persist Security Info=True;User ID=sa;Password=SAif@2000");
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete FROM project_management where pm_id = @pm_id", con);
            cmd.Parameters.AddWithValue("@pm_id", comboBox1.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            comboBox1.Text = "";
            MessageBox.Show("Successfully Removed");
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

        private void btnSalary_Click(object sender, EventArgs e)
        {
            new AdminViewAll().Show();
            this.Hide();
        }

        private void btnAnalytics_Click(object sender, EventArgs e)
        {
            new AdminProjectManagers().Show();
            this.Hide();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            new AdminDashboard().Show();
            this.Hide();
        }

        private void btnMessages_Click(object sender, EventArgs e)
        {
            new AdminEditProjectManager().Show();
            this.Hide();
        }

        private void btnMargin_Click(object sender, EventArgs e)
        {
            new AdminRemoveProjectManagers().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new AdminMessages().Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        void showTextBox() {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-BGFO52G;Initial Catalog=OOP2_Project;Persist Security Info=True;User ID=sa;Password=SAif@2000");
            con.Open();
            //
            SqlCommand cmd = new SqlCommand("SELECT pm_email FROM project_management WHERE pm_id=@pm_id", con);
                
                    cmd.Parameters.AddWithValue("@pm_id", comboBox1.Text);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string desc = (string)reader["pm_email"];
                        textBox1.Text = desc;
                        }
                    }

            SqlCommand cmd1 = new SqlCommand("SELECT pm_nid FROM project_management WHERE pm_id=@pm_id", con);

            cmd1.Parameters.AddWithValue("@pm_id", comboBox1.Text);
            using (SqlDataReader reader = cmd1.ExecuteReader())
            {
                while (reader.Read())
                {
                    string desc2 = (string)reader["pm_nid"];
                    textBox3.Text = desc2;
                }
            }

            SqlCommand cmd2 = new SqlCommand("SELECT pm_name FROM project_management WHERE pm_id=@pm_id", con);

            cmd2.Parameters.AddWithValue("@pm_id", comboBox1.Text);
            using (SqlDataReader reader = cmd2.ExecuteReader())
            {
                while (reader.Read())
                {
                    string desc2 = (string)reader["pm_name"];
                    textBox2.Text = desc2;
                }
            }


            //


            //textBox2.Text = dt1.Rows[desc1]["pm_id"].ToString();
            //textBox3.Text = dt1.Rows[desc1]["pm_nid"].ToString();

        }

        private void AdminRemoveProjectManagers_Load(object sender, EventArgs e)
        {
            Fillcombo();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            showTextBox();
        }
    }
}
