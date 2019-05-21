namespace BookExcerciseSolution
{
    partial class Chapter2HOP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chapter2HOP));
            this.groupBoxDepartment = new System.Windows.Forms.GroupBox();
            this.radioButtonPersonalTraining = new MetroFramework.Controls.MetroRadioButton();
            this.radioButtonMembership = new MetroFramework.Controls.MetroRadioButton();
            this.radioButtonJuiceBar = new MetroFramework.Controls.MetroRadioButton();
            this.radioButtonEquipment = new MetroFramework.Controls.MetroRadioButton();
            this.radioButtonClothing = new MetroFramework.Controls.MetroRadioButton();
            this.label1Chapter2HOP = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.labelMemberName = new System.Windows.Forms.Label();
            this.labelMemberID = new System.Windows.Forms.Label();
            this.textboxName = new MetroFramework.Controls.MetroTextBox();
            this.textBoxMemberID = new System.Windows.Forms.MaskedTextBox();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.checkBoxImageVisible = new MetroFramework.Controls.MetroCheckBox();
            this.richTextBoxWelcome = new System.Windows.Forms.RichTextBox();
            this.textBoxPromotions = new MetroFramework.Controls.MetroTextBox();
            this.buttonExit = new MetroFramework.Controls.MetroButton();
            this.buttonPrint = new MetroFramework.Controls.MetroButton();
            this.buttonSignIn = new MetroFramework.Controls.MetroButton();
            this.printForm1 = new Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(this.components);
            this.pictureBoxDepartment = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.groupBoxDepartment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDepartment)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxDepartment
            // 
            this.groupBoxDepartment.Controls.Add(this.radioButtonPersonalTraining);
            this.groupBoxDepartment.Controls.Add(this.radioButtonMembership);
            this.groupBoxDepartment.Controls.Add(this.radioButtonJuiceBar);
            this.groupBoxDepartment.Controls.Add(this.radioButtonEquipment);
            this.groupBoxDepartment.Controls.Add(this.radioButtonClothing);
            this.groupBoxDepartment.Enabled = false;
            this.groupBoxDepartment.Location = new System.Drawing.Point(12, 84);
            this.groupBoxDepartment.Name = "groupBoxDepartment";
            this.groupBoxDepartment.Size = new System.Drawing.Size(182, 174);
            this.groupBoxDepartment.TabIndex = 0;
            this.groupBoxDepartment.TabStop = false;
            this.groupBoxDepartment.Text = "&Department";
            // 
            // radioButtonPersonalTraining
            // 
            this.radioButtonPersonalTraining.AutoSize = true;
            this.radioButtonPersonalTraining.Location = new System.Drawing.Point(6, 136);
            this.radioButtonPersonalTraining.Name = "radioButtonPersonalTraining";
            this.radioButtonPersonalTraining.Size = new System.Drawing.Size(114, 15);
            this.radioButtonPersonalTraining.TabIndex = 4;
            this.radioButtonPersonalTraining.Text = "Personal &Training";
            this.radioButtonPersonalTraining.UseSelectable = true;
            this.radioButtonPersonalTraining.CheckedChanged += new System.EventHandler(this.radioButtonPersonalTraining_CheckedChanged);
            // 
            // radioButtonMembership
            // 
            this.radioButtonMembership.AutoSize = true;
            this.radioButtonMembership.Location = new System.Drawing.Point(6, 108);
            this.radioButtonMembership.Name = "radioButtonMembership";
            this.radioButtonMembership.Size = new System.Drawing.Size(90, 15);
            this.radioButtonMembership.TabIndex = 3;
            this.radioButtonMembership.Text = "&Membership";
            this.radioButtonMembership.UseSelectable = true;
            this.radioButtonMembership.CheckedChanged += new System.EventHandler(this.radioButtonMembership_CheckedChanged);
            // 
            // radioButtonJuiceBar
            // 
            this.radioButtonJuiceBar.AutoSize = true;
            this.radioButtonJuiceBar.Location = new System.Drawing.Point(6, 80);
            this.radioButtonJuiceBar.Name = "radioButtonJuiceBar";
            this.radioButtonJuiceBar.Size = new System.Drawing.Size(69, 15);
            this.radioButtonJuiceBar.TabIndex = 2;
            this.radioButtonJuiceBar.Text = "&Juice Bar";
            this.radioButtonJuiceBar.UseSelectable = true;
            this.radioButtonJuiceBar.CheckedChanged += new System.EventHandler(this.radioButtonJuiceBar_CheckedChanged);
            // 
            // radioButtonEquipment
            // 
            this.radioButtonEquipment.AutoSize = true;
            this.radioButtonEquipment.Location = new System.Drawing.Point(6, 52);
            this.radioButtonEquipment.Name = "radioButtonEquipment";
            this.radioButtonEquipment.Size = new System.Drawing.Size(153, 15);
            this.radioButtonEquipment.TabIndex = 1;
            this.radioButtonEquipment.Text = "&Equipment / Accessories";
            this.radioButtonEquipment.UseSelectable = true;
            this.radioButtonEquipment.CheckedChanged += new System.EventHandler(this.radioButtonEquipment_CheckedChanged);
            // 
            // radioButtonClothing
            // 
            this.radioButtonClothing.AutoSize = true;
            this.radioButtonClothing.Location = new System.Drawing.Point(6, 24);
            this.radioButtonClothing.Name = "radioButtonClothing";
            this.radioButtonClothing.Size = new System.Drawing.Size(69, 15);
            this.radioButtonClothing.TabIndex = 0;
            this.radioButtonClothing.Text = "&Clothing";
            this.radioButtonClothing.UseSelectable = true;
            this.radioButtonClothing.CheckedChanged += new System.EventHandler(this.radioButtonClothing_CheckedChanged);
            // 
            // label1Chapter2HOP
            // 
            this.label1Chapter2HOP.AutoSize = true;
            this.label1Chapter2HOP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1Chapter2HOP.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1Chapter2HOP.Location = new System.Drawing.Point(137, 12);
            this.label1Chapter2HOP.Name = "label1Chapter2HOP";
            this.label1Chapter2HOP.Size = new System.Drawing.Size(232, 24);
            this.label1Chapter2HOP.TabIndex = 3;
            this.label1Chapter2HOP.Text = "Look Sharp Fitness Center";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(504, 489);
            this.shapeContainer1.TabIndex = 5;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.lineShape1.BorderWidth = 5;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 1;
            this.lineShape1.X2 = 534;
            this.lineShape1.Y1 = 50;
            this.lineShape1.Y2 = 50;
            // 
            // labelMemberName
            // 
            this.labelMemberName.AutoSize = true;
            this.labelMemberName.Location = new System.Drawing.Point(282, 157);
            this.labelMemberName.Name = "labelMemberName";
            this.labelMemberName.Size = new System.Drawing.Size(35, 13);
            this.labelMemberName.TabIndex = 6;
            this.labelMemberName.Text = "&Name";
            // 
            // labelMemberID
            // 
            this.labelMemberID.AutoSize = true;
            this.labelMemberID.Location = new System.Drawing.Point(267, 186);
            this.labelMemberID.Name = "labelMemberID";
            this.labelMemberID.Size = new System.Drawing.Size(59, 13);
            this.labelMemberID.TabIndex = 7;
            this.labelMemberID.Text = "Member &ID";
            // 
            // textboxName
            // 
            // 
            // 
            // 
            this.textboxName.CustomButton.Image = null;
            this.textboxName.CustomButton.Location = new System.Drawing.Point(124, 1);
            this.textboxName.CustomButton.Name = "";
            this.textboxName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textboxName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textboxName.CustomButton.TabIndex = 1;
            this.textboxName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textboxName.CustomButton.UseSelectable = true;
            this.textboxName.CustomButton.Visible = false;
            this.textboxName.Lines = new string[0];
            this.textboxName.Location = new System.Drawing.Point(340, 157);
            this.textboxName.MaxLength = 32767;
            this.textboxName.Name = "textboxName";
            this.textboxName.PasswordChar = '\0';
