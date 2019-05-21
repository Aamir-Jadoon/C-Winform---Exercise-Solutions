using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question_3._2
{
    public partial class Form1 : Form
    {
        private const double rentalRatePerHour = 200.0 / 60.0;
        private decimal totalNoOfGroup = 0;
        private double totalChargesForAllGroup = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // Total charge for Group
            try {
                double totalChargeforGroup = double.Parse(minuteTextbox.Text) * rentalRatePerHour;
                
                // Increment Total Number of Group
                totalNoOfGroup++;
                // Average Charge per Group
                double averageChargePerGroup = (totalChargesForAllGroup + totalChargeforGroup) / (double)totalNoOfGroup;
                // Total charge for All Group
                totalChargesForAllGroup = totalChargesForAllGroup + totalChargeforGroup;
                // assign total charge for group value to text box
                totalChargeForGroupTextbox.Text = totalChargeforGroup.ToString("C");
                // assign total no of group to textbox
                totalNumberOfGroupTextbox.Text = totalNoOfGroup.ToString();
                // assign total charges for all group to text box
                totalChargesForAllGroupTextbox.Text = totalChargesForAllGroup.ToString("C");
                // assign average to textbox
                averageChargePerGroupTextbox.Text = averageChargePerGroup.ToString("C");

            }
            catch (FormatException msg)
            {
                MessageBox.Show(msg.Message, "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                minuteTextbox.Focus();
                minuteTextbox.SelectAll();
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            foreach(Control c in this.Controls)
            {
                if(c is TextBox)
                {
                    (c as TextBox).Clear();
                }
            }
            totalChargesForAllGroupTextbox.Clear();
            totalNumberOfGroupTextbox.Clear();
            averageChargePerGroupTextbox.Clear();
            totalChargesForAllGroup = 0;
            totalNoOfGroup = 0;
            
            groupTextbox.Focus();
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
