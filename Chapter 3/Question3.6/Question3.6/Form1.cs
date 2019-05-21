using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question3._6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Base pay = $900
                const decimal basePay = 900;
                decimal employeeSales = decimal.Parse(employeeSaleTextbox.Text.Trim());
                // Commission 6% of sales
                decimal commission = (employeeSales / 100) * 6;
                // Gross pay = Sum of base oay and commission
                decimal grossPay = basePay + commission;
                // Deduction = 18% of gross pay
                decimal deduction = ((grossPay / 100) * 18);
                // Net Pay = Gross pay minus deduction
                decimal netPay = grossPay - deduction;
                // Housing 30% of net pay
                decimal housing = (netPay / 100) * 30;
                // Food and Clothing 15% of net pay
                decimal foodClothing = (netPay / 100) * 15;
                // Entertainemnt 50% of net pay
                decimal entertainment = (netPay / 100) * 50;
                // Miscellaneous 5% of net play
                decimal miscellaneous = (netPay / 100) * 5;

                CommisonTextbox.Text = commission.ToString("C");
                grossPayTextbox.Text = grossPay.ToString("C");
                deductionsTextbox.Text = deduction.ToString("C");
                netPayTextbox.Text = netPay.ToString("C");

                housingTextbox.Text = housing.ToString("C");
                foodandClothingTextbox.Text = foodClothing.ToString("C");
                entertaimentTextbox.Text = entertainment.ToString("C");
                miscellaneousTextbox.Text = miscellaneous.ToString("C");

            }
            catch (FormatException msg)
            {
                MessageBox.Show(employeeSaleTextbox.Text + " is a Invalid Employee Sales.\nWrite Something like 560.", msg.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                employeeSaleTextbox.Focus();
                employeeSaleTextbox.SelectAll();
            }

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            employeeSaleTextbox.Clear();
            CommisonTextbox.Clear();
            grossPayTextbox.Clear();
            deductionsTextbox.Clear();
            netPayTextbox.Clear();
            housingTextbox.Clear();
            entertaimentTextbox.Clear();
            miscellaneousTextbox.Clear();
            foodandClothingTextbox.Clear();
            employeeSaleTextbox.Focus();

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
