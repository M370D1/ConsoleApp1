using System;

namespace ConsoleApp1
{
    internal class Task4 // Calculate the Area of a Circle
    {
        public static void Execute()
        {
            Console.Write("Enter the radius of the circle: ");
            string radiusInput = Console.ReadLine();

            if (double.TryParse(radiusInput, out double radius))
            {
                double area = Math.PI * radius * radius;

                Console.WriteLine($"The area of the circle with radius {radius} is: {area:F2}");
            }
            else
            {
                Console.WriteLine("Invalid radius entered. Please enter a valid number.");
            }
        }
    }
}