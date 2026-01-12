using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StationaryShopManagement
{
    public partial class ShopUI : Form
    {
        private Shop aShop;

        public ShopUI()
        {
            InitializeComponent();
            productListForSaleComboBox.DisplayMember = "Name";
            productListForPurchaseComboBox.DisplayMember = "Name";
            productListForDamangeComboBox.DisplayMember = "Name";
        }

        private void saveProductInfo_Click(object sender, EventArgs e)
        {
            Product aProduct = new Product();
            aProduct.Name = productNameTextBox.Text;
            aProduct.Code = productCodeTextBox.Text;
            aProduct.UnitPrice = Convert.ToDouble(productUnitPriceTextBox.Text);
            string msg = aShop.EnlistProduct(aProduct);
            productListForSaleComboBox.Items.Add(aProduct);
            productListForPurchaseComboBox.Items.Add(aProduct);
            productListForDamangeComboBox.Items.Add(aProduct);
            ReloadAllDisplayInformation();
            MessageBox.Show(msg);
        }

        private void ReloadAllDisplayInformation()
        {
            ReloadTotalNoOfProduct();
            ReloadTotalQuantity();
            ReloadInventoryDisplay();
        }

        private void ReloadTotalNoOfProduct()
        {
            totalProductLabel.Text = "Total Product: " + aShop.CountTotalProduct().ToString();
        }

        private void ReloadTotalQuantity()
        {
            totalQuantityLabel.Text = "Total Quantity: " + aShop.CountProductsQuantity().ToString();
        }


        private void shopInfoSaveButton_Click(object sender, EventArgs e)
        {
            aShop = new Shop(shopNameTextBox.Text, operatingHoursTextBox.Text);
            shopNameLabel.Text = aShop.Name;
            shopOpenLabel.Text = "Open: " + aShop.OperatingHours;
            MessageBox.Show("Shop Information has been saved.");
        }

        private void productSellButton_Click(object sender, EventArgs e)
        {
            Sale aSale = new Sale();
            aSale.Product = (Product)productListForSaleComboBox.SelectedItem;
            aSale.Quantity = Convert.ToInt16(saleQuantityTextBox.Text);
            aSale.OperationDate = saleDateDateTimePicker.Value;
            aSale.TotalAmount = Convert.ToDouble(totalAmountTextBox.Text);
            string msg = aShop.AddSale(aSale);
            ReloadAllDisplayInformation();
            MessageBox.Show(msg);
        }

        private void showDailySalesReportButton_Click(object sender, EventArgs e)
        {
            DateTime operationDate = dailyOperationReportDateTimePicker.Value;
            dailyReportListBox.Items.Clear();
            if (purchaseRadioButton.Checked)
            {
                ShowPurchaseList(operationDate);
            }
            else if (SaleRadioButton.Checked)
            {
                ShowSalesList(operationDate);
            }
            else if (damageRadioButton.Checked)
            {
                ShowDamageList(operationDate);
            }
        }

        private void ShowSalesList(DateTime operationDate)
        {
            List<Sale> salesListOfADate = aShop.GetSalesOfADate(operationDate);
            dailyReportListBox.Items.Add("Name || Code || Quantity || Total Amount");
            foreach (Sale aSale in salesListOfADate)
            {
                dailyReportListBox.Items.Add(aSale.GetBasicInfo());
            }
        }

        private void ShowPurchaseList(DateTime operationDate)
        {
            List<Purchase> purchaseListOfADate = aShop.GetPurchaseOfADate(operationDate);
            dailyReportListBox.Items.Add("Vendor || Name || Code || Quantity");
            foreach (Purchase aPurchase in purchaseListOfADate)
            {
                dailyReportListBox.Items.Add(aPurchase.GetBasicInfo());
            }
        }

        private void ShowDamageList(DateTime operationDate)
        {
            List<Damage> damageListOfADate = aShop.GetDamageOfADate(operationDate);
            dailyReportListBox.Items.Add("Name || Code || Quantity || Cause");
            foreach (Damage aDamage in damageListOfADate)
            {
                dailyReportListBox.Items.Add(aDamage.GetBasicInfo());
            }
        }

        private void purchaseButton_Click(object sender, EventArgs e)
        {
            Purchase aPurchase = new Purchase();
            aPurchase.Product = (Product)productListForPurchaseComboBox.SelectedItem;
            aPurchase.Quantity = Convert.ToInt16(purchaseQuantityTextBox.Text);
            aPurchase.OperationDate = purchaseDateDateTimePicker.Value;
            aPurchase.VendorName = vendorNameTextBox.Text;
            string msg = aShop.AddPurchase(aPurchase);
            ReloadAllDisplayInformation();
            MessageBox.Show(msg);
        }

        private void ReloadInventoryDisplay()
        {
            productInventoryListBox.Items.Clear();
            productInventoryListBox.Items.Add("Name ।। Code || Quantity");
            foreach (Product aProduct in aShop.ProductList)
            {
                string info = aProduct.Name + " || " + 
                    aProduct.Code + " || " + aProduct.Quantity;
                productInventoryListBox.Items.Add(info);
            }
        }

        private void damageButton_Click(object sender, EventArgs e)
        {
            Damage aDamage = new Damage();
            aDamage.Product = (Product)productListForDamangeComboBox.SelectedItem;
            aDamage.OperationDate = damageDateDateTimePicker.Value;
            aDamage.Quantity = Convert.ToInt16(damageQuantityTextBox.Text);
            aDamage.CauseOfDamage = couseOfDamageTextBox.Text;
            string msg = aShop.AddDamage(aDamage);
            ReloadInventoryDisplay();
            MessageBox.Show(msg);
        }

        private void ShopUI_Load(object sender, EventArgs e)
        {

        }
    }
}
