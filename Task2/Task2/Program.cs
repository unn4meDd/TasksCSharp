using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 2, 8, 3, 9, 0, 30, 1 };
            int maxNumber = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if(array[i] > maxNumber)
                {
                    maxNumber = array[i];
                }
            }
            Console.WriteLine(maxNumber);
        }
    }
}
