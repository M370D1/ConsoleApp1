using System;

namespace ConsoleApp1
{
    internal class Task1 // Convert and Add Two Numbers
    {
        public static void Execute()
        {
            Console.Write("Enter the first number: ");
            string input1 = Console.ReadLine();

            Console.Write("Enter the second number: ");
            string input2 = Console.ReadLine();

            int number1 = int.Parse(input1);
            int number2 = int.Parse(input2);

            Console.WriteLine($"The sum is: {number1 + number2}");
        }
    }
}