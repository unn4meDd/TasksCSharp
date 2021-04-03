using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите любую строку: ");
            string userInput = Console.ReadLine();
            char symbol = ' ';

            int length = userInput.Length;
            char[] stringArray = userInput.ToCharArray();
            int wordCounter = 0;
            for (int i = 0; i < length; i++)
            {
                if (stringArray[i] == symbol)
                    wordCounter++;
            }
            Console.WriteLine($"Количество слов: {wordCounter + 1}");
            Console.ReadLine();
        }
    }
}
