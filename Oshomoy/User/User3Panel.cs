﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;  
using System.Windows.Forms;
using ClosedXML.Excel;  


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
        }

        public void LoadData()
        {
            if (UserId > 0)
            {
                LoadPaymentData();
            }
            else
            {
                MessageBox.Show("Invalid User ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                dataGridView1.AutoResizeColumns();  
                dataGridView1.AutoResizeRows();     
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files|*.xlsx";
            saveFileDialog.Title = "Save Payment Data as Excel File";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (XLWorkbook wb = new XLWorkbook()) 
                    {
                        DataTable dataTable = (DataTable)dataGridView1.DataSource; 
                        if (dataTable != null)
                        {
                            wb.Worksheets.Add(dataTable, "PaymentData"); 
                            wb.SaveAs(saveFileDialog.FileName); 
                            MessageBox.Show("Data saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No data available to save.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while saving: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}