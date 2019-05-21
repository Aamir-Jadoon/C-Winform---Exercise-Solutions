using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question3._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            printForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview;
            printForm1.Print();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Begining Inventroy
                decimal beginningInventory = decimal.Parse(beginningTextBox.Text);
                try
                {
                    // Ending Inventory
                    decimal endingInventory = decimal.Parse(endingTextBox.Text);
                    try
                    {
                        // Cost of Goods Sold
                        decimal costOfGoodsSold = decimal.Parse(costOfGoodsSoldTextBox.Text);
                        // Average Inventory
                        decimal averageInventory = beginningInventory + endingInventory / 2;
                        // Turnover
                        decimal turnOver = costOfGoodsSold / averageInventory;

                        averageInventoryTextBox.Text = averageInventory.ToString("C");
                        turnOverTextBox.Text = decimal.Round(turnOver, 1).ToString();


                    }
                    catch
                    {
                        // cost of goods sold Error
                        MessageBox.Show("Invalid Cost of Goods", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        costOfGoodsSoldTextBox.Focus();
                        costOfGoodsSoldTextBox.SelectAll();
                    }
                }
                catch
                {
                    // Ending Inventory Error
                    MessageBox.Show("Invalid Ending Inventory", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    endingTextBox.Focus();
                    endingTextBox.SelectAll();
                }
            }
            catch
            {
                // Begining Inventory Error
                MessageBox.Show("Invalid Beginning Inventory", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                beginningTextBox.Focus();
                beginningTextBox.SelectAll();
            }

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            beginningTextBox.Clear();
            endingTextBox.Clear();
            averageInventoryTextBox.Clear();
            turnOverTextBox.Clear();
            costOfGoodsSoldTextBox.Clear();
            beginningTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