#pragma warning disable CS0618 // Type or member is obsolete
            this.textboxName.PromptText = "Name";
#pragma warning restore CS0618 // Type or member is obsolete
            this.textboxName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textboxName.SelectedText = "";
            this.textboxName.SelectionLength = 0;
            this.textboxName.SelectionStart = 0;
            this.textboxName.ShortcutsEnabled = true;
            this.textboxName.Size = new System.Drawing.Size(146, 23);
            this.textboxName.TabIndex = 8;
            this.textboxName.UseSelectable = true;
            this.textboxName.WaterMark = "Name";
            this.textboxName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textboxName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // textBoxMemberID
            // 
            this.textBoxMemberID.Location = new System.Drawing.Point(340, 186);
            this.textBoxMemberID.Mask = "00000";
            this.textBoxMemberID.Name = "textBoxMemberID";
            this.textBoxMemberID.Size = new System.Drawing.Size(146, 20);
            this.textBoxMemberID.TabIndex = 9;
            this.metroToolTip1.SetToolTip(this.textBoxMemberID, "Your 5 digit Member number.");
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.AutoPopDelay = 5000;
            this.metroToolTip1.InitialDelay = 50000;
            this.metroToolTip1.ReshowDelay = 100;
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // checkBoxImageVisible
            // 
            this.checkBoxImageVisible.AutoSize = true;
            this.checkBoxImageVisible.Location = new System.Drawing.Point(7, 467);
            this.checkBoxImageVisible.Name = "checkBoxImageVisible";
            this.checkBoxImageVisible.Size = new System.Drawing.Size(93, 15);
            this.checkBoxImageVisible.TabIndex = 10;
            this.checkBoxImageVisible.Text = "Image &Visible";
            this.checkBoxImageVisible.UseSelectable = true;
            this.checkBoxImageVisible.Visible = false;
            this.checkBoxImageVisible.CheckedChanged += new System.EventHandler(this.checkBoxImageVisible_CheckedChanged);
            // 
            // richTextBoxWelcome
            // 
            this.richTextBoxWelcome.Location = new System.Drawing.Point(270, 231);
            this.richTextBoxWelcome.Name = "richTextBoxWelcome";
            this.richTextBoxWelcome.Size = new System.Drawing.Size(216, 96);
            this.richTextBoxWelcome.TabIndex = 11;
            this.richTextBoxWelcome.Text = "";
            this.richTextBoxWelcome.Visible = false;
            // 
            // textBoxPromotions
            // 
            // 
            // 
            // 
            this.textBoxPromotions.CustomButton.Image = null;
            this.textBoxPromotions.CustomButton.Location = new System.Drawing.Point(194, 1);
            this.textBoxPromotions.CustomButton.Name = "";
            this.textBoxPromotions.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBoxPromotions.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxPromotions.CustomButton.TabIndex = 1;
            this.textBoxPromotions.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxPromotions.CustomButton.UseSelectable = true;
            this.textBoxPromotions.CustomButton.Visible = false;
            this.textBoxPromotions.Lines = new string[0];
            this.textBoxPromotions.Location = new System.Drawing.Point(270, 345);
            this.textBoxPromotions.MaxLength = 32767;
            this.textBoxPromotions.Multiline = true;
            this.textBoxPromotions.Name = "textBoxPromotions";
            this.textBoxPromotions.PasswordChar = '\0';
