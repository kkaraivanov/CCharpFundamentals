namespace Race
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(", ");
            var players = new Dictionary<string, double>();

            foreach (var player in input)
                if (!players.ContainsKey(player))
                    players[player] = 0;

            string resultats = Console.ReadLine();
            while (true)
            {
                if (resultats == "end of race")
                    break;
                
                string name = null;
                string regerForName = @"[A-Za-z]";
                var matchName = Regex.Matches(resultats, regerForName);
                
                foreach (Match item in matchName)
                    name += item.Value;
                
                if (players.ContainsKey(name))
                {
                    string regerForDistance = @"[0-9]";
                    var matchDistance = Regex.Matches(resultats, regerForDistance);
                    double distance = 0;
                    foreach (Match item in matchDistance)
                    {
                        distance += double.Parse(item.Value);
                    }
                    players[name] += distance;
                }
                resultats = Console.ReadLine();
            }

            int counter = 1;
            foreach (var player in players.OrderByDescending(x => x.Value))
            {
                if(counter == 1)
                    Console.WriteLine($"{counter}st place: {player.Key}");
                else if(counter == 2)
                    Console.WriteLine($"{counter}nd place: {player.Key}"); 
                else if(counter == 3)
                    Console.WriteLine($"{counter}rd place: {player.Key}");

                counter++;
            }
        }
    }
}
