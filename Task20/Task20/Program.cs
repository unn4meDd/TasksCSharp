using System;

namespace Task20
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[,] array = new int[10, 10];
            int positiveCount = 0;
            int negativeCount = 0;
            int zeroCount = 0;
            Console.WriteLine("This is our array: ");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rand.Next(-100, 101);
                    Console.Write(array[i, j] + " ");
                    if (array[i, j] >= 1)
                    {
                        positiveCount++;
                    }
                    else if (array[i, j] <= -1)
                    {
                        negativeCount++;
                    } 
                    else
                    {
                        zeroCount++;
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("Positive numbers - " + positiveCount);
            Console.WriteLine("Negative numbers - " + negativeCount);
            Console.WriteLine("Zero numbers - " + zeroCount);
        }
    }
}
