using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.CondenseArrayToNumber
{
    class CondenseArr
    {
        static void Main(string[] args)
        {
            int[] arr = GetArrFromLine();
            

            while(arr.Length>1)
            {
                int[] condense = new int[arr.Length - 1];
                for (int i = 0; i < condense.Length; i++)
                {
                    condense[i] = arr[i] + arr[i + 1];
                }
                arr = condense;

            }

            Console.WriteLine(arr[0]);

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
