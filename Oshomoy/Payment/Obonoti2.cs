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
    public partial class Obonoti2 : UserControl
    {
        public Obonoti2()
        {
            InitializeComponent();
            lbWarnObonotiPassword.Hide();
            lblWarnObonotiConPass.Hide();

            showPaymentPass2.Show();
            showPaymentPass1.Hide();
            showConPassObonoti2.Show();
            showConPassObonoti1.Hide();

            tbObonotiPassword.MaxLength = 8;

        }

        private void showPaymentPass2_Click(object sender, EventArgs e)
        {
            tbObonotiPassword.PasswordChar = '•';
            showPaymentPass1.Show();
            showPaymentPass2.Hide();
        }

        private void showPaymentPass1_Click(object sender, EventArgs e)
        {
            tbObonotiPassword.PasswordChar = '\0';
            showPaymentPass1.Hide();
            showPaymentPass2.Show();
        }

        private void showConPassObonoti1_Click(object sender, EventArgs e)
        {
            tbObonotiPassword.PasswordChar = '\0';
            showConPassObonoti1.Hide();
            showConPassObonoti2.Show();
        }

        private void showConPassObonoti2_Click(object sender, EventArgs e)
        {
            tbObonotiPassword.PasswordChar = '•';
            showConPassObonoti1.Show();
            showConPassObonoti2.Hide();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            lbWarnObonotiPassword.Hide();
            lblWarnObonotiConPass.Hide();
            
            
            bool hasError = false;

            if (string.IsNullOrWhiteSpace(tbObonotiPassword.Text))
            {
                lbWarnObonotiPassword.Show();
                lbWarnObonotiPassword.Text = "Password can't be empty";
               
                hasError = true;
            }

            else if (tbObonotiPassword.MaxLength < 8)
            {
                lbWarnObonotiPassword.Show();
                lbWarnObonotiPassword.Text = "Password must be at least 8 characters long";
                hasError = true;
            }

            if (string.IsNullOrWhiteSpace(tbConfirmPasswordObonoti.Text))
            {
                lblWarnObonotiConPass.Show();
                lblWarnObonotiConPass.Text = "Confirm Password can't be empty";
                hasError = true;
            }

            if (!hasError && tbObonotiPassword.Text != tbConfirmPasswordObonoti.Text)
            {
                lblWarnObonotiConPass.Show();
                lblWarnObonotiConPass.Text = "Passwords do not match";
                hasError = true;
            }



            if(!hasError)
            {
                MessageBox.Show("Confirmation Successful");
            }



        }
    }
}

