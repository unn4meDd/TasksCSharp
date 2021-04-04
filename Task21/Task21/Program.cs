using System;

namespace Task21
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new[] { 1, 2, 3, 4, 5 };
            var b = new[] { 5, 4, 3, 2, 1 };
            var c = new[] { 1, 3, 2, 5, 4 };
            PrintCheck(a);
            PrintCheck(b);
            PrintCheck(c);

            static bool Check(int[] array, bool ask)
            {
                for (int i = 0; i < array.Length - 1; i++)
                    if ( (ask && (array[i] > array[i + 1])) || (!ask && (array[i] < array[i + 1])) ) 
                        return false;
                return true;
            }

            static void PrintCheck(int[] a)
            {
                if (Check(a, true))
                {
                    Console.WriteLine("Упорядочен по возрастанию");
                }
                else if (Check(a, false))
                {
                    Console.WriteLine("Упорядочен по убыванию");
                }
                else
                {
                    Console.WriteLine("Не упорядочен");
                }
            }
        }
    }
}
