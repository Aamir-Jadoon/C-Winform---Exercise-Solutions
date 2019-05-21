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
    public partial class Chapter2HOP : Form
    {
        public Chapter2HOP()
        {
            InitializeComponent();
        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            // Display the specials, set the visibility of the controls.

            richTextBoxWelcome.Text = "Welcome #"
                + textBoxMemberID.Text
                + Environment.NewLine + textboxName.Text;

            // Set the visibility properties
            labelMemberID.Visible = false;
            textBoxMemberID.Visible = false;
            labelMemberName.Visible = false;
            textboxName.Visible = false;
            richTextBoxWelcome.Visible = true;
            textBoxPromotions.Visible = true;
            checkBoxImageVisible.Visible = true;
            pictureBoxDepartment.Visible = true;

            // Enable radio buttons
            groupBoxDepartment.Enabled = true;


        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            // Print the form as a print preview

            printForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview;
            printForm1.Print();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            // End of the Project
            this.Close();
        }

        private void radioButtonClothing_CheckedChanged(object sender, EventArgs e)
        {
            // Display the clothing image and show the special
            pictureBoxDepartment.Image = BookExcerciseSolution.Properties.Resources.clothing;
            textBoxPromotions.Text = "30% off clearance items.";
        }

        private void radioButtonEquipment_CheckedChanged(object sender, EventArgs e)
        {
            // Display the equipment image and show the special
            pictureBoxDepartment.Image = BookExcerciseSolution.Properties.Resources.accessories;
            textBoxPromotions.Text = "25% off all equipment";
        }

        private void radioButtonJuiceBar_CheckedChanged(object sender, EventArgs e)
        {
            // Display the juice bar image and show the special
            pictureBoxDepartment.Image = BookExcerciseSolution.Properties.Resources.juicebar;
            textBoxPromotions.Text = "Free seerving of WheatBerry Shake";

        }

        private void radioButtonMembership_CheckedChanged(object sender, EventArgs e)
        {
            // Display the membership image and show the special
            pictureBoxDepartment.Image = BookExcerciseSolution.Properties.Resources.membership;
            textBoxPromotions.Text = "Free Personal Trainer for 1st month";

        }

        private void radioButtonPersonalTraining_CheckedChanged(object sender, EventArgs e)
        {
            // Display the personal training image and show the special
            pictureBoxDepartment.Image = BookExcerciseSolution.Properties.Resources.personalTraining;
            textBoxPromotions.Text = "3 free sessions with membership renewal";

        }

        private void checkBoxImageVisible_CheckedChanged(object sender, EventArgs e)
        {
            // set the visibilty of department image
            pictureBoxDepartment.Visible = checkBoxImageVisible.Checked;
        }
    }
}
