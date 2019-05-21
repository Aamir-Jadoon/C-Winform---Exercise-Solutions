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
    public partial class FormChapter1ProgrammingExercise : Form
    {
        public FormChapter1ProgrammingExercise()
        {
            InitializeComponent();
        }

        private void helloWorldFranceButton_Click(object sender, EventArgs e)
        {
            labelhelloworld.Text = "Bonjour tout le monde";
            
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            labelhelloworld.Text = "Ciao Mondo";
        }

        private void buttonStudentLearning_Click(object sender, EventArgs e)
        {
            labelHours.Text = " 8.30 A.M. to 3.30 P.M., from Monday to Friday inclusive.";
        }

        private void buttonFinancialAid_Click(object sender, EventArgs e)
        {
            labelHours.Text = "8.30 A.M. to 5.30 P.M., from Monday to Saturday.";
        }

        private void buttonCounseling_Click(object sender, EventArgs e)
        {
            labelHours.Text = "9.30 A.M. to 1.30 P.M., from Monday to Thursday inclusive.";
        }

        private void buttonBookstore_Click(object sender, EventArgs e)
        {
            labelHours.Text = "8.30 A.M. to 5.30 P.M., from Monday to Sunday inclusive.";
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            metroTabPage2.Hide();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            metroTabPage2.Hide();
        }

        private void buttonSaying1_Click(object sender, EventArgs e)
        {
            labelSaying.Text = "Don't reinvent the wheel.";
        }

        private void buttonSaying2_Click(object sender, EventArgs e)
        {
            labelSaying.Text = "The early bird gets the worm";
        }

        private void buttonSaying3_Click(object sender, EventArgs e)
        {
            labelSaying.Text = "A penny saved is a penny earned";
        }

        private void buttonSaying4_Click(object sender, EventArgs e)
        {
            labelSaying.Text = "Knowledge is more than equivalent to force.";
        }

        private void button3exit_Click(object sender, EventArgs e)
        {
            metroTabPage3.Hide();
        }

        private void labelSaying_Click(object sender, EventArgs e)
        {

        }

        private void buttonContactPerson_Click(object sender, EventArgs e)
        {
            labelContactPerson.Text = "H. David S.H";
        }

        private void buttonDepartment_Click(object sender, EventArgs e)
        {
            labelDepartment.Text = "Human Resource";
        }

        private void buttonPhone_Click(object sender, EventArgs e)
        {
            labelPhone.Text = "888-567-909";
        }

        private void button4Exit_Click(object sender, EventArgs e)
        {
            metroTabPage4.Hide();
        }

        private void buttonSoupOfTheDay_Click(object sender, EventArgs e)
        {
            labelSoupOfTheDay.Text = "Dorothy’s Diner is offering Tortilla Soup";
            
        }

        private void buttonChefsSpecial_Click(object sender, EventArgs e)
        {
            labelchefSpecial.Text = "a California Cobb Salad";
        }

        private void buttonDailyFish_Click(object sender, EventArgs e)
        {
            labelDailyFish.Text = "Hazelnut-Coated Mahi Mahi";
        }

        private void metroButton2_Click_1(object sender, EventArgs e)
        {
            metroTabPage5.Hide();
        }
    }
}
