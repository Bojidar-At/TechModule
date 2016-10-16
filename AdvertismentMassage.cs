using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02AdvertismentMassage
{
    class AdvertismentMassage
    {
        static void Main(string[] args)
        {
            string[] phrases = new string[] {
                "Excellent product.", "Such a great product.", "I always use that product.",
            "Best product of its category.", "Exceptional product.", 
            "I can’t live without this product."};

            string[] enets = new string[] {
                "Now I feel good.", "I have succeeded with this product.",
            "Makes miracles. I am happy of the results!",
            "I cannot believe but now I feel awesome.",
            "Try it yourself, I am very satisfied.",
            "I feel great!"
            };

            string[] author = new string[] {
                "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"
            };

            string[] city = new string[] { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            int advertismentCount = int.Parse(Console.ReadLine());
            Random rand = new Random();
            

            for (int i = 0; i < advertismentCount; i++)
            {
                Console.WriteLine("{0} {1} {2} - {3}", phrases[rand.Next(0, phrases.Length)]
                    , enets[rand.Next(0, enets.Length)]
                    , author[rand.Next(0, author.Length)]
                    , city[rand.Next(0,city.Length)]);
            }
        }
    }
}
