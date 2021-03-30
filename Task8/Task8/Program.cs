using System;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 5, -2, 3, 8, 0, -1, 10, -15 };
            int zeroNumbers = 0;
            int negativeNumbers = 0;
            int positiveNumbers = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if(array[i] < -1)
                {
                    negativeNumbers++;
                }
                if(array[i] == 0)
                {
                    zeroNumbers++;
                }
                if(array[i] >= 0)
                {
                    positiveNumbers++;
                }
            }
            Console.WriteLine("Отрицательных чисел - " + negativeNumbers);
            Console.WriteLine("Позитивных чисел - " + positiveNumbers);
            Console.WriteLine("Числе равных нулю - " + zeroNumbers);
        }
    }
}
