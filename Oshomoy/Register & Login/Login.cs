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
using System.Data.SqlClient;


namespace Oshomoy
{
    public partial class Login : UserControl
    {
        string connectionString;
        public Login()
        {
            InitializeComponent();
            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\SALMAN\Documents\UserInfo.mdf;Integrated Security=True;Connect Timeout=30";

            lbWarn1.Hide();
            lbWarn2.Hide();

            paassImg.Show();
            paassImg2.Hide();

            tbUsername.Focus();

            tbUsername.MaxLength = 16;
            tbPassword.MaxLength = 16;

            tbUsername.KeyPress += TbUsername_KeyPress;
            tbPassword.KeyPress += TbPassword_KeyPress;

        }

        private void Login_Load(object sender, EventArgs e)
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

        private void lbLinkForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 parentForm = this.Parent as Form1;
            if (parentForm != null)
            {
                parentForm.ShowForgotPassword();
            }
        }

        private void paassImg_Click(object sender, EventArgs e)
        {
            tbPassword.PasswordChar = '\0';
            paassImg.Hide();
            paassImg2.Show();
        }
        private void paassImg2_Click(object sender, EventArgs e)
        {
            tbPassword.PasswordChar = '•';
            paassImg.Show();
            paassImg2.Hide();
        }
        private void gitHub_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/salman-sayeed/Project-Oshomoy";
            System.Diagnostics.Process.Start(url);
        }
        private void faceBook_Click(object sender, EventArgs e)
        {
            string url = "https://www.facebook.com/salmansayeed.25";
            System.Diagnostics.Process.Start(url);
        }
        private void linkedIn_Click(object sender, EventArgs e)
        {
            string url = "https://www.linkedin.com/in/salmansayeed25";
            System.Diagnostics.Process.Start(url);
        }
        private void TbUsername_KeyPress(object sender, KeyPressEventArgs e)
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
                btLogin_Click (sender, e);
            }
        }


        private void btLogin_Click(object sender, EventArgs e)
        {
            lbWarn1.Hide();
            lbWarn2.Hide();
            bool hasError = false;

            if (string.IsNullOrWhiteSpace(tbUsername.Text) && string.IsNullOrWhiteSpace(tbPassword.Text))
            {
                lbWarn1.Text = "Username can't be empty";
                lbWarn1.Show();
                lbWarn2.Text = "Password can't be empty";
                lbWarn2.Show();
                hasError = true;
            }
            else if (string.IsNullOrWhiteSpace(tbUsername.Text))
            {
                lbWarn1.Text = "Username can't be empty";
                lbWarn1.Show();
                lbWarn2.Hide();
                hasError = true;
            }
            else if (string.IsNullOrWhiteSpace(tbPassword.Text))
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

                string query = "SELECT UserId, UserType FROM Users WHERE UserName = @UserName AND Password = @Password";

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@UserName", tbUsername.Text);
                            command.Parameters.AddWithValue("@Password", tbPassword.Text);

                            connection.Open();

                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    int userId = reader.GetInt32(0); 
                                    string userType = reader.GetString(1);

                                    tbUsername.Clear();
                                    tbPassword.Clear();
                                    Form1 parentForm = this.Parent as Form1;

                                    if (userType == "Admin")
                                    {
                                        if (parentForm != null)
                                        {
                                            parentForm.ShowAdminDb(userId);
                                        }
                                    }
                                    else if (userType == "User")
                                    {
                                        if (parentForm != null)
                                        {
                                            parentForm.ShowDashboard(userId);
                                        }
                                    }
                                }
                                else
                                {
                                    lbWarn1.Text = "Invalid username or password";
                                    lbWarn1.Show();
                                }
                            }
                        }
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
