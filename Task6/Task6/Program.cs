using System;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 10, 4, 60, 5 };
            int maxNumber = 0;
            int minNumber = array[0];
            Console.WriteLine("Это наш массив: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            for (int i = 1; i < array.Length; i++)
            {
                if(array[i] > maxNumber)
                {
                    maxNumber = array[i];
                }
                if(array[i] < minNumber)
                {
                    minNumber = array[i];
                }
            }
            Console.WriteLine("Максимальное число - " + maxNumber);
            Console.WriteLine("Минимальное число - " + minNumber);
        }
    }
}
