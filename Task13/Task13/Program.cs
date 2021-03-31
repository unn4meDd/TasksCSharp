using System;

namespace Task13
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = { 
                { 6, 5, 3, 8, 7},
                { 3, 1, 10, 6, 8},
                { 4, 2, 5, 8, 20},
                { 7, 3, 4, 9, 5},
                { 6, 2, 5, 10, 15},
                { 4, 7, 12, 18, 19},
                { 20, 1, 6, 10, 11},
                { 1, 12, 10, 12, 6},
                { 18, 12, 19, 4, 2},
                { 15, 5, 11, 2, 14}
            };
            int sum = 0;
            Random rand = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    sum += array[i, j];
                }
                Console.WriteLine(sum + " ");
            }
        }
    }
}
