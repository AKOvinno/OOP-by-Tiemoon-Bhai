namespace MethodParameter
{
    internal class Program
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
