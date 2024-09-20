using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public Dashboard()
        {
            InitializeComponent();
            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\SALMAN\Documents\UserInfo.mdf;Integrated Security=True;Connect Timeout=30";

        }
        public void LoadUserData()
        {
            showUsername.Text = "";
            showEmail.Text = "";
        }
    }
}
