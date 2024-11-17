using System;

namespace ConsoleApp1
{
    internal class Task3 // Extract and Modify Substring
    {
        public static void Execute()
        {
            Console.Write("Enter a sentence: ");
            string sentence = Console.ReadLine();

            Console.Write("Enter the starting index of the word to extract: ");
            int startIndex = int.Parse(Console.ReadLine());

            Console.Write("Enter the length of the word to extract: ");
            int length = int.Parse(Console.ReadLine());

            string extractedWord = sentence.Substring(startIndex, length);

            string modifiedWord = extractedWord.ToUpper();

            Console.WriteLine($"Extracted and modified word: {modifiedWord}");
        }
    }
}
