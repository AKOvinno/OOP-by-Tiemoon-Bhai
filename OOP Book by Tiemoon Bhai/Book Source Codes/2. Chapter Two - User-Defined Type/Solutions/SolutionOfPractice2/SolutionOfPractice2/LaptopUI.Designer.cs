namespace SolutionOfPractice2
{
    partial class LaptopUI
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
            this.processorCoreNumberTextBox = new System.Windows.Forms.TextBox();
            this.ramSizeTextBox = new System.Windows.Forms.TextBox();
            this.brandNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.showButton = new System.Windows.Forms.Button();
            this.saveAndClearButton = new System.Windows.Forms.Button();
            this.goodOrBadForProgrammerTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // processorCoreNumberTextBox
            // 
            this.processorCoreNumberTextBox.Location = new System.Drawing.Point(142, 69);
            this.processorCoreNumberTextBox.Name = "processorCoreNumberTextBox";
            this.processorCoreNumberTextBox.Size = new System.Drawing.Size(107, 20);
            this.processorCoreNumberTextBox.TabIndex = 10;
            // 
            // ramSizeTextBox
            // 
            this.ramSizeTextBox.Location = new System.Drawing.Point(142, 41);
            this.ramSizeTextBox.Name = "ramSizeTextBox";
            this.ramSizeTextBox.Size = new System.Drawing.Size(107, 20);
            this.ramSizeTextBox.TabIndex = 6;
            // 
            // brandNameTextBox
            // 
            this.brandNameTextBox.Location = new System.Drawing.Point(142, 12);
            this.brandNameTextBox.Name = "brandNameTextBox";
            this.brandNameTextBox.Size = new System.Drawing.Size(107, 20);
            this.brandNameTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "No. of Core";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "RAM (GB)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Brand Name";
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(149, 130);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(100, 23);
            this.showButton.TabIndex = 12;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // saveAndClearButton
            // 
            this.saveAndClearButton.Location = new System.Drawing.Point(44, 130);
            this.saveAndClearButton.Name = "saveAndClearButton";
            this.saveAndClearButton.Size = new System.Drawing.Size(99, 23);
            this.saveAndClearButton.TabIndex = 11;
            this.saveAndClearButton.Text = "Save and Clear";
            this.saveAndClearButton.UseVisualStyleBackColor = true;
            this.saveAndClearButton.Click += new System.EventHandler(this.saveAndClearButton_Click);
            // 
            // goodOrBadForProgrammerTextBox
            // 
            this.goodOrBadForProgrammerTextBox.Location = new System.Drawing.Point(44, 104);
            this.goodOrBadForProgrammerTextBox.Name = "goodOrBadForProgrammerTextBox";
            this.goodOrBadForProgrammerTextBox.Size = new System.Drawing.Size(205, 20);
            this.goodOrBadForProgrammerTextBox.TabIndex = 13;
            // 
            // LaptopUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 167);
            this.Controls.Add(this.goodOrBadForProgrammerTextBox);
            this.Controls.Add(this.processorCoreNumberTextBox);
            this.Controls.Add(this.ramSizeTextBox);
            this.Controls.Add(this.brandNameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.saveAndClearButton);
            this.Name = "LaptopUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laptop Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox processorCoreNumberTextBox;
        private System.Windows.Forms.TextBox ramSizeTextBox;
        private System.Windows.Forms.TextBox brandNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Button saveAndClearButton;
        private System.Windows.Forms.TextBox goodOrBadForProgrammerTextBox;
    }
}

