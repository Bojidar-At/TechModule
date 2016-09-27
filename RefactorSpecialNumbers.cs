using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Refactor_Special_Numbers
{
    class RefactorSpecialNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                int sumOfDigit = 0; 
                int num = i;                            
                while (num > 0)
                {
                    sumOfDigit += num % 10;
                    num = num / 10;
                }
                bool isSpecialNumber = (sumOfDigit == 5) || (sumOfDigit == 7) || (sumOfDigit == 11);
                Console.WriteLine("{0} -> {1}", i, isSpecialNumber);
                
                
            }

        }
    }
}
