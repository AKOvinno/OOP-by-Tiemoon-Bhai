namespace FastBankSolution
{
    partial class FastBankSolutionUI
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.TypeEntryComboBox = new System.Windows.Forms.ComboBox();
            this.AccountNumberEntryTextBox = new System.Windows.Forms.TextBox();
            this.EmailEntryTextBox = new System.Windows.Forms.TextBox();
            this.CustomerNameEntryTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TypeShowTextBox = new System.Windows.Forms.TextBox();
            this.ShowDetailsButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.BalanceInBDTShowTextBox = new System.Windows.Forms.TextBox();
            this.AccountNoShowTextBox = new System.Windows.Forms.TextBox();
            this.EmailShowTextBox = new System.Windows.Forms.TextBox();
            this.CustomerNameShowTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.WithdrawButton = new System.Windows.Forms.Button();
            this.DepositButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.AmountEntryTextBox = new System.Windows.Forms.TextBox();
            this.BalanceInUSDShowTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SaveButton);
            this.groupBox1.Controls.Add(this.TypeEntryComboBox);
            this.groupBox1.Controls.Add(this.AccountNumberEntryTextBox);
            this.groupBox1.Controls.Add(this.EmailEntryTextBox);
            this.groupBox1.Controls.Add(this.CustomerNameEntryTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(429, 273);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create Bank Account";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(263, 202);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(99, 29);
            this.SaveButton.TabIndex = 8;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // TypeEntryComboBox
            // 
            this.TypeEntryComboBox.FormattingEnabled = true;
            this.TypeEntryComboBox.Location = new System.Drawing.Point(119, 159);
            this.TypeEntryComboBox.Name = "TypeEntryComboBox";
            this.TypeEntryComboBox.Size = new System.Drawing.Size(243, 24);
            this.TypeEntryComboBox.TabIndex = 7;
            this.TypeEntryComboBox.SelectedIndexChanged += new System.EventHandler(this.TypeEntryComboBox_SelectedIndexChanged);
            // 
            // AccountNumberEntryTextBox
            // 
            this.AccountNumberEntryTextBox.Location = new System.Drawing.Point(118, 123);
            this.AccountNumberEntryTextBox.Name = "AccountNumberEntryTextBox";
            this.AccountNumberEntryTextBox.Size = new System.Drawing.Size(244, 22);
            this.AccountNumberEntryTextBox.TabIndex = 6;
            // 
            // EmailEntryTextBox
            // 
            this.EmailEntryTextBox.Location = new System.Drawing.Point(119, 72);
            this.EmailEntryTextBox.Name = "EmailEntryTextBox";
            this.EmailEntryTextBox.Size = new System.Drawing.Size(244, 22);
            this.EmailEntryTextBox.TabIndex = 5;
            // 
            // CustomerNameEntryTextBox
            // 
            this.CustomerNameEntryTextBox.Location = new System.Drawing.Point(119, 44);
            this.CustomerNameEntryTextBox.Name = "CustomerNameEntryTextBox";
            this.CustomerNameEntryTextBox.Size = new System.Drawing.Size(244, 22);
            this.CustomerNameEntryTextBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Account Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.BalanceInUSDShowTextBox);
            this.groupBox2.Controls.Add(this.TypeShowTextBox);
            this.groupBox2.Controls.Add(this.ShowDetailsButton);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.BalanceInBDTShowTextBox);
            this.groupBox2.Controls.Add(this.AccountNoShowTextBox);
            this.groupBox2.Controls.Add(this.EmailShowTextBox);
            this.groupBox2.Controls.Add(this.CustomerNameShowTextBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(447, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(390, 426);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Report";
            // 
            // TypeShowTextBox
            // 
            this.TypeShowTextBox.Location = new System.Drawing.Point(140, 187);
            this.TypeShowTextBox.Name = "TypeShowTextBox";
            this.TypeShowTextBox.Size = new System.Drawing.Size(244, 22);
            this.TypeShowTextBox.TabIndex = 19;
            // 
            // ShowDetailsButton
            // 
            this.ShowDetailsButton.Location = new System.Drawing.Point(140, 31);
            this.ShowDetailsButton.Name = "ShowDetailsButton";
            this.ShowDetailsButton.Size = new System.Drawing.Size(243, 29);
            this.ShowDetailsButton.TabIndex = 18;
            this.ShowDetailsButton.Text = "Show Details";
            this.ShowDetailsButton.UseVisualStyleBackColor = true;
            this.ShowDetailsButton.Click += new System.EventHandler(this.ShowDetailsButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 279);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "Balance";
            // 
            // BalanceInBDTShowTextBox
            // 
            this.BalanceInBDTShowTextBox.Location = new System.Drawing.Point(30, 308);
            this.BalanceInBDTShowTextBox.Name = "BalanceInBDTShowTextBox";
            this.BalanceInBDTShowTextBox.Size = new System.Drawing.Size(167, 22);
            this.BalanceInBDTShowTextBox.TabIndex = 16;
            // 
            // AccountNoShowTextBox
            // 
            this.AccountNoShowTextBox.Location = new System.Drawing.Point(139, 151);
            this.AccountNoShowTextBox.Name = "AccountNoShowTextBox";
            this.AccountNoShowTextBox.Size = new System.Drawing.Size(244, 22);
            this.AccountNoShowTextBox.TabIndex = 14;
            // 
            // EmailShowTextBox
            // 
            this.EmailShowTextBox.Location = new System.Drawing.Point(140, 100);
            this.EmailShowTextBox.Name = "EmailShowTextBox";
            this.EmailShowTextBox.Size = new System.Drawing.Size(244, 22);
            this.EmailShowTextBox.TabIndex = 13;
            // 
            // CustomerNameShowTextBox
            // 
            this.CustomerNameShowTextBox.Location = new System.Drawing.Point(140, 72);
            this.CustomerNameShowTextBox.Name = "CustomerNameShowTextBox";
            this.CustomerNameShowTextBox.Size = new System.Drawing.Size(244, 22);
            this.CustomerNameShowTextBox.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(95, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Account Number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(93, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "Customer Name";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.WithdrawButton);
            this.groupBox3.Controls.Add(this.DepositButton);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.AmountEntryTextBox);
            this.groupBox3.Location = new System.Drawing.Point(12, 291);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(429, 147);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Transaction";
            // 
            // WithdrawButton
            // 
            this.WithdrawButton.Location = new System.Drawing.Point(198, 60);
            this.WithdrawButton.Name = "WithdrawButton";
            this.WithdrawButton.Size = new System.Drawing.Size(121, 29);
            this.WithdrawButton.TabIndex = 21;
            this.WithdrawButton.Text = "Withdraw";
            this.WithdrawButton.UseVisualStyleBackColor = true;
            this.WithdrawButton.Click += new System.EventHandler(this.WithdrawButton_Click);
            // 
            // DepositButton
            // 
            this.DepositButton.Location = new System.Drawing.Point(75, 60);
            this.DepositButton.Name = "DepositButton";
            this.DepositButton.Size = new System.Drawing.Size(117, 29);
            this.DepositButton.TabIndex = 20;
            this.DepositButton.Text = "Deposite";
            this.DepositButton.UseVisualStyleBackColor = true;
            this.DepositButton.Click += new System.EventHandler(this.DepositButton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "Amount";
            // 
            // AmountEntryTextBox
            // 
            this.AmountEntryTextBox.Location = new System.Drawing.Point(75, 32);
            this.AmountEntryTextBox.Name = "AmountEntryTextBox";
            this.AmountEntryTextBox.Size = new System.Drawing.Size(244, 22);
            this.AmountEntryTextBox.TabIndex = 18;
            // 
            // BalanceInUSDShowTextBox
            // 
            this.BalanceInUSDShowTextBox.Location = new System.Drawing.Point(30, 342);
            this.BalanceInUSDShowTextBox.Name = "BalanceInUSDShowTextBox";
            this.BalanceInUSDShowTextBox.Size = new System.Drawing.Size(167, 22);
            this.BalanceInUSDShowTextBox.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(203, 311);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 16);
            this.label11.TabIndex = 21;
            this.label11.Text = "in BDT";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(203, 345);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(164, 16);
            this.label12.TabIndex = 22;
            this.label12.Text = "in USD (1 USD = 120 BDT)";
            // 
            // FastBankSolutionUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 484);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FastBankSolutionUI";
            this.Text = "Fast Bank Solution";
            this.Load += new System.EventHandler(this.FastBankSolutionUI_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.ComboBox TypeEntryComboBox;
        private System.Windows.Forms.TextBox AccountNumberEntryTextBox;
        private System.Windows.Forms.TextBox EmailEntryTextBox;
        private System.Windows.Forms.TextBox CustomerNameEntryTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ShowDetailsButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox BalanceInBDTShowTextBox;
        private System.Windows.Forms.TextBox AccountNoShowTextBox;
        private System.Windows.Forms.TextBox EmailShowTextBox;
        private System.Windows.Forms.TextBox CustomerNameShowTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button WithdrawButton;
        private System.Windows.Forms.Button DepositButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox AmountEntryTextBox;
        private System.Windows.Forms.TextBox TypeShowTextBox;
        private System.Windows.Forms.TextBox BalanceInUSDShowTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
    }
}

