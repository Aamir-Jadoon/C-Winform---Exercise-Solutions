using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question_4._7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonDispaly_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            groupBox2.Enabled = true;
            pictureBoxCountry.Visible = true;
            labelCountryName.Visible = true;
            radioButtonPakistan.Checked = true;
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonPakistan.Checked)
            {
                pictureBoxCountry.Image = Question_4._7.Properties.Resources.pakistan;
                labelCountryName.Text = "Pakistan";
            }
            else if (radioButtonIran.Checked)
            {
                pictureBoxCountry.Image = Question_4._7.Properties.Resources.iran;
                labelCountryName.Text = "Iran";
            }
            else if (radioButtonSpain.Checked)
            {
                pictureBoxCountry.Image = Question_4._7.Properties.Resources.spain;
                labelCountryName.Text = "Spain";
            }
            else if (radioButtonTurkey.Checked)
            {
                pictureBoxCountry.Image = Question_4._7.Properties.Resources.turkey;
                labelCountryName.Text = "Turkey";
            }
        }

        private void CheckedBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CheckBox_Checked(object sender, EventArgs e)
        {
            if (checkBoxFormTitle.Checked)
            {
                labelFormTitle.Visible = true;
            }
            else if (!checkBoxFormTitle.Checked)
            {
                labelFormTitle.Visible = false;
            }

            if (checkBoxProgrammerName.Checked)
            {
                labelprogrammer.Visible = true;
            }else
            {
                labelprogrammer.Visible = false;
            }

            if (checkBoxCountryName.Checked)
            {
                labelCountryName.Visible = true;
            }
            else
            {
                labelCountryName.Visible = false;
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            printForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview;
            printForm1.Print();
        }
    }
}
