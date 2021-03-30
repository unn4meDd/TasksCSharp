using System;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            string vowels = "aeouiys";
            Console.WriteLine("Write a sentence any length: ");
            string userInput = Console.ReadLine();
            Console.WriteLine();

            int length = userInput.Length;
            int counter = 0;
            char[] strArray = userInput.ToCharArray();
            foreach (char symbol in userInput)
            {
                if (vowels.Contains(symbol.ToString()))
                    counter++;
            }
            double lengthDouble = Convert.ToDouble(length);
            double counterDouble = Convert.ToDouble(counter);
            double percentage = (counterDouble / 100) * lengthDouble;
            Console.WriteLine($"Percentage vowels in your sentence - {percentage}%");
        }
    }
}
