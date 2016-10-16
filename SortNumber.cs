using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14SortNumbers
{
    class SortNumber
    {
        static void Main(string[] args)
        {
            List<decimal> numbers = new List<decimal>();
            string input = Console.ReadLine();
            List<string> list = input.Split(' ').ToList();
            for (int i = 0; i < list.Count; i++)
            {
                numbers.Add(decimal.Parse(list[i]));
            }

            numbers.Sort();
           
            Console.WriteLine(string.Join(" <= ", numbers));

        }
    }
}
