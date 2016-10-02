using System;


namespace CoordinatePoint
{
    class GeometryCalk
    {
        static void Main()
        {            
            string type = Console.ReadLine();

            if (type == "triangle")
            {
                double height = double.Parse(Console.ReadLine());
                double side = double.Parse(Console.ReadLine());
                PrintTriangleArea(height, side);
            }
            else if (type == "square")
            {
                double side = double.Parse(Console.ReadLine());
                PrintSquareArea(side);
            }
            else if (type == "rectangle")
            {
                double height = double.Parse(Console.ReadLine());
                double side = double.Parse(Console.ReadLine());
                PrintRectangleArea(height, side);
            }
            else
            {
                double side = double.Parse(Console.ReadLine());
                PrintCubeArea(side);
            }


        }

        static void PrintTriangleArea(double height, double side)
        {
            Console.WriteLine("{0:f2}", height*side/2);
        }

        static void PrintSquareArea(double side)
        {
            Console.WriteLine("{0:f2}", side * side);
        }
        static void PrintRectangleArea(double height, double side)
        {
            Console.WriteLine("{0:f2}", height * side);
        }
        static void PrintCubeArea(double side)
        {
            Console.WriteLine("{0:f2}", Math.PI* side * side);
        }
     }
}