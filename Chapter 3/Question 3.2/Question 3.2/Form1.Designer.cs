namespace Question_3._2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupTextbox = new System.Windows.Forms.TextBox();
            this.minuteTextbox = new System.Windows.Forms.TextBox();
            this.totalChargeForGroupTextbox = new System.Windows.Forms.TextBox();
            this.summaryGroupBox = new System.Windows.Forms.GroupBox();
            this.totalChargesForAllGroupTextbox = new System.Windows.Forms.TextBox();
            this.averageChargePerGroupTextbox = new System.Windows.Forms.TextBox();
            this.totalNumberOfGroupTextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.printButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.printForm1 = new Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(this.components);
            this.summaryGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Studio Rent Fee";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Group";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Minutes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total Charges for group";
            // 
            // groupTextbox
            // 
            this.groupTextbox.Location = new System.Drawing.Point(198, 96);
            this.groupTextbox.Name = "groupTextbox";
            this.groupTextbox.Size = new System.Drawing.Size(153, 20);
            this.groupTextbox.TabIndex = 4;
            // 
            // minuteTextbox
            // 
            this.minuteTextbox.Location = new System.Drawing.Point(198, 137);
            this.minuteTextbox.Name = "minuteTextbox";
            this.minuteTextbox.Size = new System.Drawing.Size(153, 20);
            this.minuteTextbox.TabIndex = 5;
            // 
            // totalChargeForGroupTextbox
            // 
            this.totalChargeForGroupTextbox.Location = new System.Drawing.Point(198, 178);
            this.totalChargeForGroupTextbox.Name = "totalChargeForGroupTextbox";
            this.totalChargeForGroupTextbox.ReadOnly = true;
            this.totalChargeForGroupTextbox.Size = new System.Drawing.Size(153, 20);
            this.totalChargeForGroupTextbox.TabIndex = 6;
            this.totalChargeForGroupTextbox.TabStop = false;
            this.totalChargeForGroupTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // summaryGroupBox
            // 
            this.summaryGroupBox.Controls.Add(this.totalChargesForAllGroupTextbox);
            this.summaryGroupBox.Controls.Add(this.averageChargePerGroupTextbox);
            this.summaryGroupBox.Controls.Add(this.totalNumberOfGroupTextbox);
            this.summaryGroupBox.Controls.Add(this.label5);
            this.summaryGroupBox.Controls.Add(this.label7);
            this.summaryGroupBox.Controls.Add(this.label6);
            this.summaryGroupBox.Location = new System.Drawing.Point(33, 241);
            this.summaryGroupBox.Name = "summaryGroupBox";
            this.summaryGroupBox.Size = new System.Drawing.Size(375, 147);
            this.summaryGroupBox.TabIndex = 7;
            this.summaryGroupBox.TabStop = false;
            this.summaryGroupBox.Text = "      Summary      ";
            // 
            // totalChargesForAllGroupTextbox
            // 
            this.totalChargesForAllGroupTextbox.Location = new System.Drawing.Point(196, 107);
            this.totalChargesForAllGroupTextbox.Name = "totalChargesForAllGroupTextbox";
            this.totalChargesForAllGroupTextbox.ReadOnly = true;
            this.totalChargesForAllGroupTextbox.Size = new System.Drawing.Size(122, 20);
            this.totalChargesForAllGroupTextbox.TabIndex = 12;
            this.totalChargesForAllGroupTextbox.TabStop = false;
            this.totalChargesForAllGroupTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // averageChargePerGroupTextbox
            // 
            this.averageChargePerGroupTextbox.Location = new System.Drawing.Point(196, 70);
            this.averageChargePerGroupTextbox.Name = "averageChargePerGroupTextbox";
            this.averageChargePerGroupTextbox.ReadOnly = true;
            this.averageChargePerGroupTextbox.Size = new System.Drawing.Size(122, 20);
            this.averageChargePerGroupTextbox.TabIndex = 11;
            this.averageChargePerGroupTextbox.TabStop = false;
            this.averageChargePerGroupTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // totalNumberOfGroupTextbox
            // 
            this.totalNumberOfGroupTextbox.Location = new System.Drawing.Point(196, 33);
            this.totalNumberOfGroupTextbox.Name = "totalNumberOfGroupTextbox";
            this.totalNumberOfGroupTextbox.ReadOnly = true;
            this.totalNumberOfGroupTextbox.Size = new System.Drawing.Size(122, 20);
            this.totalNumberOfGroupTextbox.TabIndex = 8;
            this.totalNumberOfGroupTextbox.TabStop = false;
            this.totalNumberOfGroupTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Total Charges for all group";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(58, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Average Charge per group";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(75, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Total Number of Group";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(43, 409);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 13;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(138, 409);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 14;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // printButton
            // 
            this.printButton.Location = new System.Drawing.Point(227, 409);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(75, 23);
            this.printButton.TabIndex = 15;
            this.printButton.Text = "Print";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(323, 409);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 16;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
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
            this.AcceptButton = this.calculateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(441, 455);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.summaryGroupBox);
            this.Controls.Add(this.totalChargeForGroupTextbox);
            this.Controls.Add(this.minuteTextbox);
            this.Controls.Add(this.groupTextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recording Studio";
            this.summaryGroupBox.ResumeLayout(false);
            this.summaryGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox groupTextbox;
        private System.Windows.Forms.TextBox minuteTextbox;
        private System.Windows.Forms.TextBox totalChargeForGroupTextbox;
        private System.Windows.Forms.GroupBox summaryGroupBox;
        private System.Windows.Forms.TextBox totalChargesForAllGroupTextbox;
        private System.Windows.Forms.TextBox averageChargePerGroupTextbox;
        private System.Windows.Forms.TextBox totalNumberOfGroupTextbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Button exitButton;
        private Microsoft.VisualBasic.PowerPacks.Printing.PrintForm printForm1;
    }
}

