using System;
using System.Collections.Generic;
using System.Text;

namespace Task18
{
    class Triangle
    {
        public double firstSide;
        public double secondSide;
        public double thirthSide;
        public double perimeter = 0;
        public double square = 0;
        public double maxSquare = 0;

        public void EnterSides()
        {
            Console.Write("First side: ");
            firstSide = double.Parse(Console.ReadLine());
            Console.Write("Second side: ");
            secondSide = double.Parse(Console.ReadLine());
            Console.Write("Thirth side: ");
            thirthSide = double.Parse(Console.ReadLine());
        }
        public void FindSquare()
        {
            perimeter = (firstSide + secondSide + thirthSide);
            square = (perimeter / 2) * (perimeter / 2 - firstSide) * (perimeter / 2 - secondSide) * (perimeter / 2 - thirthSide);
            Console.WriteLine("Square of triangle - " + square);
        }
        public void FindMaxSquare()
        {
            if (square > maxSquare)
            {
                maxSquare = square;
            }
            Console.WriteLine("MaxSquare of triangle - " + maxSquare);
        }
    }
}
