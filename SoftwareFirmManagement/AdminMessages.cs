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
    public partial class AdminMessages : Form
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
                string sid = myReader.GetString("pm_email");
                comboBox1.Items.Add(sid);

            }
        }

        void Fillcombo1()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-BGFO52G;Initial Catalog=OOP2_Project;Persist Security Info=True;User ID=sa;Password=SAif@2000");
            con.Open();
            string query = "select * from employee  ; ";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader myReader;
            myReader = cmd.ExecuteReader();
            while (myReader.Read())
            {
                string sid = myReader.GetString("emp_email");
                comboBox1.Items.Add(sid);

            }
        }
        public AdminMessages()
        {
            InitializeComponent();
        }

        private void AdminMessages_Load(object sender, EventArgs e)
        {
            Fillcombo();
            Fillcombo1();

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

        private void btnProfile_Click(object sender, EventArgs e)
        {
            new AdminDashboard().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new AdminMessageInbox().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new AdminMessages().Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label6.Text = "";
            

            bool hasError = false;
            if (textBox1.Text == "") // Email
            {
                label6.Text = "*error";
                hasError = true;

            }
            




            if (!hasError)
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-BGFO52G;Initial Catalog=OOP2_Project;Persist Security Info=True;User ID=sa;Password=SAif@2000");
                con.Open();
                SqlCommand cmd = new SqlCommand("Insert into message(email_sender,email_receiver,subject,description,markAs) VALUES(@email_sender,@email_receiver,@subject,@description,@markAs)", con);

                cmd.Parameters.AddWithValue("@email_sender", "admin@quadtech.com");
                cmd.Parameters.AddWithValue("@email_receiver", comboBox1.Text);
                cmd.Parameters.AddWithValue("@subject", textBox3.Text);
                cmd.Parameters.AddWithValue("@description", textBox1.Text);
                cmd.Parameters.AddWithValue("@markAs", "No");
                cmd.ExecuteNonQuery();
                con.Close();
                textBox1.Text = "";
                comboBox1.Text = "";
                textBox3.Text = "";
                
                MessageBox.Show("Message Successfully Sent");




            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            new AllEmail().Show();
            this.Hide();
        }
    }
}
