namespace BookExcerciseSolution
{
    partial class question3
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(question3));
            this.labelNameQ3 = new System.Windows.Forms.Label();
            this.textboxNameQ3 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.groupBoxWheatherQ3 = new System.Windows.Forms.GroupBox();
            this.radiobuttonCloudyQ3 = new MetroFramework.Controls.MetroRadioButton();
            this.radiobuttonSunnyQ3 = new MetroFramework.Controls.MetroRadioButton();
            this.radiobuttonSnowQ3 = new MetroFramework.Controls.MetroRadioButton();
            this.radiobuttonRainQ3 = new MetroFramework.Controls.MetroRadioButton();
            this.labelWheatherMessageQ3 = new System.Windows.Forms.Label();
            this.labelTitleQ3 = new System.Windows.Forms.Label();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.labelProgrammerName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.groupBoxWheatherQ3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNameQ3
            // 
            this.labelNameQ3.AutoSize = true;
            this.labelNameQ3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameQ3.Location = new System.Drawing.Point(242, 176);
            this.labelNameQ3.Name = "labelNameQ3";
            this.labelNameQ3.Size = new System.Drawing.Size(66, 19);
            this.labelNameQ3.TabIndex = 0;
            this.labelNameQ3.Text = "Name: ";
            // 
            // textboxNameQ3
            // 
            this.textboxNameQ3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.textboxNameQ3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.textboxNameQ3.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.textboxNameQ3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textboxNameQ3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textboxNameQ3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textboxNameQ3.HintForeColor = System.Drawing.Color.Empty;
            this.textboxNameQ3.HintText = "Your Name";
            this.textboxNameQ3.isPassword = false;
            this.textboxNameQ3.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(205)))), ((int)(((byte)(80)))));
            this.textboxNameQ3.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.textboxNameQ3.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.textboxNameQ3.LineThickness = 3;
            this.textboxNameQ3.Location = new System.Drawing.Point(315, 162);
            this.textboxNameQ3.Margin = new System.Windows.Forms.Padding(4);
            this.textboxNameQ3.MaxLength = 32767;
            this.textboxNameQ3.Name = "textboxNameQ3";
            this.textboxNameQ3.Size = new System.Drawing.Size(210, 33);
            this.textboxNameQ3.TabIndex = 1;
            this.textboxNameQ3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.metroToolTip1.SetToolTip(this.textboxNameQ3, "Type your name here.");
            // 
            // groupBoxWheatherQ3
            // 
            this.groupBoxWheatherQ3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBoxWheatherQ3.Controls.Add(this.radiobuttonCloudyQ3);
            this.groupBoxWheatherQ3.Controls.Add(this.radiobuttonSunnyQ3);
            this.groupBoxWheatherQ3.Controls.Add(this.radiobuttonSnowQ3);
            this.groupBoxWheatherQ3.Controls.Add(this.radiobuttonRainQ3);
            this.groupBoxWheatherQ3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxWheatherQ3.Location = new System.Drawing.Point(229, 345);
            this.groupBoxWheatherQ3.Name = "groupBoxWheatherQ3";
            this.groupBoxWheatherQ3.Size = new System.Drawing.Size(325, 83);
            this.groupBoxWheatherQ3.TabIndex = 2;
            this.groupBoxWheatherQ3.TabStop = false;
            this.groupBoxWheatherQ3.Text = "  Wheather  ";
            this.metroToolTip1.SetToolTip(this.groupBoxWheatherQ3, "Select a Weather ...");
            // 
            // radiobuttonCloudyQ3
            // 
            this.radiobuttonCloudyQ3.AutoSize = true;
            this.radiobuttonCloudyQ3.Location = new System.Drawing.Point(240, 36);
            this.radiobuttonCloudyQ3.Name = "radiobuttonCloudyQ3";
            this.radiobuttonCloudyQ3.Size = new System.Drawing.Size(61, 15);
            this.radiobuttonCloudyQ3.TabIndex = 3;
            this.radiobuttonCloudyQ3.Text = "Cloudy";
            this.radiobuttonCloudyQ3.UseSelectable = true;
            this.radiobuttonCloudyQ3.CheckedChanged += new System.EventHandler(this.radiobuttonCloudyQ3_CheckedChanged);
            // 
            // radiobuttonSunnyQ3
            // 
            this.radiobuttonSunnyQ3.AutoSize = true;
            this.radiobuttonSunnyQ3.Location = new System.Drawing.Point(163, 36);
            this.radiobuttonSunnyQ3.Name = "radiobuttonSunnyQ3";
            this.radiobuttonSunnyQ3.Size = new System.Drawing.Size(56, 15);
            this.radiobuttonSunnyQ3.TabIndex = 2;
            this.radiobuttonSunnyQ3.Text = "Sunny";
            this.radiobuttonSunnyQ3.UseSelectable = true;
            this.radiobuttonSunnyQ3.CheckedChanged += new System.EventHandler(this.radiobuttonSunnyQ3_CheckedChanged);
            // 
            // radiobuttonSnowQ3
            // 
            this.radiobuttonSnowQ3.AutoSize = true;
            this.radiobuttonSnowQ3.Location = new System.Drawing.Point(90, 36);
            this.radiobuttonSnowQ3.Name = "radiobuttonSnowQ3";
            this.radiobuttonSnowQ3.Size = new System.Drawing.Size(52, 15);
            this.radiobuttonSnowQ3.TabIndex = 1;
            this.radiobuttonSnowQ3.Text = "Snow";
            this.radiobuttonSnowQ3.UseSelectable = true;
            this.radiobuttonSnowQ3.CheckedChanged += new System.EventHandler(this.radiobuttonSnowQ3_CheckedChanged);
            // 
            // radiobuttonRainQ3
            // 
            this.radiobuttonRainQ3.AutoSize = true;
            this.radiobuttonRainQ3.Location = new System.Drawing.Point(23, 36);
            this.radiobuttonRainQ3.Name = "radiobuttonRainQ3";
            this.radiobuttonRainQ3.Size = new System.Drawing.Size(46, 15);
            this.radiobuttonRainQ3.TabIndex = 0;
            this.radiobuttonRainQ3.Text = "Rain";
            this.radiobuttonRainQ3.UseSelectable = true;
            this.radiobuttonRainQ3.CheckedChanged += new System.EventHandler(this.radiobuttonRainQ3_CheckedChanged);
            // 
            // labelWheatherMessageQ3
            // 
            this.labelWheatherMessageQ3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWheatherMessageQ3.Location = new System.Drawing.Point(233, 235);
            this.labelWheatherMessageQ3.Name = "labelWheatherMessageQ3";
            this.labelWheatherMessageQ3.Size = new System.Drawing.Size(190, 70);
            this.labelWheatherMessageQ3.TabIndex = 4;
            this.labelWheatherMessageQ3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTitleQ3
            // 
            this.labelTitleQ3.AutoSize = true;
            this.labelTitleQ3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleQ3.Location = new System.Drawing.Point(143, 63);
            this.labelTitleQ3.Name = "labelTitleQ3";
            this.labelTitleQ3.Size = new System.Drawing.Size(500, 28);
            this.labelTitleQ3.TabIndex = 5;
            this.labelTitleQ3.Text = "Weather Report for a Sporting Goods Store";
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.AutoPopDelay = 5000;
            this.metroToolTip1.InitialDelay = 500;
            this.metroToolTip1.ReshowDelay = 100;
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // labelProgrammerName
            // 
            this.labelProgrammerName.AutoSize = true;
            this.labelProgrammerName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProgrammerName.Location = new System.Drawing.Point(523, 594);
            this.labelProgrammerName.Name = "labelProgrammerName";
            this.labelProgrammerName.Size = new System.Drawing.Size(250, 16);
            this.labelProgrammerName.TabIndex = 14;
            this.labelProgrammerName.Text = "Programmed by: Aamir Khan Jadoon";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BookExcerciseSolution.Properties.Resources.weather;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox1.BorderRadius = 59;
            this.bunifuPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuPictureBox1.Image")));
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(435, 212);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(119, 119);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 3;
            this.bunifuPictureBox1.TabStop = false;
            this.metroToolTip1.SetToolTip(this.bunifuPictureBox1, "Image related to the selected weather inside Wheater Group.");
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            // 
            // question3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.labelTitleQ3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelProgrammerName);
            this.Controls.Add(this.labelWheatherMessageQ3);
            this.Controls.Add(this.bunifuPictureBox1);
            this.Controls.Add(this.groupBoxWheatherQ3);
            this.Controls.Add(this.textboxNameQ3);
            this.Controls.Add(this.labelNameQ3);
            this.Name = "question3";
            this.Size = new System.Drawing.Size(786, 638);
            this.Load += new System.EventHandler(this.question3_Load);
            this.groupBoxWheatherQ3.ResumeLayout(false);
            this.groupBoxWheatherQ3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNameQ3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textboxNameQ3;
        private System.Windows.Forms.GroupBox groupBoxWheatherQ3;
        private MetroFramework.Controls.MetroRadioButton radiobuttonCloudyQ3;
        private MetroFramework.Controls.MetroRadioButton radiobuttonSunnyQ3;
        private MetroFramework.Controls.MetroRadioButton radiobuttonSnowQ3;
        private MetroFramework.Controls.MetroRadioButton radiobuttonRainQ3;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        private System.Windows.Forms.Label labelWheatherMessageQ3;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private System.Windows.Forms.Label labelTitleQ3;
        private System.Windows.Forms.Label labelProgrammerName;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
