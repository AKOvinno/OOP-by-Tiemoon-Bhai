namespace BankManagementSystem
{
    partial class BankAccountUI
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
            this.AccountCreationGroupBox = new System.Windows.Forms.GroupBox();
            this.TransactionGroupBox = new System.Windows.Forms.GroupBox();
            this.ReportButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AccountNumberTextBox = new System.Windows.Forms.TextBox();
            this.AccountHolderNameTextBox = new System.Windows.Forms.TextBox();
            this.AmountTextBox = new System.Windows.Forms.TextBox();
            this.CreateButton = new System.Windows.Forms.Button();
            this.DepositButton = new System.Windows.Forms.Button();
            this.WithdrawButton = new System.Windows.Forms.Button();
            this.AccountCreationGroupBox.SuspendLayout();
            this.TransactionGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // AccountCreationGroupBox
            // 
            this.AccountCreationGroupBox.Controls.Add(this.CreateButton);
            this.AccountCreationGroupBox.Controls.Add(this.AccountHolderNameTextBox);
            this.AccountCreationGroupBox.Controls.Add(this.AccountNumberTextBox);
            this.AccountCreationGroupBox.Controls.Add(this.label2);
            this.AccountCreationGroupBox.Controls.Add(this.label1);
            this.AccountCreationGroupBox.Location = new System.Drawing.Point(48, 39);
            this.AccountCreationGroupBox.Name = "AccountCreationGroupBox";
            this.AccountCreationGroupBox.Size = new System.Drawing.Size(680, 153);
            this.AccountCreationGroupBox.TabIndex = 0;
            this.AccountCreationGroupBox.TabStop = false;
            this.AccountCreationGroupBox.Text = "Account Creation";
            // 
            // TransactionGroupBox
            // 
            this.TransactionGroupBox.Controls.Add(this.WithdrawButton);
            this.TransactionGroupBox.Controls.Add(this.DepositButton);
            this.TransactionGroupBox.Controls.Add(this.AmountTextBox);
            this.TransactionGroupBox.Controls.Add(this.label3);
            this.TransactionGroupBox.Location = new System.Drawing.Point(48, 210);
            this.TransactionGroupBox.Name = "TransactionGroupBox";
            this.TransactionGroupBox.Size = new System.Drawing.Size(680, 146);
            this.TransactionGroupBox.TabIndex = 1;
            this.TransactionGroupBox.TabStop = false;
            this.TransactionGroupBox.Text = "Transaction";
            // 
            // ReportButton
            // 
            this.ReportButton.Location = new System.Drawing.Point(285, 374);
            this.ReportButton.Name = "ReportButton";
            this.ReportButton.Size = new System.Drawing.Size(183, 37);
            this.ReportButton.TabIndex = 2;
            this.ReportButton.Text = "Report";
            this.ReportButton.UseVisualStyleBackColor = true;
            this.ReportButton.Click += new System.EventHandler(this.ReportButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Holder Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(179, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Amount";
            // 
            // AccountNumberTextBox
            // 
            this.AccountNumberTextBox.Location = new System.Drawing.Point(237, 50);
            this.AccountNumberTextBox.Name = "AccountNumberTextBox";
            this.AccountNumberTextBox.Size = new System.Drawing.Size(310, 22);
            this.AccountNumberTextBox.TabIndex = 2;
            // 
            // AccountHolderNameTextBox
            // 
            this.AccountHolderNameTextBox.Location = new System.Drawing.Point(237, 82);
            this.AccountHolderNameTextBox.Name = "AccountHolderNameTextBox";
            this.AccountHolderNameTextBox.Size = new System.Drawing.Size(310, 22);
            this.AccountHolderNameTextBox.TabIndex = 3;
            // 
            // AmountTextBox
            // 
            this.AmountTextBox.Location = new System.Drawing.Point(237, 54);
            this.AmountTextBox.Name = "AmountTextBox";
            this.AmountTextBox.Size = new System.Drawing.Size(310, 22);
            this.AmountTextBox.TabIndex = 3;
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(432, 110);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(115, 27);
            this.CreateButton.TabIndex = 4;
            this.CreateButton.Text = "Create";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // DepositButton
            // 
            this.DepositButton.Location = new System.Drawing.Point(237, 82);
            this.DepositButton.Name = "DepositButton";
            this.DepositButton.Size = new System.Drawing.Size(157, 27);
            this.DepositButton.TabIndex = 5;
            this.DepositButton.Text = "Deposit";
            this.DepositButton.UseVisualStyleBackColor = true;
            this.DepositButton.Click += new System.EventHandler(this.DepositButton_Click);
            // 
            // WithdrawButton
            // 
            this.WithdrawButton.Location = new System.Drawing.Point(400, 82);
            this.WithdrawButton.Name = "WithdrawButton";
            this.WithdrawButton.Size = new System.Drawing.Size(147, 27);
            this.WithdrawButton.TabIndex = 6;
            this.WithdrawButton.Text = "Withdraw";
            this.WithdrawButton.UseVisualStyleBackColor = true;
            this.WithdrawButton.Click += new System.EventHandler(this.WithdrawButton_Click);
            // 
            // BankAccountUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ReportButton);
            this.Controls.Add(this.TransactionGroupBox);
            this.Controls.Add(this.AccountCreationGroupBox);
            this.Name = "BankAccountUI";
            this.Text = "Bank Account";
            this.AccountCreationGroupBox.ResumeLayout(false);
            this.AccountCreationGroupBox.PerformLayout();
            this.TransactionGroupBox.ResumeLayout(false);
            this.TransactionGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox AccountCreationGroupBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox TransactionGroupBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ReportButton;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.TextBox AccountHolderNameTextBox;
        private System.Windows.Forms.TextBox AccountNumberTextBox;
        private System.Windows.Forms.Button WithdrawButton;
        private System.Windows.Forms.Button DepositButton;
        private System.Windows.Forms.TextBox AmountTextBox;
    }
}

