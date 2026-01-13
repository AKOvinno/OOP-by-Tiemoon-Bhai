namespace ClubMemberInformation
{
    partial class ClubMemberInfoUI
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
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.ContactNoTextBox = new System.Windows.Forms.TextBox();
            this.PaidMembershipFeeCheckBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MonthlyRadioButton = new System.Windows.Forms.RadioButton();
            this.YearlyRadioButton = new System.Windows.Forms.RadioButton();
            this.LifetimeRadioButton = new System.Windows.Forms.RadioButton();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ShowAllButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contact No";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(246, 67);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(278, 22);
            this.NameTextBox.TabIndex = 2;
            // 
            // ContactNoTextBox
            // 
            this.ContactNoTextBox.Location = new System.Drawing.Point(246, 95);
            this.ContactNoTextBox.Name = "ContactNoTextBox";
            this.ContactNoTextBox.Size = new System.Drawing.Size(278, 22);
            this.ContactNoTextBox.TabIndex = 3;
            // 
            // PaidMembershipFeeCheckBox
            // 
            this.PaidMembershipFeeCheckBox.AutoSize = true;
            this.PaidMembershipFeeCheckBox.Location = new System.Drawing.Point(246, 136);
            this.PaidMembershipFeeCheckBox.Name = "PaidMembershipFeeCheckBox";
            this.PaidMembershipFeeCheckBox.Size = new System.Drawing.Size(184, 20);
            this.PaidMembershipFeeCheckBox.TabIndex = 4;
            this.PaidMembershipFeeCheckBox.Text = "Has paid membership fee";
            this.PaidMembershipFeeCheckBox.UseVisualStyleBackColor = true;
            this.PaidMembershipFeeCheckBox.CheckedChanged += new System.EventHandler(this.PaidMembershipFeeCheckBox_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(226, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Membership Type";
            // 
            // MonthlyRadioButton
            // 
            this.MonthlyRadioButton.AutoSize = true;
            this.MonthlyRadioButton.Location = new System.Drawing.Point(378, 194);
            this.MonthlyRadioButton.Name = "MonthlyRadioButton";
            this.MonthlyRadioButton.Size = new System.Drawing.Size(74, 20);
            this.MonthlyRadioButton.TabIndex = 6;
            this.MonthlyRadioButton.TabStop = true;
            this.MonthlyRadioButton.Text = "Monthly";
            this.MonthlyRadioButton.UseVisualStyleBackColor = true;
            this.MonthlyRadioButton.CheckedChanged += new System.EventHandler(this.MonthlyRadioButton_CheckedChanged);
            // 
            // YearlyRadioButton
            // 
            this.YearlyRadioButton.AutoSize = true;
            this.YearlyRadioButton.Location = new System.Drawing.Point(378, 220);
            this.YearlyRadioButton.Name = "YearlyRadioButton";
            this.YearlyRadioButton.Size = new System.Drawing.Size(67, 20);
            this.YearlyRadioButton.TabIndex = 7;
            this.YearlyRadioButton.TabStop = true;
            this.YearlyRadioButton.Text = "Yearly";
            this.YearlyRadioButton.UseVisualStyleBackColor = true;
            // 
            // LifetimeRadioButton
            // 
            this.LifetimeRadioButton.AutoSize = true;
            this.LifetimeRadioButton.Location = new System.Drawing.Point(378, 246);
            this.LifetimeRadioButton.Name = "LifetimeRadioButton";
            this.LifetimeRadioButton.Size = new System.Drawing.Size(74, 20);
            this.LifetimeRadioButton.TabIndex = 8;
            this.LifetimeRadioButton.TabStop = true;
            this.LifetimeRadioButton.Text = "Lifetime";
            this.LifetimeRadioButton.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(246, 303);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(126, 36);
            this.SaveButton.TabIndex = 9;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ShowAllButton
            // 
            this.ShowAllButton.Location = new System.Drawing.Point(378, 303);
            this.ShowAllButton.Name = "ShowAllButton";
            this.ShowAllButton.Size = new System.Drawing.Size(146, 36);
            this.ShowAllButton.TabIndex = 10;
            this.ShowAllButton.Text = "Show All";
            this.ShowAllButton.UseVisualStyleBackColor = true;
            this.ShowAllButton.Click += new System.EventHandler(this.ShowAllButton_Click);
            // 
            // ClubMemberInfoUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ShowAllButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.LifetimeRadioButton);
            this.Controls.Add(this.YearlyRadioButton);
            this.Controls.Add(this.MonthlyRadioButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PaidMembershipFeeCheckBox);
            this.Controls.Add(this.ContactNoTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ClubMemberInfoUI";
            this.Text = "Club Member Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox ContactNoTextBox;
        private System.Windows.Forms.CheckBox PaidMembershipFeeCheckBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton MonthlyRadioButton;
        private System.Windows.Forms.RadioButton YearlyRadioButton;
        private System.Windows.Forms.RadioButton LifetimeRadioButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button ShowAllButton;
    }
}

