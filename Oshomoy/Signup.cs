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
        public Signup()
        {
            InitializeComponent();

            lbWarnUN.Hide();
            lbWarnEmail.Hide(); 
            lbWarnPass.Hide();
            lbWarnConPass.Hide();

            tbSignUserName.Focus();

            signPass1.Show();
            signPass2.Hide();
            signConPass1.Show();
            signConPass2.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 parentForm = this.Parent as Form1;
            if (parentForm != null)
            {
                parentForm.ShowLogin();
            }
        }

        private void tbSignUserName_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void tbSignEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void logPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pbSignConPass1_Click(object sender, EventArgs e)
        {

        }

        private void pbSignConPass2_Click(object sender, EventArgs e)
        {

        }

        private void signPass1_Click(object sender, EventArgs e)
        {
            tbSignPass.PasswordChar = '\0';
            signPass1.Hide();
            signPass2.Show();
        }

        private void signPass2_Click_1(object sender, EventArgs e)
        {
            tbSignPass.PasswordChar = '•';
            signPass1.Show();
            signPass2.Hide();
        }

        private void signConPass1_Click(object sender, EventArgs e)
        {
            tbConfirmPass.PasswordChar = '\0';
            signConPass1.Hide();
            signConPass2.Show();
        }

        private void signConPass2_Click(object sender, EventArgs e)
        {
            tbConfirmPass.PasswordChar = '•';
            signConPass1.Show();
            signConPass2.Hide();
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
                hasError = true;
            }
            else if (!hasError)
            {
                // Directly use the connection string
                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\SALMAN\Documents\UserInfo.mdf;Integrated Security=True;Connect Timeout=30";

                string query = "INSERT INTO Users (UserName, Email, Password, UserType) VALUES (@UserName, @Email, @Password, 'User')";

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@UserName", tbSignUserName.Text);
                            command.Parameters.AddWithValue("@Email", tbSignEmail.Text);
                            command.Parameters.AddWithValue("@Password", tbSignPass.Text); // Ensure this is hashed

                            connection.Open();
                            command.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Registration successful!");
                    tbSignUserName.Clear();
                    tbSignEmail.Clear();
                    tbSignPass.Clear();
                    tbConfirmPass.Clear();
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
