using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Ex01.CountWorkingDays
{
    class CountWorkingDay
    {
        static void Main(string[] args)
        {
            string firstDate = Console.ReadLine();
            string secondDate = Console.ReadLine();

            DateTime startDate = DateTime.ParseExact(firstDate, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime endDate = DateTime.ParseExact(secondDate, "dd-MM-yyyy", CultureInfo.InvariantCulture);

            List<DateTime> holidays = new List<DateTime>();
            holidays.Add(new DateTime(2016,01,01));
            holidays.Add(new DateTime(2016,03,03));
            holidays.Add(new DateTime(2016,05,01));
            holidays.Add(new DateTime(2016,05,06));
            holidays.Add(new DateTime(2016,05,24));
            holidays.Add(new DateTime(2016,09,06));
            holidays.Add(new DateTime(2016,09,22));
            holidays.Add(new DateTime(2016,11,01));
            holidays.Add(new DateTime(2016,12,24));
            holidays.Add(new DateTime(2016,12,25));
            holidays.Add(new DateTime(2016,12,26));

            int workingDays = 0;

            for (DateTime curentDate = startDate; curentDate <= endDate; curentDate=curentDate.AddDays(1))
			{
			 DateTime newDate = new DateTime(2016, curentDate.Month, curentDate.Day);
                if (!holidays.Contains(newDate)&& curentDate.DayOfWeek != DayOfWeek.Saturday
                    && curentDate.DayOfWeek != DayOfWeek.Sunday)
                {
                    workingDays++;
                }
                
			}
            Console.WriteLine(workingDays);
        }
    }
}
