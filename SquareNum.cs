using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15SquareNumbers
{
    class SquareNum
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            string input = Console.ReadLine();
            List<string> list = input.Split(' ').ToList();
            for (int i = 0; i < list.Count; i++)
            {
                numbers.Add(int.Parse(list[i]));
            }

            List<int> result = new List<int>();

            foreach (int item in numbers)
            {
                if(Math.Sqrt(item)%1==0)
                {
                    result.Add(item);
                }
            }
            result.Sort();
            result.Reverse();
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
