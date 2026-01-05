Console.WriteLine("Enter a number: ");
string input = Console.ReadLine();
try
{
    double aNumber = Convert.ToDouble(input);
    Console.WriteLine("You entered: " + aNumber);
}
catch (Exception exObj)
{
    Console.WriteLine("You entered text. " + "Please enter number only"); 
}
finally
{
    Console.WriteLine("Finally code here...");
    Console.ReadKey();
}