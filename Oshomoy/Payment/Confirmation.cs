using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Oshomoy.Payment
{
    public partial class Confirmation : UserControl
    {
        public Confirmation()
        {
            InitializeComponent();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.SendToBack();
        }


        private void btReceipt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The receipt has been sent to the email address.");
        }


    }
}
