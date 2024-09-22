using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oshomoy
{
    public partial class Form1 : Form
    {
        public Point mouseLocation;

        public Form1()
        {
            InitializeComponent();
            signup1.Hide();
            adminDb1.Hide();
            dashboard1.Hide();
            login1.Show();
            login1.BringToFront();
        }

        private void closeBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void minimizeBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void mouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }
        private void mouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {


        }
        private void topPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void login1_Load_2(object sender, EventArgs e)
        {

        }


        public void ShowSignup()
        {
            login1.Hide();
            adminDb1.Hide();
            dashboard1.Hide();
            signup1.Show();
            signup1.BringToFront();
        }

        public void ShowLogin()
        {
            signup1.Hide();
            adminDb1.Hide();
            dashboard1.Hide();
            login1.Show();
            login1.BringToFront();
        }

        public void ShowAdminDb(int userId)
        {
            signup1.Hide();
            login1.Hide();
            dashboard1.Hide();

            adminDb1.Show();
            adminDb1.BringToFront();

            adminDb1.UserId = userId;
            adminDb1.LoadAdminData();
        }

        public void ShowDashboard(int userId)
        {
            signup1.Hide();
            login1.Hide();
            adminDb1.Hide();

            dashboard1.Show();
            dashboard1.BringToFront();

            dashboard1.UserId = userId;
            dashboard1.LoadUserData();
        }

        private void adminDb1_Load(object sender, EventArgs e)
        {

        }
    }
}
