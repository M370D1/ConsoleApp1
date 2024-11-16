using System;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a task to execute (1-5):");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Task1.Execute();
                    break;
                case "2":
                    Task2.Execute();
                    break;
                // Add more cases for other tasks
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}