using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

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
            PaymentSelect parentForm = this.Parent as PaymentSelect;
            if (parentForm != null)
            {
                parentForm.Reciept();
                this.Hide();
                this.SendToBack();
            }
        }

       
    }
}
