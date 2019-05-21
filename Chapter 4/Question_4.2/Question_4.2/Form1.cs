using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question_4._2
{
    public partial class Form1 : Form
    {
        private decimal totalDue = 0;
        private decimal totalDuePermanent = 0;
        private int patrons = 1;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            decimal currentDue;
            decimal discount;
            decimal service;

            // Check for discount
            if (radioButton10PercentDiscount.Checked)
            {
                discount = 10;
            }
            else if (radioButton20PercentDiscount.Checked)
            {
                discount = 20;
            }
            else if (radioButtonNoneDiscount.Checked)
            {
                discount = 0;
            }
            else
                discount = 0;

            // Check for selected service
            if (radioButtonMakeOver.Checked)
            {
                service = 125;
            }
            else if (radioButtonHairStyling.Checked)
            {
                service = 60;
            }
            else if (radioButtonManicure.Checked)
            {
                service = 35;
            }
            else if (radioButtonPermanentMakeup.Checked)
            {
                service = 200;
            }
            else
                service = 0;

            // Current Due
            currentDue = service - ((service / 100) * discount);
            
            // Total Due
            totalDue = totalDue + currentDue;

            // Save totalDue in totalDuePermanent Variable
            totalDuePermanent = totalDuePermanent + currentDue;

            // Uncheck all radio buttons
            uncheckRadioButtons();

            // Check None Discount Radio Button
            radioButtonNoneDiscount.Checked = true;

            //assign values to textbox
            textBoxCurrentDue.Text = currentDue.ToString("C");
            textBoxTotalDue.Text = totalDue.ToString("C");

            // Enable patron button
            buttonNextPatron.Enabled = true;

            // Enable Summary button
            buttonSummary.Enabled = true;

           
        }

        private void uncheckRadioButtons()
        {
            radioButton10PercentDiscount.Checked = false;
            radioButton20PercentDiscount.Checked = false;
            radioButtonHairStyling.Checked = false;
            radioButtonMakeOver.Checked = false;
            radioButtonManicure.Checked = false;
            radioButtonNoneDiscount.Checked = false;
            radioButtonPermanentMakeup.Checked = false;
            
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            DialogResult response;
            string msg = "Are you want to also clear Sale Summary?";
            response = MessageBox.Show(msg, "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if(response == DialogResult.Yes)
            {
                totalDuePermanent = 0;
                patrons = 1;
                buttonSummary.Enabled = false;
                buttonNextPatron.Enabled = false;
            }

            buttonNextPatron.Enabled = false;
            uncheckRadioButtons();
            textBoxTotalDue.Clear();
            textBoxCurrentDue.Clear();
            totalDue = 0;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            printForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview;
            printForm1.Print();
        }

        private void buttonNextPatron_Click(object sender, EventArgs e)
        {
            patrons++;
            string question = "Ary you wants to clear the totals for the current customer?";

            // Dialog Confirmation
            if(totalDue != 0)
            {
                DialogResult respone;
                respone = MessageBox.Show(question, "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if(respone == DialogResult.Yes)
                {
                    
                    totalDue = 0;
                    textBoxTotalDue.Clear();
                }
            }
            uncheckRadioButtons();
            textBoxCurrentDue.Clear();
            buttonNextPatron.Enabled = false;
        }

        private void buttonSummary_Click(object sender, EventArgs e)
        {
            string msg = "   --- Summary ---   \n\n"
                        + "Total Customers =  " + patrons.ToString()
                        + "\n\nTotal Sale =  " + totalDuePermanent.ToString()+"\n\n\n                                                                    ";

            MessageBox.Show(msg, "Summary", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
