using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparableExample
{
class Book : IComparable
{
    public string Title { set; get; }
    public double Price { set; get; }

    public int CompareTo(object bookToCompare)
    {
        Book aBook = (Book) bookToCompare;
        if (this.Price > aBook.Price)
        {
            return 1;
        }
        else if (this.Price < aBook.Price)
        {
            return -1;
        }
        else
        {
            return 0;
        }
    }
}
}
