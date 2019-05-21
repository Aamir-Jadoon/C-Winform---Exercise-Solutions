namespace BookExcerciseSolution
{
    partial class Chapter1HOP
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
            this.clothingButton = new System.Windows.Forms.Button();
            this.equipmentButton = new System.Windows.Forms.Button();
            this.juiceBarButton = new System.Windows.Forms.Button();
            this.personalTrainingButton = new System.Windows.Forms.Button();
            this.membershipButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.promotionLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clothingButton
            // 
            this.clothingButton.Location = new System.Drawing.Point(31, 106);
            this.clothingButton.Name = "clothingButton";
            this.clothingButton.Size = new System.Drawing.Size(159, 23);
            this.clothingButton.TabIndex = 0;
            this.clothingButton.Text = "Clothing";
            this.clothingButton.UseVisualStyleBackColor = true;
            this.clothingButton.Click += new System.EventHandler(this.clothingButton_Click);
            // 
            // equipmentButton
            // 
            this.equipmentButton.Location = new System.Drawing.Point(31, 137);
            this.equipmentButton.Name = "equipmentButton";
            this.equipmentButton.Size = new System.Drawing.Size(159, 23);
            this.equipmentButton.TabIndex = 1;
            this.equipmentButton.Text = "Equipment / Accessories";
            this.equipmentButton.UseVisualStyleBackColor = true;
            this.equipmentButton.Click += new System.EventHandler(this.equipmentButton_Click);
            // 
            // juiceBarButton
            // 
            this.juiceBarButton.Location = new System.Drawing.Point(31, 168);
            this.juiceBarButton.Name = "juiceBarButton";
            this.juiceBarButton.Size = new System.Drawing.Size(159, 23);
            this.juiceBarButton.TabIndex = 2;
            this.juiceBarButton.Text = "Juice Bar";
            this.juiceBarButton.UseVisualStyleBackColor = true;
            this.juiceBarButton.Click += new System.EventHandler(this.juiceBarButton_Click);
            // 
            // personalTrainingButton
            // 
            this.personalTrainingButton.Location = new System.Drawing.Point(31, 230);
            this.personalTrainingButton.Name = "personalTrainingButton";
            this.personalTrainingButton.Size = new System.Drawing.Size(159, 23);
            this.personalTrainingButton.TabIndex = 3;
            this.personalTrainingButton.Text = "Personal Training";
            this.personalTrainingButton.UseVisualStyleBackColor = true;
            this.personalTrainingButton.Click += new System.EventHandler(this.personalTrainingButton_Click);
            // 
            // membershipButton
            // 
            this.membershipButton.Location = new System.Drawing.Point(31, 199);
            this.membershipButton.Name = "membershipButton";
            this.membershipButton.Size = new System.Drawing.Size(159, 23);
            this.membershipButton.TabIndex = 3;
            this.membershipButton.Text = "Membership";
            this.membershipButton.UseVisualStyleBackColor = true;
            this.membershipButton.Click += new System.EventHandler(this.membershipButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(31, 261);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(159, 23);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(189, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Look Sharp Fitness Center";
            // 
            // promotionLabel
            // 
            this.promotionLabel.AutoSize = true;
            this.promotionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.promotionLabel.Location = new System.Drawing.Point(202, 169);
            this.promotionLabel.Name = "promotionLabel";
            this.promotionLabel.Size = new System.Drawing.Size(0, 20);
            this.promotionLabel.TabIndex = 6;
            this.promotionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(296, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Programmed by Aamir Khan Jadoon";
            // 
            // Chapter1HOP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 311);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.promotionLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.membershipButton);
            this.Controls.Add(this.personalTrainingButton);
            this.Controls.Add(this.juiceBarButton);
            this.Controls.Add(this.equipmentButton);
            this.Controls.Add(this.clothingButton);
            this.Name = "Chapter1HOP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Current Promotions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clothingButton;
        private System.Windows.Forms.Button equipmentButton;
        private System.Windows.Forms.Button juiceBarButton;
        private System.Windows.Forms.Button personalTrainingButton;
        private System.Windows.Forms.Button membershipButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label promotionLabel;
        private System.Windows.Forms.Label label3;
    }
}