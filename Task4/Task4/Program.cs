using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 7, 1, 8, 9, 4};
            int maxNumber = 0; 
            int minNumber = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if(numbers[i] > maxNumber)
                {
                    maxNumber = numbers[i];
                }
                if(numbers[i] < minNumber)
                {
                    minNumber = numbers[i];
                }
            }
            Console.Write($"Разница между максимальным - {maxNumber}, и минимальным числом - {minNumber}, равна - {maxNumber - minNumber}");
            Console.ReadKey();
        }
    }
}
