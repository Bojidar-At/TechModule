using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.OddOccurance
{
    class OddOccurences
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().ToLower();
            var words = text.Split(' ');
            var counts = new Dictionary<string, int>();

            foreach (var w in words)
            {
                if (counts.ContainsKey(w)) 
                    counts[w]++;
                else
                    counts[w] = 1;
                               
            }

            var list = new List<string>();
            foreach (var pair in counts)
            {
                if (pair.Value % 2 == 1)
                    list.Add(pair.Key);                    
            }

            Console.WriteLine(string.Join(", ", list));
        }
    }
}
