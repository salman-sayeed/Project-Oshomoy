using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oshomoy.Register___Login
{
    public partial class Forgotpass : UserControl
    {
        string connectionString;
        public Forgotpass()
        {
            InitializeComponent();
            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\SALMAN\Documents\UserInfo.mdf;Integrated Security=True;Connect Timeout=30";

            lbWarn.Hide();

            tbEmail.MaxLength = 20;
            tbEmail.KeyPress += TbEmail_KeyPress;
            tbEmail.Focus();
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
        private void lbLinkSign_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            Form1 parentForm = this.Parent as Form1;
            if (parentForm != null)
            {
                parentForm.ShowLogin();
            }

            
        }
        private void lbLinnkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 parentForm = this.Parent as Form1;
            if (parentForm != null)
            {
                parentForm.ShowSignup();
            }
        }

        private void TbEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btForgotpassword_Click(sender, e);
            }
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

        private void btForgotpassword_Click(object sender, EventArgs e)
        {
            bool hasError = false;
            lbWarn.Hide();
            if (string.IsNullOrWhiteSpace(tbEmail.Text))
            {
                lbWarn.Show();
                lbWarn.Text = "Email can't be empty";
                hasError = true;
            }
            if (!IsValidEmail(tbEmail.Text))
            {
                lbWarn.Show();
                lbWarn.Text = "Invalid Email";
                hasError = true;
            }

            if (!hasError)
            {
                string query = "SELECT COUNT(*) FROM Users WHERE Email = @Email"; 
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Email", tbEmail.Text);

                            connection.Open();
                            int emailCount = (int)command.ExecuteScalar();

                            if (emailCount > 0)
                            {
                                MessageBox.Show("An email has been sent to reset your password.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                lbWarn.Show();
                                lbWarn.Text = "Email not found. Please register!";
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }   
}
