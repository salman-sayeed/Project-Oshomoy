using System;
using System.Data;
using System.Data.SqlClient;

namespace Oshomoy
{
    public class DataAccess
    {
        // Centralized connection string (can also be placed in the app.config file for easier maintenance)
        private readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\SALMAN\Documents\UserInfo.mdf;Integrated Security=True;Connect Timeout=30";

        // Method to open a connection and return it
        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        // ExecuteNonQuery: Insert, Update, Delete commands
        public int ExecuteNonQuery(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }
                    return command.ExecuteNonQuery();
                }
            }
        }


        
    }
}
