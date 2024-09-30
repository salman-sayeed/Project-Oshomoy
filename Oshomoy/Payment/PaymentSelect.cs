using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;


namespace Oshomoy
{
    public partial class PaymentSelect : UserControl
    {
        string connectionString;
        public int Amount { get; set; }
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }

        public PaymentSelect()
        {
            InitializeComponent();
            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\SALMAN\Documents\UserInfo.mdf;Integrated Security=True;Connect Timeout=30";

            confirmation1.Hide();
        }

        public void UpdateAmounts()
        {
            tbBkashAmount.Text = Amount.ToString();
            tbNagadAmount.Text = Amount.ToString();
        }

        public void LoadUserInfo() 
        {
            lbTest1.Text = UserId.ToString();
            lbTest2.Text = Username;
            lbTest3.Text = Email;
        }

        public void Reciept() 
        {

        }

        private void bkashConfirm_Click(object sender, EventArgs e)
        {
            if  (string.IsNullOrWhiteSpace(tbBkashPhone.Text) ||
                string.IsNullOrWhiteSpace(tbBkashPin.Text))
            {
                MessageBox.Show("Please fill in all fields: Phone Number and PIN.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }
            if (tbBkashPin.Text.Length != 5 || !tbBkashPin.Text.All(char.IsDigit))
            {
                MessageBox.Show("The PIN must be exactly 5 digits long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }
            if (tbBkashPhone.Text.Length != 11 || !tbBkashPhone.Text.All(char.IsDigit))
            {
                MessageBox.Show("The phone number must be exactly 11 digits long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            string query = "INSERT INTO Payment (Username, Email, Phone, Method, Date, UserId) VALUES (@Username, @Email, @Phone, @Method, @Date, @UserId)";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", Username);
                        command.Parameters.AddWithValue("@Email", Email);
                        command.Parameters.AddWithValue("@Phone", tbBkashPhone.Text); 
                        command.Parameters.AddWithValue("@Method", "Bkash");  
                        command.Parameters.AddWithValue("@Date", DateTime.Now); 
                        command.Parameters.AddWithValue("@UserId", UserId);  

                        connection.Open();
                        int result = command.ExecuteNonQuery(); 

                        if (result > 0)
                        {
                            confirmation1.Show();
                            confirmation1.BringToFront();
                        }
                        else
                        {
                            MessageBox.Show("Payment failed, please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void nagadConfirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbNagadPhone.Text) ||
                string.IsNullOrWhiteSpace(tbNagadPin.Text))
            {
                MessageBox.Show("Please fill in all fields: Phone Number and PIN.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tbNagadPin.Text.Length != 5 || !tbNagadPin.Text.All(char.IsDigit))
            {
                MessageBox.Show("The PIN must be exactly 5 digits long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tbNagadPhone.Text.Length != 11 || !tbNagadPhone.Text.All(char.IsDigit))
            {
                MessageBox.Show("The phone number must be exactly 11 digits long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "INSERT INTO Payment (Username, Email, Phone, Method, Date, UserId) VALUES (@Username, @Email, @Phone, @Method, @Date, @UserId)";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", Username);
                        command.Parameters.AddWithValue("@Email", Email);
                        command.Parameters.AddWithValue("@Phone", tbNagadPhone.Text);
                        command.Parameters.AddWithValue("@Method", "Nagad");  
                        command.Parameters.AddWithValue("@Date", DateTime.Now); 
                        command.Parameters.AddWithValue("@UserId", UserId);  

                        connection.Open();
                        int result = command.ExecuteNonQuery(); 

                        if (result > 0)
                        {
                            confirmation1.Show();
                            confirmation1.BringToFront();
                        }
                        else
                        {
                            MessageBox.Show("Payment failed, please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
