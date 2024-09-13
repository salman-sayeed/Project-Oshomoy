using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;


namespace Oshomoy
{
    public partial class Login : UserControl //Form
    {
        public Login()
        {
            InitializeComponent();
            lbWarn1.Hide();
            lbWarn2.Hide();

            paassImg.Show();
            paassImg2.Hide();

            tbLogin.Focus();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void logPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void logPanel_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void loginImage_Click(object sender, EventArgs e)
        {

        }

        private void lbUsername_Click(object sender, EventArgs e)
        {

        }

        private void tbLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 parentForm = this.Parent as Form1;
            if (parentForm != null)
            {
                parentForm.ShowSignup();
            }

        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            lbWarn1.Hide();
            lbWarn2.Hide();
            bool hasError = false;

            if (string.IsNullOrWhiteSpace(tbLogin.Text) && string.IsNullOrWhiteSpace(tbLogin2.Text))
            {
                lbWarn1.Text = "Username can't be empty";
                lbWarn1.Show();
                lbWarn2.Text = "Password can't be empty";
                lbWarn2.Show();
                hasError = true;
            }

            else if (string.IsNullOrWhiteSpace(tbLogin.Text))
            {
                lbWarn1.Text = "Username can't be empty";
                lbWarn1.Show();
                lbWarn2.Hide();
                hasError = true;
            }

            else if (string.IsNullOrWhiteSpace(tbLogin2.Text))
            {
                lbWarn2.Text = "Password can't be empty";
                lbWarn1.Hide();
                lbWarn2.Show();
                hasError = true;
            }

            if (!hasError)
            {
                lbWarn1.Hide();
                lbWarn2.Hide();

                Form1 parentForm = this.Parent as Form1;
                if (parentForm != null)
                {
                    parentForm.ShowSignup();
                }
            }
        }


        private void lbWarn1_Click(object sender, EventArgs e)
        {

        }

        

        private void paassImg_Click(object sender, EventArgs e)
        {
            tbLogin2.PasswordChar = '\0';
            paassImg.Hide();
            paassImg2.Show();
        }

        private void paassImg2_Click(object sender, EventArgs e)
        {
            tbLogin2.PasswordChar = '•';
            paassImg.Show();
            paassImg2.Hide();
        }
    }
}
