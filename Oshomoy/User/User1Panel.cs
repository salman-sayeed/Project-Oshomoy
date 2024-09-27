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
    public partial class User1Panel : UserControl
    {
        public User1Panel()
        {
            InitializeComponent();
        }

        private void btDonate_Click(object sender, EventArgs e)
        {
            Dashboard parentForm = this.Parent as Dashboard;
            if (parentForm != null)
            {
                parentForm.ShowPayment();
            }
        }
    }
}
