using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.SalesReport
{
    class SalesReport
    {
        static void Main(string[] args)
        {
            Sale[] sales = ReadSales();

            string[] towns = sales.Select(s => s.Town).Distinct().OrderBy(t => t).ToArray();

            foreach (var town in towns)
            {
                decimal salesByTown = sales
                                    .Where(s => s.Town == town)
                                    .Select(s => s.Price * s.Quantyti)
                                    .Sum();
                Console.WriteLine("{0} -> {1:f2}", town, salesByTown);
            }
        }

        static Sale ReadSale()
        {
            string[] items = Console.ReadLine().Split(' ');
            return new Sale()
            {
                Town = items[0],
                Product = items[1],
                Price = decimal.Parse(items[2]),
                Quantyti = decimal.Parse(items[3])
            };

        }

        static Sale[] ReadSales()
        {
            int n = int.Parse(Console.ReadLine());
            Sale[] sales = new Sale[n];
            for (int i = 0; i < n; i++)
            {
                sales[i] = ReadSale();
            }
            return sales;
        }
    }

    class Sale
    {
        public string Town { get; set; }
        public string Product { get; set; }
        public decimal Price { get; set; }
        public decimal Quantyti { get; set; }

    }
}
