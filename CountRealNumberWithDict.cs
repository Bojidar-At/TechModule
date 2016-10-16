﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.CountRealNumber
{
    class CountRealNumberWithDict
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();

            var counts = new SortedDictionary<decimal, int>();

            foreach (var num in nums)
            {
                if (counts.ContainsKey(num))
                    counts[num]++;
                else
                    counts[num] = 1;
                
            }
           

            foreach (var i in counts.Keys)
            {
                if(counts[i]>0)
                Console.WriteLine("{0} -> {1}",i, counts[i]);
            }
        }
    }
}
