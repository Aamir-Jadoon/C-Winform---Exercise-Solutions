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
    public partial class CH02Q1 : UserControl
    {
        
        

        public CH02Q1()
        {
            InitializeComponent();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            groupBoxFemaleShoes.Visible = false;
            groupBoxMensShoes.Visible = false;
            pictureboxShoes.Visible = false;
            textboxPicture.Visible = false;
            radiobuttonMensShoe.Checked = false;
            radiobuttonWomenShoe.Checked = false;
            radiobuttonManSandals.Checked = false;
            radiobuttonManTennis.Checked = false;
            radiobuttonManWestern.Checked = false;
            radiobuttonManWork.Checked = false;
            radiobuttonMenDree.Checked = false;
            radiobuttonWomenBoots.Checked = false;
            radiobuttonWomendress.Checked = false;
            radiobuttonWomenRunningShoes.Checked = false;
            radiobuttonWomenSandals.Checked = false;
        }

        private void radiobuttonMensShoe_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxMensShoes.Visible = true;
            groupBoxFemaleShoes.Visible = false;
            pictureboxShoes.Visible = true;
            textboxPicture.Visible = true;

            pictureboxShoes.Image = null;
            textboxPicture.Text = string.Empty;


        }

        private void radiobuttonWomenShoe_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxMensShoes.Visible = false; ;
            groupBoxFemaleShoes.Visible = true;
            groupBoxFemaleShoes.Location = new Point(150,219);
            pictureboxShoes.Visible = true;
            textboxPicture.Visible = true;
            pictureboxShoes.Image = null;
            textboxPicture.Text = string.Empty;

        }

        private void radiobuttonMenDree_CheckedChanged(object sender, EventArgs e)
        {
            string textboxMen = "Men's ";
            pictureboxShoes.Image = BookExcerciseSolution.Properties.Resources.mendressshoes;
            textboxMen += radiobuttonMenDree.Text;
            textboxPicture.Text = textboxMen; 
        }

        private void radiobuttonManWork_CheckedChanged(object sender, EventArgs e)
        {
            string textboxMen = "Men's ";
            pictureboxShoes.Image = BookExcerciseSolution.Properties.Resources.menworkboots;
            textboxMen += radiobuttonManWork.Text;
            textboxPicture.Text = textboxMen;
        }

        private void radiobuttonManWestern_CheckedChanged(object sender, EventArgs e)
        {
            string textboxMen = "Men's ";
            pictureboxShoes.Image = BookExcerciseSolution.Properties.Resources.menwesternboots;
            textboxMen += radiobuttonManWestern.Text;
            textboxPicture.Text = textboxMen;
        }

        private void radiobuttonManTennis_CheckedChanged(object sender, EventArgs e)
        {
            string textboxMen = "Men's ";
            pictureboxShoes.Image = BookExcerciseSolution.Properties.Resources.menstennisshoes;
            textboxMen += radiobuttonManTennis.Text;
            textboxPicture.Text = textboxMen;
        }

        private void radiobuttonManSandals_CheckedChanged(object sender, EventArgs e)
        {
            string textboxMen = "Men's ";
            pictureboxShoes.Image = BookExcerciseSolution.Properties.Resources.mensandels;
            textboxMen += radiobuttonManSandals.Text;
            textboxPicture.Text = textboxMen;
        }

        private void radiobuttonWomendress_CheckedChanged(object sender, EventArgs e)
        {
            string textboxMen = "Women's ";
            pictureboxShoes.Image = BookExcerciseSolution.Properties.Resources.womendressshoes;
            textboxMen += radiobuttonWomendress.Text;
            textboxPicture.Text = textboxMen;
        }

        private void radiobuttonWomenRunningShoes_CheckedChanged(object sender, EventArgs e)
        {
            string textboxMen = "Women's ";

            pictureboxShoes.Image = BookExcerciseSolution.Properties.Resources.womenrunningshoes;
            textboxMen += radiobuttonWomenRunningShoes.Text;
            textboxPicture.Text = textboxMen;
        }

        private void radiobuttonWomenBoots_CheckedChanged(object sender, EventArgs e)
        {
            string textboxMen = "Women's ";

            pictureboxShoes.Image = BookExcerciseSolution.Properties.Resources.womenboots;
            textboxMen += radiobuttonWomenBoots.Text;
            textboxPicture.Text = textboxMen;
        }

        private void radiobuttonWomenSandals_CheckedChanged(object sender, EventArgs e)
        {
            string textboxMen = "Women's ";

            pictureboxShoes.Image = BookExcerciseSolution.Properties.Resources.womensandals;
            textboxMen += radiobuttonWomenSandals.Text;
            textboxPicture.Text = textboxMen;
        }

      
    }
}
