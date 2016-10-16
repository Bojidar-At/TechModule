using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ShortWordSorted
{
    class ShortWordSorted
    {
        static void Main(string[] args)
        {
            char[] separators = ".,;:()[]\"'\\/!? ".ToArray();
            var words = Console.ReadLine().ToLower().Split(separators);

            var result = words.Where(w => w != "").Where(w => w.Length < 5).OrderBy(x => x).Distinct();
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
