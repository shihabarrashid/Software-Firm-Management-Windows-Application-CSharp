﻿using System;
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
    public partial class AdminProjectManagers : Form
    {
        public AdminProjectManagers()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click_1(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label18.Text = "";
            label19.Text = "";
            label20.Text = "";
            label21.Text = "";
            label22.Text = "";
            label23.Text = "";
            label24.Text = "";
            label25.Text = "";
            label26.Text = "";
            label27.Text = "";
            label28.Text = "";
            label29.Text = "";
            label30.Text = "";

            bool hasError = false;
            if (textBox1.Text == "")
            {
                label18.Text = "*cannot be empty";
                hasError = true;

            }
            if (textBox2.Text == "")
            {
                label19.Text = "*cannot be empty";
                hasError = true;

            }
            if (textBox3.Text == "")
            {
                label20.Text = "*cannot be empty";
                hasError = true;

            }
            if (textBox4.Text == "")
            {
                label21.Text = "*cannot be empty";
                hasError = true;

            }
            if (textBox5.Text == "")
            {
                label22.Text = "*cannot be empty";
                hasError = true;

            }
            if (textBox6.Text == "")
            {
                label24.Text = "*cannot be empty";
                hasError = true;

            }
            if (textBox7.Text == "")
            {
                label25.Text = "*cannot be empty";
                hasError = true;

            }
            if (textBox8.Text == "")
            {
                label26.Text = "*cannot be empty";
                hasError = true;

            }
            if (textBox9.Text == "")
            {
                label27.Text = "*cannot be empty";
                hasError = true;

            }
            if (textBox10.Text == "")
            {
                label28.Text = "*cannot be empty";
                hasError = true;

            }
            if (textBox11.Text == "")
            {
                label29.Text = "*cannot be empty";
                hasError = true;

            }
            if (comboBox1.Text == "")
            {
                label23.Text = "*cannot be empty";
                hasError = true;

            }
            if (comboBox2.Text == "")
            {
                label30.Text = "*cannot be empty";
                hasError = true;

            }





            if (!hasError)
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-BGFO52G;Initial Catalog=OOP2_Project;Persist Security Info=True;User ID=sa;Password=SAif@2000");
                con.Open();
                SqlCommand cmd = new SqlCommand("Insert into project_management(pm_id,pm_name,pm_password,pm_email,pm_salary,pm_gender,pm_nid,pm_phone_number,pm_dob,pm_present_address,pm_blood_group,pm_maritial_status,pm_role) VALUES(@pm_id,@pm_name,@pm_password,@pm_email,@pm_salary,@pm_gender,@pm_nid,@pm_phone_number,@pm_dob,@pm_present_address,@pm_blood_group,@pm_maritial_status,@pm_role)", con);

                cmd.Parameters.AddWithValue("@pm_id", int.Parse(textBox1.Text));
                cmd.Parameters.AddWithValue("@pm_name", textBox2.Text);
                cmd.Parameters.AddWithValue("@pm_password", textBox3.Text);
                cmd.Parameters.AddWithValue("@pm_email", textBox4.Text);
                cmd.Parameters.AddWithValue("@pm_gender", comboBox1.Text);
                cmd.Parameters.AddWithValue("@pm_salary", textBox5.Text);
                cmd.Parameters.AddWithValue("@pm_nid", textBox6.Text);
                cmd.Parameters.AddWithValue("@pm_phone_number", textBox7.Text);
                cmd.Parameters.AddWithValue("@pm_dob", textBox8.Text);
                cmd.Parameters.AddWithValue("@pm_present_address", textBox9.Text);
                cmd.Parameters.AddWithValue("@pm_blood_group", textBox10.Text);
                cmd.Parameters.AddWithValue("@pm_maritial_status", textBox11.Text);
                cmd.Parameters.AddWithValue("@pm_role", comboBox2.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
                textBox9.Text = "";
                textBox10.Text = "";
                textBox11.Text = "";
                MessageBox.Show("Successfully Inserted");
               



            }
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click_1(object sender, EventArgs e)
        {

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
