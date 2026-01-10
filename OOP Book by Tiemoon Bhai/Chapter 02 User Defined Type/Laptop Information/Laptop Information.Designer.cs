namespace Laptop_Information
{
    partial class LaptopInfoUI
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
            this.BrandName = new System.Windows.Forms.Label();
            this.RamGB = new System.Windows.Forms.Label();
            this.ProcessorCoreI = new System.Windows.Forms.Label();
            this.BrandNameTextBox = new System.Windows.Forms.TextBox();
            this.RamSizeTextBox = new System.Windows.Forms.TextBox();
            this.ProcessorCoreTextBox = new System.Windows.Forms.TextBox();
            this.SaveAndClearButton = new System.Windows.Forms.Button();
            this.ShowButton = new System.Windows.Forms.Button();
            this.isAppropriateForProgrammerTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BrandName
            // 
            this.BrandName.AutoSize = true;
            this.BrandName.Location = new System.Drawing.Point(125, 95);
            this.BrandName.Name = "BrandName";
            this.BrandName.Size = new System.Drawing.Size(83, 16);
            this.BrandName.TabIndex = 0;
            this.BrandName.Text = "Brand Name";
            // 
            // RamGB
            // 
            this.RamGB.AutoSize = true;
            this.RamGB.Location = new System.Drawing.Point(141, 140);
            this.RamGB.Name = "RamGB";
            this.RamGB.Size = new System.Drawing.Size(67, 16);
            this.RamGB.TabIndex = 1;
            this.RamGB.Text = "RAM (GB)";
            // 
            // ProcessorCoreI
            // 
            this.ProcessorCoreI.AutoSize = true;
            this.ProcessorCoreI.Location = new System.Drawing.Point(94, 183);
            this.ProcessorCoreI.Name = "ProcessorCoreI";
            this.ProcessorCoreI.Size = new System.Drawing.Size(114, 16);
            this.ProcessorCoreI.TabIndex = 2;
            this.ProcessorCoreI.Text = "Processor - Core i";
            // 
            // BrandNameTextBox
            // 
            this.BrandNameTextBox.Location = new System.Drawing.Point(223, 89);
            this.BrandNameTextBox.Name = "BrandNameTextBox";
            this.BrandNameTextBox.Size = new System.Drawing.Size(216, 22);
            this.BrandNameTextBox.TabIndex = 3;
            // 
            // RamSizeTextBox
            // 
            this.RamSizeTextBox.Location = new System.Drawing.Point(223, 134);
            this.RamSizeTextBox.Name = "RamSizeTextBox";
            this.RamSizeTextBox.Size = new System.Drawing.Size(216, 22);
            this.RamSizeTextBox.TabIndex = 4;
            // 
            // ProcessorCoreTextBox
            // 
            this.ProcessorCoreTextBox.Location = new System.Drawing.Point(223, 183);
            this.ProcessorCoreTextBox.Name = "ProcessorCoreTextBox";
            this.ProcessorCoreTextBox.Size = new System.Drawing.Size(216, 22);
            this.ProcessorCoreTextBox.TabIndex = 5;
            // 
            // SaveAndClearButton
            // 
            this.SaveAndClearButton.Location = new System.Drawing.Point(161, 287);
            this.SaveAndClearButton.Name = "SaveAndClearButton";
            this.SaveAndClearButton.Size = new System.Drawing.Size(127, 34);
            this.SaveAndClearButton.TabIndex = 6;
            this.SaveAndClearButton.Text = "Save and Clear";
            this.SaveAndClearButton.UseVisualStyleBackColor = true;
            this.SaveAndClearButton.Click += new System.EventHandler(this.SaveAndClearButton_Click);
            // 
            // ShowButton
            // 
            this.ShowButton.Location = new System.Drawing.Point(312, 287);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(127, 34);
            this.ShowButton.TabIndex = 7;
            this.ShowButton.Text = "Show";
            this.ShowButton.UseVisualStyleBackColor = true;
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // isAppropriateForProgrammerTextBox
            // 
            this.isAppropriateForProgrammerTextBox.Location = new System.Drawing.Point(97, 239);
            this.isAppropriateForProgrammerTextBox.Name = "isAppropriateForProgrammerTextBox";
            this.isAppropriateForProgrammerTextBox.Size = new System.Drawing.Size(342, 22);
            this.isAppropriateForProgrammerTextBox.TabIndex = 8;
            this.isAppropriateForProgrammerTextBox.TextChanged += new System.EventHandler(this.isAppropriateForProgrammerTextBox_TextChanged);
            // 
            // LaptopInfoUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.isAppropriateForProgrammerTextBox);
            this.Controls.Add(this.ShowButton);
            this.Controls.Add(this.SaveAndClearButton);
            this.Controls.Add(this.ProcessorCoreTextBox);
            this.Controls.Add(this.RamSizeTextBox);
            this.Controls.Add(this.BrandNameTextBox);
            this.Controls.Add(this.ProcessorCoreI);
            this.Controls.Add(this.RamGB);
            this.Controls.Add(this.BrandName);
            this.Name = "LaptopInfoUI";
            this.Text = "Laptop Information";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BrandName;
        private System.Windows.Forms.Label RamGB;
        private System.Windows.Forms.Label ProcessorCoreI;
        private System.Windows.Forms.TextBox BrandNameTextBox;
        private System.Windows.Forms.TextBox RamSizeTextBox;
        private System.Windows.Forms.TextBox ProcessorCoreTextBox;
        private System.Windows.Forms.Button SaveAndClearButton;
        private System.Windows.Forms.Button ShowButton;
        private System.Windows.Forms.TextBox isAppropriateForProgrammerTextBox;
    }
}

