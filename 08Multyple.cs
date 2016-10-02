using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsDebuggingTroublesh
{
    class MultiplyEvensOdds
    {
        static void Main(string[] args)
        {
            int num = Math.Abs(int.Parse(Console.ReadLine()));

            int sumOdd = GetOdd(num);
            int sumEvent = GetEvent(num);
            Console.WriteLine(sumEvent*sumOdd);
          
        }

        static int GetOdd (int number)
        {
            int sumEvent = 0;
            while (number >0)
            {
                int lastDigit = number % 10;
                if (lastDigit % 2 != 0 )
                {
                    sumEvent += lastDigit;
                }
                number/=10;
            }
            return sumEvent;
        }

        static int GetEvent(int number)
        {
            int sumEvent = 0;
            while (number > 0)
            {
                int lastDigit = number % 10;
                if (lastDigit % 2 == 0)
                {
                    sumEvent += lastDigit;
                }
                number /= 10;
            }
            return sumEvent;
        }
    }
}
