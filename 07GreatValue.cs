using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsDebuggingTroublesh
{
    class GreatValue
    {
        static void Main(string[] args)
        {
            var type = Console.ReadLine();

            if (type == "int")
            {
                int first = int.Parse(Console.ReadLine());
                int second = int.Parse(Console.ReadLine());
                int max = GetMax(first, second);
                Console.WriteLine(max);

            }
            else if (type == "char" || type == "string")
            {
                string first =  Console.ReadLine();
                string second = Console.ReadLine();
                string max = GetMax(first, second);
                Console.WriteLine(max);

            }
            else
            {
                Console.WriteLine("Моля въведете коректна стойност");
            }



        }

            static int GetMax (int edno, int dve)
            {

   
                    if (edno >= dve)
                    {
                    return edno;
                    }
                    else
	                {
		                 return dve;
	                }
             }

            static string GetMax(string edno, string dve)
            {


                if (edno.CompareTo(dve)>=0)
                {
                    return edno;
                }
                else
                {
                    return dve;
                }
            }

            

    }
}
