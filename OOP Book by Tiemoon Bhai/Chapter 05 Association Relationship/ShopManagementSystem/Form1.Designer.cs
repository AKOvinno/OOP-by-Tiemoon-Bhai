namespace ShopManagementSystem
{
    partial class ShopUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NameShowTextBox = new System.Windows.Forms.TextBox();
            this.NoOfProductsShowTextBox = new System.Windows.Forms.TextBox();
            this.ProductListShowTextBox = new System.Windows.Forms.RichTextBox();
            this.ShowReportButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.NameEntryTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AddressEntryTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ShopSaveButton = new System.Windows.Forms.Button();
            this.ProductAddButton = new System.Windows.Forms.Button();
            this.ProductQuantityEntryTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ProductCodeEntryTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ShowReportButton);
            this.groupBox1.Controls.Add(this.ProductListShowTextBox);
            this.groupBox1.Controls.Add(this.NoOfProductsShowTextBox);
            this.groupBox1.Controls.Add(this.NameShowTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(402, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 431);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Report";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "No of Products";
            // 
            // NameShowTextBox
            // 
            this.NameShowTextBox.Location = new System.Drawing.Point(107, 53);
            this.NameShowTextBox.Name = "NameShowTextBox";
            this.NameShowTextBox.Size = new System.Drawing.Size(268, 22);
            this.NameShowTextBox.TabIndex = 2;
            // 
            // NoOfProductsShowTextBox
            // 
            this.NoOfProductsShowTextBox.Location = new System.Drawing.Point(107, 83);
            this.NoOfProductsShowTextBox.Name = "NoOfProductsShowTextBox";
            this.NoOfProductsShowTextBox.Size = new System.Drawing.Size(268, 22);
            this.NoOfProductsShowTextBox.TabIndex = 3;
            // 
            // ProductListShowTextBox
            // 
            this.ProductListShowTextBox.Location = new System.Drawing.Point(107, 122);
            this.ProductListShowTextBox.Name = "ProductListShowTextBox";
            this.ProductListShowTextBox.Size = new System.Drawing.Size(267, 222);
            this.ProductListShowTextBox.TabIndex = 4;
            this.ProductListShowTextBox.Text = "";
            // 
            // ShowReportButton
            // 
            this.ShowReportButton.Location = new System.Drawing.Point(214, 350);
            this.ShowReportButton.Name = "ShowReportButton";
            this.ShowReportButton.Size = new System.Drawing.Size(160, 36);
            this.ShowReportButton.TabIndex = 5;
            this.ShowReportButton.Text = "Show Report";
            this.ShowReportButton.UseVisualStyleBackColor = true;
            this.ShowReportButton.Click += new System.EventHandler(this.ShowReportButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ShopSaveButton);
            this.groupBox2.Controls.Add(this.AddressEntryTextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.NameEntryTextBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(7, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(389, 206);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Shop Information";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ProductAddButton);
            this.groupBox3.Controls.Add(this.ProductQuantityEntryTextBox);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.ProductCodeEntryTextBox);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(7, 219);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(389, 219);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Product Information";
            // 
            // NameEntryTextBox
            // 
            this.NameEntryTextBox.Location = new System.Drawing.Point(89, 53);
            this.NameEntryTextBox.Name = "NameEntryTextBox";
            this.NameEntryTextBox.Size = new System.Drawing.Size(268, 22);
            this.NameEntryTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name";
            // 
            // AddressEntryTextBox
            // 
            this.AddressEntryTextBox.Location = new System.Drawing.Point(89, 83);
            this.AddressEntryTextBox.Name = "AddressEntryTextBox";
            this.AddressEntryTextBox.Size = new System.Drawing.Size(268, 22);
            this.AddressEntryTextBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Address";
            // 
            // ShopSaveButton
            // 
            this.ShopSaveButton.Location = new System.Drawing.Point(253, 122);
            this.ShopSaveButton.Name = "ShopSaveButton";
            this.ShopSaveButton.Size = new System.Drawing.Size(104, 36);
            this.ShopSaveButton.TabIndex = 7;
            this.ShopSaveButton.Text = "Save";
            this.ShopSaveButton.UseVisualStyleBackColor = true;
            this.ShopSaveButton.Click += new System.EventHandler(this.ShopSaveButton_Click);
            // 
            // ProductAddButton
            // 
            this.ProductAddButton.Location = new System.Drawing.Point(253, 117);
            this.ProductAddButton.Name = "ProductAddButton";
            this.ProductAddButton.Size = new System.Drawing.Size(104, 36);
            this.ProductAddButton.TabIndex = 12;
            this.ProductAddButton.Text = "Add";
            this.ProductAddButton.UseVisualStyleBackColor = true;
            this.ProductAddButton.Click += new System.EventHandler(this.ProductAddButton_Click);
            // 
            // ProductQuantityEntryTextBox
            // 
            this.ProductQuantityEntryTextBox.Location = new System.Drawing.Point(89, 78);
            this.ProductQuantityEntryTextBox.Name = "ProductQuantityEntryTextBox";
            this.ProductQuantityEntryTextBox.Size = new System.Drawing.Size(268, 22);
            this.ProductQuantityEntryTextBox.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Quantity";
            // 
            // ProductCodeEntryTextBox
            // 
            this.ProductCodeEntryTextBox.Location = new System.Drawing.Point(89, 48);
            this.ProductCodeEntryTextBox.Name = "ProductCodeEntryTextBox";
            this.ProductCodeEntryTextBox.Size = new System.Drawing.Size(268, 22);
            this.ProductCodeEntryTextBox.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Code";
            // 
            // ShopUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ShopUI";
            this.Text = "Shop";
            this.Load += new System.EventHandler(this.ShopUI_Load);
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
        private System.Windows.Forms.Button ShowReportButton;
        private System.Windows.Forms.RichTextBox ProductListShowTextBox;
        private System.Windows.Forms.TextBox NoOfProductsShowTextBox;
        private System.Windows.Forms.TextBox NameShowTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ShopSaveButton;
        private System.Windows.Forms.TextBox AddressEntryTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NameEntryTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button ProductAddButton;
        private System.Windows.Forms.TextBox ProductQuantityEntryTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ProductCodeEntryTextBox;
        private System.Windows.Forms.Label label6;
    }
}

