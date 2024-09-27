using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Oshomoy
{
    public partial class Adm2Panel : UserControl
    {
        string connectionString;

        public Adm2Panel()
        {
            InitializeComponent();
            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\SALMAN\Documents\UserInfo.mdf;Integrated Security=True;Connect Timeout=30";

            LoadUserData();
            tbUsername.MaxLength = 16;
            tbEmail.MaxLength = 20;
            tbPassword.MaxLength = 16;
            tbUserId.MaxLength = 5;
        }

        private void LoadUserData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Users"; 
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;
                    dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool IsValidEmail(string email)
        {
            try
            {
                // Regex for validating email addresses
                var emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                return System.Text.RegularExpressions.Regex.IsMatch(email, emailPattern);
            }
            catch (Exception)
            {
                return false;
            }
        }
        private void btAddUser_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text.Trim();
            string email = tbEmail.Text.Trim();
            string password = tbPassword.Text.Trim();
            string defaultRole = "User";

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters long.", "Password Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Please enter a valid email address.", "Email Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string insertQuery = "INSERT INTO Users (UserName, Email, Password, UserType) VALUES (@Username, @Email, @Password, @UserType)";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Password", password); 
                        command.Parameters.AddWithValue("@UserType", defaultRole); 

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("User added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            tbUsername.Clear();
                            tbEmail.Clear();
                            tbPassword.Clear();

                            LoadUserData();
                        }
                        else
                        {
                            MessageBox.Show("Failed to add user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btUpdateUser_Click(object sender, EventArgs e)
        {
            string userId = tbUserId.Text.Trim();
            string username = tbUsername.Text.Trim();
            string email = tbEmail.Text.Trim();
            string password = tbPassword.Text.Trim();

            if (string.IsNullOrEmpty(userId))
            {
                MessageBox.Show("Please enter the UserID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(username) && string.IsNullOrEmpty(email) && string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in at least one field to update.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!string.IsNullOrEmpty(email) && !IsValidEmail(email))
            {
                MessageBox.Show("Please enter a valid email address.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!string.IsNullOrEmpty(password) && password.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters long.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    List<string> fieldsToUpdate = new List<string>();
                    if (!string.IsNullOrEmpty(username))
                        fieldsToUpdate.Add("UserName = @Username");
                    if (!string.IsNullOrEmpty(email))
                        fieldsToUpdate.Add("Email = @Email");
                    if (!string.IsNullOrEmpty(password))
                        fieldsToUpdate.Add("Password = @Password");

                    string updateQuery = $"UPDATE Users SET {string.Join(", ", fieldsToUpdate)} WHERE UserID = @UserID";

                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@UserID", userId);
                        if (!string.IsNullOrEmpty(username))
                            command.Parameters.AddWithValue("@Username", username);
                        if (!string.IsNullOrEmpty(email))
                            command.Parameters.AddWithValue("@Email", email);
                        if (!string.IsNullOrEmpty(password))
                            command.Parameters.AddWithValue("@Password", password);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("User updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            tbUserId.Clear();
                            tbUsername.Clear();
                            tbEmail.Clear();
                            tbPassword.Clear();

                            LoadUserData();
                        }
                        else
                        {
                            MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
