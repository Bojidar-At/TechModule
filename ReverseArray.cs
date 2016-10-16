using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07ReverseArray
{
    class ReverseArray
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] arr = input.Split(' ');
            Array.Reverse(arr);
            foreach (var item in arr)
            {
                Console.Write(item+ " ");
            }

        }
    }
}
