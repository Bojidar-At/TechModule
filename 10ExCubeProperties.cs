using System;


namespace CoordinatePoint
{
    class CubeProperties
    {
        static void Main()
        {
            double side = double.Parse(Console.ReadLine());
            string type = Console.ReadLine();

            if(type=="volume")
            {
                PrintCubeVolume(side);
            }
            else if (type == "face")
            {
                PrintCubeFace(side);
            }
            else if (type == "space")
            {
                PrintCubeSpace(side);
            }
            else
            {
                PrintCubeArea(side);
            }


        }

        static void PrintCubeVolume (double side)
        {
            Console.WriteLine("{0:f2}", side*side*side);
        }
        static void PrintCubeArea(double side)
        {
            Console.WriteLine("{0:f2}", 6 * side * side);
        }
        static void PrintCubeFace(double side)
        {
            Console.WriteLine("{0:f2}", (Math.Sqrt(2 * side * side)));
        }
        static void PrintCubeSpace(double side)
        {
            Console.WriteLine("{0:f2}", (Math.Sqrt(3 * side * side)));
        }
     }
}