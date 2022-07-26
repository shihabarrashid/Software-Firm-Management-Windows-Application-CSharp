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
    public partial class PMForm1 : Form
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

        public PMForm1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = btnDashbord.Height;
            pnlNav.Top = btnDashbord.Top;
            pnlNav.Left = btnDashbord.Left;

            lbltitle.Text = "Dashbord";
            PMDashboard PMDashboard_vrb = new PMDashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            PMDashboard_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(PMDashboard_vrb);
            PMDashboard_vrb.Show();
        }

        private void PMForm1_Load(object sender, EventArgs e)
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
            PMDashboard PMDashboard_vrb = new PMDashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            PMDashboard_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(PMDashboard_vrb);
            PMDashboard_vrb.Show();

        }

        private void btnAnalytics_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnAnalytics.Height;
            pnlNav.Top = btnAnalytics.Top;
            btnAnalytics.BackColor = Color.FromArgb(46, 51, 73);

            lbltitle.Text = "Assign Team Members";
            this.pnlFormLoader.Controls.Clear();
            PMAssignTeam PMAssignTeam_vrb = new PMAssignTeam() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            PMAssignTeam_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(PMAssignTeam_vrb);
            PMAssignTeam_vrb.Show();
        }

        private void btnCalender_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnCalender.Height;
            pnlNav.Top = btnCalender.Top;
            btnCalender.BackColor = Color.FromArgb(46, 51, 73);

            this.pnlFormLoader.Controls.Clear();
            PMAssignProject PMAssignProject_vrb = new PMAssignProject() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            PMAssignProject_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(PMAssignProject_vrb);
            PMAssignProject_vrb.Show();
            lbltitle.Text = "Assign Projects";
        }

        private void btnContactUs_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnContactUs.Height;
            pnlNav.Top = btnContactUs.Top;
            btnContactUs.BackColor = Color.FromArgb(46, 51, 73);

            this.pnlFormLoader.Controls.Clear();
            PMessage PMessage_vrb = new PMessage() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            PMessage_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(PMessage_vrb);
            PMessage_vrb.Show();
            lbltitle.Text = "Message";
        }

        private void btnsettings_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnsettings.Height;
            pnlNav.Top = btnsettings.Top;
            btnsettings.BackColor = Color.FromArgb(46, 51, 73);

            this.pnlFormLoader.Controls.Clear();
            PMFunds PMFunds_vrb = new PMFunds() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            PMFunds_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(PMFunds_vrb);
            PMFunds_vrb.Show();
            lbltitle.Text = "Allocate Funds";
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

        private void button2_Leave(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(24, 30, 54);
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

        private void button2_Click(object sender, EventArgs e)
        {
            pnlNav.Height = button2.Height;
            pnlNav.Top = button2.Top;
            button2.BackColor = Color.FromArgb(46, 51, 73);

            this.pnlFormLoader.Controls.Clear();
            PMFunds PMFunds_vrb = new PMFunds() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            PMFunds_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(PMFunds_vrb);
            PMFunds_vrb.Show();
            lbltitle.Text = "Assign Team Leader";
        }

        private void pnlFormLoader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlNav_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbltitle_Click(object sender, EventArgs e)
        {

        }
    }
}
