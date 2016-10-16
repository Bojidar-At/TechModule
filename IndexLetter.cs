using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex09.IndexLetter
{
    class IndexLetter
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            
            var a = input[0];
            
            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine(input[i] + " -> " + ((int)input[i]-97));
            }

        }
    }
}
