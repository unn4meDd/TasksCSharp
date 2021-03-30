using System;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[] array = new int[10];
            int numbers = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(-201, 201);
                Console.WriteLine(array[i] + " ");
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > -100 && array[i] < 100)
                    numbers++;
            }
            Console.WriteLine("Количевство действительных чисел - " + numbers);
            Console.ReadKey();
        }
    }
}
