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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void PictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonChapter1_Click(object sender, EventArgs e)
        {
            Chapter1 f = new Chapter1(); // General Form for chapters
            f.handsOnProgrammingChapter = 1; // Chapter 1 Hands on Programming Example
            f.programmingExerciseChapter = 1; // Chapter 1 Programming Exercise
            f.labelChapterName.Text = "Introduction to Programming and Visual C# 2008";
            f.Text = "Chapter 1";
            f.ShowDialog();
        }

        private void buttonChapter2_Click(object sender, EventArgs e)
        {
            Chapter1 f = new Chapter1(); // General Form for chapters
            f.handsOnProgrammingChapter = 2;
            f.programmingExerciseChapter = 2;
            f.labelChapterName.Text = "User Interface Design";
            f.Text = "Chapter 2";
            f.ShowDialog();
        }

        private void buttonChapter3_Click(object sender, EventArgs e)
        {
            Chapter1 f = new Chapter1(); // General Form for chapters
            f.labelChapterName.Text = "Variables, Constants, and Calculations";
            f.Text = "Chapter 3";
            f.ShowDialog();

        }

        private void buttonChapter4_Click(object sender, EventArgs e)
        {
            Chapter1 f = new Chapter1(); // General Form for chapters
            f.labelChapterName.Text = "Decisions and Conditions";
            f.Text = "Chapter 4";
            f.ShowDialog();
        }

        private void buttonChapter5_Click(object sender, EventArgs e)
        {
            Chapter1 f = new Chapter1(); // General Form for chapters
            f.labelChapterName.Text = "Menus, Common Dialog Boxes, and Methods";
            f.Text = "Chapter 5";
            f.ShowDialog();
        }
    }
}
