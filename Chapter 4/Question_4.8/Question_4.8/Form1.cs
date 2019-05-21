using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question_4._8
{
    public partial class Form1 : Form
    {
        decimal selectedMenu;
        decimal selectedBarOption;

        decimal totalEvents;
        decimal totalNumberofguest;
        decimal totalAmountDue;

        public Form1()
        {
            InitializeComponent();
        }

       

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                int noOfGuests = Convert.ToInt32( textBoxNumberOfGuest.Text );
               
                    decimal amountdue = (noOfGuests * selectedMenu) + (noOfGuests * selectedBarOption);

                    //Assign due amount to textbox
                    textBoxAmountDue.Text = amountdue.ToString("C");

                // totalNumberofGuests
                totalNumberofguest = totalNumberofguest + noOfGuests;
                // totalAmountdue
                totalAmountDue = totalAmountDue + amountdue;
                // total number of events
                totalEvents++;

             
            }
            catch
            {
                MessageBox.Show("Enter a valid number in guest box!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            decimal primbLimbPrice = 25.95M;
            decimal chickenPrice = 18.95M;
            decimal pastaPrice = 12.95M;


            if (radioButtonChicken.Checked)
            {
                selectedMenu = chickenPrice;
            }
            else if (radioButtonPasta.Checked)
            {
                selectedMenu = pastaPrice;
            }
            else if (radioButtonPrimeRib.Checked)
            {
                selectedMenu = primbLimbPrice;
            }
            else
            {
                selectedMenu = 0;
            }
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            decimal openBarPrice = 25.00M;
            decimal wineWithDinnerPrice = 8.00M;

            decimal selectedBar;
            decimal selectedWine;

            // Wine With Open Bar Checkbox
            if (checkBoxOpenBar.Checked)
            {
                selectedBar = openBarPrice;
            }
            else
            {
                selectedBar = 0;
            }

            // Wine With Dinner Checkbox
            if (checkBoxWineWithDinner.Checked)
            {
                selectedWine = wineWithDinnerPrice;
            }
            else
            {
                selectedWine = 0;
            }

            selectedBarOption = selectedBar + selectedWine;

        }

        private void buttonSummary_Click(object sender, EventArgs e)
        {
            string msg = "\n\nTotal Number of Guests:     " + totalNumberofguest
                        + "\n\nTotal Number of Events:     " + totalEvents
                        + "\n\nTotal Amount Due:     " + totalAmountDue.ToString("C");

            MessageBox.Show(msg, "Summary", MessageBoxButtons.OK, MessageBoxIcon.Information);  
        }

        void clear()
        {
            textBoxAmountDue.Clear();
            textBoxNumberOfGuest.Clear();
            radioButtonChicken.Checked = false;
            radioButtonPasta.Checked = false;
            radioButtonPrimeRib.Checked = false;
            checkBoxOpenBar.Checked = false;
            checkBoxWineWithDinner.Checked = false;
            textBoxNumberOfGuest.Focus();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
