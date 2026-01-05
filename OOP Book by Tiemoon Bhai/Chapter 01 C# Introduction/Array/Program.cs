Console.WriteLine("How many number will you enter: ");
int arraySize = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[arraySize];
for(int i = 0; i < arraySize; i++)
{
    numbers[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Even Numbers: ");
for (int i = 0; i < arraySize; i++)
{
    if(numbers[i] % 2 == 0) Console.WriteLine(numbers[i]);
}