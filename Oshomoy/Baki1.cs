using Oshomoy;
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
    public partial class Baki1 : UserControl
    {
        public Baki1()
        {
            InitializeComponent();

            lbWarnBakiPhone.Hide();
            lbWarnBakiAmount.Hide();
            tbBakiPhoneNumber.MaxLength = 11;


        }

        private void btBakiNext_Click(object sender, EventArgs e)
        {
            lbWarnBakiPhone.Hide();

            bool hasError = false;


            if (string.IsNullOrWhiteSpace(tbBakiPhoneNumber.Text))
            {
                lbWarnBakiPhone.Show();
                lbWarnBakiPhone.Text = "Please Enter PhoneNumber";
                hasError = true;
            }

            if (tbBakiPhoneNumber.MaxLength > 11 || tbBakiPhoneNumber.MaxLength < 11)
            {
                lbWarnBakiPhone.Show();
                lbWarnBakiPhone.Text = "Invalid Number";
                hasError = true;
            }

            if (string.IsNullOrWhiteSpace(tbBakiAmount.Text))
            {
                lbWarnBakiAmount.Show();
                lbWarnBakiAmount.Text = "Enter an amount";
                hasError = true;
            }

            if (!decimal.TryParse(tbBakiAmount.Text, out decimal amount))
            {
                lbWarnBakiAmount.Show();
                lbWarnBakiAmount.Text = "Invalid amount format";
                hasError = true;
            }
            else if (amount <= 0)
            {
                lbWarnBakiAmount.Show();
                lbWarnBakiAmount.Text = "Amount must be greater than zero";
                hasError = true;
            }






        }
    }
}

