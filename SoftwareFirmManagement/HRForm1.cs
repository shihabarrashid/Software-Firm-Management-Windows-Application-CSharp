using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace OOP2Project
{
    public partial class HRForm1 : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
         (
               int nLeftRect,
               int nTopRect,
               int nRightRect,
               int nBottomRect,
               int nWidthEllipse,
               int nHeightEllipse

         );

        public HRForm1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = btnDashbord.Height;
            pnlNav.Top = btnDashbord.Top;
            pnlNav.Left = btnDashbord.Left;

            lbltitle.Text = "Dashboard";
            HRDashboard HRDashboard_vrb = new HRDashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            HRDashboard_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(HRDashboard_vrb);
            HRDashboard_vrb.Show();
        }

        private void HRForm1_Load(object sender, EventArgs e)
        {

        }

        private void btnDashbord_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnDashbord.Height;
            pnlNav.Top = btnDashbord.Top;
            pnlNav.Left = btnDashbord.Left;
            btnDashbord.BackColor = Color.FromArgb(46, 51, 73);

            lbltitle.Text = "Dashboard";
            this.pnlFormLoader.Controls.Clear();
            HRDashboard HRDashboard_vrb = new HRDashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            HRDashboard_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(HRDashboard_vrb);
            HRDashboard_vrb.Show();

        }

        private void btnAnalytics_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnAnalytics.Height;
            pnlNav.Top = btnAnalytics.Top;
            btnAnalytics.BackColor = Color.FromArgb(46, 51, 73);

            lbltitle.Text = "Create Log In Credentials";
            this.pnlFormLoader.Controls.Clear();
            HRCrud HRCrud_vrb = new HRCrud() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            HRCrud_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(HRCrud_vrb);
            HRCrud_vrb.Show();
        }

        private void btnCalender_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnCalender.Height;
            pnlNav.Top = btnCalender.Top;
            btnCalender.BackColor = Color.FromArgb(46, 51, 73);

            this.pnlFormLoader.Controls.Clear();
            HRAssignSal HRAssignSal_vrb = new HRAssignSal() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            HRAssignSal_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(HRAssignSal_vrb);
            HRAssignSal_vrb.Show();
            lbltitle.Text = "Assign Salary";
        }

        private void btnContactUs_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnContactUs.Height;
            pnlNav.Top = btnContactUs.Top;
            btnContactUs.BackColor = Color.FromArgb(46, 51, 73);

            this.pnlFormLoader.Controls.Clear();
            HRUpdate HRUpdate_vrb = new HRUpdate() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            HRUpdate_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(HRUpdate_vrb);
            HRUpdate_vrb.Show();
            lbltitle.Text = "Update/Remove Employees";

        }

        private void btnsettings_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnsettings.Height;
            pnlNav.Top = btnsettings.Top;
            btnsettings.BackColor = Color.FromArgb(46, 51, 73);

            this.pnlFormLoader.Controls.Clear();
            HRMessage HRMessage_vrb = new HRMessage() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            HRMessage_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(HRMessage_vrb);
            HRMessage_vrb.Show();
            lbltitle.Text = "Message";
        }

        private void btnDashbord_Leave(object sender, EventArgs e)
        {
            btnDashbord.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnAnalytics_Leave(object sender, EventArgs e)
        {
            btnAnalytics.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnCalender_Leave(object sender, EventArgs e)
        {
            btnCalender.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnContactUs_Leave(object sender, EventArgs e)
        {
            btnContactUs.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnsettings_Leave(object sender, EventArgs e)
        {
            btnsettings.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {

        }


        //log_out
        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
