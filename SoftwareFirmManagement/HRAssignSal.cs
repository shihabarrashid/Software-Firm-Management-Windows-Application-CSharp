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
    public partial class HRAssignSal : Form
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

        public HRAssignSal()
        {
            InitializeComponent();
            Fillcombo();
        }

       
        private void button1_Click_1(object sender, EventArgs e)
        {
            label7.Text = "";//used this
            label6.Text = "";
            label1.Text = "";

            bool hasError = false;
            if (tbSalary.Text == "")
            {
                hasError = true;
                label7.Text = "*error";




            }

            if (!hasError)
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-OF10F86;Initial Catalog=OOP2_Project;Persist Security Info=True;User ID=sa;Password=Saro@1998");
                con.Open();
                SqlCommand cmd = new SqlCommand("Update employee set emp_salary = @emp_salary where emp_name = @emp_name", con);
                cmd.Parameters.AddWithValue("@emp_salary", tbSalary.Text);
                cmd.Parameters.AddWithValue("@emp_name", comboBox1.Text);
                cmd.ExecuteNonQuery();
                con.Close();



                tbSalary.Text = "";



                MessageBox.Show("Successfully Assigned");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label7.Text = "";//used this
            label6.Text = "";//used this
            label1.Text = "";

            bool hasError = false;
            if (tbBonus.Text == "")
            {
                hasError = true;
                label6.Text = "*error";




            }

            if (!hasError)
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-OF10F86;Initial Catalog=OOP2_Project;Persist Security Info=True;User ID=sa;Password=Saro@1998");
                con.Open();
                SqlCommand cmd = new SqlCommand("Update employee set emp_bonus = @emp_bonus where emp_name = @emp_name", con);
                cmd.Parameters.AddWithValue("@emp_bonus", tbBonus.Text);
                cmd.Parameters.AddWithValue("@emp_name", comboBox1.Text);
                cmd.ExecuteNonQuery();
                con.Close();



                tbBonus.Text = "";



                MessageBox.Show("Successfully Assigned");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label7.Text = "";//used this
            label6.Text = "";//used this
            label1.Text = "";

            bool hasError = false;
            if (tbPaid_Leave.Text == "")
            {
                hasError = true;
                label1.Text = "*error";




            }

            if (!hasError)
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-OF10F86;Initial Catalog=OOP2_Project;Persist Security Info=True;User ID=sa;Password=Saro@1998");
                con.Open();
                SqlCommand cmd = new SqlCommand("Update employee set emp_paid_leave = @emp_paid_leave where emp_name = @emp_name", con);
                cmd.Parameters.AddWithValue("@emp_paid_leave", tbPaid_Leave.Text);
                cmd.Parameters.AddWithValue("@emp_name", comboBox1.Text);
                cmd.ExecuteNonQuery();
                con.Close();



                tbPaid_Leave.Text = "";



                MessageBox.Show("Successfully Assigned");
            }
        }

        private void HRAssignSal_Load(object sender, EventArgs e)
        {

        }
    }
}
