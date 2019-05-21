namespace Question_4._8
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNumberOfGuest = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButtonPrimeRib = new System.Windows.Forms.RadioButton();
            this.radioButtonChicken = new System.Windows.Forms.RadioButton();
            this.radioButtonPasta = new System.Windows.Forms.RadioButton();
            this.checkBoxOpenBar = new System.Windows.Forms.CheckBox();
            this.checkBoxWineWithDinner = new System.Windows.Forms.CheckBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonSummary = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAmountDue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of guests";
            // 
            // textBoxNumberOfGuest
            // 
            this.textBoxNumberOfGuest.Location = new System.Drawing.Point(275, 111);
            this.textBoxNumberOfGuest.Name = "textBoxNumberOfGuest";
            this.textBoxNumberOfGuest.Size = new System.Drawing.Size(65, 20);
            this.textBoxNumberOfGuest.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonPasta);
            this.groupBox2.Controls.Add(this.radioButtonChicken);
            this.groupBox2.Controls.Add(this.radioButtonPrimeRib);
            this.groupBox2.Location = new System.Drawing.Point(101, 155);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(153, 111);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "   Menu Option  ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBoxWineWithDinner);
            this.groupBox3.Controls.Add(this.checkBoxOpenBar);
            this.groupBox3.Location = new System.Drawing.Point(279, 155);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(153, 111);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "   Bar Option   ";
            // 
            // radioButtonPrimeRib
            // 
            this.radioButtonPrimeRib.AutoSize = true;
            this.radioButtonPrimeRib.Location = new System.Drawing.Point(49, 23);
            this.radioButtonPrimeRib.Name = "radioButtonPrimeRib";
            this.radioButtonPrimeRib.Size = new System.Drawing.Size(70, 17);
            this.radioButtonPrimeRib.TabIndex = 4;
            this.radioButtonPrimeRib.TabStop = true;
            this.radioButtonPrimeRib.Text = "Prime Rib";
            this.radioButtonPrimeRib.UseVisualStyleBackColor = true;
            this.radioButtonPrimeRib.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // radioButtonChicken
            // 
            this.radioButtonChicken.AutoSize = true;
            this.radioButtonChicken.Location = new System.Drawing.Point(49, 52);
            this.radioButtonChicken.Name = "radioButtonChicken";
            this.radioButtonChicken.Size = new System.Drawing.Size(64, 17);
            this.radioButtonChicken.TabIndex = 5;
            this.radioButtonChicken.TabStop = true;
            this.radioButtonChicken.Text = "Chicken";
            this.radioButtonChicken.UseVisualStyleBackColor = true;
            this.radioButtonChicken.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // radioButtonPasta
            // 
            this.radioButtonPasta.AutoSize = true;
            this.radioButtonPasta.Location = new System.Drawing.Point(49, 81);
            this.radioButtonPasta.Name = "radioButtonPasta";
            this.radioButtonPasta.Size = new System.Drawing.Size(52, 17);
            this.radioButtonPasta.TabIndex = 6;
            this.radioButtonPasta.TabStop = true;
            this.radioButtonPasta.Text = "Pasta";
            this.radioButtonPasta.UseVisualStyleBackColor = true;
            this.radioButtonPasta.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // checkBoxOpenBar
            // 
            this.checkBoxOpenBar.AutoSize = true;
            this.checkBoxOpenBar.Location = new System.Drawing.Point(31, 35);
            this.checkBoxOpenBar.Name = "checkBoxOpenBar";
            this.checkBoxOpenBar.Size = new System.Drawing.Size(71, 17);
            this.checkBoxOpenBar.TabIndex = 7;
            this.checkBoxOpenBar.Text = "Open Bar";
            this.checkBoxOpenBar.UseVisualStyleBackColor = true;
            this.checkBoxOpenBar.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // checkBoxWineWithDinner
            // 
            this.checkBoxWineWithDinner.AutoSize = true;
            this.checkBoxWineWithDinner.Location = new System.Drawing.Point(31, 66);
            this.checkBoxWineWithDinner.Name = "checkBoxWineWithDinner";
            this.checkBoxWineWithDinner.Size = new System.Drawing.Size(107, 17);
            this.checkBoxWineWithDinner.TabIndex = 8;
            this.checkBoxWineWithDinner.Text = "Wine with Dinner";
            this.checkBoxWineWithDinner.UseVisualStyleBackColor = true;
            this.checkBoxWineWithDinner.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(95, 331);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(75, 23);
            this.buttonCalculate.TabIndex = 9;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(273, 331);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 10;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonSummary
            // 
            this.buttonSummary.Location = new System.Drawing.Point(184, 331);
            this.buttonSummary.Name = "buttonSummary";
            this.buttonSummary.Size = new System.Drawing.Size(75, 23);
            this.buttonSummary.TabIndex = 11;
            this.buttonSummary.Text = "Summary";
            this.buttonSummary.UseVisualStyleBackColor = true;
            this.buttonSummary.Click += new System.EventHandler(this.buttonSummary_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(362, 331);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 12;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(149, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Catherine\'s Catering";
            // 
            // textBoxAmountDue
            // 
            this.textBoxAmountDue.Enabled = false;
            this.textBoxAmountDue.Location = new System.Drawing.Point(339, 291);
            this.textBoxAmountDue.Name = "textBoxAmountDue";
            this.textBoxAmountDue.ReadOnly = true;
            this.textBoxAmountDue.Size = new System.Drawing.Size(93, 20);
            this.textBoxAmountDue.TabIndex = 15;
            this.textBoxAmountDue.TabStop = false;
            this.textBoxAmountDue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Amount Due";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(519, 374);
            this.Controls.Add(this.textBoxAmountDue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonSummary);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.textBoxNumberOfGuest);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNumberOfGuest;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonPasta;
        private System.Windows.Forms.RadioButton radioButtonChicken;
        private System.Windows.Forms.RadioButton radioButtonPrimeRib;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBoxWineWithDinner;
        private System.Windows.Forms.CheckBox checkBoxOpenBar;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonSummary;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAmountDue;
        private System.Windows.Forms.Label label3;
    }
}

