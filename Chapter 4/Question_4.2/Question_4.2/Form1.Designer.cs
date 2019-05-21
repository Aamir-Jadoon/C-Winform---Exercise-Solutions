namespace Question_4._2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonPermanentMakeup = new System.Windows.Forms.RadioButton();
            this.radioButtonManicure = new System.Windows.Forms.RadioButton();
            this.radioButtonHairStyling = new System.Windows.Forms.RadioButton();
            this.radioButtonMakeOver = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonNoneDiscount = new System.Windows.Forms.RadioButton();
            this.radioButton20PercentDiscount = new System.Windows.Forms.RadioButton();
            this.radioButton10PercentDiscount = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCurrentDue = new System.Windows.Forms.TextBox();
            this.textBoxTotalDue = new System.Windows.Forms.TextBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.printForm1 = new Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(this.components);
            this.buttonSummary = new System.Windows.Forms.Button();
            this.buttonNextPatron = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonPermanentMakeup);
            this.groupBox1.Controls.Add(this.radioButtonManicure);
            this.groupBox1.Controls.Add(this.radioButtonHairStyling);
            this.groupBox1.Controls.Add(this.radioButtonMakeOver);
            this.groupBox1.Location = new System.Drawing.Point(54, 165);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 205);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "   Services   ";
            // 
            // radioButtonPermanentMakeup
            // 
            this.radioButtonPermanentMakeup.AutoSize = true;
            this.radioButtonPermanentMakeup.Location = new System.Drawing.Point(26, 171);
            this.radioButtonPermanentMakeup.Name = "radioButtonPermanentMakeup";
            this.radioButtonPermanentMakeup.Size = new System.Drawing.Size(148, 17);
            this.radioButtonPermanentMakeup.TabIndex = 7;
            this.radioButtonPermanentMakeup.Text = "Permanent Makeup  $200";
            this.radioButtonPermanentMakeup.UseVisualStyleBackColor = true;
            // 
            // radioButtonManicure
            // 
            this.radioButtonManicure.AutoSize = true;
            this.radioButtonManicure.Location = new System.Drawing.Point(26, 129);
            this.radioButtonManicure.Name = "radioButtonManicure";
            this.radioButtonManicure.Size = new System.Drawing.Size(93, 17);
            this.radioButtonManicure.TabIndex = 6;
            this.radioButtonManicure.Text = "Manicure  $35";
            this.radioButtonManicure.UseVisualStyleBackColor = true;
            // 
            // radioButtonHairStyling
            // 
            this.radioButtonHairStyling.AutoSize = true;
            this.radioButtonHairStyling.Location = new System.Drawing.Point(26, 87);
            this.radioButtonHairStyling.Name = "radioButtonHairStyling";
            this.radioButtonHairStyling.Size = new System.Drawing.Size(102, 17);
            this.radioButtonHairStyling.TabIndex = 5;
            this.radioButtonHairStyling.Text = "Hair Styling  $60";
            this.radioButtonHairStyling.UseVisualStyleBackColor = true;
            // 
            // radioButtonMakeOver
            // 
            this.radioButtonMakeOver.AutoSize = true;
            this.radioButtonMakeOver.Location = new System.Drawing.Point(26, 45);
            this.radioButtonMakeOver.Name = "radioButtonMakeOver";
            this.radioButtonMakeOver.Size = new System.Drawing.Size(108, 17);
            this.radioButtonMakeOver.TabIndex = 4;
            this.radioButtonMakeOver.Text = "Make Over  $125";
            this.radioButtonMakeOver.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonNoneDiscount);
            this.groupBox2.Controls.Add(this.radioButton20PercentDiscount);
            this.groupBox2.Controls.Add(this.radioButton10PercentDiscount);
            this.groupBox2.Location = new System.Drawing.Point(90, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(129, 115);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "   Discount   ";
            // 
            // radioButtonNoneDiscount
            // 
            this.radioButtonNoneDiscount.AutoSize = true;
            this.radioButtonNoneDiscount.Checked = true;
            this.radioButtonNoneDiscount.Location = new System.Drawing.Point(44, 83);
            this.radioButtonNoneDiscount.Name = "radioButtonNoneDiscount";
            this.radioButtonNoneDiscount.Size = new System.Drawing.Size(51, 17);
            this.radioButtonNoneDiscount.TabIndex = 5;
            this.radioButtonNoneDiscount.TabStop = true;
            this.radioButtonNoneDiscount.Text = "None";
            this.radioButtonNoneDiscount.UseVisualStyleBackColor = true;
            // 
            // radioButton20PercentDiscount
            // 
            this.radioButton20PercentDiscount.AutoSize = true;
            this.radioButton20PercentDiscount.Location = new System.Drawing.Point(44, 55);
            this.radioButton20PercentDiscount.Name = "radioButton20PercentDiscount";
            this.radioButton20PercentDiscount.Size = new System.Drawing.Size(48, 17);
            this.radioButton20PercentDiscount.TabIndex = 4;
            this.radioButton20PercentDiscount.Text = "20 %";
            this.radioButton20PercentDiscount.UseVisualStyleBackColor = true;
            // 
            // radioButton10PercentDiscount
            // 
            this.radioButton10PercentDiscount.AutoSize = true;
            this.radioButton10PercentDiscount.Location = new System.Drawing.Point(44, 27);
            this.radioButton10PercentDiscount.Name = "radioButton10PercentDiscount";
            this.radioButton10PercentDiscount.Size = new System.Drawing.Size(48, 17);
            this.radioButton10PercentDiscount.TabIndex = 3;
            this.radioButton10PercentDiscount.Text = "10 %";
            this.radioButton10PercentDiscount.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 401);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Currently due";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 438);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Total due";
            // 
            // textBoxCurrentDue
            // 
            this.textBoxCurrentDue.Enabled = false;
            this.textBoxCurrentDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCurrentDue.Location = new System.Drawing.Point(257, 397);
            this.textBoxCurrentDue.Name = "textBoxCurrentDue";
            this.textBoxCurrentDue.ReadOnly = true;
            this.textBoxCurrentDue.Size = new System.Drawing.Size(153, 20);
            this.textBoxCurrentDue.TabIndex = 4;
            this.textBoxCurrentDue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTotalDue
            // 
            this.textBoxTotalDue.Enabled = false;
            this.textBoxTotalDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotalDue.Location = new System.Drawing.Point(257, 434);
            this.textBoxTotalDue.Name = "textBoxTotalDue";
            this.textBoxTotalDue.ReadOnly = true;
            this.textBoxTotalDue.Size = new System.Drawing.Size(153, 20);
            this.textBoxTotalDue.TabIndex = 5;
            this.textBoxTotalDue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(40, 407);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(75, 23);
            this.buttonCalculate.TabIndex = 6;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(128, 498);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 7;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonPrint
            // 
            this.buttonPrint.Location = new System.Drawing.Point(216, 498);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(75, 23);
            this.buttonPrint.TabIndex = 8;
            this.buttonPrint.Text = "Print";
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(304, 498);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 9;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // printForm1
            // 
            this.printForm1.DocumentName = "document";
            this.printForm1.Form = this;
            this.printForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter;
            this.printForm1.PrinterSettings = ((System.Drawing.Printing.PrinterSettings)(resources.GetObject("printForm1.PrinterSettings")));
            this.printForm1.PrintFileName = null;
            // 
            // buttonSummary
            // 
            this.buttonSummary.Enabled = false;
            this.buttonSummary.Location = new System.Drawing.Point(40, 498);
            this.buttonSummary.Name = "buttonSummary";
            this.buttonSummary.Size = new System.Drawing.Size(75, 23);
            this.buttonSummary.TabIndex = 11;
            this.buttonSummary.Text = "Summary";
            this.buttonSummary.UseVisualStyleBackColor = true;
            this.buttonSummary.Click += new System.EventHandler(this.buttonSummary_Click);
            // 
            // buttonNextPatron
            // 
            this.buttonNextPatron.Enabled = false;
            this.buttonNextPatron.Location = new System.Drawing.Point(40, 452);
            this.buttonNextPatron.Name = "buttonNextPatron";
            this.buttonNextPatron.Size = new System.Drawing.Size(75, 23);
            this.buttonNextPatron.TabIndex = 12;
            this.buttonNextPatron.Text = "Next Patron";
            this.buttonNextPatron.UseVisualStyleBackColor = true;
            this.buttonNextPatron.Click += new System.EventHandler(this.buttonNextPatron_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(419, 538);
            this.Controls.Add(this.buttonNextPatron);
            this.Controls.Add(this.buttonSummary);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.textBoxTotalDue);
            this.Controls.Add(this.textBoxCurrentDue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Consulting Shop";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonPermanentMakeup;
        private System.Windows.Forms.RadioButton radioButtonManicure;
        private System.Windows.Forms.RadioButton radioButtonHairStyling;
        private System.Windows.Forms.RadioButton radioButtonMakeOver;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonNoneDiscount;
        private System.Windows.Forms.RadioButton radioButton20PercentDiscount;
        private System.Windows.Forms.RadioButton radioButton10PercentDiscount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCurrentDue;
        private System.Windows.Forms.TextBox textBoxTotalDue;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.Button buttonExit;
        private Microsoft.VisualBasic.PowerPacks.Printing.PrintForm printForm1;
        private System.Windows.Forms.Button buttonNextPatron;
        private System.Windows.Forms.Button buttonSummary;
    }
}

