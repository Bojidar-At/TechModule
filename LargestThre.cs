using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.LINQSumMaxMinAve
{
    class LargestThre
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse);
            var result = nums.OrderByDescending(x => x).Take(3);
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
