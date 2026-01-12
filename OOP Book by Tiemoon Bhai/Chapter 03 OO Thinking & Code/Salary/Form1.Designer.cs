namespace Salary
{
    partial class SalaryCalculatorUI
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.EmployeeNameTextBox = new System.Windows.Forms.TextBox();
            this.BasicAmountTextBox = new System.Windows.Forms.TextBox();
            this.HouseRentTextBox = new System.Windows.Forms.TextBox();
            this.MedicalAllowanceTextBox = new System.Windows.Forms.TextBox();
            this.ShowTotalButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Basic Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "House Rent";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Medical Allowance";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(481, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "% of Basic";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(481, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "% of Basic";
            // 
            // EmployeeNameTextBox
            // 
            this.EmployeeNameTextBox.Location = new System.Drawing.Point(226, 103);
            this.EmployeeNameTextBox.Name = "EmployeeNameTextBox";
            this.EmployeeNameTextBox.Size = new System.Drawing.Size(466, 22);
            this.EmployeeNameTextBox.TabIndex = 6;
            // 
            // BasicAmountTextBox
            // 
            this.BasicAmountTextBox.Location = new System.Drawing.Point(226, 148);
            this.BasicAmountTextBox.Name = "BasicAmountTextBox";
            this.BasicAmountTextBox.Size = new System.Drawing.Size(231, 22);
            this.BasicAmountTextBox.TabIndex = 7;
            // 
            // HouseRentTextBox
            // 
            this.HouseRentTextBox.Location = new System.Drawing.Point(226, 192);
            this.HouseRentTextBox.Name = "HouseRentTextBox";
            this.HouseRentTextBox.Size = new System.Drawing.Size(231, 22);
            this.HouseRentTextBox.TabIndex = 8;
            // 
            // MedicalAllowanceTextBox
            // 
            this.MedicalAllowanceTextBox.Location = new System.Drawing.Point(226, 242);
            this.MedicalAllowanceTextBox.Name = "MedicalAllowanceTextBox";
            this.MedicalAllowanceTextBox.Size = new System.Drawing.Size(231, 22);
            this.MedicalAllowanceTextBox.TabIndex = 9;
            // 
            // ShowTotalButton
            // 
            this.ShowTotalButton.Location = new System.Drawing.Point(265, 284);
            this.ShowTotalButton.Name = "ShowTotalButton";
            this.ShowTotalButton.Size = new System.Drawing.Size(136, 34);
            this.ShowTotalButton.TabIndex = 10;
            this.ShowTotalButton.Text = "Show Total";
            this.ShowTotalButton.UseVisualStyleBackColor = true;
            this.ShowTotalButton.Click += new System.EventHandler(this.ShowTotalButton_Click);
            // 
            // SalaryCalculatorUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ShowTotalButton);
            this.Controls.Add(this.MedicalAllowanceTextBox);
            this.Controls.Add(this.HouseRentTextBox);
            this.Controls.Add(this.BasicAmountTextBox);
            this.Controls.Add(this.EmployeeNameTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SalaryCalculatorUI";
            this.Text = "Salary Calculator";
            this.Load += new System.EventHandler(this.SalaryCalculatorUI_Load);
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
        private System.Windows.Forms.TextBox EmployeeNameTextBox;
        private System.Windows.Forms.TextBox BasicAmountTextBox;
        private System.Windows.Forms.TextBox HouseRentTextBox;
        private System.Windows.Forms.TextBox MedicalAllowanceTextBox;
        private System.Windows.Forms.Button ShowTotalButton;
    }
}

