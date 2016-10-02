using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsDebuggingTroublesh
{
    class MathPower
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double pow = double.Parse(Console.ReadLine());

            Console.WriteLine(Power(n, pow));


        }

        static double Power(double n, double pow)
        {
            double result = 1;
            for (int i = 0; i < pow; i++)
            {
                result *= n;
            }
            return result;

        }
    
    }
}
