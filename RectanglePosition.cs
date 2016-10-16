using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.RectanglePosition
{
    class RectanglePosition
    {
        static void Main(string[] args)
        {
            Rectangle rect1 = ReadRectangle();
            Rectangle rect2 = ReadRectangle();

            
            if (rect1.IsInside(rect2))
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Not Inside");
            }
            
        }

        static Rectangle ReadRectangle()
        {
            int[] rectInfo = Console.ReadLine()
                        .Split()
                        .Select(int.Parse)
                        .ToArray();
            Rectangle rect = new Rectangle();
            rect.Top = rectInfo[0];
            rect.Left = rectInfo[1];
            rect.Width = rectInfo[2];
            rect.Height = rectInfo[3];


            return rect;
        }


    }

    class Rectangle
    {
        public int Top { get; set; }
        public int Left { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public int Bottom
        {
            get
            {
                return Top + Height;
            }
                
        }

        public int Right
        {
            get
            {
                return Left + Width;
            }

        }

        public int CalcArea()
        {
            return Width * Height;
        }

        public bool IsInside (Rectangle r)
        {
            return (r.Left <= Left) && (r.Right >= Right) &&
                (r.Top <= Top) && (r.Bottom >= Bottom);
        }
    }
}
