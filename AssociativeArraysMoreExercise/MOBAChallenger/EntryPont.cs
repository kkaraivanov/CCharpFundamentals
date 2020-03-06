namespace MOBAChallenger
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class EntryPont
    {
        static void Main()
        {
            var players = new Dictionary<string, Dictionary<string, int>>();
            AddPlayersToDictionary(players);

            foreach (var item in players
                .OrderByDescending(x => x.Value.Values.Sum())
                .ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value.Values.Sum()} skill");
                Console.WriteLine(string.Join($"{Environment.NewLine}", item.Value
                    .OrderByDescending(x => x.Value)
                    .ThenBy(x => x.Key)
                    .Select(x => $"- {x.Key} <::> {x.Value}")));
            }
        }

        private static void AddPlayersToDictionary(Dictionary<string, Dictionary<string, int>> dict)
        {
            string input = null;
            bool separator = false;

            while ((input = Console.ReadLine()) != "Season end")
            {
                string user = null;
                string position = null;
                int skill = 0;
                separator = input.Contains(" vs ") ? true : false;
                var inputArray = input.Split().ToArray().Where(x => x != "vs" && x != "->").ToArray();
                
                if (separator)
                {
                    user = inputArray[0];
                    string oponent = inputArray[1];

                    if (dict.ContainsKey(user) && dict.ContainsKey(oponent))
                        GameBattle(dict, user, oponent);
                }
                else
                {
                    user = inputArray[0];
                    position = inputArray[1];
                    skill = int.Parse(inputArray[2]);

                    if (!dict.ContainsKey(user))
                        dict[user] = new Dictionary<string, int>();

                    if (!dict[user].ContainsKey(position))
                        dict[user][position] = 0;

                    if (dict[user][position] < skill)
                        dict[user][position] = skill;
                }
            }
        }

        static void RemovePlayerFromDictionary(Dictionary<string, Dictionary<string, int>> dict, string player)
        {
            foreach (var item in dict)
            {
                dict.Remove(player);
            }
        }

        static void CompareSkills(Dictionary<string, Dictionary<string, int>> dict, 
            int skillOne, int skillTwo,
            string playerOne, string playerTwo)
        {
            if (skillOne > skillTwo)
            {
                RemovePlayerFromDictionary(dict, playerTwo);
            }
            else if (skillOne < skillTwo)
            {
                RemovePlayerFromDictionary(dict, playerOne);
            }
        }
        private static void GameBattle(Dictionary<string, Dictionary<string, int>> dict, string playerOne, string playerTwo)
        {
            var skillPlayerOne = GetPlayerSkills(dict, playerOne).ToDictionary(x => x.Key, x => x.Value);
            var skillPlayerTwo = GetPlayerSkills(dict, playerTwo).ToDictionary(x => x.Key, x => x.Value);

            foreach (var positionPlayerOne in skillPlayerOne)
            {
                foreach (var positionPlayerTwo in skillPlayerTwo)
                {
                    if (positionPlayerOne.Key == positionPlayerTwo.Key)
                    {
                        CompareSkills(dict, positionPlayerOne.Value, positionPlayerTwo.Value, playerOne, playerTwo);
                    }
                }
            }
        }

        static Dictionary<string, int> GetPlayerSkills(Dictionary<string, Dictionary<string, int>> dict, string player)
        {
            var temp = new Dictionary<string, int>();
            foreach (var item in dict)
            {
                if (item.Key == player)
                {
                    foreach (var position in item.Value)
                    {
                        temp.Add(position.Key, position.Value);
                    }
                }
            }

            return temp;
        }
    }
}
