using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13SplitByWord
{
    class Split
    {
        static void Main(string[] args)
        {
            var separators = new char[] 
            {
                ',',';', ':', '.', '!', '(', ')', '"', '\'', '/', '\\', '[', ']', ' ' 
            };

            var word = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries);

            var lowerCase = new List<string>();
            var mixedCase = new List<string>();
            var upperCase = new List<string>();

            foreach (var w in word)
            {
                var type = GetWordType(w);
                if (type == WordType.UpperCase)
                {
                    upperCase.Add(w);
                }
                else if ( type == WordType.MixedCase)
                {
                    mixedCase.Add(w);
                }
                else
                {
                    lowerCase.Add(w);
                }
            }

            Console.WriteLine("Lower-case: {0}", string.Join(", ", lowerCase));
            Console.WriteLine("Mixed-case: {0}", string.Join(", ", mixedCase));
            Console.WriteLine("Upper-case: {0}", string.Join(", ", upperCase));



        }

        enum WordType { UpperCase, MixedCase, LowerCase };

        static WordType GetWordType (string word)
        {
            var upperLetters = 0;
            var lowerLetters = 0;
            foreach (var l in word)
            {
                if (char.IsUpper(l))
                {
                    upperLetters++;
                }
                else if (char.IsLower(l))
                {
                    lowerLetters++;
                }
                
            }
            if(upperLetters == word.Length)
            {
                return WordType.UpperCase;
            }
            if(lowerLetters == word.Length)
            {
                return WordType.LowerCase;
            }
            else
            {
                return WordType.MixedCase;
            }


        }
    }
}
