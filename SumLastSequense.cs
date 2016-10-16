using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SumLastSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] elements = new int[n];
            elements[0] = 1;
           
            for (int i = 1; i < elements.Length; i++)
            {
                for (int j = 0; j <= k; j++)
                {
                    if((i-j)>=0)
                    {
                        elements[i] += elements[i-j]; 
                    }
                    
                }
 
            }

            for (int i = 0; i < elements.Length; i++)
            {
                Console.WriteLine(elements[i]);
            }

        }
    }
}
