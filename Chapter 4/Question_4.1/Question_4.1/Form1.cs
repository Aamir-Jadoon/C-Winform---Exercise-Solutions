using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question_4._1
{
    public partial class Form1 : Form
    {
        private decimal totalDue = 0;

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

            // Uncheck all radio buttons
            //uncheckRadioButtons();

            // Check None Discount Radio Button
            //radioButtonNoneDiscount.Checked = true;

            //assign values to textbox
            textBoxCurrentDue.Text = currentDue.ToString("C");
            textBoxTotalDue.Text = totalDue.ToString("C");
             
            
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
    }
}
