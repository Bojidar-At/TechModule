using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _05.AwaysFromZero
{
    class AwaysFromZero
    {
        static void Main(string[] args)
        {
            
            double[] arr = GetArrFromLine();

            foreach (var item in arr)
            {
                double roundedItem = Math.Round(item, MidpointRounding.AwayFromZero);
                Console.WriteLine("{0} => {1}", item, roundedItem);
            }

        }

        private static double[] GetArrFromLine()
        {
                string input = Console.ReadLine();
                string[] items = input.Split(' ');
                double[] arr = new double[items.Length];

                for (int i = 0; i < items.Length; i++)
			    {
                    arr[i] = double.Parse(items[i]);
                }
                return arr;

           }

    }
}
