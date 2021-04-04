using System;

namespace Task12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[100];
            int counter = 0;
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(-100, 200);
                if (array[i] > 0 && array[i] < 125)
                    counter++;
            }
            Console.WriteLine(counter);
        }
    }
}
