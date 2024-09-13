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
    public partial class Login : UserControl //Form
    {
        public Login()
        {
            InitializeComponent();
            lbWarn1.Hide();
            lbWarn2.Hide();
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
            if(tbLogin.Text.Length <= 0 && tbLogin2.Text.Length <= 0) 
            {
                lbWarn1.Text = "Username can't be empty";
                lbWarn1.Show();
                lbWarn2.Text = "Password can't be empty";
                lbWarn2.Show();
            }
            else if(tbLogin.Text.Length <= 0) 
            {
                lbWarn1.Text = "Username can't be empty";
                lbWarn1.Show();
                lbWarn2.Hide();
            }
            else if(tbLogin2.Text.Length <= 0)
            {
                lbWarn2.Text = "Password can't be empty";
                lbWarn2.Show();
                lbWarn2.Hide();
            }
        }

        private void lbWarn1_Click(object sender, EventArgs e)
        {

        }
    }
}
