using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationaryShopManagement
{
class Shop
{
    public string Name { set; get; }
    public string OperatingHours { set; get; }
    public List<Product> ProductList { set; get; }
    public List<Purchase> PurchaseList { set; get; }
    public List<Sale> SalesList { set; get; }
    public List<Damage> DamageList { set; get; }
        
        public Shop(string name, string operationalTime) :this()
        {
            Name = name;
            OperatingHours = operationalTime;
        }
        public Shop()
        {
            ProductList = new List<Product>();
            PurchaseList = new List<Purchase>();
            SalesList = new List<Sale>();
            DamageList = new List<Damage>();
        }

        internal string AddPurchase(Purchase aPurchase)
        {
            foreach (Product aProduct in ProductList)
            {
                if (aProduct.Code == aPurchase.Product.Code)
                {
                    aProduct.Quantity += aPurchase.Quantity;
                }
            }
            PurchaseList.Add(aPurchase);
            return "Purchase information has been updated.";
        }
        public string EnlistProduct(Product aProduct)
        {
            foreach(Product product1 in ProductList)
            {
                if (product1.Code == aProduct.Code)
                {
                    return "Product code is already enlisted.";
                }
                else if (product1.Name == aProduct.Name)
                {
                    return "Product name is already enlisted.";
                }
            }
            ProductList.Add(aProduct);
            return "Product is enlisted.";
        }

        public string AddSale(Sale aSale)
        {
            foreach (Product aProduct in ProductList)
            {
                if (aProduct.Code == aSale.Product.Code)
                {
                    if (aProduct.Quantity >= aSale.Quantity)
                    {
                        aProduct.Quantity -= aSale.Quantity;
                    }
                    else
                    {
                        return "Sorry, you have not enough quantity to sell";
                    }
                }
            }
            SalesList.Add(aSale);
            return "Sales information has been updated.";
        }

        public string AddDamage(Damage aDamage)
        {
            foreach (Product aProduct in ProductList)
            {
                if (aProduct.Code == aDamage.Product.Code)
                {
                    if (aProduct.Quantity >= aDamage.Quantity)
                    {
                        aProduct.Quantity -= aDamage.Quantity;
                    }
                    else
                    {
                        return "Sorry, you have not enough quantity to record damage info of this product";
                    }
                }
            }
            DamageList.Add(aDamage);
            return "Damage information has been recorded.";
        }



        public int CountTotalProduct()
        {
            return ProductList.Count;
        }

        public  int CountProductsQuantity()
        {
            int totalQuantity = 0;
            foreach (Product aProduct in ProductList)
            {
                totalQuantity += aProduct.Quantity;
            }
            return totalQuantity;
        }

        public List<Sale> GetSalesOfADate(DateTime saleDate)
        {
            List<Sale> salesListOfADate = new List<Sale>();
            foreach (Sale aSale in SalesList)
            {
                if (aSale.OperationDate.Date == saleDate.Date)
                {
                    salesListOfADate.Add(aSale);
                }
            }
            return salesListOfADate;
        }

        public List<Purchase> GetPurchaseOfADate(DateTime purchaseDate)
        {
            List<Purchase> purchaseListOfADate = new List<Purchase>();
            foreach (Purchase aPurchase in PurchaseList)
            {
                if (aPurchase.OperationDate.Date == purchaseDate.Date)
                {
                    purchaseListOfADate.Add(aPurchase);
                }
            }
            return purchaseListOfADate;
        }

        public List<Damage> GetDamageOfADate(DateTime damageDate)
        {
            List<Damage> damageListOfADate = new List<Damage>();
            foreach (Damage aDamage in DamageList)
            {
                if (aDamage.OperationDate.Date == damageDate.Date)
                {
                    damageListOfADate.Add(aDamage);
                }
            }
            return damageListOfADate;
        }
    }
}
