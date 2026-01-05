namespace Odd_EvenWithinLimit
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
            this.ShowOddNum = new System.Windows.Forms.Button();
            this.ShowEvenNum = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ShowOddNum
            // 
            this.ShowOddNum.Location = new System.Drawing.Point(218, 200);
            this.ShowOddNum.Name = "ShowOddNum";
            this.ShowOddNum.Size = new System.Drawing.Size(193, 43);
            this.ShowOddNum.TabIndex = 0;
            this.ShowOddNum.Text = "Show Odd Number";
            this.ShowOddNum.UseVisualStyleBackColor = true;
            this.ShowOddNum.Click += new System.EventHandler(this.ShowOddNum_Click);
            // 
            // ShowEvenNum
            // 
            this.ShowEvenNum.Location = new System.Drawing.Point(218, 272);
            this.ShowEvenNum.Name = "ShowEvenNum";
            this.ShowEvenNum.Size = new System.Drawing.Size(193, 43);
            this.ShowEvenNum.TabIndex = 1;
            this.ShowEvenNum.Text = "Show Even Number";
            this.ShowEvenNum.UseVisualStyleBackColor = true;
            this.ShowEvenNum.Click += new System.EventHandler(this.ShowEvenNum_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "To";
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(179, 99);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(279, 22);
            this.txtFrom.TabIndex = 4;
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(179, 141);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(279, 22);
            this.txtTo.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ShowEvenNum);
            this.Controls.Add(this.ShowOddNum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ShowOddNum;
        private System.Windows.Forms.Button ShowEvenNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.TextBox txtTo;
    }
}

