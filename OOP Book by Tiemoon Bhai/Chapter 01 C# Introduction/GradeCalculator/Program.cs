Console.WriteLine("Enter obtained score in physics: ");
string userInput = Console.ReadLine();
double physicsScore = Convert.ToDouble(userInput);

if(physicsScore > 100 || physicsScore < 0)
{
    Console.WriteLine("Your entered score is invalid. " + "Check it and try again");
    return;
}
else if(physicsScore <= 100 && physicsScore >= 90)
{
    Console.WriteLine("Your grade is A+");
}
else if(physicsScore < 90 && physicsScore >= 80)
{
    Console.WriteLine("Your grade is B+");
}
else if(physicsScore < 80 && physicsScore >= 70)
{
    Console.WriteLine("Your grade is C+");
}
else if(physicsScore < 70 && physicsScore >= 60)
{
    Console.WriteLine("Your grade is D+");
}
else
{
    Console.WriteLine("Your grade is F");
}
