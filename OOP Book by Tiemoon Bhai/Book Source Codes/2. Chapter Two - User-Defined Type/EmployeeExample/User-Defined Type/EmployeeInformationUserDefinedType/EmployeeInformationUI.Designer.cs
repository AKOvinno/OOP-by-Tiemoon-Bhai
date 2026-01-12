namespace EmployeeInformationUserDefinedType
{
    partial class EmployeeInformationUI
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
            this.saveAndClearButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.salaryTextBox = new System.Windows.Forms.TextBox();
            this.showSavedDataButton = new System.Windows.Forms.Button();
            this.isPunctualButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // saveAndClearButton
            // 
            this.saveAndClearButton.Location = new System.Drawing.Point(32, 99);
            this.saveAndClearButton.Name = "saveAndClearButton";
            this.saveAndClearButton.Size = new System.Drawing.Size(111, 23);
            this.saveAndClearButton.TabIndex = 3;
            this.saveAndClearButton.Text = "Save and Clear";
            this.saveAndClearButton.UseVisualStyleBackColor = true;
            this.saveAndClearButton.Click += new System.EventHandler(this.saveAndClearButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Salary Amount";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(110, 9);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(166, 20);
            this.idTextBox.TabIndex = 0;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(110, 33);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(166, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // salaryTextBox
            // 
            this.salaryTextBox.Location = new System.Drawing.Point(110, 58);
            this.salaryTextBox.Name = "salaryTextBox";
            this.salaryTextBox.Size = new System.Drawing.Size(100, 20);
            this.salaryTextBox.TabIndex = 2;
            // 
            // showSavedDataButton
            // 
            this.showSavedDataButton.Location = new System.Drawing.Point(159, 99);
            this.showSavedDataButton.Name = "showSavedDataButton";
            this.showSavedDataButton.Size = new System.Drawing.Size(105, 23);
            this.showSavedDataButton.TabIndex = 4;
            this.showSavedDataButton.Text = "Show Saved Data";
            this.showSavedDataButton.UseVisualStyleBackColor = true;
            this.showSavedDataButton.Click += new System.EventHandler(this.showSavedDataButton_Click);
            // 
            // isPunctualButton
            // 
            this.isPunctualButton.Location = new System.Drawing.Point(32, 129);
            this.isPunctualButton.Name = "isPunctualButton";
            this.isPunctualButton.Size = new System.Drawing.Size(232, 23);
            this.isPunctualButton.TabIndex = 5;
            this.isPunctualButton.Text = "Is this employee punctual?";
            this.isPunctualButton.UseVisualStyleBackColor = true;
            this.isPunctualButton.Click += new System.EventHandler(this.isPunctualButton_Click);
            // 
            // EmployeeInformationUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 166);
            this.Controls.Add(this.isPunctualButton);
            this.Controls.Add(this.salaryTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showSavedDataButton);
            this.Controls.Add(this.saveAndClearButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EmployeeInformationUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveAndClearButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox salaryTextBox;
        private System.Windows.Forms.Button showSavedDataButton;
        private System.Windows.Forms.Button isPunctualButton;
    }
}

