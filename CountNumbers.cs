using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.CountNumbers
{
    class CountNumbers
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').
                Select(decimal.Parse).ToList();

            var keys = nums.Distinct().OrderBy(X => X);

            foreach (var k in keys)
            {
                var count = nums.Count(x => x == k);
                Console.WriteLine("{0} -> {1}", k, count);
            }
        }
    }
}
