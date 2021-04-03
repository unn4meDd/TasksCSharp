using System;

namespace Task16
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = { "Romanko", "Lysev", "Bek" };
            Array.Sort(array);
            foreach (string s in array)
            {
                Console.WriteLine(s);
            }
        }
    }
}
