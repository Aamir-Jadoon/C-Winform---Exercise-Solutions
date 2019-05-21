namespace BookExcerciseSolution
{
    partial class CHO2Q2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CHO2Q2));
            this.textBoxFlagName = new System.Windows.Forms.TextBox();
            this.radiobuttonPakistan = new MetroFramework.Controls.MetroRadioButton();
            this.radiobuttonTurkey = new MetroFramework.Controls.MetroRadioButton();
            this.radiobuttonIran = new MetroFramework.Controls.MetroRadioButton();
            this.radiobuttonAfgan = new MetroFramework.Controls.MetroRadioButton();
            this.groupBoxCountriesFlags = new System.Windows.Forms.GroupBox();
            this.groupBoxDisplayHide = new System.Windows.Forms.GroupBox();
            this.checkboxProgrammerName = new MetroFramework.Controls.MetroCheckBox();
            this.checkboxCountryName = new MetroFramework.Controls.MetroCheckBox();
            this.checkboxFormTitle = new MetroFramework.Controls.MetroCheckBox();
            this.labelformtitle = new System.Windows.Forms.Label();
            this.labelProgrammerName = new System.Windows.Forms.Label();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureboxFlag = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.groupBoxCountriesFlags.SuspendLayout();
            this.groupBoxDisplayHide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxFlag)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxFlagName
            // 
            this.textBoxFlagName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(157)))));
            this.textBoxFlagName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFlagName.Location = new System.Drawing.Point(280, 285);
            this.textBoxFlagName.Name = "textBoxFlagName";
            this.textBoxFlagName.Size = new System.Drawing.Size(226, 27);
            this.textBoxFlagName.TabIndex = 4;
            this.textBoxFlagName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.metroToolTip1.SetToolTip(this.textBoxFlagName, "This Textbox will display name of country associated with flag.");
            // 
            // radiobuttonPakistan
            // 
            this.radiobuttonPakistan.AutoSize = true;
            this.radiobuttonPakistan.Checked = true;
            this.radiobuttonPakistan.Location = new System.Drawing.Point(49, 34);
            this.radiobuttonPakistan.Name = "radiobuttonPakistan";
            this.radiobuttonPakistan.Size = new System.Drawing.Size(67, 15);
            this.radiobuttonPakistan.TabIndex = 5;
            this.radiobuttonPakistan.TabStop = true;
            this.radiobuttonPakistan.Text = "&Pakistan";
            this.radiobuttonPakistan.UseSelectable = true;
            this.radiobuttonPakistan.CheckedChanged += new System.EventHandler(this.radiobuttonPakistan_CheckedChanged);
            // 
            // radiobuttonTurkey
            // 
            this.radiobuttonTurkey.AutoSize = true;
            this.radiobuttonTurkey.Location = new System.Drawing.Point(49, 55);
            this.radiobuttonTurkey.Name = "radiobuttonTurkey";
            this.radiobuttonTurkey.Size = new System.Drawing.Size(59, 15);
            this.radiobuttonTurkey.TabIndex = 6;
            this.radiobuttonTurkey.Text = "&Turkey";
            this.radiobuttonTurkey.UseSelectable = true;
            this.radiobuttonTurkey.CheckedChanged += new System.EventHandler(this.radiobuttonTurkey_CheckedChanged);
            // 
            // radiobuttonIran
            // 
            this.radiobuttonIran.AutoSize = true;
            this.radiobuttonIran.Location = new System.Drawing.Point(49, 76);
            this.radiobuttonIran.Name = "radiobuttonIran";
            this.radiobuttonIran.Size = new System.Drawing.Size(43, 15);
            this.radiobuttonIran.TabIndex = 7;
            this.radiobuttonIran.Text = "&Iran";
            this.radiobuttonIran.UseSelectable = true;
            this.radiobuttonIran.CheckedChanged += new System.EventHandler(this.radiobuttonIran_CheckedChanged);
            // 
            // radiobuttonAfgan
            // 
            this.radiobuttonAfgan.AutoSize = true;
            this.radiobuttonAfgan.Location = new System.Drawing.Point(49, 97);
            this.radiobuttonAfgan.Name = "radiobuttonAfgan";
            this.radiobuttonAfgan.Size = new System.Drawing.Size(87, 15);
            this.radiobuttonAfgan.TabIndex = 8;
            this.radiobuttonAfgan.Text = "&Afghanistan";
            this.radiobuttonAfgan.UseSelectable = true;
            this.radiobuttonAfgan.CheckedChanged += new System.EventHandler(this.radiobuttonAfgan_CheckedChanged);
            // 
            // groupBoxCountriesFlags
            // 
            this.groupBoxCountriesFlags.Controls.Add(this.radiobuttonPakistan);
            this.groupBoxCountriesFlags.Controls.Add(this.radiobuttonAfgan);
            this.groupBoxCountriesFlags.Controls.Add(this.radiobuttonTurkey);
            this.groupBoxCountriesFlags.Controls.Add(this.radiobuttonIran);
            this.groupBoxCountriesFlags.Location = new System.Drawing.Point(195, 327);
            this.groupBoxCountriesFlags.Name = "groupBoxCountriesFlags";
            this.groupBoxCountriesFlags.Size = new System.Drawing.Size(178, 147);
            this.groupBoxCountriesFlags.TabIndex = 9;
            this.groupBoxCountriesFlags.TabStop = false;
            this.groupBoxCountriesFlags.Text = "  Country  ";
            this.metroToolTip1.SetToolTip(this.groupBoxCountriesFlags, "Select a country for displaying an image.");
            // 
            // groupBoxDisplayHide
            // 
            this.groupBoxDisplayHide.Controls.Add(this.checkboxProgrammerName);
            this.groupBoxDisplayHide.Controls.Add(this.checkboxCountryName);
            this.groupBoxDisplayHide.Controls.Add(this.checkboxFormTitle);
            this.groupBoxDisplayHide.Location = new System.Drawing.Point(414, 327);
            this.groupBoxDisplayHide.Name = "groupBoxDisplayHide";
            this.groupBoxDisplayHide.Size = new System.Drawing.Size(178, 147);
            this.groupBoxDisplayHide.TabIndex = 10;
            this.groupBoxDisplayHide.TabStop = false;
            this.groupBoxDisplayHide.Text = "Display / Hide";
            this.metroToolTip1.SetToolTip(this.groupBoxDisplayHide, "Check or Uncheck, if you want to hide or display related information");
            // 
            // checkboxProgrammerName
            // 
            this.checkboxProgrammerName.AutoSize = true;
            this.checkboxProgrammerName.Checked = true;
            this.checkboxProgrammerName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkboxProgrammerName.Location = new System.Drawing.Point(34, 83);
            this.checkboxProgrammerName.Name = "checkboxProgrammerName";
            this.checkboxProgrammerName.Size = new System.Drawing.Size(125, 15);
            this.checkboxProgrammerName.TabIndex = 12;
            this.checkboxProgrammerName.Text = "&Programmer Name";
            this.checkboxProgrammerName.UseSelectable = true;
            this.checkboxProgrammerName.CheckedChanged += new System.EventHandler(this.checkboxProgrammerName_CheckedChanged);
            // 
            // checkboxCountryName
            // 
            this.checkboxCountryName.AutoSize = true;
            this.checkboxCountryName.Checked = true;
            this.checkboxCountryName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkboxCountryName.Location = new System.Drawing.Point(34, 62);
            this.checkboxCountryName.Name = "checkboxCountryName";
            this.checkboxCountryName.Size = new System.Drawing.Size(101, 15);
            this.checkboxCountryName.TabIndex = 11;
            this.checkboxCountryName.Text = "&Country Name";
            this.checkboxCountryName.UseSelectable = true;
            this.checkboxCountryName.CheckedChanged += new System.EventHandler(this.checkboxCountryName_CheckedChanged);
            // 
            // checkboxFormTitle
            // 
            this.checkboxFormTitle.AutoSize = true;
            this.checkboxFormTitle.Checked = true;
            this.checkboxFormTitle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkboxFormTitle.Location = new System.Drawing.Point(34, 41);
            this.checkboxFormTitle.Name = "checkboxFormTitle";
            this.checkboxFormTitle.Size = new System.Drawing.Size(85, 15);
            this.checkboxFormTitle.TabIndex = 0;
            this.checkboxFormTitle.Text = "&Form\'s Title";
            this.checkboxFormTitle.UseSelectable = true;
            this.checkboxFormTitle.CheckedChanged += new System.EventHandler(this.checkboxFormTitle_CheckedChanged);
            // 
            // labelformtitle
            // 
            this.labelformtitle.AutoSize = true;
            this.labelformtitle.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelformtitle.Location = new System.Drawing.Point(190, 56);
            this.labelformtitle.Name = "labelformtitle";
            this.labelformtitle.Size = new System.Drawing.Size(406, 32);
            this.labelformtitle.TabIndex = 12;
            this.labelformtitle.Text = "Flag of four different Countries";
            this.metroToolTip1.SetToolTip(this.labelformtitle, "Title of the project");
            // 
            // labelProgrammerName
            // 
            this.labelProgrammerName.AutoSize = true;
            this.labelProgrammerName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProgrammerName.Location = new System.Drawing.Point(513, 582);
            this.labelProgrammerName.Name = "labelProgrammerName";
            this.labelProgrammerName.Size = new System.Drawing.Size(250, 16);
            this.labelProgrammerName.TabIndex = 13;
            this.labelProgrammerName.Text = "Programmed by: Aamir Khan Jadoon";
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.AutoPopDelay = 5000;
            this.metroToolTip1.InitialDelay = 50;
            this.metroToolTip1.ReshowDelay = 10;
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BookExcerciseSolution.Properties.Resources.flag;
            this.pictureBox1.Location = new System.Drawing.Point(145, -46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // pictureboxFlag
            // 
            this.pictureboxFlag.AllowFocused = false;
            this.pictureboxFlag.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureboxFlag.BorderRadius = 75;
            this.pictureboxFlag.Image = ((System.Drawing.Image)(resources.GetObject("pictureboxFlag.Image")));
            this.pictureboxFlag.IsCircle = true;
            this.pictureboxFlag.Location = new System.Drawing.Point(318, 113);
            this.pictureboxFlag.Name = "pictureboxFlag";
            this.pictureboxFlag.Size = new System.Drawing.Size(151, 151);
            this.pictureboxFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureboxFlag.TabIndex = 0;
            this.pictureboxFlag.TabStop = false;
            this.metroToolTip1.SetToolTip(this.pictureboxFlag, "Picture of Country flag");
            this.pictureboxFlag.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            // 
            // CHO2Q2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.labelformtitle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelProgrammerName);
            this.Controls.Add(this.groupBoxDisplayHide);
            this.Controls.Add(this.groupBoxCountriesFlags);
            this.Controls.Add(this.textBoxFlagName);
            this.Controls.Add(this.pictureboxFlag);
            this.Name = "CHO2Q2";
            this.Size = new System.Drawing.Size(786, 638);
            this.Load += new System.EventHandler(this.CHO2Q2_Load);
            this.groupBoxCountriesFlags.ResumeLayout(false);
            this.groupBoxCountriesFlags.PerformLayout();
            this.groupBoxDisplayHide.ResumeLayout(false);
            this.groupBoxDisplayHide.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxFlag)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPictureBox pictureboxFlag;
        private System.Windows.Forms.TextBox textBoxFlagName;
        private MetroFramework.Controls.MetroRadioButton radiobuttonPakistan;
        private MetroFramework.Controls.MetroRadioButton radiobuttonTurkey;
        private MetroFramework.Controls.MetroRadioButton radiobuttonIran;
        private MetroFramework.Controls.MetroRadioButton radiobuttonAfgan;
        private System.Windows.Forms.GroupBox groupBoxCountriesFlags;
        private System.Windows.Forms.GroupBox groupBoxDisplayHide;
        private MetroFramework.Controls.MetroCheckBox checkboxProgrammerName;
        private MetroFramework.Controls.MetroCheckBox checkboxCountryName;
        private MetroFramework.Controls.MetroCheckBox checkboxFormTitle;
        private System.Windows.Forms.Label labelformtitle;
        private System.Windows.Forms.Label labelProgrammerName;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
