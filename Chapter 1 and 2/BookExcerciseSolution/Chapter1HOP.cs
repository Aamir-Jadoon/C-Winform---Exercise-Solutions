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
    public partial class Chapter1HOP : Form
    {
        public Chapter1HOP()
        {
            InitializeComponent();
        }

        private void clothingButton_Click(object sender, EventArgs e)
        {
            promotionLabel.Text = "Take an extra 30% off the clearance items.";
        }

        private void equipmentButton_Click(object sender, EventArgs e)
        {
            promotionLabel.Text = "Yoga mats - 25% off";
        }

        private void juiceBarButton_Click(object sender, EventArgs e)
        {
            promotionLabel.Text = "Try a free serving of our new WheatBerry Shake";
        }

        private void membershipButton_Click(object sender, EventArgs e)
        {
            promotionLabel.Text = "First month personal training included";
        }

        private void personalTrainingButton_Click(object sender, EventArgs e)
        {
            promotionLabel.Text = "3 free sessions with membership renewal";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
