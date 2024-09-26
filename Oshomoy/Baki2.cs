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
    public partial class Baki2 : UserControl
    {
        public Baki2()
        {
            InitializeComponent();

            lbWarnBakiPassword.Hide();
            lblWarnBakiConPass.Hide();

            showBakiPaymentPass2.Show();
            showBakiPaymentPass1.Hide();
            showConPassBaki2.Show();
            showConPassBaki1.Hide();

            tbBakiPassword.MaxLength = 8;
        }

        private void Baki2_Load(object sender, EventArgs e)
        {

        }

        private void tbBakiPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void showBakiPaymentPass2_Click(object sender, EventArgs e)
        {
            tbBakiPassword.PasswordChar = '•';
            showBakiPaymentPass1.Show();
            showBakiPaymentPass2.Hide();
        }

        private void showBakiPaymentPass1_Click(object sender, EventArgs e)
        {
            tbBakiPassword.PasswordChar = '\0';
            showBakiPaymentPass1.Hide();
            showBakiPaymentPass2.Show();
        }

        private void showConPassBaki1_Click(object sender, EventArgs e)
        {
            tbBakiPassword.PasswordChar = '\0';
            showConPassBaki1.Hide();
            showConPassBaki2.Show();
        }

        private void showConPassBaki2_Click(object sender, EventArgs e)
        {
            tbBakiPassword.PasswordChar = '•';
            showConPassBaki1.Show();
            showConPassBaki2.Hide();
        }

        private void btnConfirmBaki_Click(object sender, EventArgs e)
        {
            lbWarnBakiPassword.Hide();
            lblWarnBakiConPass.Hide();


            bool hasError = false;

            if (string.IsNullOrWhiteSpace(tbBakiPassword.Text))
            {
                lbWarnBakiPassword.Show();
                lbWarnBakiPassword.Text = "Password can't be empty";

                hasError = true;
            }

            else if (tbBakiPassword.MaxLength < 8)
            {
                lbWarnBakiPassword.Show();
                lbWarnBakiPassword.Text = "Password must be at least 8 characters long";
                hasError = true;
            }

            if (string.IsNullOrWhiteSpace(tbConfirmPasswordBaki.Text))
            {
                lblWarnBakiConPass.Show();
                lblWarnBakiConPass.Text = "Confirm Password can't be empty";
                hasError = true;
            }

            if (!hasError && tbBakiPassword.Text != tbConfirmPasswordBaki.Text)
            {
                lblWarnBakiConPass.Show();
                lblWarnBakiConPass.Text = "Passwords do not match";
                hasError = true;
            }



            if (!hasError)
            {
                MessageBox.Show("Confirmation Successful");
            }

        }
    }
}




