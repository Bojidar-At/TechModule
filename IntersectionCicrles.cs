using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.IntersectionOfCircles
{
    public class IntersectionCicrles
    {
        static void Main(string[] args)
        {
            int[] firstCicrleParams = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] secondCicrleParams = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                      
            
            Point firstdPoint = new Point
            {
                X = firstCicrleParams[0],
                Y = firstCicrleParams[1]
            };
            
            Point secondPoint= new Point
            {
                X = secondCicrleParams[0],
                Y = secondCicrleParams[1]
            };

            Cicrle firstCircle = new Cicrle
            {
                Radius = firstCicrleParams[2],
                Center = firstdPoint
            };
            Cicrle secondCircle = new Cicrle
            {
                Radius = secondCicrleParams[2],
                Center = secondPoint
            };


            if(Cicrle.Intersect(firstCircle, secondCircle))
            {
                Console.WriteLine("Yes");
            }
            else Console.WriteLine("No");
        }

    }

    public class Cicrle
    {
        public int Radius { get; set; }
        public Point Center { get; set; }

        public static bool Intersect (Cicrle firstCircle, Cicrle secondCircle)
        {
            int deltaX = Math.Abs(firstCircle.Center.X - secondCircle.Center.X);
            int deltaY = Math.Abs(secondCircle.Center.Y - firstCircle.Center.Y);

            double distance = Math.Sqrt(deltaY * deltaY + deltaX * deltaX);
            int sumRadius = firstCircle.Radius + secondCircle.Radius;

            if (distance <= sumRadius)
            {
                return true;
            }
            else return false;
        }
    }

    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}
