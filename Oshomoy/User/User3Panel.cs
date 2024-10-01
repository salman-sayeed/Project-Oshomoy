using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
