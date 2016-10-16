using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05.CompareChar
{
    class CompareChar
    {
        static void Main(string[] args)
        {
            string[] firstArr = Console.ReadLine().Split(' ');
            string[] secondArr = Console.ReadLine().Split(' ');
            int longestArr = Math.Max(firstArr.Length, secondArr.Length);

            for (int i = 0; i < longestArr; i++)
            {
                if(firstArr[i].CompareTo(secondArr[i]) == 0)
                {
                    if(firstArr.Length-i==1)
                    {
                        Console.WriteLine(string.Join("", firstArr));
                        Console.WriteLine(string.Join("", secondArr));
                        break;
                    }
                    else if (secondArr.Length - i == 1)
                    {
                        Console.WriteLine(string.Join("", secondArr));
                        Console.WriteLine(string.Join("", firstArr));
                        break;
                    }
                    continue;
                }
                else if(firstArr[i].CompareTo(secondArr[i]) > 0)
                {
                    Console.WriteLine(string.Join("", secondArr));
                    Console.WriteLine(string.Join("", firstArr));
                    break;
                }
                else
                {
                    Console.WriteLine(string.Join("", firstArr));
                    Console.WriteLine(string.Join("", secondArr));
                    break;
                }
            }

        }
    }
}
