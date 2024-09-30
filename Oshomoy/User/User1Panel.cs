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
            lbWarn.Hide();
            lbWarn2.Hide();
        }

        private void btCheckout_Click(object sender, EventArgs e)
        {
            lbWarn.Hide();
            lbWarn2.Hide();

            if (string.IsNullOrWhiteSpace(tbDonation.Text) )
            {
                lbWarn.Show();
                lbWarn2.Hide();
                lbWarn.Text = "Donation amount can't be empty!"; 
            }
            else if (!tbDonation.Text.All(char.IsDigit))
            {
                lbWarn.Show();
                lbWarn2.Hide();
                lbWarn.Text = "Please enter a valid donation amount!";
            }
            else if (!(rbYearly.Checked || rbMonthly.Checked || rbOneTime.Checked))
            {
                lbWarn2.Show();
                lbWarn2.Text = "Please select a package!";
            }
            else 
            {
                Dashboard parentForm = this.Parent as Dashboard;
                if (parentForm != null)
                {

                    PaymentSelect paymentSelect = parentForm.Controls.Find("paymentSelect1", true).FirstOrDefault() as PaymentSelect;
                    if (paymentSelect != null)
                    {
                        paymentSelect.Amount = int.Parse(tbDonation.Text); 
                        paymentSelect.UpdateAmounts(); 
                    }

                    parentForm.ShowPayment();
                    tbDonation.Clear();

                }
            }
            
        }
    }
}
