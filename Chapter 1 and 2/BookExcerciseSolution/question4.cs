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
    public partial class question4 : UserControl
    {
        public question4()
        {
            InitializeComponent();
        }

        private void radiobuttonDaypack_CheckedChanged(object sender, EventArgs e)
        {
            if (radiobuttonDaypack.Checked)
                pictureBoxBackpack.Image = BookExcerciseSolution.Properties.Resources.daypack;
            else
                pictureBoxBackpack.Image = null;
        }

        private void radiobuttonSchoolpack_CheckedChanged(object sender, EventArgs e)
        {
            if (radiobuttonSchoolpack.Checked)
                pictureBoxBackpack.Image = BookExcerciseSolution.Properties.Resources.schoolbag;
            else
                pictureBoxBackpack.Image = null;
        }

        private void radiobuttonSlingBackpacks_CheckedChanged(object sender, EventArgs e)
        {
            if (radiobuttonSlingBackpacks.Checked)
                pictureBoxBackpack.Image = BookExcerciseSolution.Properties.Resources.slingbackpack;
            else
                pictureBoxBackpack.Image = null;

        }

        private void radiobuttonCyclingbackpacks_CheckedChanged(object sender, EventArgs e)
        {
            if (radiobuttonCyclingbackpacks.Checked)
                pictureBoxBackpack.Image = BookExcerciseSolution.Properties.Resources.cyclingbackpack;
            else
                pictureBoxBackpack.Image = null;
        }

        private void radiobuttonWeekingHiking_CheckedChanged(object sender, EventArgs e)
        {
            if (radiobuttonWeekingHiking.Checked)
                pictureBoxBackpack.Image = BookExcerciseSolution.Properties.Resources.weekinghikingbackpack;
            else
                pictureBoxBackpack.Image = null;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            pictureBoxBackpack.Image = null;
            radiobuttonCyclingbackpacks.Checked = false;
            radiobuttonDaypack.Checked = false;
            radiobuttonSchoolpack.Checked = false;
            radiobuttonWeekingHiking.Checked = false;
            radiobuttonSlingBackpacks.Checked = false;
        }
    }
}
