using System;

namespace Task15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter any sentence: ");
            string userInput = Console.ReadLine();
            int wordsCount = 0;
            char symbol = ' ';
            for (int i = 0; i < userInput.Length; i++)
            {
                if (userInput[i] == symbol)
                    wordsCount++;
            }
            Console.WriteLine($"In your sentence - {wordsCount + 1} words");
        }
    }
}
