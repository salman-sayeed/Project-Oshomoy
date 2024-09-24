using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oshomoy
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
            
            lbWarnObonotiPhone.Hide(); 
            lbWarnAmount.Hide();
            

            


            tbObonotiPhoneNumber.MaxLength = 11;
           
        }

        

       

        private void btObonotiNext_Click(object sender, EventArgs e)
        {
            lbWarnObonotiPhone.Hide();
           

            bool hasError = false;


            if (string.IsNullOrWhiteSpace(tbObonotiPhoneNumber.Text))
            {
                lbWarnObonotiPhone.Show();
                lbWarnObonotiPhone.Text = "Please Enter PhoneNumber";
                hasError = true;
            }

            if (tbObonotiPhoneNumber.MaxLength > 11 || tbObonotiPhoneNumber.MaxLength < 11)
            {
                lbWarnObonotiPhone.Show();
                lbWarnObonotiPhone.Text = "Invalid Number";
                hasError = true;
            }

            if(string.IsNullOrWhiteSpace(tbAmount.Text))
            {
                lbWarnAmount.Show();
                lbWarnAmount.Text = "Enter an amount";
                hasError = true;
            }

        }

    }
}


}