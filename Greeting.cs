using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Greeting
{
    class Greeting
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Hello, {0} {1}. \r\nYou are {2} years old.", firstName, lastName, n);

        }
    }
}
