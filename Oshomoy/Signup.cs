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
using System.Web.UI.WebControls;
using System.Data.SqlClient;


namespace Oshomoy
{
    public partial class Signup : UserControl
    {
        string connectionString;
        public Signup()
        {
            InitializeComponent();

            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\SALMAN\Documents\UserInfo.mdf;Integrated Security=True;Connect Timeout=30";

            lbWarnUN.Hide();
            lbWarnEmail.Hide(); 
            lbWarnPass.Hide();
            lbWarnConPass.Hide();

            tbUsername.Focus();

            showPass1.Show();
            showPass2.Hide();
            showConPass1.Show();
            showConPass2.Hide();

            tbUsername.MaxLength = 16;
            tbEmail.MaxLength = 20;
            tbPassword.MaxLength = 16;
            tbConPassword.MaxLength = 16;
            tbUsername.KeyPress += TbUsername_KeyPress;
            tbEmail.KeyPress += TbEmail_KeyPress;
            tbPassword.KeyPress += TbPassword_KeyPress;
            tbConPassword.KeyPress += TbConPassword_KeyPress;
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 parentForm = this.Parent as Form1;
            if (parentForm != null)
            {
                parentForm.ShowLogin();
            }
        }
        private void showPass1_Click(object sender, EventArgs e)
        {
            tbPassword.PasswordChar = '\0';
            showPass1.Hide();
            showPass2.Show();
        }
        private void showPass2_Click_1(object sender, EventArgs e)
        {
            tbPassword.PasswordChar = '•';
            showPass1.Show();
            showPass2.Hide();
        }
        private void showConPass1_Click(object sender, EventArgs e)
        {
            tbConPassword.PasswordChar = '\0';
            showConPass1.Hide();
            showConPass2.Show();
        }
        private void showConPass2_Click(object sender, EventArgs e)
        {
            tbConPassword.PasswordChar = '•';
            showConPass1.Show();
            showConPass2.Hide();
        }
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void TbUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                tbEmail.Focus();
            }
        }
        private void TbEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                tbPassword.Focus();
            }
        }
        private void TbPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                tbConPassword.Focus();
            }
        }
        private void TbConPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btRegister_Click(sender, e);
            }
        }


        private void btRegister_Click(object sender, EventArgs e)
        {
            lbWarnUN.Hide();
            lbWarnEmail.Hide();
            lbWarnPass.Hide();
            lbWarnConPass.Hide();

            bool hasError = false;

            if (string.IsNullOrWhiteSpace(tbUsername.Text))
            {
                lbWarnUN.Show();
                lbWarnUN.Text = "Username can't be empty";
                hasError = true;
            }

            if (string.IsNullOrWhiteSpace(tbEmail.Text))
            {
                lbWarnEmail.Show();
                lbWarnEmail.Text = "Email can't be empty";
                hasError = true;
            }

            if(!IsValidEmail(tbEmail.Text))
            {
                lbWarnEmail.Show();
                lbWarnEmail.Text = "Invalid Email";
                hasError = true;
            }

            if (string.IsNullOrWhiteSpace(tbPassword.Text))
            {
                lbWarnPass.Show();
                lbWarnPass.Text = "Password can't be empty";
                hasError = true;
            }
            else if (tbPassword.Text.Length < 8)
            {
                lbWarnPass.Show();
                lbWarnPass.Text = "Password must be at least 8 characters long";
                hasError = true;
            }

            if (string.IsNullOrWhiteSpace(tbConPassword.Text))
            {
                lbWarnConPass.Show();
                lbWarnConPass.Text = "Confirm Password can't be empty";
                hasError = true;
            }

            if (!hasError && tbPassword.Text != tbConPassword.Text)
            {
                lbWarnConPass.Show();
                lbWarnConPass.Text = "Passwords do not match";
                hasError = true;
            }

             if (!hasError)
            {
                string query = "INSERT INTO Users (UserName, Email, Password, UserType) VALUES (@UserName, @Email, @Password, 'User')";

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@UserName", tbUsername.Text);
                            command.Parameters.AddWithValue("@Email", tbEmail.Text);
                            command.Parameters.AddWithValue("@Password", tbPassword.Text);

                            connection.Open();
                            command.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Registration successful!");
                    tbUsername.Clear();
                    tbEmail.Clear();
                    tbPassword.Clear();
                    tbConPassword.Clear();
                    Form1 parentForm = this.Parent as Form1;
                    if (parentForm != null)
                    {
                        parentForm.ShowLogin();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

    }
}
