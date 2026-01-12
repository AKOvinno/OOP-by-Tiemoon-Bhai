using System;

namespace PersonExample
{
    class EntryPoint
    {
        public static void Main()
        {
            Person person1 = new Person();
            Console.Write("Enter First Name:");
            person1.firstName = Console.ReadLine();

            Console.Write("Enter Middle Name:");
            person1.middleName = Console.ReadLine();
            
            Console.Write("Enter Last Name:");
            person1.lastName = Console.ReadLine();

            string fullName = person1.GetMyFullName();
            string reverseName = person1.GetMyReverseName();

            Console.WriteLine("Full Name: " + fullName);
            Console.WriteLine("Reverse Form: " + reverseName);
            Console.ReadLine();
        }
    }
}
