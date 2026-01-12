namespace SolutionOfPractice8
{
    partial class MemberAddUI
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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.contactNoTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.paidFeeCheckBox = new System.Windows.Forms.CheckBox();
            this.lifetimeTypeRadioButton = new System.Windows.Forms.RadioButton();
            this.yearlyTypeRadioButton = new System.Windows.Forms.RadioButton();
            this.monthlyTypeRadioButton = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.showAllButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(97, 25);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(155, 20);
            this.nameTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(97, 216);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // contactNoTextBox
            // 
            this.contactNoTextBox.Location = new System.Drawing.Point(97, 51);
            this.contactNoTextBox.Name = "contactNoTextBox";
            this.contactNoTextBox.Size = new System.Drawing.Size(155, 20);
            this.contactNoTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contact No";
            // 
            // paidFeeCheckBox
            // 
            this.paidFeeCheckBox.AutoSize = true;
            this.paidFeeCheckBox.Location = new System.Drawing.Point(97, 86);
            this.paidFeeCheckBox.Name = "paidFeeCheckBox";
            this.paidFeeCheckBox.Size = new System.Drawing.Size(145, 17);
            this.paidFeeCheckBox.TabIndex = 2;
            this.paidFeeCheckBox.Text = "Has paid membership fee";
            this.paidFeeCheckBox.UseVisualStyleBackColor = true;
            // 
            // lifetimeTypeRadioButton
            // 
            this.lifetimeTypeRadioButton.AutoSize = true;
            this.lifetimeTypeRadioButton.Location = new System.Drawing.Point(183, 179);
            this.lifetimeTypeRadioButton.Name = "lifetimeTypeRadioButton";
            this.lifetimeTypeRadioButton.Size = new System.Drawing.Size(61, 17);
            this.lifetimeTypeRadioButton.TabIndex = 5;
            this.lifetimeTypeRadioButton.Text = "Lifetime";
            this.lifetimeTypeRadioButton.UseVisualStyleBackColor = true;
            // 
            // yearlyTypeRadioButton
            // 
            this.yearlyTypeRadioButton.AutoSize = true;
            this.yearlyTypeRadioButton.Location = new System.Drawing.Point(183, 155);
            this.yearlyTypeRadioButton.Name = "yearlyTypeRadioButton";
            this.yearlyTypeRadioButton.Size = new System.Drawing.Size(54, 17);
            this.yearlyTypeRadioButton.TabIndex = 4;
            this.yearlyTypeRadioButton.Text = "Yearly";
            this.yearlyTypeRadioButton.UseVisualStyleBackColor = true;
            // 
            // monthlyTypeRadioButton
            // 
            this.monthlyTypeRadioButton.AutoSize = true;
            this.monthlyTypeRadioButton.Checked = true;
            this.monthlyTypeRadioButton.Location = new System.Drawing.Point(183, 132);
            this.monthlyTypeRadioButton.Name = "monthlyTypeRadioButton";
            this.monthlyTypeRadioButton.Size = new System.Drawing.Size(62, 17);
            this.monthlyTypeRadioButton.TabIndex = 3;
            this.monthlyTypeRadioButton.TabStop = true;
            this.monthlyTypeRadioButton.Text = "Monthly";
            this.monthlyTypeRadioButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Membership Type";
            // 
            // showAllButton
            // 
            this.showAllButton.Location = new System.Drawing.Point(177, 216);
            this.showAllButton.Name = "showAllButton";
            this.showAllButton.Size = new System.Drawing.Size(75, 23);
            this.showAllButton.TabIndex = 7;
            this.showAllButton.Text = "Show All";
            this.showAllButton.UseVisualStyleBackColor = true;
            this.showAllButton.Click += new System.EventHandler(this.showAllButton_Click);
            // 
            // MemberAddUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 261);
            this.Controls.Add(this.monthlyTypeRadioButton);
            this.Controls.Add(this.yearlyTypeRadioButton);
            this.Controls.Add(this.lifetimeTypeRadioButton);
            this.Controls.Add(this.paidFeeCheckBox);
            this.Controls.Add(this.showAllButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.contactNoTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Name = "MemberAddUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Club Member Information Entry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox contactNoTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox paidFeeCheckBox;
        private System.Windows.Forms.RadioButton lifetimeTypeRadioButton;
        private System.Windows.Forms.RadioButton yearlyTypeRadioButton;
        private System.Windows.Forms.RadioButton monthlyTypeRadioButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button showAllButton;
    }
}

