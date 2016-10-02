using System;


namespace CoordinatePoint
{
    class CoordinatePoint
    {
        static void Main()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());

            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());

            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            PrintLongerLine(x1, y1, x2, y2, x3, y3, x4, y4);
        }

        static void PrintLongerLine (double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            if (LineLength(x1, y1, x2, y2) >= LineLength(x3, y3, x4, y4))
            {
                printClosestPointFirst(x1, y1, x2, y2);
            }
            else if (LineLength(x1, y1, x2, y2) < LineLength(x3, y3, x4, y4))
            {
                printClosestPointFirst(x3, y3, x4, y4);
            }
        }

        private static double LineLength(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
        }


        static void printClosestPointFirst(double x1, double y1, double x2, double y2)
        {
            double DistanceFromPointToCenter1 = Math.Sqrt(x1 * x1 + y1 * y1);
            double DistanceFromPointToCenter2 = Math.Sqrt(x2 * x2 + y2 * y2);

            if (DistanceFromPointToCenter1 > DistanceFromPointToCenter2)
            {
                Console.Write("(" + x2 + ", " + y2 + ")");
                Console.WriteLine("(" + x1 + ", " + y1 + ")");
            }
            else
            {
                Console.Write("(" + x1 + ", " + y1 + ")");
                Console.WriteLine("(" + x2 + ", " + y2 + ")");
            }
        }

     }
}