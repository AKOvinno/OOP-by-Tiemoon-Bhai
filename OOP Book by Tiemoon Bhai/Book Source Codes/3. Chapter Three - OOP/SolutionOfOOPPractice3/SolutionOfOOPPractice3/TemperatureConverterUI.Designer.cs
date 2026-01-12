namespace SolutionOfOOPPractice3
{
    partial class TemperatureConverterUI
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
            this.fahrenheitToCelsiusButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.celsiusToFahrenheitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fahrenheitToCelsiusButton
            // 
            this.fahrenheitToCelsiusButton.Location = new System.Drawing.Point(148, 52);
            this.fahrenheitToCelsiusButton.Name = "fahrenheitToCelsiusButton";
            this.fahrenheitToCelsiusButton.Size = new System.Drawing.Size(113, 35);
            this.fahrenheitToCelsiusButton.TabIndex = 1;
            this.fahrenheitToCelsiusButton.Text = "Fahrenheit to Celsius";
            this.fahrenheitToCelsiusButton.UseVisualStyleBackColor = true;
            this.fahrenheitToCelsiusButton.Click += new System.EventHandler(this.fahrenheitToCelsiusButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Input";
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(148, 26);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(113, 20);
            this.inputTextBox.TabIndex = 0;
            this.inputTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // celsiusToFahrenheitButton
            // 
            this.celsiusToFahrenheitButton.Location = new System.Drawing.Point(148, 93);
            this.celsiusToFahrenheitButton.Name = "celsiusToFahrenheitButton";
            this.celsiusToFahrenheitButton.Size = new System.Drawing.Size(113, 32);
            this.celsiusToFahrenheitButton.TabIndex = 2;
            this.celsiusToFahrenheitButton.Text = "Celsius to Fahrenheit";
            this.celsiusToFahrenheitButton.UseVisualStyleBackColor = true;
            this.celsiusToFahrenheitButton.Click += new System.EventHandler(this.celsiusToFahrenheitButton_Click);
            // 
            // TemperatureConverterUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 149);
            this.Controls.Add(this.celsiusToFahrenheitButton);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fahrenheitToCelsiusButton);
            this.Name = "TemperatureConverterUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Temperature Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fahrenheitToCelsiusButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Button celsiusToFahrenheitButton;
    }
}

