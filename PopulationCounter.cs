using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex07.PopulationCounter
{
    class PopulationCounter
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, SortedDictionary<string, long>> cityPopulation = new SortedDictionary<string, SortedDictionary<string, long>>();

            string entry = Console.ReadLine();

            while(!entry.Equals("report"))
            {
                string[] entryArgs = entry.Split('|');
                string city = entryArgs[0];
                string country = entryArgs[1];
                long population = long.Parse(entryArgs[2]);

                InsertCountry(cityPopulation, country);
                InsertCityAndPopulation(cityPopulation, country, city, population);

                entry = Console.ReadLine();
            }
           
            PrintCityPopulation(cityPopulation);
        }

        private static void PrintCityPopulation(SortedDictionary<string, SortedDictionary<string, long>> cityPopulation)
        {
            foreach (var item in cityPopulation.OrderByDescending(x=>x.Value.Sum(y=>y.Value)))
            {
                string country = item.Key;
                List<string> city = item.Value.Keys.ToList();
                long populations = item.Value.Values.Sum();
                Console.WriteLine("{0} (total population: {1})", country, populations);
                foreach (var c in item.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine("=>{0}: {1}", c.Key, c.Value); 
                }
                
                
            }
        }

        private static void InsertCityAndPopulation(SortedDictionary<string, SortedDictionary<string, long>> cityPopulation, string country, string city, long population)
        {
            if (!cityPopulation[country].ContainsKey(city))
            {
                cityPopulation[country].Add(city, 0);
            }
            cityPopulation[country][city] += population;

        }

        private static void InsertCountry(SortedDictionary<string, SortedDictionary<string, long>> cityPopulation, string country)
        {
            if (!cityPopulation.ContainsKey(country))
            {
                cityPopulation.Add(country, new SortedDictionary<string, long>());
            }
        }
    }
}
