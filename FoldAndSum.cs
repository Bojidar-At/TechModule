using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Ex.FoldAndSum
{
    class FoldAndSum
    {
        static void Main(string[] args)
        {
            int[] arr = GetArrFromLine();
            int k = arr.Length / 4;

            int[] middleElements = new int[2 * k];
            for (int i = 0; i < middleElements.Length; i++)
            {
                middleElements[i] = arr[k + i];
            }

            int[] firstKElement = new int[k];
            for (int i = 0; i < firstKElement.Length; i++)
            {
                firstKElement[i] = arr[i];
            }

            int[] lastKElement = new int[k];
            for (int i = 0; i < lastKElement.Length; i++)
            {
                lastKElement[i] = arr[3 * k + i];
            }

            Array.Reverse(lastKElement);
            Array.Reverse(firstKElement);

            int[] firstLine = new int[k * 2];

            for (int i = 0; i < firstLine.Length; i++)
            {
                if(i<k)
                {
                    firstLine[i] = firstKElement[i];
                }
                else
                {
                    firstLine[i] = lastKElement[i - k];
                }
            }

            for (int i = 0; i < middleElements.Length; i++)
            {
                middleElements[i] += firstLine[i];
            }

            Console.WriteLine(string.Join(" ", middleElements));


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
