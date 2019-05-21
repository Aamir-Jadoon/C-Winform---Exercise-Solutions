using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question3._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculatebutton_Click(object sender, EventArgs e)
        {
            try {

                // try Amount Textbox Error
                double amout = double.Parse(amountTextbox.Text.Trim());

                try
                {
                    // try Year Textbox Error
                    double year = double.Parse(yearsTextbox.Text.Trim());

                    try {

                        // try Rate Textbox Error
                        double rate = double.Parse("." + rateTextbox.Text.Trim());
                        
                        // Future value = investment amount * (1 + interest rate) ^ Years

                        decimal futureValue = (decimal)amout * (decimal)Math.Pow((1 + rate), year);
                        futureValueTextbox.Text = futureValue.ToString("C");
                    }
                    catch (FormatException msg) {

                        // catch Rate Textbox Error
                        MessageBox.Show(msg.Message, "Rate Textbox Data Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        rateTextbox.Focus();
                        rateTextbox.SelectAll();
                    }
                }
                catch (FormatException msg) {
                    // catch Year Textbox Error
                    MessageBox.Show(msg.Message, "Year Textbox Data Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    yearsTextbox.Focus();
                    yearsTextbox.SelectAll();
                }
            }
            catch (FormatException msg) {
                // catch Amount Textbox Error
                MessageBox.Show(msg.Message, "Amount Textbox Data Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                amountTextbox.Focus();
                amountTextbox.SelectAll();
            }            
            
            
           
        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            foreach(Control c in this.Controls)
            {
                if (c is TextBox)
                    (c as TextBox).Clear();
            }
            rateTextbox.Clear();
            amountTextbox.Focus();
        }

        private void printbutton_Click(object sender, EventArgs e)
        {
            printForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview;
            printForm1.Print();
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
