namespace SolutionOfPractice2ShopApp
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
            this.saveShopButton = new System.Windows.Forms.Button();
            this.shopAddressTextBox = new System.Windows.Forms.TextBox();
            this.shopNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.addItemTextBox = new System.Windows.Forms.Button();
            this.itemQuantityTextBox = new System.Windows.Forms.TextBox();
            this.itemCodeTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.showButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.allItemListBox = new System.Windows.Forms.ListBox();
            this.noOfItemsShowTextBox = new System.Windows.Forms.TextBox();
            this.shopNameShowTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.saveShopButton);
            this.groupBox1.Controls.Add(this.shopAddressTextBox);
            this.groupBox1.Controls.Add(this.shopNameTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 117);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shop Information";
            // 
            // saveShopButton
            // 
            this.saveShopButton.Location = new System.Drawing.Point(200, 86);
            this.saveShopButton.Name = "saveShopButton";
            this.saveShopButton.Size = new System.Drawing.Size(75, 23);
            this.saveShopButton.TabIndex = 2;
            this.saveShopButton.Text = "Save";
            this.saveShopButton.UseVisualStyleBackColor = true;
            this.saveShopButton.Click += new System.EventHandler(this.saveShopButton_Click);
            // 
            // shopAddressTextBox
            // 
            this.shopAddressTextBox.Location = new System.Drawing.Point(82, 50);
            this.shopAddressTextBox.Multiline = true;
            this.shopAddressTextBox.Name = "shopAddressTextBox";
            this.shopAddressTextBox.Size = new System.Drawing.Size(193, 30);
            this.shopAddressTextBox.TabIndex = 1;
            // 
            // shopNameTextBox
            // 
            this.shopNameTextBox.Location = new System.Drawing.Point(81, 20);
            this.shopNameTextBox.Name = "shopNameTextBox";
            this.shopNameTextBox.Size = new System.Drawing.Size(194, 20);
            this.shopNameTextBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.addItemTextBox);
            this.groupBox2.Controls.Add(this.itemQuantityTextBox);
            this.groupBox2.Controls.Add(this.itemCodeTextBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 135);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(287, 117);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " Product Information";
            // 
            // addItemTextBox
            // 
            this.addItemTextBox.Location = new System.Drawing.Point(200, 78);
            this.addItemTextBox.Name = "addItemTextBox";
            this.addItemTextBox.Size = new System.Drawing.Size(75, 23);
            this.addItemTextBox.TabIndex = 2;
            this.addItemTextBox.Text = "Add";
            this.addItemTextBox.UseVisualStyleBackColor = true;
            this.addItemTextBox.Click += new System.EventHandler(this.addItemTextBox_Click);
            // 
            // itemQuantityTextBox
            // 
            this.itemQuantityTextBox.Location = new System.Drawing.Point(82, 52);
            this.itemQuantityTextBox.Name = "itemQuantityTextBox";
            this.itemQuantityTextBox.Size = new System.Drawing.Size(193, 20);
            this.itemQuantityTextBox.TabIndex = 1;
            this.itemQuantityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // itemCodeTextBox
            // 
            this.itemCodeTextBox.Location = new System.Drawing.Point(81, 20);
            this.itemCodeTextBox.Name = "itemCodeTextBox";
            this.itemCodeTextBox.Size = new System.Drawing.Size(194, 20);
            this.itemCodeTextBox.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Code";
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(161, 204);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(114, 23);
            this.showButton.TabIndex = 5;
            this.showButton.Text = "Show Report";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.allItemListBox);
            this.groupBox3.Controls.Add(this.noOfItemsShowTextBox);
            this.groupBox3.Controls.Add(this.shopNameShowTextBox);
            this.groupBox3.Controls.Add(this.showButton);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(311, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(287, 240);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Report";
            // 
            // allItemListBox
            // 
            this.allItemListBox.FormattingEnabled = true;
            this.allItemListBox.Location = new System.Drawing.Point(81, 77);
            this.allItemListBox.Name = "allItemListBox";
            this.allItemListBox.Size = new System.Drawing.Size(194, 121);
            this.allItemListBox.TabIndex = 2;
            // 
            // noOfItemsShowTextBox
            // 
            this.noOfItemsShowTextBox.Location = new System.Drawing.Point(82, 50);
            this.noOfItemsShowTextBox.Name = "noOfItemsShowTextBox";
            this.noOfItemsShowTextBox.Size = new System.Drawing.Size(193, 20);
            this.noOfItemsShowTextBox.TabIndex = 1;
            // 
            // shopNameShowTextBox
            // 
            this.shopNameShowTextBox.Location = new System.Drawing.Point(81, 20);
            this.shopNameShowTextBox.Name = "shopNameShowTextBox";
            this.shopNameShowTextBox.Size = new System.Drawing.Size(194, 20);
            this.shopNameShowTextBox.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "No of Products";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Name";
            // 
            // ShopUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 264);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "ShopUI";
            this.Text = "Shop";
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
        private System.Windows.Forms.Button saveShopButton;
        private System.Windows.Forms.TextBox shopAddressTextBox;
        private System.Windows.Forms.TextBox shopNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button addItemTextBox;
        private System.Windows.Forms.TextBox itemQuantityTextBox;
        private System.Windows.Forms.TextBox itemCodeTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox noOfItemsShowTextBox;
        private System.Windows.Forms.TextBox shopNameShowTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox allItemListBox;
    }
}

