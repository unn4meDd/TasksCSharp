using System;

namespace Task11
{
    class Program
    {
        static void Main(string[] args)
        {
            InformationOfArray();
        }
        public static void InformationOfArray()
        {
            Console.Write("Введите количество элементов для массива: ");
            int arrayNumbers = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[arrayNumbers];
            for (int i = 0; i < arrayNumbers; i++)
            {
                Console.WriteLine("Введите {0}-й элемент", i + 1);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            int count = 0;
            for (int i = 0; i < a.Length; i++)
                if (a[i] % 2 == 0)
                    count++;
            Console.WriteLine(count);
            Console.ReadKey();
        }
    }
}
