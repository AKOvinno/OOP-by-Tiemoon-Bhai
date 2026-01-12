using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodExample02
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowName("Rabbi");
            string name = "Jamil";
            ShowName(name);
            Console.ReadKey();
        }

        static void ShowName(string aName)
        {
            Console.WriteLine(aName);
        }
    }
}
