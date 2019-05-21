namespace Question3._6
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CommisonTextbox = new System.Windows.Forms.TextBox();
            this.grossPayTextbox = new System.Windows.Forms.TextBox();
            this.deductionsTextbox = new System.Windows.Forms.TextBox();
            this.netPayTextbox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.miscellaneousTextbox = new System.Windows.Forms.TextBox();
            this.entertaimentTextbox = new System.Windows.Forms.TextBox();
            this.foodandClothingTextbox = new System.Windows.Forms.TextBox();
            this.housingTextbox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.printButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.employeeSaleTextbox = new System.Windows.Forms.TextBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.printForm1 = new Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee\'s Sales";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gross pay";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Deductions";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Net pay";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(118, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Housing";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Food and Clothing";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(76, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Entertainment";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(70, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 18);
            this.label8.TabIndex = 7;
            this.label8.Text = "Miscellaneous";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(101, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 18);
            this.label9.TabIndex = 8;
            this.label9.Text = "Comission";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.netPayTextbox);
            this.groupBox1.Controls.Add(this.deductionsTextbox);
            this.groupBox1.Controls.Add(this.grossPayTextbox);
            this.groupBox1.Controls.Add(this.CommisonTextbox);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(59, 144);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(472, 186);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "     Pay      ";
            // 
            // CommisonTextbox
            // 
            this.CommisonTextbox.Location = new System.Drawing.Point(191, 21);
            this.CommisonTextbox.Name = "CommisonTextbox";
            this.CommisonTextbox.ReadOnly = true;
            this.CommisonTextbox.Size = new System.Drawing.Size(197, 26);
            this.CommisonTextbox.TabIndex = 9;
            this.CommisonTextbox.TabStop = false;
            this.CommisonTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // grossPayTextbox
            // 
            this.grossPayTextbox.Location = new System.Drawing.Point(191, 62);
            this.grossPayTextbox.Name = "grossPayTextbox";
            this.grossPayTextbox.ReadOnly = true;
            this.grossPayTextbox.Size = new System.Drawing.Size(197, 26);
            this.grossPayTextbox.TabIndex = 10;
            this.grossPayTextbox.TabStop = false;
            this.grossPayTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // deductionsTextbox
            // 
            this.deductionsTextbox.Location = new System.Drawing.Point(191, 100);
            this.deductionsTextbox.Name = "deductionsTextbox";
            this.deductionsTextbox.ReadOnly = true;
            this.deductionsTextbox.Size = new System.Drawing.Size(197, 26);
            this.deductionsTextbox.TabIndex = 11;
            this.deductionsTextbox.TabStop = false;
            this.deductionsTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // netPayTextbox
            // 
            this.netPayTextbox.Location = new System.Drawing.Point(191, 141);
            this.netPayTextbox.Name = "netPayTextbox";
            this.netPayTextbox.ReadOnly = true;
            this.netPayTextbox.Size = new System.Drawing.Size(197, 26);
            this.netPayTextbox.TabIndex = 12;
            this.netPayTextbox.TabStop = false;
            this.netPayTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.miscellaneousTextbox);
            this.groupBox2.Controls.Add(this.entertaimentTextbox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.foodandClothingTextbox);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.housingTextbox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(59, 357);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(472, 202);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "      Budget      ";
            // 
            // miscellaneousTextbox
            // 
            this.miscellaneousTextbox.Location = new System.Drawing.Point(191, 164);
            this.miscellaneousTextbox.Name = "miscellaneousTextbox";
            this.miscellaneousTextbox.ReadOnly = true;
            this.miscellaneousTextbox.Size = new System.Drawing.Size(197, 26);
            this.miscellaneousTextbox.TabIndex = 16;
            this.miscellaneousTextbox.TabStop = false;
            this.miscellaneousTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // entertaimentTextbox
            // 
            this.entertaimentTextbox.Location = new System.Drawing.Point(191, 119);
            this.entertaimentTextbox.Name = "entertaimentTextbox";
            this.entertaimentTextbox.ReadOnly = true;
            this.entertaimentTextbox.Size = new System.Drawing.Size(197, 26);
            this.entertaimentTextbox.TabIndex = 15;
            this.entertaimentTextbox.TabStop = false;
            this.entertaimentTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // foodandClothingTextbox
            // 
            this.foodandClothingTextbox.Location = new System.Drawing.Point(191, 76);
            this.foodandClothingTextbox.Name = "foodandClothingTextbox";
            this.foodandClothingTextbox.ReadOnly = true;
            this.foodandClothingTextbox.Size = new System.Drawing.Size(197, 26);
            this.foodandClothingTextbox.TabIndex = 14;
            this.foodandClothingTextbox.TabStop = false;
            this.foodandClothingTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // housingTextbox
            // 
            this.housingTextbox.Location = new System.Drawing.Point(191, 33);
            this.housingTextbox.Name = "housingTextbox";
            this.housingTextbox.ReadOnly = true;
            this.housingTextbox.Size = new System.Drawing.Size(197, 26);
            this.housingTextbox.TabIndex = 13;
            this.housingTextbox.TabStop = false;
            this.housingTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.Location = new System.Drawing.Point(93, 584);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(93, 28);
            this.calculateButton.TabIndex = 14;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(197, 584);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(93, 28);
            this.clearButton.TabIndex = 15;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // printButton
            // 
            this.printButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printButton.Location = new System.Drawing.Point(301, 584);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(93, 28);
            this.printButton.TabIndex = 16;
            this.printButton.Text = "Print";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(405, 584);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(93, 28);
            this.exitButton.TabIndex = 17;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // employeeSaleTextbox
            // 
            this.employeeSaleTextbox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeSaleTextbox.Location = new System.Drawing.Point(201, 75);
            this.employeeSaleTextbox.Name = "employeeSaleTextbox";
            this.employeeSaleTextbox.Size = new System.Drawing.Size(176, 26);
            this.employeeSaleTextbox.TabIndex = 13;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(590, 631);
            this.shapeContainer1.TabIndex = 18;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.DarkTurquoise;
            this.lineShape1.BorderWidth = 2;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 63;
            this.lineShape1.X2 = 380;
            this.lineShape1.Y1 = 115;
            this.lineShape1.Y2 = 115;
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
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(590, 631);
            this.Controls.Add(this.employeeSaleTextbox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Earnings ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox netPayTextbox;
        private System.Windows.Forms.TextBox deductionsTextbox;
        private System.Windows.Forms.TextBox grossPayTextbox;
        private System.Windows.Forms.TextBox CommisonTextbox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox miscellaneousTextbox;
        private System.Windows.Forms.TextBox entertaimentTextbox;
        private System.Windows.Forms.TextBox foodandClothingTextbox;
        private System.Windows.Forms.TextBox housingTextbox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox employeeSaleTextbox;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.Printing.PrintForm printForm1;
    }
}