#pragma warning disable CS0618 // Type or member is obsolete
            this.textBoxPromotions.PromptText = "Promotion of the Day";
#pragma warning restore CS0618 // Type or member is obsolete
            this.textBoxPromotions.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxPromotions.SelectedText = "";
            this.textBoxPromotions.SelectionLength = 0;
            this.textBoxPromotions.SelectionStart = 0;
            this.textBoxPromotions.ShortcutsEnabled = true;
            this.textBoxPromotions.Size = new System.Drawing.Size(216, 23);
            this.textBoxPromotions.TabIndex = 12;
            this.textBoxPromotions.TabStop = false;
            this.textBoxPromotions.UseSelectable = true;
            this.textBoxPromotions.Visible = false;
            this.textBoxPromotions.WaterMark = "Promotion of the Day";
            this.textBoxPromotions.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxPromotions.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.buttonExit.ForeColor = System.Drawing.Color.White;
            this.buttonExit.Location = new System.Drawing.Point(375, 452);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(111, 23);
            this.buttonExit.TabIndex = 13;
            this.buttonExit.Text = "E&xit";
            this.buttonExit.UseCustomBackColor = true;
            this.buttonExit.UseCustomForeColor = true;
            this.buttonExit.UseSelectable = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonPrint
            // 
            this.buttonPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.buttonPrint.ForeColor = System.Drawing.Color.White;
            this.buttonPrint.Location = new System.Drawing.Point(375, 423);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(111, 23);
            this.buttonPrint.TabIndex = 14;
            this.buttonPrint.Text = "&Print";
            this.buttonPrint.UseCustomBackColor = true;
            this.buttonPrint.UseCustomForeColor = true;
            this.buttonPrint.UseSelectable = true;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // buttonSignIn
            // 
            this.buttonSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.buttonSignIn.ForeColor = System.Drawing.Color.White;
            this.buttonSignIn.Location = new System.Drawing.Point(375, 394);
            this.buttonSignIn.Name = "buttonSignIn";
            this.buttonSignIn.Size = new System.Drawing.Size(111, 23);
            this.buttonSignIn.TabIndex = 15;
            this.buttonSignIn.Text = "&Sign In";
            this.buttonSignIn.UseCustomBackColor = true;
            this.buttonSignIn.UseCustomForeColor = true;
            this.buttonSignIn.UseSelectable = true;
            this.buttonSignIn.Click += new System.EventHandler(this.buttonSignIn_Click);
            // 
            // printForm1
            // 
            this.printForm1.DocumentName = "document";
            this.printForm1.Form = this;
            this.printForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter;
            this.printForm1.PrinterSettings = ((System.Drawing.Printing.PrinterSettings)(resources.GetObject("printForm1.PrinterSettings")));
            this.printForm1.PrintFileName = null;
            // 
            // pictureBoxDepartment
            // 
            this.pictureBoxDepartment.AllowFocused = false;
            this.pictureBoxDepartment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxDepartment.BorderRadius = 68;
            this.pictureBoxDepartment.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDepartment.Image")));
            this.pictureBoxDepartment.IsCircle = true;
            this.pictureBoxDepartment.Location = new System.Drawing.Point(37, 280);
            this.pictureBoxDepartment.Name = "pictureBoxDepartment";
            this.pictureBoxDepartment.Size = new System.Drawing.Size(137, 137);
            this.pictureBoxDepartment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDepartment.TabIndex = 1;
            this.pictureBoxDepartment.TabStop = false;
            this.pictureBoxDepartment.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            this.pictureBoxDepartment.Visible = false;
            // 
            // Chapter2HOP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(504, 489);
            this.Controls.Add(this.buttonSignIn);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.textBoxPromotions);
            this.Controls.Add(this.richTextBoxWelcome);
            this.Controls.Add(this.checkBoxImageVisible);
            this.Controls.Add(this.textBoxMemberID);
            this.Controls.Add(this.textboxName);
            this.Controls.Add(this.labelMemberID);
            this.Controls.Add(this.labelMemberName);
            this.Controls.Add(this.label1Chapter2HOP);
            this.Controls.Add(this.pictureBoxDepartment);
            this.Controls.Add(this.groupBoxDepartment);
            this.Controls.Add(this.shapeContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Chapter2HOP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.groupBoxDepartment.ResumeLayout(false);
            this.groupBoxDepartment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDepartment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDepartment;
        private Bunifu.UI.WinForms.BunifuPictureBox pictureBoxDepartment;
        private System.Windows.Forms.Label label1Chapter2HOP;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Label labelMemberName;
        private System.Windows.Forms.Label labelMemberID;
        private MetroFramework.Controls.MetroTextBox textboxName;
        private System.Windows.Forms.MaskedTextBox textBoxMemberID;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private MetroFramework.Controls.MetroRadioButton radioButtonClothing;
        private MetroFramework.Controls.MetroRadioButton radioButtonPersonalTraining;
        private MetroFramework.Controls.MetroRadioButton radioButtonMembership;
        private MetroFramework.Controls.MetroRadioButton radioButtonJuiceBar;
        private MetroFramework.Controls.MetroRadioButton radioButtonEquipment;
        private MetroFramework.Controls.MetroCheckBox checkBoxImageVisible;
        private System.Windows.Forms.RichTextBox richTextBoxWelcome;
        private MetroFramework.Controls.MetroTextBox textBoxPromotions;
        private MetroFramework.Controls.MetroButton buttonExit;
        private MetroFramework.Controls.MetroButton buttonPrint;
        private MetroFramework.Controls.MetroButton buttonSignIn;
        private Microsoft.VisualBasic.PowerPacks.Printing.PrintForm printForm1;
    }
}