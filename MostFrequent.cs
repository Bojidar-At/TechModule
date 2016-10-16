using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex08.MostFrequent
{
    class MostFrequent
    {
        static void Main(string[] args)
        {
            int[] arr = GetArrFromLine();

            int bestResult = 0;
            int bestNumber = 0;
            
            for (int i = 0; i < arr.Length-1; i++)
            {
                int currentNumber = 0;
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        currentNumber++;
                    }
                    if(currentNumber>bestNumber)
                    {
                        bestNumber = currentNumber;
                        bestResult = arr[i];
                    }
                }
            }
            Console.WriteLine(bestResult);


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
