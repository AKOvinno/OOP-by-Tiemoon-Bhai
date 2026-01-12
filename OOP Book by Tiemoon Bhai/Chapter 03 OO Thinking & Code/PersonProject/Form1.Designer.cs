namespace PersonProject
{
    partial class PersonUI
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
            this.showButton = new System.Windows.Forms.Button();
            this.firstName = new System.Windows.Forms.Label();
            this.middleName = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.Label();
            this.fullName = new System.Windows.Forms.Label();
            this.reverseName = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.middleNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.reverseNameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(429, 145);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(83, 25);
            this.showButton.TabIndex = 0;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // firstName
            // 
            this.firstName.AutoSize = true;
            this.firstName.Location = new System.Drawing.Point(66, 66);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(72, 16);
            this.firstName.TabIndex = 1;
            this.firstName.Text = "First Name";
            // 
            // middleName
            // 
            this.middleName.AutoSize = true;
            this.middleName.Location = new System.Drawing.Point(48, 106);
            this.middleName.Name = "middleName";
            this.middleName.Size = new System.Drawing.Size(88, 16);
            this.middleName.TabIndex = 2;
            this.middleName.Text = "Middle Name";
            // 
            // lastName
            // 
            this.lastName.AutoSize = true;
            this.lastName.Location = new System.Drawing.Point(64, 145);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(72, 16);
            this.lastName.TabIndex = 3;
            this.lastName.Text = "Last Name";
            // 
            // fullName
            // 
            this.fullName.AutoSize = true;
            this.fullName.Location = new System.Drawing.Point(68, 204);
            this.fullName.Name = "fullName";
            this.fullName.Size = new System.Drawing.Size(68, 16);
            this.fullName.TabIndex = 4;
            this.fullName.Text = "Full Name";
            // 
            // reverseName
            // 
            this.reverseName.AutoSize = true;
            this.reverseName.Location = new System.Drawing.Point(37, 238);
            this.reverseName.Name = "reverseName";
            this.reverseName.Size = new System.Drawing.Size(99, 16);
            this.reverseName.TabIndex = 5;
            this.reverseName.Text = "Reverse Name";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(158, 66);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(163, 22);
            this.firstNameTextBox.TabIndex = 6;
            // 
            // middleNameTextBox
            // 
            this.middleNameTextBox.Location = new System.Drawing.Point(158, 103);
            this.middleNameTextBox.Name = "middleNameTextBox";
            this.middleNameTextBox.Size = new System.Drawing.Size(163, 22);
            this.middleNameTextBox.TabIndex = 7;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(158, 145);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(163, 22);
            this.lastNameTextBox.TabIndex = 8;
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.Location = new System.Drawing.Point(158, 204);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.Size = new System.Drawing.Size(354, 22);
            this.fullNameTextBox.TabIndex = 9;
            // 
            // reverseNameTextBox
            // 
            this.reverseNameTextBox.Location = new System.Drawing.Point(158, 238);
            this.reverseNameTextBox.Name = "reverseNameTextBox";
            this.reverseNameTextBox.Size = new System.Drawing.Size(354, 22);
            this.reverseNameTextBox.TabIndex = 10;
            // 
            // PersonUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 360);
            this.Controls.Add(this.reverseNameTextBox);
            this.Controls.Add(this.fullNameTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.middleNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.reverseName);
            this.Controls.Add(this.fullName);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.middleName);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.showButton);
            this.Name = "PersonUI";
            this.Text = "Person\'s Name";
            this.Load += new System.EventHandler(this.PersonUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Label firstName;
        private System.Windows.Forms.Label middleName;
        private System.Windows.Forms.Label lastName;
        private System.Windows.Forms.Label fullName;
        private System.Windows.Forms.Label reverseName;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox middleNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox fullNameTextBox;
        private System.Windows.Forms.TextBox reverseNameTextBox;
    }
}

