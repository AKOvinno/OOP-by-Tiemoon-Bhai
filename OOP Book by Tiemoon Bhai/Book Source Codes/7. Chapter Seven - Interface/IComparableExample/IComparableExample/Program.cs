using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparableExample
{
    class Program
    {
        static void Main(string[] args)
        {

            //List<double> prices = new List<double>();
            //prices.Add(120.50);
            //prices.Add(195.00);
            //prices.Add(110.50);
            //prices.Sort();
            //foreach (double aPrice in prices)
            //{
            //    Console.WriteLine(aPrice);
            //}

            List<Book> books = new List<Book>();
            books.Add(new Book() { Title = "Android for professionals", Price = 350 });
            books.Add(new Book() { Title = "OOP by examples", Price = 475 });
            books.Add(new Book() { Title = "ASP.Net Core", Price = 450 });

            books.Sort();

            foreach (Book aBook in books)
            {
                Console.WriteLine(aBook.Price + " " + aBook.Title);
            }

            Console.ReadKey();

        }
    }
}
