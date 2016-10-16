using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex08.LogsAgregator
{
    class LogsAgregator
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, SortedDictionary<string, int>> userLogs = new SortedDictionary<string, SortedDictionary<string, int>>();

            int entryCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < entryCount; i++)
            {
                string entry = Console.ReadLine();
                string[] entryArgs = entry
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string ip = entryArgs[0];
                string user = entryArgs[1];
                int duration = int.Parse(entryArgs[2]);

                InsertUserName(userLogs, user);
                InsertIPAndDuration(userLogs, user, ip, duration);
            }
            PrintUserLogs(userLogs);
        }

        private static void PrintUserLogs(SortedDictionary<string, SortedDictionary<string, int>> userLogs)
        {
            foreach (var userEntry in userLogs)
            {
                string userName = userEntry.Key;
                int durationTotal = userEntry.Value.Values.Sum();
                List<string> userIPs = userEntry.Value.Keys.ToList();
                Console.WriteLine("{0}: {1} [{2}]", userName, durationTotal, string.Join(", ", userIPs));
            }
        }

        private static void InsertIPAndDuration(SortedDictionary<string, SortedDictionary<string, int>> userLogs, string user, string ip, int duration)
        {
            if (!userLogs[user].ContainsKey(ip))
            {
                userLogs[user].Add(ip, 0);
            }
            userLogs[user][ip] += duration;
        }

        private static void InsertUserName(SortedDictionary<string, SortedDictionary<string, int>> userLogs, string user)
        {
            if(!userLogs.ContainsKey(user))
            {
                userLogs.Add(user, new SortedDictionary<string, int>());
            }
        }
    }
}
