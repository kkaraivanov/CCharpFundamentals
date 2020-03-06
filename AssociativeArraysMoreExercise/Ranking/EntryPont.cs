namespace Ranking
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class EntryPont
    {
        static void Main(string[] args)
        {
            string input = null;
            var contests = new Dictionary<string, string>();
            var users = new Dictionary<string, Dictionary<string, int>>();

            while ((input = Console.ReadLine()) != "end of contests")
            {
                string contest = input.Split(':')[0];
                string password = input.Split(':')[1];

                if (!contests.ContainsKey(contest))
                    contests[contest] = password;
            }

            while ((input = Console.ReadLine()) != "end of submissions")
            {
                string contest = input.Split("=>")[0];
                string password = input.Split("=>")[1];
                string username = input.Split("=>")[2];
                int points = int.Parse(input.Split("=>")[3]);

                if(ContestIsValid(contests, contest) && PasswordIsValid(contests, password))
                {
                    if (!users.ContainsKey(username))
                        users[username] = new Dictionary<string, int>();
                    if (!users[username].ContainsKey(contest))
                        users[username][contest] = points;
                    else
                    {
                        if(users[username][contest] < points)
                            users[username][contest] = points;
                    }
                }
            }

            var bestPoint = new Dictionary<string, int>();
            foreach (var user in users)
            {
                bestPoint[user.Key] = user.Value.Values.Sum();
            }

            int maxPoint = bestPoint.Values.Max();
            foreach (var user in bestPoint)
            {
                if(user.Value == maxPoint)
                    Console.WriteLine($"Best candidate is {user.Key} with total {user.Value} points.");
            }

            Console.WriteLine("Ranking: ");
            foreach (var user in users.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{user.Key}");
                foreach (var points in user.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {points.Key} -> {points.Value}");
                }
            }
        }
        static bool ContestIsValid(Dictionary<string,string> dict, string str)
        {
            return dict.ContainsKey(str);
        }
        static bool PasswordIsValid(Dictionary<string, string> dict, string str)
        {
            return dict.ContainsValue(str);
        }
    }
}
