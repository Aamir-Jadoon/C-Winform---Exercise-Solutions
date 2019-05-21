using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question_4._3
{
    public partial class Form1 : Form
    {
        decimal balance = 0;
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
                    balance = balance - amount;
                }
                else if (radioButtonServiceCharge.Checked)
                {
                    balance = balance - amount;
                }
                else if (radioButtonDeposit.Checked)
                {
                    balance = balance + amount;
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
    }
}
