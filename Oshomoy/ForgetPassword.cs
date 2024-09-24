using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace Oshomoy
{
    public partial class ForgetPassword : UserControl
    {
        public ForgetPassword()
        {
            InitializeComponent();
            lbWarn1.Hide();

           
        }

 
        private void btnReset_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();

            if (string.IsNullOrWhiteSpace(email))
            {
                // If the text box is empty
                lbWarn1.Text = "Email field cannot be empty.";
                lbWarn1.ForeColor = Color.Red;
                lbWarn1.Show();
            }
            else if (!IsValidEmail(email))
            {
                // If the email is not valid
                lbWarn1.Text = "Please enter a valid email address.";
                lbWarn1.ForeColor = Color.Red;
                lbWarn1.Show();
            }
            else
            {
           
                lbWarn1.Hide();
                SendResetLink(email); 
            }
        }
        private bool IsValidEmail(string email)
        {
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, emailPattern);
        }
        private void SendResetLink(string email)
        {
            MessageBox.Show("Reset password link has been sent to " + email, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

           
        }
 
        private void btnSign_Click(object sender, EventArgs e)
        {
            Form1 parentForm = this.Parent as Form1;
            if (parentForm != null)
            {
                parentForm.ShowLogin2(); 
            }
        }
        private void lbGetStart_Click(object sender, EventArgs e)
        {

        }
    }
}
