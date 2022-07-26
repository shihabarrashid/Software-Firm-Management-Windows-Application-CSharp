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
    public partial class HRUpdate : Form
    {
        void Fillcombo()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-OF10F86;Initial Catalog=OOP2_Project;Persist Security Info=True;User ID=sa;Password=Saro@1998");
            con.Open();
            string query = "SELECT * FROM employee ; ";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader myReader;
            myReader = cmd.ExecuteReader();
            while (myReader.Read())
            {
                string sName = myReader.GetString(myReader.GetOrdinal("emp_name"));
                comboBox1.Items.Add(sName); 
            }
        }

        public HRUpdate()
        {
            InitializeComponent();
            Fillcombo();
        }

        /*private void HRUpdate_Load(object sender, EventArgs e)
        {
            Fillcombo();
        }*/

        private void button1_Click_1(object sender, EventArgs e)
        {
            label9.Text = "";//used this
            label4.Text = "";
            label3.Text = "";
         
            bool hasError = false;
            if (tbID.Text == "")
            {
                hasError = true;
                label9.Text = "*error";




            }

            if (!hasError)
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-OF10F86;Initial Catalog=OOP2_Project;Persist Security Info=True;User ID=sa;Password=Saro@1998");
                con.Open();
                SqlCommand cmd = new SqlCommand("Update employee set emp_id = @emp_id where emp_name = @emp_name", con);
                cmd.Parameters.AddWithValue("@emp_id", tbID.Text);
                cmd.Parameters.AddWithValue("@emp_name", comboBox1.Text);
                cmd.ExecuteNonQuery();
                con.Close();



                tbID.Text = "";



                MessageBox.Show("Successfully Updated");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label9.Text = "";//used this
            label4.Text = "";//used this
            label3.Text = "";

            bool hasError = false;
            if (tbPassword.Text == "")
            {
                hasError = true;
                label4.Text = "*error";




            }

            if (!hasError)
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-OF10F86;Initial Catalog=OOP2_Project;Persist Security Info=True;User ID=sa;Password=Saro@1998");
                con.Open();
                SqlCommand cmd = new SqlCommand("Update employee set emp_password = @emp_password where emp_name = @emp_name", con);
                cmd.Parameters.AddWithValue("@emp_password", tbPassword.Text);
                cmd.Parameters.AddWithValue("@emp_name", comboBox1.Text);
                cmd.ExecuteNonQuery();
                con.Close();



                tbPassword.Text = "";



                MessageBox.Show("Successfully Updated");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label9.Text = "";//used this
            label4.Text = "";//used this
            label3.Text = "";//used this

            bool hasError = false;
            if (tbEmail.Text == "")
            {
                hasError = true;
                label3.Text = "*error";




            }

            if (!hasError)
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-OF10F86;Initial Catalog=OOP2_Project;Persist Security Info=True;User ID=sa;Password=Saro@1998");
                con.Open();
                SqlCommand cmd = new SqlCommand("Update employee set emp_email = @emp_email where emp_name = @emp_name", con);
                cmd.Parameters.AddWithValue("@emp_email", tbEmail.Text);
                cmd.Parameters.AddWithValue("@emp_name", comboBox1.Text);
                cmd.ExecuteNonQuery();
                con.Close();



                tbEmail.Text = "";



                MessageBox.Show("Successfully Updated");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-OF10F86;Initial Catalog=OOP2_Project;Persist Security Info=True;User ID=sa;Password=Saro@1998");
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete FROM EMPLOYEE where emp_name = @pm_id", con);
            cmd.Parameters.AddWithValue("@pm_id", comboBox1.Text);
            cmd.ExecuteNonQuery();
            con.Close();



            comboBox1.Text = "";
            MessageBox.Show("Successfully Removed");
        }

        private void HRUpdate_Load(object sender, EventArgs e)
        {

        }
    }
}
