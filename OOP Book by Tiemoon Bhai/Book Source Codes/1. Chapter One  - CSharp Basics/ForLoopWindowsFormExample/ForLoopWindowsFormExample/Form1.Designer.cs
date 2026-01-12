namespace FoorLoopWindowsFormExample
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
            this.fromTextBox = new System.Windows.Forms.TextBox();
            this.toTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.showOddNumberButton = new System.Windows.Forms.Button();
            this.showEvenNumberTextBox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fromTextBox
            // 
            this.fromTextBox.Location = new System.Drawing.Point(173, 60);
            this.fromTextBox.Name = "fromTextBox";
            this.fromTextBox.Size = new System.Drawing.Size(258, 31);
            this.fromTextBox.TabIndex = 0;
            // 
            // toTextBox
            // 
            this.toTextBox.Location = new System.Drawing.Point(173, 112);
            this.toTextBox.Name = "toTextBox";
            this.toTextBox.Size = new System.Drawing.Size(258, 31);
            this.toTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "To";
            // 
            // showOddNumberButton
            // 
            this.showOddNumberButton.Location = new System.Drawing.Point(173, 185);
            this.showOddNumberButton.Name = "showOddNumberButton";
            this.showOddNumberButton.Size = new System.Drawing.Size(258, 44);
            this.showOddNumberButton.TabIndex = 2;
            this.showOddNumberButton.Text = "Show Odd Number";
            this.showOddNumberButton.UseVisualStyleBackColor = true;
            this.showOddNumberButton.Click += new System.EventHandler(this.showOddNumberButton_Click);
            // 
            // showEvenNumberTextBox
            // 
            this.showEvenNumberTextBox.Location = new System.Drawing.Point(173, 260);
            this.showEvenNumberTextBox.Name = "showEvenNumberTextBox";
            this.showEvenNumberTextBox.Size = new System.Drawing.Size(258, 44);
            this.showEvenNumberTextBox.TabIndex = 3;
            this.showEvenNumberTextBox.Text = "Show Even Number";
            this.showEvenNumberTextBox.UseVisualStyleBackColor = true;
            this.showEvenNumberTextBox.Click += new System.EventHandler(this.showEvenNumberTextBox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 392);
            this.Controls.Add(this.showEvenNumberTextBox);
            this.Controls.Add(this.showOddNumberButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toTextBox);
            this.Controls.Add(this.fromTextBox);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fromTextBox;
        private System.Windows.Forms.TextBox toTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button showOddNumberButton;
        private System.Windows.Forms.Button showEvenNumberTextBox;
    }
}

