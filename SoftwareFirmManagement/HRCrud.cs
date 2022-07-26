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
    public partial class HRCrud : Form
    {
        public HRCrud()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
            //label9.Text = "";
            label10.Text = "";
            label11.Text = "";
            label12.Text = "";
            label13.Text = "";
            label14.Text = "";
            label15.Text = "";
            label16.Text = "";
            label17.Text = "";

            bool hasError = false;
            if (tbName.Text == "")
            {
                label2.Text = "*cannot be empty";
                hasError = true;



            }
            if (tbEmail.Text == "")
            {
                label3.Text = "*cannot be empty";
                hasError = true;



            }
            if (tbPassword.Text == "")
            {
                label4.Text = "*cannot be empty";
                hasError = true;



            }
            /*if (tbPaid_Leave.Text == "")
            {
                label5.Text = "*cannot be empty";
                hasError = true;



            }
            if (tbBonus.Text == "")
            {
                label6.Text = "*cannot be empty";
                hasError = true;



            }
            if (tbSalary.Text == "")
            {
                label7.Text = "*cannot be empty";
                hasError = true;



            }*/
            if (tbRole.Text == "")
            {
                label8.Text = "*cannot be empty";
                hasError = true;



            }
            if (tbID.Text == "")
            {
                label9.Text = "*cannot be empty";
                hasError = true;



            }
           /* if (tbM_Status.Text == "")
            {
                label10.Text = "*cannot be empty";
                hasError = true;



            }*/
            if (tbB_Group.Text == "")
            {
                label11.Text = "*cannot be empty";
                hasError = true;



            }
            if (tbNID.Text == "")
            {
                label12.Text = "*cannot be empty";
                hasError = true;



            }
            if (tbGender.Text == "")
            {
                label13.Text = "*cannot be empty";
                hasError = true;



            }
            /*if (tbPermanent_Address.Text == "")
            {
                label14.Text = "*cannot be empty";
                hasError = true;

            }
            if (tbPresent_Address.Text == "")
            {
                label15.Text = "*cannot be empty";
                hasError = true;



            }*/
            if (tbDOB.Text == "")
            {
                label16.Text = "*cannot be empty";
                hasError = true;



            }
            if (tbPhone_Number.Text == "")
            {
                label17.Text = "*cannot be empty";
                hasError = true;



            }

            if (!hasError)
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-OF10F86;Initial Catalog=OOP2_Project;Persist Security Info=True;User ID=sa;Password=Saro@1998");
                con.Open();
                SqlCommand cmd = new SqlCommand("Insert into employee(emp_id,emp_name,emp_password,emp_email,emp_salary,emp_gender,emp_nid,emp_phone_number,emp_dob,emp_present_address,emp_blood_group,emp_maritial_status,emp_role) VALUES(@emp_id,@emp_name,@emp_password,@emp_email,@emp_salary,@emp_gender,@emp_nid,@emp_phone_number,@emp_dob,@emp_present_address,@emp_blood_group,@emp_maritial_status,@emp_role)", con);



                cmd.Parameters.AddWithValue("@emp_id", int.Parse(tbID.Text));
                cmd.Parameters.AddWithValue("@emp_name", tbName.Text);
                cmd.Parameters.AddWithValue("@emp_password", tbPassword.Text);
                cmd.Parameters.AddWithValue("@emp_email", tbEmail.Text);
               // cmd.Parameters.AddWithValue("@emp_bonus", tbBonus.Text);
                //cmd.Parameters.AddWithValue("@emp_paid_leave", tbPaid_Leave.Text);
                cmd.Parameters.AddWithValue("@emp_gender", tbGender.Text);
                cmd.Parameters.AddWithValue("@emp_salary", tbSalary.Text);
                cmd.Parameters.AddWithValue("@emp_nid", tbNID.Text);
                cmd.Parameters.AddWithValue("@emp_phone_number", tbPhone_Number.Text);
                cmd.Parameters.AddWithValue("@emp_dob", tbDOB.Text);
                cmd.Parameters.AddWithValue("@emp_present_address", tbPresent_Address.Text);
               // cmd.Parameters.AddWithValue("@emp_permanent_address", tbPresent_Address.Text);
                cmd.Parameters.AddWithValue("@emp_blood_group", tbB_Group.Text);
                cmd.Parameters.AddWithValue("@emp_maritial_status", tbM_Status.Text);
                cmd.Parameters.AddWithValue("@emp_role", tbRole.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                tbID.Text = "";
                tbName.Text = "";
                tbEmail.Text = "";
                tbPassword.Text = "";
               // tbPaid_Leave.Text = "";
               // tbBonus.Text = "";
                tbSalary.Text = "";
                tbRole.Text = "";
                tbM_Status.Text = "";
                tbB_Group.Text = "";
                tbNID.Text = "";
                tbGender.Text = "";
                tbPermanent_Address.Text = "";
                //tbPresent_Address.Text = "";
                tbDOB.Text = "";
                tbPhone_Number.Text = "";
                MessageBox.Show("Successfully Inserted");
            }

        }

        private void HRCrud_Load(object sender, EventArgs e)
        {

        }
    }
}
