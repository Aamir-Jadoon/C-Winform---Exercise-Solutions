using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookExcerciseSolution
{
    
    public partial class FormChapter2ProgrammingExercise : Form
    {
        
        public FormChapter2ProgrammingExercise()
        {
            InitializeComponent();
        }

      

        private void FormChapter2ProgrammingExercise_Load(object sender, EventArgs e)
        {
            // hide questin 5 window
            question51.Visible = false;
            // hide exit button
            buttonExitQ5.Visible = false;
            // print and exit button for question 4
            buttonExitQ4.Visible = false;
            buttonPrintQ4.Visible = false;
            cH02Q11.Visible = false;

            // visible = false for exitQ3 and printQ3 buttons
            buttonExitQ3.Visible = false;
            buttonPrintQ3.Visible = false;

            // Question 1 panel exit and print button visible = false
            buttonExit.Visible = false;
            buttonPrint.Visible = false;

            // Question 2 panel, exit and print button visible = false
            buttonPrintQ2.Visible = false;
            buttonExitQ2.Visible = false;
        }

        private void buttonQuestion1_Click(object sender, EventArgs e)
        {
            // hide exit button
            buttonExitQ5.Visible = false;
            // display question 5 window
            question51.Visible = false;
            // print and exit button for question 4
            buttonExitQ4.Visible = false;
            buttonPrintQ4.Visible = false;
            // hide question 4 window
            question41.Visible = false;
            // visible = false for exitQ3 and printQ3 buttons
            buttonExitQ3.Visible = false;
            buttonPrintQ3.Visible = false;
            // visible = false for question 3
            question31.Visible = false;
            textboxWelcomeMessage.Visible = false;
            cH02Q11.Visible = true;
            chO2Q21.Visible = false; 

            buttonExit.Visible = true;
            buttonPrint.Visible = true;
            // visible = false, for Question 2 panel
            buttonPrintQ2.Visible = false;
            buttonExitQ2.Visible = false;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            cH02Q11.Visible = false;
            buttonExit.Visible = false;
            buttonPrint.Visible = false;
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            printForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview;
            printForm1.Print();
        }

        private void buttonQuestion2_Click(object sender, EventArgs e)
        {
            // hide exit button
            buttonExitQ5.Visible = false;
            // display question 5 window
            question51.Visible = false;
            // print and exit button for question 4
            buttonExitQ4.Visible = false;
            buttonPrintQ4.Visible = false;
            // hide question 4 window
            question41.Visible = false;
            // visible = false for exitQ3 and printQ3 buttons
            buttonExitQ3.Visible = false;
            buttonPrintQ3.Visible = false;
            // visible = false for question 3
            question31.Visible = false;
            chO2Q21.Visible = true;
            textboxWelcomeMessage.Visible = false;
            buttonPrintQ2.Visible = true;
            buttonExitQ2.Visible = true;
            if (cH02Q11.Visible)
            {
                buttonExit.Visible = false;
                buttonPrint.Visible = false;
                cH02Q11.Visible = false;
            }
        }

        private void buttonPrintQ2_Click(object sender, EventArgs e)
        {
            printForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview;
            printForm1.Print();
        }

        private void buttonExitQ2_Click(object sender, EventArgs e)
        {
            chO2Q21.Visible = false;
            buttonPrintQ2.Visible = false;
            buttonExitQ2.Visible = false;
        }

        private void buttonQuestion3_Click(object sender, EventArgs e)
        {
            // hide exit button
            buttonExitQ5.Visible = false;
            // display question 5 window
            question51.Visible = false;
            // print and exit button for question 4
            buttonExitQ4.Visible = false;
            buttonPrintQ4.Visible = false;
            // hide question 4 window
            question41.Visible = false;
            // visible = false, for welcome message
            textboxWelcomeMessage.Visible = false;
            // visible = false, for question 2
            chO2Q21.Visible = false;
            // visible = false, for question 1
            cH02Q11.Visible = false;
            // visible = true, for question 3
            question31.Visible = true;
            // visible = true for exitQ3 and printQ3 buttons
            buttonExitQ3.Visible = true;
            buttonPrintQ3.Visible = true;
        }

        private void buttonPrintQ3_Click(object sender, EventArgs e)
        {
            printForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview;
            printForm1.Print();
        }

        private void buttonExitQ3_Click(object sender, EventArgs e)
        {
            question31.Visible = false;
            // visible = false for exitQ3 and printQ3 buttons
            buttonExitQ3.Visible = false;
            buttonPrintQ3.Visible = false;
        }

        private void buttonQuestion4_Click(object sender, EventArgs e)
        {
            // hide exit button
            buttonExitQ5.Visible = false;
            // display question 5 window
            question51.Visible = false;
            // print and exit button for question 4
            buttonExitQ4.Visible = true;
            buttonPrintQ4.Visible = true;
            // display question 4 window
            question41.Visible = true;
            // visible = false, for welcome message
            textboxWelcomeMessage.Visible = false;
            // visible = false, for question 2
            chO2Q21.Visible = false;
            // visible = false, for question 1
            cH02Q11.Visible = false;
            // visible = true, for question 3
            question31.Visible = false;
        }

        private void buttonPrintQ4_Click(object sender, EventArgs e)
        {
            printForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview;
            printForm1.Print();
        }

        private void buttonExitQ4_Click(object sender, EventArgs e)
        {
            
            question41.Visible = false;
            // print and exit button for question 4
            buttonExitQ4.Visible = false;
            buttonPrintQ4.Visible = false;

        }

        private void buttonQuestion5_Click(object sender, EventArgs e)
        {
            // hide exit button
            buttonExitQ5.Visible = true;
            // display question 5 window
            question51.Visible = true;
            // visible = false, for welcome message
            textboxWelcomeMessage.Visible = false;
            // visible = false, for question 2
            chO2Q21.Visible = false;
            // visible = false, for question 1
            cH02Q11.Visible = false;
            // visible = true, for question 3
            question31.Visible = false;
            // visible = false, for question 4
            question41.Visible = false;
        }

        private void buttonExitQ5_Click(object sender, EventArgs e)
        {
            // hide question 5 window
            question51.Visible = false;
            // hide exit button
            buttonExitQ5.Visible = false;
        }
    }
}
