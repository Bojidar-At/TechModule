using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01.LargestCommon
{
    class LargestCommon
    {
        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine().Split(' ');
            string[] arr2 = Console.ReadLine().Split(' ');

            if (arr1.Length < arr2.Length)
            {
                GetLargestCommon(arr1, arr2);
            }
            else
            {
                GetLargestCommon(arr2, arr1);
            }



        }

        private static void GetLargestCommon(string[] arr1, string[] arr2)
        {
            int bestResult = 0;
            int bestIndexStart = 0;

            for (int i = 0; i < arr1.Length; i++)
            {
                int currentResult = 0;
                if (arr1[i] == arr2[i])
                {
                    for (int j = i; j < arr1.Length; j++)
                    {
                        if (arr1[j] == arr2[j])
                            currentResult++;
                    }
                    if (currentResult > bestResult)
                    {
                        bestResult = currentResult;
                        bestIndexStart = i;
                    }
                }
            }

            Console.WriteLine(bestResult);

        }

    }
}