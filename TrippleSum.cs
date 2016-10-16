using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.TrippleSum
{
    class TrippleSum
    {
        static void Main(string[] args)
          {
            string input = Console.ReadLine();
            string[] items = input.Split(' ');
            int[] arr = new int[items.Length];

            for (int i = 0; i < items.Length; i++)
			{
                arr[i] = int.Parse(items[i]);
            }
            bool ContainSum = false;
            
            for (int i = 0; i < arr.Length; i++)
            {
                int sum = 0;
                for (int j = i+1; j < arr.Length; j++)
                {
                    sum = arr[i] + arr[j];
                    for (int q = 0; q < arr.Length; q++)
                    {
                        if (arr[q] == sum)
                        {
                            Console.WriteLine("{0} + {1} == {2}", arr[i], arr[j], sum);
                            ContainSum = true;
                            break;
                        }                        
                    }
                }
                
            }
            if (!ContainSum)
            {
                Console.WriteLine("No");
            }



        }
    }
}
