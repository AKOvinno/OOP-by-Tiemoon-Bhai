using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WalkThrough2ConstructorExample
{
class Item
{
    public Item()
    {
        Console.WriteLine("This line has been executed");
    }

    public double GetUnitPriceAfterDiscount(double discountPercent)
    {
        double discountAmount = (UnitPrice * discountPercent) / 100.0;
        return UnitPrice - discountAmount;
    }

    public string Name { set; get; }
    public double UnitPrice { set; get; }
}
}
