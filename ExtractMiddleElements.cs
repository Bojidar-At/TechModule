using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.ExtractMiddleElements
{
    class ExtractMiddleElements
    {
        static void Main(string[] args)
        {
            int[] arr = GetArrFromLine();
            if(arr.Length==1)
            {
                Console.WriteLine("{0}", arr[0]);
            }
            else if(arr.Length%2==0)
            {
                Console.WriteLine("{0}, {1}", arr[arr.Length / 2 - 1], arr[arr.Length / 2]);
            }
            else if (arr.Length % 2 != 0)
            {
                Console.WriteLine("{0}, {1}, {2}", arr[arr.Length / 2 - 1], arr[arr.Length/2], arr[arr.Length / 2 + 1]);
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
