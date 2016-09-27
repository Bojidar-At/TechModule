using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Triples_of_Letters
{
    class TriplesofLetters
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        Console.Write(Convert.ToChar(i + 97));
                        Console.Write(Convert.ToChar(j + 97));
                        Console.WriteLine(Convert.ToChar(k + 97));

                    }
                }
                
            }
            
        }
    }
}
