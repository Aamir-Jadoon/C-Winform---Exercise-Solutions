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
    public partial class CHO2Q2 : UserControl
    {
        public CHO2Q2()
        {
            InitializeComponent();
        }

       

        private void radiobuttonPakistan_CheckedChanged(object sender, EventArgs e)
        {
            if (radiobuttonPakistan.Checked)
            {
                pictureboxFlag.Image = BookExcerciseSolution.Properties.Resources.flagpak;
                textBoxFlagName.Text = "Pakistan";
            }


        }

        private void radiobuttonTurkey_CheckedChanged(object sender, EventArgs e)
        {
            if(radiobuttonTurkey.Checked)
                pictureboxFlag.Image = BookExcerciseSolution.Properties.Resources.flagturkey;
            textBoxFlagName.Text = "Turkey";


        }

        private void radiobuttonIran_CheckedChanged(object sender, EventArgs e)
        {
            if(radiobuttonIran.Checked)
                pictureboxFlag.Image = BookExcerciseSolution.Properties.Resources.flagiran;
            textBoxFlagName.Text = "Iran";

        }

        private void radiobuttonAfgan_CheckedChanged(object sender, EventArgs e)
        {
            if(radiobuttonAfgan.Checked)
                pictureboxFlag.Image = BookExcerciseSolution.Properties.Resources.flagafgainistan;
            textBoxFlagName.Text = "Afghanistan";

        }

        private void checkboxFormTitle_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxFormTitle.Checked)
                labelformtitle.Visible = true;
            else
                labelformtitle.Visible = false;


        }

        private void checkboxCountryName_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxCountryName.Checked)
                textBoxFlagName.Visible = true;
            else
                textBoxFlagName.Visible = false;

        }

        private void checkboxProgrammerName_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxProgrammerName.Checked)
                labelProgrammerName.Visible = true;
            else
                labelProgrammerName.Visible = false;

        }

        private void CHO2Q2_Load(object sender, EventArgs e)
        {
           
            textBoxFlagName.Text = "Pakistan";
            pictureboxFlag.Image = BookExcerciseSolution.Properties.Resources.flagpak;
        }

       
    }
}
