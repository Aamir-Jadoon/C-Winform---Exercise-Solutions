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
    public partial class Form_SplashScreen : Form
    {
      
        int timeElapsed = 1;
        
        public Form_SplashScreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            timeElapsed++;
            if(timeElapsed == 400)
            {
                timer1.Stop();
                MainForm f = new MainForm();
                f.ShowDialog();
                this.Close();
            }
                
        }

        private void Form_SplashScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
