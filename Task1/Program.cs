using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку любой длинны: ");
            string userInput = Console.ReadLine();
            Console.Write("Введите любой символ, для того чтобы подсчитать процент вхождения данного символа: ");
            char symbol = Console.ReadKey().KeyChar;
            Console.WriteLine();

            int length = userInput.Length;
            char[] stringArray = userInput.ToCharArray();
            int counter = 0;
            for (int i = 0; i < length; i++)
            {
                if(stringArray[i] == symbol)
                    counter++;
            }
            char quotes = '"';
            double lengthDouble = Convert.ToDouble(length);
            double counterDouble = Convert.ToDouble(counter);
            double percentage = (counterDouble / 100) * lengthDouble;
            Console.WriteLine($"Процент вхождения символа - {quotes}{symbol}{quotes}, равен - {percentage}");
        }
    }
}
