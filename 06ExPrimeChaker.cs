using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.PrimeChaker
{
    class PrimeChaker
    {
        static void Main()
        {
            long num1 = long.Parse(Console.ReadLine());
            bool isPrime = IsPrime(num1);
            Console.WriteLine(isPrime);
            
        }

        static bool IsPrime(long number)
        {
            bool isPrime = true;
            for (long divider = 2; divider <= Math.Sqrt(number); divider++)
            {
                if (number % divider == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (number == 0 || number == 1)
            {
                isPrime = false;
            }
            return isPrime;
        }
    }
}
