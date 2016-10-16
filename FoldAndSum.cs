using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.FoldAndSum
{
    class FoldAndSum
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = input.Length/4;

            var leftNum = input.Take(k).Reverse();
            var rightNum = input.Reverse().Take(k);
            var secondLine = input.Skip(k).Take(2 * k).ToArray();
            var firstLine = leftNum.Concat(rightNum).ToArray();

            var sumArr = firstLine.Select((x, index) => x + secondLine[index]);
            Console.WriteLine(string.Join(" ",sumArr));


        }
    }
}
