using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookExcerciseSolution
{
    public partial class question5 : UserControl
    {
        public question5()
        {
            InitializeComponent();
        }

        private void enter_button(MaskedTextBox txtbox)
        {
            
            txtbox.BackColor = Color.FromArgb(255, 242, 157);
        }

        private void maskedTextBox1_Enter(object sender, EventArgs e)
        {
            enter_button(textboxFirstName);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void enteringTextBox(MaskedTextBox tbox, Bunifu.UI.WinForms.BunifuPictureBox pbox)
        {
            tbox.BackColor = Color.White;
            pbox.Image = null;
        }
        private void leavingTextBox(MaskedTextBox tbox, Bunifu.UI.WinForms.BunifuPictureBox pbox)
        {
            pbox.Visible = true;

            if (string.Equals(tbox.Text, ""))
            {
                //red background
                tbox.BackColor = Color.FromArgb(251, 195, 195);
                //warning picture
                pbox.Image = BookExcerciseSolution.Properties.Resources.wrong1;
            }
            else
            {
                // green backgroud
                tbox.BackColor = Color.FromArgb(192, 239, 191);
                // correct picture
                pbox.Image = BookExcerciseSolution.Properties.Resources.tick1;
            }

        }

        private void textboxFirstName_Leave(object sender, EventArgs e)
        {
            leavingTextBox(textboxFirstName, pictureboxFirstName);
        }

        private void textboxFirstName_Enter(object sender, EventArgs e)
        {
            enteringTextBox(textboxFirstName,pictureboxFirstName);
        }

        private void textboxLastName_Enter(object sender, EventArgs e)
        {
            enteringTextBox(textboxLastName, pictureboxLastName);
        }

        private void textboxLastName_Leave(object sender, EventArgs e)
        {
            leavingTextBox(textboxLastName, pictureboxLastName);
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
            pictureboxStreetAddress.Image = null;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            pictureboxStreetAddress.Visible = true;

            if (string.Equals(textBox1.Text, ""))
            {
                //red background
                textBox1.BackColor = Color.FromArgb(251, 195, 195);
                //warning picture
                pictureboxStreetAddress.Image = BookExcerciseSolution.Properties.Resources.wrong1;
            }
            else
            {
                // green backgroud
                textBox1.BackColor = Color.FromArgb(192, 239, 191);
                // correct picture
                pictureboxStreetAddress.Image = BookExcerciseSolution.Properties.Resources.tick1;
            }
        }

        private void textboxCity_Enter(object sender, EventArgs e)
        {
            enteringTextBox(textboxCity, pictureboxCity);
        }

        private void textboxCity_Leave(object sender, EventArgs e)
        {
            leavingTextBox(textboxCity, pictureboxCity);
        }

        private void textboxState_Enter(object sender, EventArgs e)
        {
            enteringTextBox(textboxState, pictureboxState);
        }

        private void textboxState_Leave(object sender, EventArgs e)
        {
            leavingTextBox(textboxState, pictureboxState);
        }

        private void textboxZipCode_Enter(object sender, EventArgs e)
        {
            enteringTextBox(textboxZipCode, pictureboxZipCode);
        }

        private void textboxZipCode_Leave(object sender, EventArgs e)
        {
            leavingTextBox(textboxZipCode, pictureboxZipCode);
        }

        private void buttonDisplayLabel_Click(object sender, EventArgs e)
        {
            richTextBoxMailingLabel.Text = "» "+textboxFirstName.Text.Trim() + " " + textboxLastName.Text.Trim()
                + "\n» " + textBox1.Text.Trim()
                + "\n» " + textboxCity.Text.Trim() + ", " + textboxState.Text.Trim() + "  " + textboxZipCode.Text.Trim();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            foreach(Control c in this.Controls)
            {
                if (c is MaskedTextBox)
                {
                    (c as MaskedTextBox).Clear();
                    c.BackColor = Color.White;
                }
            }
            foreach(Control c in this.Controls)
            {
                if(c is Bunifu.UI.WinForms.BunifuPictureBox)
                {
                    (c as Bunifu.UI.WinForms.BunifuPictureBox).Image = null;
                }
            }

            textBox1.Text = string.Empty;
            textBox1.BackColor = Color.White;
            textboxFirstName.Focus();
            richTextBoxMailingLabel.Text = string.Empty;
        }
    }
}
