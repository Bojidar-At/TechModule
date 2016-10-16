using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.SumArrays
{
    class SumArrays
    {
        static void Main(string[] args)
        {
            int[] arr = GetArrFromLine();
            int[] arr2 = GetArrFromLine();
            int[] result = new int[Math.Max(arr.Length, arr2.Length)];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = arr[i%arr.Length]+arr2[i%arr2.Length];
                Console.Write(result[i] + " ");
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
