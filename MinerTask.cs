using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Ex.MinerTask
{
    class MinerTask
    {
        static void Main(string[] args)
        {
            Dictionary<string, long> result = new Dictionary<string, long>();
            while(true)
            {
                string input = Console.ReadLine();

                if(input == "stop")
                {
                    break;
                }
                else
                {
                    if(result.ContainsKey(input))
                    {
                        result[input] += long.Parse(Console.ReadLine());
                    }
                    else
                    {
                        result.Add(input,long.Parse(Console.ReadLine()));    
                    }
                }

            }

            foreach (var r in result.Keys)
            {
                Console.WriteLine("{0} -> {1}", r, result[r]);
            }
        }
    }
}
