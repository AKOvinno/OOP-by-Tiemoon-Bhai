namespace ValueTypeReferenceSending
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 100;
            int b = 200;
            Console.WriteLine("a = " + a + ", b = " + b);
            Swap(ref a, ref b); // (a, b) = (b, a); It's tuple
            Console.WriteLine("a = " + a + ", b = " + b);
            Console.ReadKey();
        }
        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
