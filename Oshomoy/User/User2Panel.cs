using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Oshomoy.User
{
    public partial class User2Panel : UserControl
    {
        string connectionString;
        public int UserId { get; set; }
        
        public User2Panel()
        {
            InitializeComponent();
            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\SALMAN\Documents\UserInfo.mdf;Integrated Security=True;Connect Timeout=30";

            tbUsername.MaxLength = 16;
            tbEmail.MaxLength = 20;
            tbPassword.MaxLength = 16;
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                return System.Text.RegularExpressions.Regex.IsMatch(email, emailPattern);
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void btUpdateUser_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text.Trim();
            string email = tbEmail.Text.Trim();
            string password = tbPassword.Text.Trim();


            DialogResult dialogResult = MessageBox.Show("Are you sure you want to update your information?", "Confirm Update", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string query = "UPDATE Users SET ";
                List<SqlParameter> parameters = new List<SqlParameter>();

                if (!string.IsNullOrEmpty(username))
                {
                    query += "UserName = @UserName, ";
                    parameters.Add(new SqlParameter("@UserName", username));
                }

                if (!string.IsNullOrEmpty(email))
                {
                    if (!IsValidEmail(email)) 
                    {
                        MessageBox.Show("Please enter a valid email address.");
                        return;
                    }
                    query += "Email = @Email, ";
                    parameters.Add(new SqlParameter("@Email", email));
                }

                if (!string.IsNullOrEmpty(password))
                {
                    query += "Password = @Password, ";
                    parameters.Add(new SqlParameter("@Password", password));
                }

                if (parameters.Count > 0)
                {
                    query = query.TrimEnd(',', ' ') + " WHERE UserId = @UserId";
                    parameters.Add(new SqlParameter("@UserId", UserId)); 

                    try
                    {
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            using (SqlCommand command = new SqlCommand(query, connection))
                            {
                                command.Parameters.AddRange(parameters.ToArray());

                                connection.Open();
                                int rowsAffected = command.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("User information updated successfully.");
                                    
                                }
                                else
                                {
                                    MessageBox.Show("No user found with the provided User ID.");
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while updating user information: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Please fill at least one field to update.");
                }
            }
        }



    }
}
