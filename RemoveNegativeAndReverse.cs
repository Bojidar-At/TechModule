using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.RemoveNegativeAndReverse
{
    class RemoveNegativeAndReverse
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ')
                .Select(int.Parse).ToList();

            List<int> result = new List<int>();

            for (int i = input.Count; i > 0; i--)
            {
                if (input[i - 1] > 0)
                {
                    result.Add(input[i-1]);
                }
                
            }
            if (result.Any())
            {
                Console.WriteLine(string.Join(", ", result));
            }
            else
            {
                Console.WriteLine("empty");
            }
        }
    }
}
