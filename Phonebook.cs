using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01.Phonebook
{
    class Phonebook
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, string> phonebook = new SortedDictionary<string, string>();
            
            while (true)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();
                if(input[0]=="END")
                {
                    break;
                }
                else if(input[0]=="A")
                {
                    if(phonebook.ContainsKey(input[1]))
                    {
                        phonebook[input[1]] = input[2];
                    }
                    else
                        phonebook.Add(input[1], input[2]);
                    
                }
                else if (input[0] == "S")
                {

                    if (phonebook.ContainsKey(input[1]))
                    {
                        Console.WriteLine("{0} -> {1}", input[1], phonebook[input[1]]);
                    }
                    else
                    {
                        Console.WriteLine("Contact {0} does not exist.", input[1]);
                    }

                }
                else if (input[0] == "ListAll")
                {
                    foreach (var i in phonebook.Keys)
                    {
                        Console.WriteLine("{0} -> {1}",i, phonebook[i]);
                    }
                }
                
            }

        }
    }
}
