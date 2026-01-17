using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopManagementSystem
{
    public partial class ShopUI : Form
    {
        Shop aShop = new Shop();
        public ShopUI()
        {
            InitializeComponent();
        }

        private void ShopUI_Load(object sender, EventArgs e)
        {

        }

        private void ShopSaveButton_Click(object sender, EventArgs e)
        {
            aShop.Name = NameEntryTextBox.Text;
            aShop.Address = AddressEntryTextBox.Text;
            MessageBox.Show("Shop had been saved.");
        }

        private void ProductAddButton_Click(object sender, EventArgs e)
        {
            Product aProduct = new Product();
            aProduct.Code = ProductCodeEntryTextBox.Text;
            aProduct.Quantity = ProductQuantityEntryTextBox.Text;
            aShop.ProductList.Add(aProduct);
            MessageBox.Show("Product has been saved.");
        }

        private void ShowReportButton_Click(object sender, EventArgs e)
        {
            NameShowTextBox.Text = aShop.Name;
            NoOfProductsShowTextBox.Text = aShop.ProductList.Count.ToString();
            string ProductList = "Product Code\tQuantity\n";
            foreach(Product product in aShop.ProductList)
            {
                ProductList += (product.Code + "\t\t" + product.Quantity + "\n");
            }
            ProductListShowTextBox.Text = ProductList;
        }
    }
}
