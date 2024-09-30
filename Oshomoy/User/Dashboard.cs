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

namespace Oshomoy
{
    public partial class Dashboard : UserControl
    {
        string connectionString;
        public int UserId { get; set; }

        public string username;
        public string email;


        public Dashboard()
        {
            InitializeComponent();
            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\SALMAN\Documents\UserInfo.mdf;Integrated Security=True;Connect Timeout=30";

            indicator1.Show();
            indicator2.Hide();

            paymentSelect1.Hide();
            user2Panel1.Hide();

            user1Panel1.Show();
            user1Panel1.BringToFront();


        }
        public void ShowPayment()
        {
            user2Panel1.Hide();
            user2Panel1.Hide();

            paymentSelect1.UserId = this.UserId;
            paymentSelect1.Username = this.username; 
            paymentSelect1.Email = this.email;
            paymentSelect1.LoadUserInfo();

            paymentSelect1.Show();
            paymentSelect1.BringToFront(); 

        }
        public void LoadUserData()
        {
            showUsername.Text = "";
            showEmail.Text = "";

            string query = "SELECT UserName, Email FROM Users WHERE UserId = @UserId";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserId", UserId);

                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                username = reader["UserName"].ToString();
                                email = reader["Email"].ToString();

                                showUsername.Text = username;
                                showEmail.Text = email;
                            }
                            else
                            {
                                MessageBox.Show("User not found.");
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

        private void btSignout_Click(object sender, EventArgs e)
        {
            Form1 parentForm = this.Parent as Form1;
            if (parentForm != null)
            {
                parentForm.ShowLogin();
            }
        }

        private void userBtn1_Click(object sender, EventArgs e)
        {
            indicator1.Show();
            indicator2.Hide();

            user2Panel1.Hide();
            paymentSelect1.Hide();

            user1Panel1.Show();
            user1Panel1.BringToFront();

            LoadUserData();
        }

        private void UserBtn3_Click(object sender, EventArgs e)
        {
            indicator1.Hide();
            indicator2.Show();

            user1Panel1.Hide();
            paymentSelect1.Hide();

            user2Panel1.Show();
            user2Panel1.BringToFront();

            user2Panel1.UserId = this.UserId;

            LoadUserData();
        }

        
    }
}
