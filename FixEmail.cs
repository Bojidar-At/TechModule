using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.FixEmail
{
    class FixEmail
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> result = new Dictionary<string, string>();
            
            while (true)
            {
                string name = Console.ReadLine();

                if (name == "stop")
                {
                    break;
                }
                else
                {
                    result.Add(name, Console.ReadLine());
                }

            }


            RemoveEmailByDomain(result, ".uk");
            RemoveEmailByDomain(result, ".us");


            foreach (var r in result.Keys)
            {
                Console.WriteLine("{0} -> {1}", r, result[r]);
            }
        }

        private static void RemoveEmailByDomain(Dictionary<string, string> result, string domains)
        {
            var filterdEmails = result.Where(x => x.Value.EndsWith(domains)).ToList();
            foreach (var userEntry in filterdEmails)
            {
                result.Remove(userEntry.Key);
            }

        }
    }
}
