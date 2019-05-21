using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question_4._6
{
    public partial class Form1 : Form
    {
        // Total Number of Employees Worked
        private int totalEmployees = 0;

        // Total Number of Pieces
        private int totalNumberOfPieces = 0;

        // Total Payed Amount
        private decimal totalPay = 0;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxWorkerName.Text == string.Empty)
                    throw new NotImplementedException("Textbox Empty");
                try
                {
                    int noOfPiecesCompleted = Convert.ToInt32(textBoxPieceCompleted.Text);
                    

                    //Price paid per piece
                    decimal pricePaidPerPiece = 0;
                    
                    //Total Amount Earned
                    decimal amountEarned;

                    // Between 1-199
                    if (noOfPiecesCompleted >= 1 && noOfPiecesCompleted <= 199)
                        pricePaidPerPiece = 0.50M;

                    // Between 200-399 
                    else if (noOfPiecesCompleted >= 200 && noOfPiecesCompleted <= 399)
                        pricePaidPerPiece = 0.55M;

                    // Between 400-599
                    else if (noOfPiecesCompleted >= 400 && noOfPiecesCompleted <= 599)
                        pricePaidPerPiece = 0.60M;

                    // Between 600 or more
                    else if (noOfPiecesCompleted >= 600)
                        pricePaidPerPiece = 0.65M;

                    // Message Display of Error
                    else
                    {
                        MessageBox.Show("Invaid Number of Pieces Completed.\nTry Again", "Error",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    }

                    // Display Amount earned in textbox
                    amountEarned = pricePaidPerPiece * noOfPiecesCompleted;
                    // Assign earned money to textbox
                    textBoxAmountEarned.Text = amountEarned.ToString("C");

                    // assign value to class fields
                    totalEmployees++;
                    totalNumberOfPieces = totalNumberOfPieces + noOfPiecesCompleted;
                    totalPay = totalPay + amountEarned;

                    
                }
                catch
                {
                    MessageBox.Show("Invaid Number of Pieces Completed.\nTry Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
            catch
            {
                MessageBox.Show("Enter Name of Worker", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            
        }

        void clear()
        {
            textBoxAmountEarned.Clear();
            textBoxPieceCompleted.Clear();
            textBoxWorkerName.Clear();
            textBoxWorkerName.Focus();
        }

        private void buttonSummary_Click(object sender, EventArgs e)
        {
            try
            {
                string msg = ""
             + "\n\nTotal Workers:   " + totalEmployees
             + "\n\nTotal Pay:   " + totalPay.ToString("C")
                +"\n\nTotal Number of pieces:   " + totalNumberOfPieces
             + "\n\nAverage pay per Person:   " + ((decimal)(totalPay / totalEmployees)).ToString("C");

                MessageBox.Show(msg, "Summary", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Enter Data", "Insufficient Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void buttonClearAll_Click(object sender, EventArgs e)
        {
            DialogResult responce = MessageBox.Show("Are You Want Clear Summary ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (responce == DialogResult.Yes)
            {
                clear();
                totalEmployees = 0;
                totalNumberOfPieces = 0;
                totalPay = 0;
            }
            else
                clear();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
