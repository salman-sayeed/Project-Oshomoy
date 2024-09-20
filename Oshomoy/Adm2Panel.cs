using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Oshomoy
{
    public partial class Adm2Panel : UserControl
    {
        string connectionString;
        public Adm2Panel()
        {
            InitializeComponent();
            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\SALMAN\Documents\UserInfo.mdf;Integrated Security=True;Connect Timeout=30";
        }


    }
}
