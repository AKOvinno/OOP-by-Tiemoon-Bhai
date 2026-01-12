namespace TemperatureConverter
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
            this.label1 = new System.Windows.Forms.Label();
            this.TemperatureTextBox = new System.Windows.Forms.TextBox();
            this.FahrenheitToCelciusButton = new System.Windows.Forms.Button();
            this.CelciusToFahrenheitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(247, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input";
            // 
            // TemperatureTextBox
            // 
            this.TemperatureTextBox.Location = new System.Drawing.Point(297, 120);
            this.TemperatureTextBox.Name = "TemperatureTextBox";
            this.TemperatureTextBox.Size = new System.Drawing.Size(214, 22);
            this.TemperatureTextBox.TabIndex = 1;
            // 
            // FahrenheitToCelciusButton
            // 
            this.FahrenheitToCelciusButton.Location = new System.Drawing.Point(297, 160);
            this.FahrenheitToCelciusButton.Name = "FahrenheitToCelciusButton";
            this.FahrenheitToCelciusButton.Size = new System.Drawing.Size(214, 32);
            this.FahrenheitToCelciusButton.TabIndex = 2;
            this.FahrenheitToCelciusButton.Text = "Fahrenheit to Celsius";
            this.FahrenheitToCelciusButton.UseVisualStyleBackColor = true;
            this.FahrenheitToCelciusButton.Click += new System.EventHandler(this.FahrenheitToCelciusButton_Click);
            // 
            // CelciusToFahrenheitButton
            // 
            this.CelciusToFahrenheitButton.Location = new System.Drawing.Point(297, 198);
            this.CelciusToFahrenheitButton.Name = "CelciusToFahrenheitButton";
            this.CelciusToFahrenheitButton.Size = new System.Drawing.Size(214, 32);
            this.CelciusToFahrenheitButton.TabIndex = 3;
            this.CelciusToFahrenheitButton.Text = "Celsius to Fahrenheit";
            this.CelciusToFahrenheitButton.UseVisualStyleBackColor = true;
            this.CelciusToFahrenheitButton.Click += new System.EventHandler(this.CelciusToFahrenheitButton_Click);
            // 
            // TemperatureConverterUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CelciusToFahrenheitButton);
            this.Controls.Add(this.FahrenheitToCelciusButton);
            this.Controls.Add(this.TemperatureTextBox);
            this.Controls.Add(this.label1);
            this.Name = "TemperatureConverterUI";
            this.Text = "Temperature Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TemperatureTextBox;
        private System.Windows.Forms.Button FahrenheitToCelciusButton;
        private System.Windows.Forms.Button CelciusToFahrenheitButton;
    }
}

