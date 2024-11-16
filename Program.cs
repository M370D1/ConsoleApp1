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
                case "3":
                    Task3.Execute();
                    break;
                    case "4":
                        Task4.Execute();
                    break;
                    case "5":
                        Task5.Execute();
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}