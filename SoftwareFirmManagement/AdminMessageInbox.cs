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
    public partial class AdminMessageInbox : Form
    {

        void Fillcombo()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-BGFO52G;Initial Catalog=OOP2_Project;Persist Security Info=True;User ID=sa;Password=SAif@2000");
            con.Open();
            string query = "select message_id from message where email_receiver = 'admin@quadtech.com'   ; ";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader myReader;
            myReader = cmd.ExecuteReader();
            while (myReader.Read())
            {
                int sid = myReader.GetInt32("message_id");
                comboBox1.Items.Add(sid);

            }
        }

        void showTextBox()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-BGFO52G;Initial Catalog=OOP2_Project;Persist Security Info=True;User ID=sa;Password=SAif@2000");
            con.Open();
            //
            SqlCommand cmd = new SqlCommand("SELECT subject FROM message WHERE message_id = @message_id; ", con);

            cmd.Parameters.AddWithValue("@message_id", comboBox1.Text);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    string desc = (string)reader["subject"];
                    textBox4.Text = desc;
                }
            }

            SqlCommand cmd1 = new SqlCommand("SELECT description FROM message WHERE message_id = @message_id ;", con);

            cmd1.Parameters.AddWithValue("@message_id", comboBox1.Text);
            using (SqlDataReader reader = cmd1.ExecuteReader())
            {
                while (reader.Read())
                {
                    string desc2 = (string)reader["description"];
                    textBox1.Text = desc2;
                }
            }

            SqlCommand cmd2 = new SqlCommand("SELECT markAs FROM message WHERE message_id = @message_id ;", con);

            cmd2.Parameters.AddWithValue("@message_id", comboBox1.Text);
            using (SqlDataReader reader = cmd2.ExecuteReader())
            {
                while (reader.Read())
                {
                    string desc2 = (string)reader["markAs"];
                    textBox2.Text = desc2;
                }
            }

            SqlCommand cmd3 = new SqlCommand("SELECT email_sender FROM message WHERE message_id = @message_id ;", con);

            cmd3.Parameters.AddWithValue("@message_id", comboBox1.Text);
            using (SqlDataReader reader = cmd3.ExecuteReader())
            {
                while (reader.Read())
                {
                    string desc2 = (string)reader["email_sender"];
                    textBox3.Text = desc2;
                }
            }
        }

        public AdminMessageInbox()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void AdminMessageInbox_Load(object sender, EventArgs e)
        {
            Fillcombo();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            showTextBox();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-BGFO52G;Initial Catalog=OOP2_Project;Persist Security Info=True;User ID=sa;Password=SAif@2000");
            con.Open();
            SqlCommand cmd = new SqlCommand("Update message set markAs = @markAs where message_id = @message_id;", con);
            cmd.Parameters.AddWithValue("@markAs", comboBox2.Text);
            cmd.Parameters.AddWithValue("@message_id", comboBox1.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Done");
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

        private void button6_Click(object sender, EventArgs e)
        {
            new AllEmail().Show();
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

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
