using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 7, 1, 8, 9, 4};
            int maxNumber = 0, minNumber = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i] > maxNumber)
                {
                    maxNumber = numbers[i];
                }
                else if(numbers[i] == numbers[2])
                {
                    minNumber = numbers[2];
                }
            }
            Console.Write($"Разница между максимальным - {maxNumber}, и минимальным числом - {minNumber}, равна - {maxNumber - minNumber}");
            Console.ReadKey();
        }
    }
}
