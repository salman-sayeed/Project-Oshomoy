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
        private PrintDocument printDocument;

        public Confirmation()
        {
            InitializeComponent();

            printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.SendToBack();
        }

        private void btReceipt_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            string receiptText = "Oshomoy Receipt\n\n" +
                                 "--------------------------------------\n" +
                                 "Date: " + DateTime.Now.ToString("MM/dd/yyyy") + "\n" +
                                 "--------------------------------------\n" +
                                 "Donation Amount: 1000tk\n" +
                                 "--------------------------------------\n" +
                                 "A online copy of your receipt has been sent to your email. \n" +
                                 "Thank you for your payment!";

            Font receiptFont = new Font("Arial", 12);
            Brush brush = Brushes.Black;
            PointF startPosition = new PointF(100, 100);

            e.Graphics.DrawString(receiptText, receiptFont, brush, startPosition);
        }
    }
}
