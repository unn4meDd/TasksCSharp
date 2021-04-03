using System;

namespace Task18
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle abc = new Triangle();
            Triangle mkx = new Triangle();
            Triangle cba = new Triangle();
            double maxPerimeter = 0;
            double maxSquare = 0;
            Console.WriteLine("Taking value of sides for first triangle");
            abc.EnterSides();
            Console.Clear();
            Console.WriteLine("Taking value of sides for second triangle");
            mkx.EnterSides();
            Console.Clear();
            Console.WriteLine("Taking value of sides for thirth triangle");
            cba.EnterSides();
            Console.Clear();
            abc.FindPerimeter();
            mkx.FindPerimeter();
            cba.FindPerimeter();
            if (abc.perimeter == mkx.perimeter && mkx.perimeter == cba.perimeter && cba.perimeter == abc.perimeter)
            {
                Console.WriteLine("Triangles 'ABC', 'MKX', 'CBA' have same perimeter");
                maxPerimeter = abc.perimeter;
            }
            else
            {
                Console.WriteLine("Triangles 'ABC', 'MKX', 'CBA' don't have same perimeter");
            }
            Console.WriteLine(maxPerimeter);
            abc.FindSquare();
            mkx.FindSquare();
            cba.FindSquare();
            if (abc.square == mkx.square && mkx.square == cba.square && cba.square == abc.square)
            {
                Console.WriteLine("Triangles 'ABC', 'MKX', 'CBA'       have same square");
                maxSquare = abc.square;
            }
            else
            {
                Console.WriteLine("Triangles 'ABC', 'MKX', 'CBA' don't have same square");
            }
        }
    }
}
