using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndList
{
    class DayOfWeek
    {
        static void Main(string[] args)
        {
            string[] days = { "monday", "tuesday", "wednesday", "thursday", "friday", "saturday", "sunday" };
            int n = int.Parse(Console.ReadLine());
            if (n>=1&&n<=7)
            {
                Console.WriteLine(days[n-1]);
            }
            else
            {
                Console.WriteLine("Invalid Day!");
            }
        }
    }
}
