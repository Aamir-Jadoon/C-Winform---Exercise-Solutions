namespace BookExcerciseSolution
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonChapter1 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.PictureBoxClose = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.buttonChapter2 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.buttonChapter3 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.buttonChapter4 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.buttonChapter5 = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(832, 562);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.White;
            this.lineShape1.BorderWidth = 3;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 1;
            this.lineShape1.X2 = 832;
            this.lineShape1.Y1 = 83;
            this.lineShape1.Y2 = 83;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(64, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(588, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Programming in Visual C# 2008 - Exercise Solution";
            // 
            // buttonChapter1
            // 
            this.buttonChapter1.ActiveBorderThickness = 1;
            this.buttonChapter1.ActiveCornerRadius = 10;
            this.buttonChapter1.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(123)))), ((int)(((byte)(205)))));
            this.buttonChapter1.ActiveForecolor = System.Drawing.Color.White;
            this.buttonChapter1.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(123)))), ((int)(((byte)(205)))));
            this.buttonChapter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonChapter1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonChapter1.BackgroundImage")));
            this.buttonChapter1.ButtonText = "Chapter 1";
            this.buttonChapter1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonChapter1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChapter1.ForeColor = System.Drawing.Color.SeaGreen;
            this.buttonChapter1.IdleBorderThickness = 2;
            this.buttonChapter1.IdleCornerRadius = 10;
            this.buttonChapter1.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(210)))), ((int)(((byte)(238)))));
            this.buttonChapter1.IdleForecolor = System.Drawing.Color.Black;
            this.buttonChapter1.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(210)))), ((int)(((byte)(238)))));
            this.buttonChapter1.Location = new System.Drawing.Point(308, 126);
            this.buttonChapter1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonChapter1.Name = "buttonChapter1";
            this.buttonChapter1.Size = new System.Drawing.Size(208, 62);
            this.buttonChapter1.TabIndex = 4;
            this.buttonChapter1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonChapter1.Click += new System.EventHandler(this.buttonChapter1_Click);
            // 
            // PictureBoxClose
            // 
            this.PictureBoxClose.AllowFocused = false;
            this.PictureBoxClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PictureBoxClose.BackColor = System.Drawing.Color.White;
            this.PictureBoxClose.BorderRadius = 15;
            this.PictureBoxClose.Image = global::BookExcerciseSolution.Properties.Resources.close_circular_button_of_a_cross;
            this.PictureBoxClose.IsCircle = true;
            this.PictureBoxClose.Location = new System.Drawing.Point(796, 5);
            this.PictureBoxClose.Name = "PictureBoxClose";
            this.PictureBoxClose.Size = new System.Drawing.Size(30, 30);
            this.PictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxClose.TabIndex = 2;
            this.PictureBoxClose.TabStop = false;
            this.PictureBoxClose.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            this.PictureBoxClose.Click += new System.EventHandler(this.PictureBoxClose_Click);
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox1.BorderRadius = 29;
            this.bunifuPictureBox1.Image = global::BookExcerciseSolution.Properties.Resources.icons8_color_wheel_96;
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(7, 13);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(58, 58);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 1;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            // 
            // buttonChapter2
            // 
            this.buttonChapter2.ActiveBorderThickness = 1;
            this.buttonChapter2.ActiveCornerRadius = 10;
            this.buttonChapter2.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(123)))), ((int)(((byte)(205)))));
            this.buttonChapter2.ActiveForecolor = System.Drawing.Color.White;
            this.buttonChapter2.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(123)))), ((int)(((byte)(205)))));
            this.buttonChapter2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonChapter2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonChapter2.BackgroundImage")));
            this.buttonChapter2.ButtonText = "Chapter 2";
            this.buttonChapter2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonChapter2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChapter2.ForeColor = System.Drawing.Color.SeaGreen;
            this.buttonChapter2.IdleBorderThickness = 2;
            this.buttonChapter2.IdleCornerRadius = 10;
            this.buttonChapter2.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(210)))), ((int)(((byte)(238)))));
            this.buttonChapter2.IdleForecolor = System.Drawing.Color.Black;
            this.buttonChapter2.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(210)))), ((int)(((byte)(238)))));
            this.buttonChapter2.Location = new System.Drawing.Point(308, 188);
            this.buttonChapter2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonChapter2.Name = "buttonChapter2";
            this.buttonChapter2.Size = new System.Drawing.Size(208, 62);
            this.buttonChapter2.TabIndex = 5;
            this.buttonChapter2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonChapter2.Click += new System.EventHandler(this.buttonChapter2_Click);
            // 
            // buttonChapter3
            // 
            this.buttonChapter3.ActiveBorderThickness = 1;
            this.buttonChapter3.ActiveCornerRadius = 10;
            this.buttonChapter3.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(123)))), ((int)(((byte)(205)))));
            this.buttonChapter3.ActiveForecolor = System.Drawing.Color.White;
            this.buttonChapter3.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(123)))), ((int)(((byte)(205)))));
            this.buttonChapter3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonChapter3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonChapter3.BackgroundImage")));
            this.buttonChapter3.ButtonText = "Chapter 3";
            this.buttonChapter3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonChapter3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChapter3.ForeColor = System.Drawing.Color.SeaGreen;
            this.buttonChapter3.IdleBorderThickness = 2;
            this.buttonChapter3.IdleCornerRadius = 10;
            this.buttonChapter3.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(210)))), ((int)(((byte)(238)))));
            this.buttonChapter3.IdleForecolor = System.Drawing.Color.Black;
            this.buttonChapter3.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(210)))), ((int)(((byte)(238)))));
            this.buttonChapter3.Location = new System.Drawing.Point(308, 250);
            this.buttonChapter3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonChapter3.Name = "buttonChapter3";
            this.buttonChapter3.Size = new System.Drawing.Size(208, 62);
            this.buttonChapter3.TabIndex = 6;
            this.buttonChapter3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonChapter3.Click += new System.EventHandler(this.buttonChapter3_Click);
            // 
            // buttonChapter4
            // 
            this.buttonChapter4.ActiveBorderThickness = 1;
            this.buttonChapter4.ActiveCornerRadius = 10;
            this.buttonChapter4.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(123)))), ((int)(((byte)(205)))));
            this.buttonChapter4.ActiveForecolor = System.Drawing.Color.White;
            this.buttonChapter4.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(123)))), ((int)(((byte)(205)))));
            this.buttonChapter4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonChapter4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonChapter4.BackgroundImage")));
            this.buttonChapter4.ButtonText = "Chapter 4";
            this.buttonChapter4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonChapter4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChapter4.ForeColor = System.Drawing.Color.SeaGreen;
            this.buttonChapter4.IdleBorderThickness = 2;
            this.buttonChapter4.IdleCornerRadius = 10;
            this.buttonChapter4.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(210)))), ((int)(((byte)(238)))));
            this.buttonChapter4.IdleForecolor = System.Drawing.Color.Black;
            this.buttonChapter4.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(210)))), ((int)(((byte)(238)))));
            this.buttonChapter4.Location = new System.Drawing.Point(308, 312);
            this.buttonChapter4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonChapter4.Name = "buttonChapter4";
            this.buttonChapter4.Size = new System.Drawing.Size(208, 62);
            this.buttonChapter4.TabIndex = 7;
            this.buttonChapter4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonChapter4.Click += new System.EventHandler(this.buttonChapter4_Click);
            // 
            // buttonChapter5
            // 
            this.buttonChapter5.ActiveBorderThickness = 1;
            this.buttonChapter5.ActiveCornerRadius = 10;
            this.buttonChapter5.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(123)))), ((int)(((byte)(205)))));
            this.buttonChapter5.ActiveForecolor = System.Drawing.Color.White;
            this.buttonChapter5.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(123)))), ((int)(((byte)(205)))));
            this.buttonChapter5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonChapter5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonChapter5.BackgroundImage")));
            this.buttonChapter5.ButtonText = "Chapter 5";
            this.buttonChapter5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonChapter5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChapter5.ForeColor = System.Drawing.Color.SeaGreen;
            this.buttonChapter5.IdleBorderThickness = 2;
            this.buttonChapter5.IdleCornerRadius = 10;
            this.buttonChapter5.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(210)))), ((int)(((byte)(238)))));
            this.buttonChapter5.IdleForecolor = System.Drawing.Color.Black;
            this.buttonChapter5.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(210)))), ((int)(((byte)(238)))));
            this.buttonChapter5.Location = new System.Drawing.Point(308, 374);
            this.buttonChapter5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonChapter5.Name = "buttonChapter5";
            this.buttonChapter5.Size = new System.Drawing.Size(208, 62);
            this.buttonChapter5.TabIndex = 8;
            this.buttonChapter5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonChapter5.Click += new System.EventHandler(this.buttonChapter5_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(832, 562);
            this.Controls.Add(this.buttonChapter5);
            this.Controls.Add(this.buttonChapter4);
            this.Controls.Add(this.buttonChapter3);
            this.Controls.Add(this.buttonChapter2);
            this.Controls.Add(this.buttonChapter1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PictureBoxClose);
            this.Controls.Add(this.bunifuPictureBox1);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Bunifu.UI.WinForms.BunifuPictureBox PictureBoxClose;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        private System.Windows.Forms.Label label1;
        internal Bunifu.Framework.UI.BunifuThinButton2 buttonChapter1;
        internal Bunifu.Framework.UI.BunifuThinButton2 buttonChapter5;
        internal Bunifu.Framework.UI.BunifuThinButton2 buttonChapter4;
        internal Bunifu.Framework.UI.BunifuThinButton2 buttonChapter3;
        internal Bunifu.Framework.UI.BunifuThinButton2 buttonChapter2;
    }
}

