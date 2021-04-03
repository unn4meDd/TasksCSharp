using System;

namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = { "Romanko", "Rogizniy", "Golinko", "Bek", "Lisev" };
            int minLen = array[0].Length, indexMin = 0;
            int maxLen = array[0].Length, indexMax = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length > maxLen)
                {
                    maxLen = array[i].Length;
                    indexMax = i;
                }
                if (array[i].Length < minLen)
                {
                    minLen = array[i].Length;
                    indexMin = i;
                }
            }
            Console.WriteLine("Самая длинная фамилия - " + array[indexMax]);
            Console.WriteLine("Самая короткая фамилия - " + array[indexMin]);
        }
    }
}
