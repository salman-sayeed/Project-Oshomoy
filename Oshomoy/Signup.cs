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
    public partial class Signup : UserControl
    {
        public Signup()
        {
            InitializeComponent();

            lbWarnUN.Hide();
            lbWarnEmail.Hide(); 
            lbWarnPass.Hide();
            lbWarnConPass.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 parentForm = this.Parent as Form1;
            if (parentForm != null)
            {
                parentForm.ShowLogin();
            }
        }

        private void btRegister_Click(object sender, EventArgs e)
        {
            lbWarnUN.Hide();
            lbWarnEmail.Hide();
            lbWarnPass.Hide();
            lbWarnConPass.Hide();

            bool hasError = false;

            if (string.IsNullOrWhiteSpace(tbSignUserName.Text))
            {
                lbWarnUN.Show();
                lbWarnUN.Text = "Username can't be empty";
                hasError = true;
            }

            if (string.IsNullOrWhiteSpace(tbSignEmail.Text))
            {
                lbWarnEmail.Show();
                lbWarnEmail.Text = "Email can't be empty";
                hasError = true;
            }

            if (string.IsNullOrWhiteSpace(tbSignPass.Text))
            {
                lbWarnPass.Show();
                lbWarnPass.Text = "Password can't be empty";
                hasError = true;
            }
            else if (tbSignPass.Text.Length < 8)
            {
                lbWarnPass.Show();
                lbWarnPass.Text = "Password must be at least 8 characters long";
                hasError = true;
            }

            if (string.IsNullOrWhiteSpace(tbConfirmPass.Text))
            {
                lbWarnConPass.Show();
                lbWarnConPass.Text = "Confirm Password can't be empty";
                hasError = true;
            }

            if (!hasError && tbSignPass.Text != tbConfirmPass.Text)
            {
                lbWarnConPass.Show();
                lbWarnConPass.Text = "Passwords do not match";
            }
            else if (!hasError)
            {
                lbWarnUN.Hide();
                lbWarnEmail.Hide();
                lbWarnPass.Hide();
                lbWarnConPass.Hide();

                Form1 parentForm = this.Parent as Form1;
                if (parentForm != null)
                {
                    parentForm.ShowLogin();
                }
            }
        }


        private void tbSignUserName_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void tbSignEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
