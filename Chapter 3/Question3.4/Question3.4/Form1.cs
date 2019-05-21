using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question3._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculatorButton_Click(object sender, EventArgs e)
        {
            const decimal  rate = 0.12M;
            
            try
            {
                decimal WeightInPound = decimal.Parse(poundTextbox.Text);
                try
                {
                    decimal WeightInOunce = decimal.Parse(ounceTextbox.Text);
                    decimal totalWeight = WeightInOunce + (WeightInPound * 16);
                    decimal shipmentRate = totalWeight * rate;
                    shippingChargeTextbox.Text = shipmentRate.ToString("C");
                }  
                catch(FormatException msg)
                {
                    MessageBox.Show(msg.Message, "Invalid Weight in Ounce", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    ounceTextbox.Focus();
                    ounceTextbox.SelectAll();
                }
            }
            catch (FormatException msg)
            {
                MessageBox.Show(msg.Message, "Invalid Weight in Pound", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                poundTextbox.Focus();
                poundTextbox.SelectAll();
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
