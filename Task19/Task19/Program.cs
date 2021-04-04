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
            Triangle ghi = new Triangle();
            Triangle dpe = new Triangle();
            Triangle snp = new Triangle();
            Triangle rlx = new Triangle();
            Triangle bcz = new Triangle();
            Triangle jpo = new Triangle();
            Triangle qwr = new Triangle();
            int userInput;
            double maxSquare = 0;
            double[] array = { abc.square, mkx.square, cba.square, ghi.square, dpe.square, snp.square, rlx.square, bcz.square, jpo.square, qwr.square };
            Console.WriteLine("1 - take value of sides\n2 - exit");
            Console.Write("Your change: ");
            userInput = int.Parse(Console.ReadLine());
            if (userInput == 1)
            {
                Console.Clear();
                Console.WriteLine("Taking value of sides for first triangle");
                abc.EnterSides();
                Console.Clear();
                Console.WriteLine("Taking value of sides for second triangle");
                mkx.EnterSides();
                Console.Clear();
                Console.WriteLine("Taking value of sides for thirth triangle");
                cba.EnterSides();
                Console.Clear();
                Console.WriteLine("Taking value of sides for fourth triangle");
                ghi.EnterSides();
                Console.Clear();
                Console.WriteLine("Taking value of sides for fifth triangle");
                dpe.EnterSides();
                Console.Clear();
                Console.WriteLine("Taking value of sides for sixth triangle");
                snp.EnterSides();
                Console.Clear();
                Console.WriteLine("Taking value of sides for seventh triangle");
                rlx.EnterSides();
                Console.Clear();
                Console.WriteLine("Taking value of sides for eighth triangle");
                jpo.EnterSides();
                Console.Clear();
                Console.WriteLine("Taking value of sides for nineth triangle");
                qwr.EnterSides();
                Console.Clear();
                Console.WriteLine("Taking value of sides for tenth triangle");
                cba.EnterSides();
                Console.Clear();
                Console.WriteLine("Change task: ");
                Console.WriteLine("1 - find a square of triangles\n2 - exit");
                Console.Write("Your change: ");
                userInput = int.Parse(Console.ReadLine());
                if(userInput == 1)
                {
                    
                    Console.Clear();
                    abc.FindSquare();
                    mkx.FindSquare();
                    cba.FindSquare();
                    ghi.FindSquare();
                    dpe.FindSquare();
                    snp.FindSquare();
                    rlx.FindSquare();
                    bcz.FindSquare();
                    jpo.FindSquare();
                    qwr.FindSquare();
                    Console.WriteLine("\nChange task: ");
                    Console.WriteLine("1 - find a max square of triangles\n2 - exit");
                    Console.Write("Your change: ");
                    userInput = int.Parse(Console.ReadLine());
                    if(userInput == 1)
                    {
                        for (int i = 0; i < array.Length; i++)
                        {
                            if (array[i] > maxSquare)
                            {
                                maxSquare = array[i];
                            }
                        }
                        Console.Clear();
                        abc.FindMaxSquare();
                        mkx.FindMaxSquare();
                        cba.FindMaxSquare();
                        ghi.FindMaxSquare();
                        dpe.FindMaxSquare();
                        snp.FindMaxSquare();
                        rlx.FindMaxSquare();
                        bcz.FindMaxSquare();
                        jpo.FindMaxSquare();
                        qwr.FindMaxSquare();
                    }
                    else if(userInput == 2)
                    {
                        Console.Clear();
                        Console.ReadKey();
                    }
                }
                else if (userInput == 2)
                {
                    Console.Clear();
                    Console.ReadKey();
                }
            }
        }
    }
}
