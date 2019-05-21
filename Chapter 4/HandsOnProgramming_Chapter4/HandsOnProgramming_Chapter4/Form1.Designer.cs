namespace HandsOnProgramming_Chapter4
{
    partial class JuiceBarForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.twelveOunceRadioButton = new System.Windows.Forms.RadioButton();
            this.sixteenOunceRadioButton = new System.Windows.Forms.RadioButton();
            this.twentyOunceRadioButton = new System.Windows.Forms.RadioButton();
            this.noSizeRadioButton = new System.Windows.Forms.RadioButton();
            this.vitaminPackCheckBox = new System.Windows.Forms.CheckBox();
            this.energyBoosterCheckBox = new System.Windows.Forms.CheckBox();
            this.ladiesCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FruitJuiceRadioButton = new System.Windows.Forms.RadioButton();
            this.veggieJuiceRadioButton = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.promegranateSmoothieRadioButton = new System.Windows.Forms.RadioButton();
            this.strawberryBananaRadioButton = new System.Windows.Forms.RadioButton();
            this.wheatBerrySmoothieRadioButton = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.itemPriceTextBox = new System.Windows.Forms.TextBox();
            this.addToOrderButton = new System.Windows.Forms.Button();
            this.orderCompleteButton = new System.Windows.Forms.Button();
            this.summaryButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.noSizeRadioButton);
            this.groupBox1.Controls.Add(this.twentyOunceRadioButton);
            this.groupBox1.Controls.Add(this.sixteenOunceRadioButton);
            this.groupBox1.Controls.Add(this.twelveOunceRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 143);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "    Size    ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ladiesCheckBox);
            this.groupBox2.Controls.Add(this.energyBoosterCheckBox);
            this.groupBox2.Controls.Add(this.vitaminPackCheckBox);
            this.groupBox2.Location = new System.Drawing.Point(10, 176);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 135);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "    Extras - $0.50 each    ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.wheatBerrySmoothieRadioButton);
            this.groupBox3.Controls.Add(this.strawberryBananaRadioButton);
            this.groupBox3.Controls.Add(this.promegranateSmoothieRadioButton);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.veggieJuiceRadioButton);
            this.groupBox3.Controls.Add(this.FruitJuiceRadioButton);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(243, 10);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(228, 248);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "    Select the dring type    ";
            // 
            // twelveOunceRadioButton
            // 
            this.twelveOunceRadioButton.AutoSize = true;
            this.twelveOunceRadioButton.Location = new System.Drawing.Point(26, 32);
            this.twelveOunceRadioButton.Name = "twelveOunceRadioButton";
            this.twelveOunceRadioButton.Size = new System.Drawing.Size(96, 17);
            this.twelveOunceRadioButton.TabIndex = 0;
            this.twelveOunceRadioButton.TabStop = true;
            this.twelveOunceRadioButton.Text = "12 &Ounce 3.00";
            this.twelveOunceRadioButton.UseVisualStyleBackColor = true;
            this.twelveOunceRadioButton.CheckedChanged += new System.EventHandler(this.twelveOunceRadioButton_CheckedChanged);
            // 
            // sixteenOunceRadioButton
            // 
            this.sixteenOunceRadioButton.AutoSize = true;
            this.sixteenOunceRadioButton.Location = new System.Drawing.Point(26, 63);
            this.sixteenOunceRadioButton.Name = "sixteenOunceRadioButton";
            this.sixteenOunceRadioButton.Size = new System.Drawing.Size(96, 17);
            this.sixteenOunceRadioButton.TabIndex = 1;
            this.sixteenOunceRadioButton.TabStop = true;
            this.sixteenOunceRadioButton.Text = "&16 Ounce 3.50";
            this.sixteenOunceRadioButton.UseVisualStyleBackColor = true;
            // 
            // twentyOunceRadioButton
            // 
            this.twentyOunceRadioButton.AutoSize = true;
            this.twentyOunceRadioButton.Location = new System.Drawing.Point(26, 94);
            this.twentyOunceRadioButton.Name = "twentyOunceRadioButton";
            this.twentyOunceRadioButton.Size = new System.Drawing.Size(96, 17);
            this.twentyOunceRadioButton.TabIndex = 2;
            this.twentyOunceRadioButton.TabStop = true;
            this.twentyOunceRadioButton.Text = "&20 Ounce 4.00";
            this.twentyOunceRadioButton.UseVisualStyleBackColor = true;
            // 
            // noSizeRadioButton
            // 
            this.noSizeRadioButton.AutoSize = true;
            this.noSizeRadioButton.Location = new System.Drawing.Point(132, 120);
            this.noSizeRadioButton.Name = "noSizeRadioButton";
            this.noSizeRadioButton.Size = new System.Drawing.Size(62, 17);
            this.noSizeRadioButton.TabIndex = 3;
            this.noSizeRadioButton.TabStop = true;
            this.noSizeRadioButton.Text = "invisible";
            this.noSizeRadioButton.UseVisualStyleBackColor = true;
            // 
            // vitaminPackCheckBox
            // 
            this.vitaminPackCheckBox.AutoSize = true;
            this.vitaminPackCheckBox.Location = new System.Drawing.Point(32, 34);
            this.vitaminPackCheckBox.Name = "vitaminPackCheckBox";
            this.vitaminPackCheckBox.Size = new System.Drawing.Size(88, 17);
            this.vitaminPackCheckBox.TabIndex = 0;
            this.vitaminPackCheckBox.Text = "&Vitamin Pack";
            this.vitaminPackCheckBox.UseVisualStyleBackColor = true;
            // 
            // energyBoosterCheckBox
            // 
            this.energyBoosterCheckBox.AutoSize = true;
            this.energyBoosterCheckBox.Location = new System.Drawing.Point(32, 65);
            this.energyBoosterCheckBox.Name = "energyBoosterCheckBox";
            this.energyBoosterCheckBox.Size = new System.Drawing.Size(98, 17);
            this.energyBoosterCheckBox.TabIndex = 1;
            this.energyBoosterCheckBox.Text = "&Energy &Booster";
            this.energyBoosterCheckBox.UseVisualStyleBackColor = true;
            // 
            // ladiesCheckBox
            // 
            this.ladiesCheckBox.AutoSize = true;
            this.ladiesCheckBox.Location = new System.Drawing.Point(32, 96);
            this.ladiesCheckBox.Name = "ladiesCheckBox";
            this.ladiesCheckBox.Size = new System.Drawing.Size(93, 17);
            this.ladiesCheckBox.TabIndex = 2;
            this.ladiesCheckBox.Text = "For the &Ladies";
            this.ladiesCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "J u i c e s";
            // 
            // FruitJuiceRadioButton
            // 
            this.FruitJuiceRadioButton.AutoSize = true;
            this.FruitJuiceRadioButton.Location = new System.Drawing.Point(64, 53);
            this.FruitJuiceRadioButton.Name = "FruitJuiceRadioButton";
            this.FruitJuiceRadioButton.Size = new System.Drawing.Size(45, 17);
            this.FruitJuiceRadioButton.TabIndex = 4;
            this.FruitJuiceRadioButton.TabStop = true;
            this.FruitJuiceRadioButton.Text = "&Fruit";
            this.FruitJuiceRadioButton.UseVisualStyleBackColor = true;
            // 
            // veggieJuiceRadioButton
            // 
            this.veggieJuiceRadioButton.AutoSize = true;
            this.veggieJuiceRadioButton.Location = new System.Drawing.Point(64, 84);
            this.veggieJuiceRadioButton.Name = "veggieJuiceRadioButton";
            this.veggieJuiceRadioButton.Size = new System.Drawing.Size(58, 17);
            this.veggieJuiceRadioButton.TabIndex = 5;
            this.veggieJuiceRadioButton.TabStop = true;
            this.veggieJuiceRadioButton.Text = "Ve&ggie";
            this.veggieJuiceRadioButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "S m o o t h i e s";
            // 
            // promegranateSmoothieRadioButton
            // 
            this.promegranateSmoothieRadioButton.AutoSize = true;
            this.promegranateSmoothieRadioButton.Location = new System.Drawing.Point(64, 151);
            this.promegranateSmoothieRadioButton.Name = "promegranateSmoothieRadioButton";
            this.promegranateSmoothieRadioButton.Size = new System.Drawing.Size(91, 17);
            this.promegranateSmoothieRadioButton.TabIndex = 7;
            this.promegranateSmoothieRadioButton.TabStop = true;
            this.promegranateSmoothieRadioButton.Text = "&Promegranate";
            this.promegranateSmoothieRadioButton.UseVisualStyleBackColor = true;
            // 
            // strawberryBananaRadioButton
            // 
            this.strawberryBananaRadioButton.AutoSize = true;
            this.strawberryBananaRadioButton.Location = new System.Drawing.Point(64, 182);
            this.strawberryBananaRadioButton.Name = "strawberryBananaRadioButton";
            this.strawberryBananaRadioButton.Size = new System.Drawing.Size(115, 17);
            this.strawberryBananaRadioButton.TabIndex = 8;
            this.strawberryBananaRadioButton.TabStop = true;
            this.strawberryBananaRadioButton.Text = "&Strawberry Banana";
            this.strawberryBananaRadioButton.UseVisualStyleBackColor = true;
            // 
            // wheatBerrySmoothieRadioButton
            // 
            this.wheatBerrySmoothieRadioButton.AutoSize = true;
            this.wheatBerrySmoothieRadioButton.Location = new System.Drawing.Point(64, 213);
            this.wheatBerrySmoothieRadioButton.Name = "wheatBerrySmoothieRadioButton";
            this.wheatBerrySmoothieRadioButton.Size = new System.Drawing.Size(81, 17);
            this.wheatBerrySmoothieRadioButton.TabIndex = 9;
            this.wheatBerrySmoothieRadioButton.TabStop = true;
            this.wheatBerrySmoothieRadioButton.Text = "&WheatBerry";
            this.wheatBerrySmoothieRadioButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "&Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 357);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Item Price";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(82, 328);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(35, 20);
            this.quantityTextBox.TabIndex = 12;
            // 
            // itemPriceTextBox
            // 
            this.itemPriceTextBox.Location = new System.Drawing.Point(82, 354);
            this.itemPriceTextBox.Name = "itemPriceTextBox";
            this.itemPriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.itemPriceTextBox.TabIndex = 13;
            // 
            // addToOrderButton
            // 
            this.addToOrderButton.Location = new System.Drawing.Point(369, 288);
            this.addToOrderButton.Name = "addToOrderButton";
            this.addToOrderButton.Size = new System.Drawing.Size(102, 23);
            this.addToOrderButton.TabIndex = 14;
            this.addToOrderButton.Text = "&Add to Order";
            this.addToOrderButton.UseVisualStyleBackColor = true;
            this.addToOrderButton.Click += new System.EventHandler(this.addToOrderButton_Click);
            // 
            // orderCompleteButton
            // 
            this.orderCompleteButton.Location = new System.Drawing.Point(369, 326);
            this.orderCompleteButton.Name = "orderCompleteButton";
            this.orderCompleteButton.Size = new System.Drawing.Size(102, 23);
            this.orderCompleteButton.TabIndex = 15;
            this.orderCompleteButton.Text = "Order &Complete";
            this.orderCompleteButton.UseVisualStyleBackColor = true;
            this.orderCompleteButton.Click += new System.EventHandler(this.orderCompleteButton_Click);
            // 
            // summaryButton
            // 
            this.summaryButton.Location = new System.Drawing.Point(369, 364);
            this.summaryButton.Name = "summaryButton";
            this.summaryButton.Size = new System.Drawing.Size(102, 23);
            this.summaryButton.TabIndex = 16;
            this.summaryButton.Text = "Summary &Report";
            this.summaryButton.UseVisualStyleBackColor = true;
            this.summaryButton.Click += new System.EventHandler(this.summaryButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(369, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "E&xit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // JuiceBarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(482, 442);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.summaryButton);
            this.Controls.Add(this.orderCompleteButton);
            this.Controls.Add(this.addToOrderButton);
            this.Controls.Add(this.itemPriceTextBox);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "JuiceBarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Juice Bar ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton noSizeRadioButton;
        private System.Windows.Forms.RadioButton twentyOunceRadioButton;
        private System.Windows.Forms.RadioButton sixteenOunceRadioButton;
        private System.Windows.Forms.RadioButton twelveOunceRadioButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox ladiesCheckBox;
        private System.Windows.Forms.CheckBox energyBoosterCheckBox;
        private System.Windows.Forms.CheckBox vitaminPackCheckBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton wheatBerrySmoothieRadioButton;
        private System.Windows.Forms.RadioButton strawberryBananaRadioButton;
        private System.Windows.Forms.RadioButton promegranateSmoothieRadioButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton veggieJuiceRadioButton;
        private System.Windows.Forms.RadioButton FruitJuiceRadioButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.TextBox itemPriceTextBox;
        private System.Windows.Forms.Button addToOrderButton;
        private System.Windows.Forms.Button orderCompleteButton;
        private System.Windows.Forms.Button summaryButton;
        private System.Windows.Forms.Button button1;
    }
}

