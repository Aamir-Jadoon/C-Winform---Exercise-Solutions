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
    public partial class question3 : UserControl
    {
        public question3()
        {
            InitializeComponent();
        }

        private void radiobuttonRainQ3_CheckedChanged(object sender, EventArgs e)
        {
            bunifuPictureBox1.Image = BookExcerciseSolution.Properties.Resources.rain;
            labelWheatherMessageQ3.Text = "Don't go outside. it's raining, "+textboxNameQ3.Text;
        }

        private void radiobuttonSnowQ3_CheckedChanged(object sender, EventArgs e)
        {
            bunifuPictureBox1.Image = BookExcerciseSolution.Properties.Resources.snow;
            labelWheatherMessageQ3.Text = "Wear your jacket, " + textboxNameQ3.Text+". it's snowing outside.";
        }

        private void radiobuttonSunnyQ3_CheckedChanged(object sender, EventArgs e)
        {
            bunifuPictureBox1.Image = BookExcerciseSolution.Properties.Resources.sunny;
            labelWheatherMessageQ3.Text = "it looks like a day for gold, " + textboxNameQ3.Text;
        }

        private void radiobuttonCloudyQ3_CheckedChanged(object sender, EventArgs e)
        {
            bunifuPictureBox1.Image = BookExcerciseSolution.Properties.Resources.cloudy;
            labelWheatherMessageQ3.Text = "Let's play cricket outside, " + textboxNameQ3.Text+". Today weather is cloudy!";
        }

        private void question3_Load(object sender, EventArgs e)
        {
            bunifuPictureBox1.Image = null;
        }

       
    }
}
