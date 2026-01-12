using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDefinedTypeExample1
{
    class Program
    {
        static void Main(string[] args)
        {
            //string title = "Basic C#";
            //string author = "Imtiaz Rana";
            //double price = 120;

            //string msg = title + " Author: " + author + " Price: " + price;
            //Console.WriteLine(msg);

            Book book1 = new Book();
            book1.title = "Basic C#";
            book1.author = "Imtiaz Rana";
            book1.price = 120;

            string book1Info = book1.title + " Author: " + book1.author + " Price: " + book1.price;
            Console.WriteLine(book1Info);

            Book book2 = new Book();
            book2.title = "ASP.Net MVC";
            book2.author = "Himel Akber";
            book2.price = 230;

            string book2Info = book2.title + " Author: " + book2.author + " Price: " + book2.price;
            Console.WriteLine(book2Info);

            Console.ReadLine();

        }
    }
}
