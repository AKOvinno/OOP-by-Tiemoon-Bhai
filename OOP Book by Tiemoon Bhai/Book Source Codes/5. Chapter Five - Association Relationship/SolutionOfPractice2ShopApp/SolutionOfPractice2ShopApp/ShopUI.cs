using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolutionOfPractice2ShopApp
{
    public partial class ShopUI : Form
    {
        Shop aShop = new Shop();
        public ShopUI()
        {
            InitializeComponent();
        }

        private void saveShopButton_Click(object sender, EventArgs e)
        {
            aShop.Name = shopNameTextBox.Text;
            aShop.Address = addItemTextBox.Text;
            MessageBox.Show("Shop info has been saved.");
        }

        private void addItemTextBox_Click(object sender, EventArgs e)
        {
            Product aProduct = new Product();
            aProduct.Code = itemCodeTextBox.Text;
            aProduct.Quantity = Convert.ToInt16(itemQuantityTextBox.Text);
            aShop.Products.Add(aProduct);
            MessageBox.Show("Item has been added");
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            shopNameShowTextBox.Text = aShop.Name;
            noOfItemsShowTextBox.Text = aShop.Products.Count.ToString();
            allItemListBox.Items.Clear();
            foreach (Product aProduct in aShop.Products)
            {
                string info = aProduct.Code + " : " + aProduct.Quantity;
                allItemListBox.Items.Add(info);
            }
        }
    }
}
