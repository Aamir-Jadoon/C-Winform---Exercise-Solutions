using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question_4._5
{
    public partial class Form1 : Form
    {
        decimal balance = 0;
        int numberOfDeposit = 0;
        int numberOfChecks = 0;
        decimal amountOfDeposit;
        decimal amountOfChecks;
        decimal serviceCharges;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                decimal amount = Convert.ToDecimal(textBoxAmount.Text);

             
                if (radioButtonCheck.Checked)
                {
                    if((balance - amount) < 0)
                    {
                        balance = balance - 10;
                        serviceCharges = serviceCharges + 10;

                        MessageBox.Show("Insufficient Funds", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                    else
                    {
                        numberOfChecks++;
                        // Current Balance
                        balance = balance - amount;
                        // add amount to amountOfCheck variable
                        amountOfChecks = amountOfChecks + amount;
                    }
                    
                }
                else if (radioButtonServiceCharge.Checked)
                {
                    if((balance-amount) < 0)
                    {
                        MessageBox.Show("Low Balance", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        balance = balance - amount;
                        serviceCharges = serviceCharges + amount;
                    }
                }
                else if (radioButtonDeposit.Checked)
                {
                    numberOfDeposit++;
                    // Current Balance
                    balance = balance + amount;
                    // add amount to amountofdeposit variable
                    amountOfDeposit = amountOfDeposit + amount;
                }
                    else
                    {
                        MessageBox.Show("Select type of Transaction", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                textBoxBalance.Text = balance.ToString("C");
                textBoxAmount.Clear();
                uncheckRadioButton();
            
           


            }
            catch
            {
                MessageBox.Show("Enter a valid amount", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
        private void button3_Click(object sender, EventArgs e)
        {
            uncheckRadioButton();
            textBoxAmount.Clear();
            textBoxBalance.Clear();
            balance = 0;
        }

void uncheckRadioButton()
{
    radioButtonCheck.Checked = false;
    radioButtonDeposit.Checked = false;
    radioButtonServiceCharge.Checked = false;
}

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            printForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview;
            printForm1.Print();
        }

        private void buttonSummary_Click(object sender, EventArgs e)
        {
            string summary = "        --- Summary --- "
                             + "\n\n\nTotal Number of deposit:   " + numberOfDeposit
                             + "\nTotal Amount of deposit:   " + amountOfDeposit.ToString("C")
                             + "\n\nTotal Number of Checks :   " + numberOfChecks
                             + "\nTotal Amount of Checks :   " + amountOfChecks.ToString("C")
                             + "\n\nService Charges:   " + serviceCharges.ToString("C")
                             + "\n\nRemaining Balance:   " + balance.ToString("C");

            MessageBox.Show(summary, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
