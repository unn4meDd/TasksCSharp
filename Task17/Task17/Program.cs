using System;

namespace Task17
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Задан текст. Определить, входит ли в него заданное слово и сколько раз. ";
            string search = "текст";
            int count = 0;

            foreach (string i in text.Split(',', '.', ':', '!', '?', ' '))
            {
                if (i == search)
                    count++;
            }
            if (count != 0)
            {
                Console.WriteLine($"Cлово '{search}' встречается {count} раз.");
            }
            else
            {
                Console.WriteLine("В тексте нет искомого слова.");
            }
            Console.ReadKey();
        }
    }
}
