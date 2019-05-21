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
    public partial class Chapter1 : Form
    {
        private int _handsOnProgrammingChapter;
        private int _programmingExerciseChapter;

        public int handsOnProgrammingChapter
        {
            get
            {
                return _handsOnProgrammingChapter;
            }
            set
            {
                _handsOnProgrammingChapter = value;
            }
        }

        public int programmingExerciseChapter {
            get
            {
                return _programmingExerciseChapter;
            }
            set
            {
                _programmingExerciseChapter = value;
            }
        }
        public Chapter1()
        {
            InitializeComponent();
        }

        private void ChapterFormbuttonHandsOnProgramming_Click(object sender, EventArgs e)
        {
          

            if (handsOnProgrammingChapter == 1)
            {
                Chapter1HOP f1HOP = new Chapter1HOP();
                f1HOP.ShowDialog();
            }
            else if (handsOnProgrammingChapter == 2)
            {
                Chapter2HOP f2HOP = new Chapter2HOP();
                f2HOP.ShowDialog();
            }
            else
                MessageBox.Show("Currently resource is Unavailable", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void ChapterFormbuttonProgrammingExample_Click(object sender, EventArgs e)
        {
            if(programmingExerciseChapter == 1)
            {
                FormChapter1ProgrammingExercise f = new FormChapter1ProgrammingExercise();
                f.ShowDialog();
            }
            else if(programmingExerciseChapter == 2)
            {
                FormChapter2ProgrammingExercise f = new FormChapter2ProgrammingExercise();
                f.ShowDialog();
            }
            else
                MessageBox.Show("Currently resource is Unavailable", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }
    }
}
