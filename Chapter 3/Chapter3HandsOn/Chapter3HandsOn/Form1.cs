using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter3HandsOn
{
    public partial class ClothingSalesForm : Form
    {
        private const decimal DISCOUNT_RATE_Decimal = 0.3m;
        public ClothingSalesForm()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // Calculate the discound and amout due

            // Declare the variable
            int quantityInteger;
            decimal priceDecimal, extendedPriceDecimal, discountDecimal, amoutDueDecimal;
            try {
                // Convert input values to numeric and assign to variables.
                quantityInteger = int.Parse(quantityTextBox.Text);
                try {
                    priceDecimal = decimal.Parse(priceTextBox.Text);

                    // Calcualte values.
                    extendedPriceDecimal = quantityInteger * priceDecimal;
                    discountDecimal = Decimal.Round((extendedPriceDecimal * DISCOUNT_RATE_Decimal), 2);
                    amoutDueDecimal = extendedPriceDecimal - discountDecimal;

                    // Format and display answers
                    extendedPriceTextBox.Text = extendedPriceDecimal.ToString("C");
                    discountTextBox.Text = discountDecimal.ToString("N");
                    amoutDueTextBox.Text = amoutDueDecimal.ToString("C");
                }
                catch
                {
                    //Invalid Price.
                    MessageBox.Show("Invalid price.", "Data Error");
                    priceTextBox.Focus();
                    priceTextBox.SelectAll();
                }
            } 
            catch 
            {
                // Invalid quantity
                MessageBox.Show("Invalid Quantity", "Data Error");
                quantityTextBox.Focus();
                quantityTextBox.SelectAll();
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            quantityTextBox.Clear();
            priceTextBox.Clear();
            discountTextBox.Clear();
            extendedPriceTextBox.Clear();
            amoutDueTextBox.Clear();
            quantityTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // End the program.

            this.Close();
        }
    }
}
