using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsDebuggingTroublesh
{
    class DrawSqaure
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            PrintEndLine(n);
           
            for (int i = 1; i < n-1; i++)
            {
                PrintMiddleLine(n); 
            }
            
            PrintEndLine(n);
        }

        private static void PrintEndLine (int number)
        {
            for (int i = 0; i < 2*number; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
        }

        private static void PrintMiddleLine (int number)
        {
            Console.Write("-");
            for (int i = 1; i < number; i++)
            {
                Console.Write("\\/");
            }            
            Console.WriteLine("-");
        }
      
    
    }
}
