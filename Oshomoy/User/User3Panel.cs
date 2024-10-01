using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Oshomoy.User
{
    public partial class User3Panel : UserControl
    {
        string connectionString;
        public int UserId { get; set; }

        public User3Panel()
        {
            InitializeComponent();
            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\SALMAN\Documents\UserInfo.mdf;Integrated Security=True;Connect Timeout=30";

            dataGridView1.ReadOnly = true;
        }

        public void LoadData()
        {
            if (UserId > 0)
            {
                LoadPaymentData();  
            }
        }

        private void LoadPaymentData()
        {
            string query = "SELECT TrxId, Phone, Method, Date FROM Payment WHERE UserId = @UserId";
            DataTable paymentTable = new DataTable(); 

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserId", UserId); 
                        connection.Open();

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(paymentTable);  
                        }
                    }
                }

                dataGridView1.DataSource = paymentTable;
                dataGridView1.ReadOnly = true;  
                dataGridView1.AutoResizeColumns();  

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
