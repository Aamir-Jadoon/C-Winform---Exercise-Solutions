using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question3._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {   
            // try-catch block for Begining Odometer Reading
            try
            {
                double beginingOdometerReading = double.Parse(BeginingOdometerReadingTextbox.Text);
                
                // try-catch block for ending odometer reading
                try
                {
                    double endingOdometerReading = double.Parse(endingOdometerReadingTextbox.Text);
                    
                    // try-catch block for No: of days car was used
                    try
                    {
                        const decimal perMileRate = 0.12M;
                        const decimal perDayRate = 15M;

                        // No of days car was used
                        double numberOfDaysCarWasUsed = double.Parse(noOfDaysCarWasUsedTextbox.Text);
                        // Total Miles Driven
                        double milesDriven = endingOdometerReading - beginingOdometerReading;
                        // Days Charges
                        decimal dayCharges = perDayRate * decimal.Parse(noOfDaysCarWasUsedTextbox.Text.Trim());
                        // Miles Charges
                        decimal milesCharges = (decimal)milesDriven * perMileRate;
                        // Total Charges
                        decimal totalCharges = dayCharges + milesCharges;
                        // Assign to Total charge textbox
                        totalChargeTextbox.Text = totalCharges.ToString("C");

                        milesDrivenTextbox.Text = milesDriven.ToString() + " miles";
                    }
                    catch (FormatException msg)
                    {
                        MessageBox.Show(msg.Message, noOfDaysCarWasUsedTextbox.Text + " is Invalid Number", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        noOfDaysCarWasUsedTextbox.Focus();
                        noOfDaysCarWasUsedTextbox.SelectAll();
                    }
                }
                catch(FormatException msg)
                {
                    MessageBox.Show(msg.Message, endingOdometerReadingTextbox.Text + " is Invalid Number", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    endingOdometerReadingTextbox.Focus();
                    endingOdometerReadingTextbox.SelectAll();
                }
            }
            catch(FormatException msg)
            {
                MessageBox.Show(msg.Message, BeginingOdometerReadingTextbox.Text + " is Invalid Number", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                BeginingOdometerReadingTextbox.Focus();
                BeginingOdometerReadingTextbox.SelectAll();
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            foreach(Control c in this.Controls)
            {
                if (c is TextBox)
                    (c as TextBox).Clear();
            }
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            printForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview;
            printForm1.Print();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
