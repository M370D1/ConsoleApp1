using System;

namespace ConsoleApp1
{
    internal class Task5
    {
        public static void Execute()
        {
            Console.Write("Enter your age: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int age))
            {
                Console.WriteLine($"Your age is {age} years old.");
            }
            else
            {
                Console.WriteLine("Invalid age entered.");
            }
        }
    }
}