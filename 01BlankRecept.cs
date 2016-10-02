using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsDebuggingTroublesh
{
    class BlankRecept
    {
        static void Main(string[] args)
        {

            PrintReciept();
        }

        private static void PrintReciept()
        {
            PrintHeader();
            PrintBody();
            PrintFooter();

        } 

        private static void PrintHeader()
        {
            Console.WriteLine("CASH RECIEPT");
            Console.WriteLine("------------------------------");
        }

        private static void PrintBody()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }

        private static void PrintFooter()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("\u00A9 SoftUni");
        }
    
    }
}
