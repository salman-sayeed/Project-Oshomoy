using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Oshomoy.Admin
{
    public partial class Adm1Panel : UserControl
    {
        string connectionString;

        public Adm1Panel()
        {
            InitializeComponent();
            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\SALMAN\Documents\UserInfo.mdf;Integrated Security=True;Connect Timeout=30";

            dataGridView1.ReadOnly = true;

            dataGridView1.BackgroundColor = Color.FromArgb(72, 72, 72);
            dataGridView1.DefaultCellStyle.BackColor = Color.FromArgb(72, 72, 72);
            dataGridView1.DefaultCellStyle.ForeColor = Color.White;
            dataGridView1.DefaultCellStyle.Font = new Font("Arial", 11);
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(72, 72, 72);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.EnableHeadersVisualStyles = false;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToAddRows = false;

            this.Load += new EventHandler(Adm1Panel_Load);
        }

        public void LoadPaymentData()
        {
            string query = "SELECT * FROM Payment"; 
            DataTable paymentTable = new DataTable();  

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open(); 

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(paymentTable);  
                        }
                    }
                }

                dataGridView1.DataSource = paymentTable; 
                dataGridView1.AutoResizeColumns(); 
                dataGridView1.AutoResizeRows();  
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Adm1Panel_Load(object sender, EventArgs e)
        {
            LoadPaymentData();
        }
    }
}
