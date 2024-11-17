using System;

namespace ConsoleApp1
{
    internal class Task2 // Format a Full Name
    {
        public static void Execute()
        {
            Console.Write("Enter your first name: ");
            string firstName = Console.ReadLine();

            Console.Write("Enter your last name: ");
            string lastName = Console.ReadLine();

            string formattedName = $"{lastName}, {firstName}";
            Console.WriteLine($"Formatted Name: {formattedName}");
        }
    }
}
