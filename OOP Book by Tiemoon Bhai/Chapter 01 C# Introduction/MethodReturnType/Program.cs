namespace MethodReturnType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number1 = 300;
            double number2 = 450.5;
            double addResult = addResult(number1, number2);
            Console.WriteLine(addResult);
            Console.ReadLine();
        }
        static double addResult(double num1, double num2)
        {
            return num1 + num2;
        }
    }
}
