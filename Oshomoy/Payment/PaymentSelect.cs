using System;
using System.Linq;
using System.Windows.Forms;


namespace Oshomoy
{
    public partial class PaymentSelect : UserControl
    {
        public PaymentSelect()
        {
            InitializeComponent();

            confirmation1.Hide();
        }

        private void bkashConfirm_Click(object sender, EventArgs e)
        {
            if  (string.IsNullOrWhiteSpace(tbBkashPhone.Text) ||
                string.IsNullOrWhiteSpace(tbBkashPin.Text))
            {
                MessageBox.Show("Please fill in all fields: Phone Number and PIN.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }
            if (tbBkashPin.Text.Length != 5 || !tbBkashPin.Text.All(char.IsDigit))
            {
                MessageBox.Show("The PIN must be exactly 5 digits long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }
            if (tbBkashPhone.Text.Length != 11 || !tbBkashPhone.Text.All(char.IsDigit))
            {
                MessageBox.Show("The phone number must be exactly 11 digits long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            confirmation1.Show();
            confirmation1.BringToFront();
        }


        private void nagadConfirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbNagadPhone.Text) ||
                string.IsNullOrWhiteSpace(tbNagadPin.Text))
            {
                MessageBox.Show("Please fill in all fields: Phone Number and PIN.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tbBkashPin.Text.Length != 5 || !tbBkashPin.Text.All(char.IsDigit))
            {
                MessageBox.Show("The PIN must be exactly 5 digits long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tbBkashPhone.Text.Length != 11 || !tbBkashPhone.Text.All(char.IsDigit))
            {
                MessageBox.Show("The phone number must be exactly 11 digits long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            confirmation1.Show();
            confirmation1.BringToFront();
        }
    }

}
