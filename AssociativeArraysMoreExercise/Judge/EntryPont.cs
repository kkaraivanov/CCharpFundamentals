namespace Judge
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class EntryPont
    {
        static void Main(string[] args)
        {
            string input = null;
            //<contest,<username,points>>
            var contests = new Dictionary<string, Dictionary<string, int>>();

            while ((input = Console.ReadLine()) != "no more time")
            {
                string user = input.Split(" -> ")[0];
                string contest = input.Split(" -> ")[1];
                int points = int.Parse(input.Split(" -> ")[2]);

                if (!contests.ContainsKey(contest))
                    contests[contest] = new Dictionary<string, int>();

                if (!contests[contest].ContainsKey(user))
                    contests[contest][user] = points;
                else
                {
                    if (contests[contest][user] < points)
                        contests[contest][user] = points;
                }
            }

            var usersTotalPoints = new Dictionary<string, int>();
            foreach (var contest in contests)
            {
                int counter = 1;
                foreach (var vel in contest.Value)
                {
                    if (!usersTotalPoints.ContainsKey(vel.Key))
                        usersTotalPoints[vel.Key] = 0;

                    usersTotalPoints[vel.Key] += vel.Value;
                }

                Console.WriteLine($"{contest.Key}: {contest.Value.Count} participants");
                Console.WriteLine(string.Join($"{Environment.NewLine}", contest.Value
                    .OrderByDescending(x => x.Value)
                    .ThenBy(x => x.Key)
                    .Select(x => $"{counter++}. {x.Key} <::> {x.Value}")));
            }
            
            int pointsCounter = 1;
            Console.WriteLine("Individual standings:");
            Console.WriteLine(string.Join($"{Environment.NewLine}", usersTotalPoints
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key)
                .Select(x => $"{pointsCounter++}. {x.Key} -> {x.Value}")));
        }
    }
}
