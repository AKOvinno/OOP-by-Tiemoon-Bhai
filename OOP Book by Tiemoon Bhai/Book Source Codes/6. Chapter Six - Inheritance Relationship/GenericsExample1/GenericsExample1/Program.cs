using System;

namespace GenericsExample1
{
    class Program
    {
        public static void Main(string[] args)
        {
            int a = 100;
            int b = 200;
            Console.WriteLine("a = " + a + ",b = " + b);
            Swap(ref a, ref b);
            Console.WriteLine("a = " + a + ",b = " + b);

            string name1 = "Dolon";
            string name2 = "Pulok";
            Console.WriteLine("Name 1 = " + name1 + ",Name 2 = " + name2);
            Swap(ref name1, ref name2);
            Console.WriteLine("Name 1 = " + name1 + ",Name 2 = " + name2);

            char char1 = 'd';
            char char2 = 'p';
            Console.WriteLine("Char 1 = " + char1 + ",Char 2 = " + char2);
            Swap(ref char1, ref char2);
            Console.WriteLine("Char 1 = " + char1 + ",Char 2 = " + char2);
        }

        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }
}
