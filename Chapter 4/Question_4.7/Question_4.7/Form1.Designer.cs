namespace Question_4._7
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBoxCountry = new System.Windows.Forms.PictureBox();
            this.labelFormTitle = new System.Windows.Forms.Label();
            this.labelCountryName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonDispaly = new System.Windows.Forms.Button();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.radioButtonPakistan = new System.Windows.Forms.RadioButton();
            this.radioButtonIran = new System.Windows.Forms.RadioButton();
            this.radioButtonTurkey = new System.Windows.Forms.RadioButton();
            this.radioButtonSpain = new System.Windows.Forms.RadioButton();
            this.checkBoxFormTitle = new System.Windows.Forms.CheckBox();
            this.checkBoxProgrammerName = new System.Windows.Forms.CheckBox();
            this.checkBoxCountryName = new System.Windows.Forms.CheckBox();
            this.labelprogrammer = new System.Windows.Forms.Label();
            this.printForm1 = new Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCountry)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxCountry
            // 
            this.pictureBoxCountry.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxCountry.Image = global::Question_4._7.Properties.Resources.iran;
            this.pictureBoxCountry.Location = new System.Drawing.Point(202, 78);
            this.pictureBoxCountry.Name = "pictureBoxCountry";
            this.pictureBoxCountry.Size = new System.Drawing.Size(214, 134);
            this.pictureBoxCountry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCountry.TabIndex = 0;
            this.pictureBoxCountry.TabStop = false;
            this.pictureBoxCountry.Visible = false;
            // 
            // labelFormTitle
            // 
            this.labelFormTitle.AutoSize = true;
            this.labelFormTitle.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFormTitle.Location = new System.Drawing.Point(131, 24);
            this.labelFormTitle.Name = "labelFormTitle";
            this.labelFormTitle.Size = new System.Drawing.Size(356, 28);
            this.labelFormTitle.TabIndex = 1;
            this.labelFormTitle.Text = "Flag of four different countries";
            // 
            // labelCountryName
            // 
            this.labelCountryName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCountryName.Location = new System.Drawing.Point(251, 223);
            this.labelCountryName.Name = "labelCountryName";
            this.labelCountryName.Size = new System.Drawing.Size(100, 23);
            this.labelCountryName.TabIndex = 2;
            this.labelCountryName.Text = "Country Name";
            this.labelCountryName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelCountryName.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonSpain);
            this.groupBox1.Controls.Add(this.radioButtonTurkey);
            this.groupBox1.Controls.Add(this.radioButtonIran);
            this.groupBox1.Controls.Add(this.radioButtonPakistan);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(136, 271);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(165, 139);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "     Country     ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxCountryName);
            this.groupBox2.Controls.Add(this.checkBoxProgrammerName);
            this.groupBox2.Controls.Add(this.checkBoxFormTitle);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(322, 271);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(165, 139);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "      Display/Hide      ";
            // 
            // buttonDispaly
            // 
            this.buttonDispaly.Location = new System.Drawing.Point(152, 435);
            this.buttonDispaly.Name = "buttonDispaly";
            this.buttonDispaly.Size = new System.Drawing.Size(75, 23);
            this.buttonDispaly.TabIndex = 5;
            this.buttonDispaly.Text = "Display";
            this.buttonDispaly.UseVisualStyleBackColor = true;
            this.buttonDispaly.Click += new System.EventHandler(this.buttonDispaly_Click);
            // 
            // buttonPrint
            // 
            this.buttonPrint.Location = new System.Drawing.Point(275, 435);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(75, 23);
            this.buttonPrint.TabIndex = 6;
            this.buttonPrint.Text = "Print";
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(398, 435);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 7;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // radioButtonPakistan
            // 
            this.radioButtonPakistan.AutoSize = true;
            this.radioButtonPakistan.Location = new System.Drawing.Point(49, 29);
            this.radioButtonPakistan.Name = "radioButtonPakistan";
            this.radioButtonPakistan.Size = new System.Drawing.Size(66, 17);
            this.radioButtonPakistan.TabIndex = 0;
            this.radioButtonPakistan.TabStop = true;
            this.radioButtonPakistan.Text = "Pakistan";
            this.radioButtonPakistan.UseVisualStyleBackColor = true;
            this.radioButtonPakistan.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // radioButtonIran
            // 
            this.radioButtonIran.AutoSize = true;
            this.radioButtonIran.Location = new System.Drawing.Point(49, 79);
            this.radioButtonIran.Name = "radioButtonIran";
            this.radioButtonIran.Size = new System.Drawing.Size(43, 17);
            this.radioButtonIran.TabIndex = 1;
            this.radioButtonIran.TabStop = true;
            this.radioButtonIran.Text = "Iran";
            this.radioButtonIran.UseVisualStyleBackColor = true;
            this.radioButtonIran.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // radioButtonTurkey
            // 
            this.radioButtonTurkey.AutoSize = true;
            this.radioButtonTurkey.Location = new System.Drawing.Point(49, 104);
            this.radioButtonTurkey.Name = "radioButtonTurkey";
            this.radioButtonTurkey.Size = new System.Drawing.Size(58, 17);
            this.radioButtonTurkey.TabIndex = 2;
            this.radioButtonTurkey.TabStop = true;
            this.radioButtonTurkey.Text = "Turkey";
            this.radioButtonTurkey.UseVisualStyleBackColor = true;
            this.radioButtonTurkey.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // radioButtonSpain
            // 
            this.radioButtonSpain.AutoSize = true;
            this.radioButtonSpain.Location = new System.Drawing.Point(49, 54);
            this.radioButtonSpain.Name = "radioButtonSpain";
            this.radioButtonSpain.Size = new System.Drawing.Size(52, 17);
            this.radioButtonSpain.TabIndex = 3;
            this.radioButtonSpain.TabStop = true;
            this.radioButtonSpain.Text = "Spain";
            this.radioButtonSpain.UseVisualStyleBackColor = true;
            this.radioButtonSpain.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // checkBoxFormTitle
            // 
            this.checkBoxFormTitle.AutoSize = true;
            this.checkBoxFormTitle.Checked = true;
            this.checkBoxFormTitle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxFormTitle.Location = new System.Drawing.Point(26, 30);
            this.checkBoxFormTitle.Name = "checkBoxFormTitle";
            this.checkBoxFormTitle.Size = new System.Drawing.Size(72, 17);
            this.checkBoxFormTitle.TabIndex = 4;
            this.checkBoxFormTitle.Text = "Form Title";
            this.checkBoxFormTitle.UseVisualStyleBackColor = true;
            this.checkBoxFormTitle.CheckedChanged += new System.EventHandler(this.CheckBox_Checked);
            // 
            // checkBoxProgrammerName
            // 
            this.checkBoxProgrammerName.AutoSize = true;
            this.checkBoxProgrammerName.Checked = true;
            this.checkBoxProgrammerName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxProgrammerName.Location = new System.Drawing.Point(26, 61);
            this.checkBoxProgrammerName.Name = "checkBoxProgrammerName";
            this.checkBoxProgrammerName.Size = new System.Drawing.Size(113, 17);
            this.checkBoxProgrammerName.TabIndex = 5;
            this.checkBoxProgrammerName.Text = "Programmer Name";
            this.checkBoxProgrammerName.UseVisualStyleBackColor = true;
            this.checkBoxProgrammerName.CheckedChanged += new System.EventHandler(this.CheckBox_Checked);
            // 
            // checkBoxCountryName
            // 
            this.checkBoxCountryName.AutoSize = true;
            this.checkBoxCountryName.Checked = true;
            this.checkBoxCountryName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCountryName.Location = new System.Drawing.Point(26, 92);
            this.checkBoxCountryName.Name = "checkBoxCountryName";
            this.checkBoxCountryName.Size = new System.Drawing.Size(93, 17);
            this.checkBoxCountryName.TabIndex = 6;
            this.checkBoxCountryName.Text = "Country Name";
            this.checkBoxCountryName.UseVisualStyleBackColor = true;
            this.checkBoxCountryName.CheckedChanged += new System.EventHandler(this.CheckBox_Checked);
            // 
            // labelprogrammer
            // 
            this.labelprogrammer.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelprogrammer.Location = new System.Drawing.Point(348, 475);
            this.labelprogrammer.Name = "labelprogrammer";
            this.labelprogrammer.Size = new System.Drawing.Size(264, 23);
            this.labelprogrammer.TabIndex = 8;
            this.labelprogrammer.Text = "Programmed by: Aamir Khan Jadoon";
            this.labelprogrammer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // printForm1
            // 
            this.printForm1.DocumentName = "document";
            this.printForm1.Form = this;
            this.printForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter;
            this.printForm1.PrinterSettings = ((System.Drawing.Printing.PrinterSettings)(resources.GetObject("printForm1.PrinterSettings")));
            this.printForm1.PrintFileName = null;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(618, 504);
            this.Controls.Add(this.labelprogrammer);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.buttonDispaly);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelCountryName);
            this.Controls.Add(this.labelFormTitle);
            this.Controls.Add(this.pictureBoxCountry);
            this.Name = "Form1";
            this.Text = "Flag";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCountry)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxCountry;
        private System.Windows.Forms.Label labelFormTitle;
        private System.Windows.Forms.Label labelCountryName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonDispaly;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.RadioButton radioButtonSpain;
        private System.Windows.Forms.RadioButton radioButtonTurkey;
        private System.Windows.Forms.RadioButton radioButtonIran;
        private System.Windows.Forms.RadioButton radioButtonPakistan;
        private System.Windows.Forms.CheckBox checkBoxCountryName;
        private System.Windows.Forms.CheckBox checkBoxProgrammerName;
        private System.Windows.Forms.CheckBox checkBoxFormTitle;
        private System.Windows.Forms.Label labelprogrammer;
        private Microsoft.VisualBasic.PowerPacks.Printing.PrintForm printForm1;
    }
}

