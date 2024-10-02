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
    public partial class AdminDb : UserControl
    {
        public int UserId { get; set; }
        string connectionString;
        public AdminDb()
        {
            InitializeComponent();
            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\SALMAN\Documents\UserInfo.mdf;Integrated Security=True;Connect Timeout=30";
            
            indicator2.Show();
            indicator1.Hide();

            adm2Panel1.Show();
            adm2Panel1.BringToFront();

            adm1Panel1.Hide();
        }
        public void LoadAdminData()
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
                                string username = reader["UserName"].ToString();
                                string email = reader["Email"].ToString();

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

        private void admBtn1_Click(object sender, EventArgs e)
        {
            indicator1.Show();
            indicator2.Hide();

            adm1Panel1.Show();
            adm1Panel1.BringToFront();

            adm2Panel1.Hide();
        }
        private void admBtn2_Click(object sender, EventArgs e)
        {
            indicator1.Hide();
            indicator2.Show();

            adm1Panel1.Hide();

            adm2Panel1.Show();
            adm2Panel1.BringToFront();

        }

        private void btSignout_Click(object sender, EventArgs e)
        {
            Form1 parentForm = this.Parent as Form1;
            if (parentForm != null)
            {
                parentForm.ShowLogin();
            }
        } 
    }
}
