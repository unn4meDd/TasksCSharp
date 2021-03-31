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
                array[i] = rand.Next(-300, 300);
                Console.WriteLine(array[i]);
            }
            for (int i = 0; i < array.Length; i++)
            {
                if(0 < array[i] < 125)
                {
                    counter++;
                }
            }
        }
    }
}
