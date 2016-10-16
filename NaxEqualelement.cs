using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex06.MaxEqualelement
{
    class NaxEqualelement
    {
        static void Main(string[] args)
        {
            int[] arr = GetArrFromLine();


            int bestResult = 0;
            int bestIndexStart = 0;
            int currentResult = 1;
            for (int i = 1; i < arr.Length; i++)
            {
                
                if (arr[i] == arr[i-1])
                {
                    currentResult++;
                }
                else
                {
                    currentResult = 1;
                }
                    if (currentResult > bestResult)
                    {
                        bestResult = currentResult;
                        bestIndexStart = i;
                        
                    }
                    
            }
            
            for (int i = 0; i < bestResult; i++)
            {
                Console.Write("{0} ", arr[bestIndexStart]);
            }

        }

        private static int[] GetArrFromLine()
        {
            string input = Console.ReadLine();
            string[] items = input.Split(' ');
            int[] arr = new int[items.Length];

            for (int i = 0; i < items.Length; i++)
            {
                arr[i] = int.Parse(items[i]);
            }
            return arr;

        }

    }

}
