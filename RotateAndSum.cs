using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02.RotatedAndSum
{
    class RotateAndSum

    {
        static void Main(string[] args)
        {
            int[] arr = GetArrFromLine();
            int n = int.Parse(Console.ReadLine());
            int[] result = new int[arr.Length];
                       
            for (int curentRotation = 0; curentRotation < n; curentRotation ++)
            {
                int lastElement = arr[arr.Length-1];
                for (int i = arr.Length-1; i >0; i--)
			    {
			    arr[i] = arr[i-1];
			    }
                arr[0]=lastElement;

                for (int j = 0; j < arr.Length; j++)
			    {
			     result[j] += arr[j];
			    }
            }

            Console.WriteLine(string.Join(" ", result));
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
