using System;
using System.Collections.Generic;
using System.Linq;

namespace HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> ghost = new List<string>();
            int numberOfCommands = int.Parse(Console.ReadLine());

            while (numberOfCommands > 0)
            {
                string[] commands = Console.ReadLine().Split().ToArray();
                string command = commands[2];

                switch (command)
                {
                    case "going!":
                        string addGhost = commands[0];
                        AddGhost(ghost, addGhost);
                        break;
                    case "not":
                        string removeGhost = commands[0];
                        RemoveGhost(ghost, removeGhost);
                        break;
                }

                numberOfCommands--;
            }

            Console.WriteLine(string.Join("\n", ghost));
        }

        private static void AddGhost(List<string> ghost, string ghostName)
        {
            if (!ghost.Contains(ghostName))
                ghost.Add(ghostName);
            else
                Console.WriteLine($"{ghostName} is already in the list!");
        }
        private static void RemoveGhost(List<string> ghost, string ghostName)
        {
            if (ghost.Contains(ghostName))
                ghost.Remove(ghostName);
            else
                Console.WriteLine($"{ghostName} is not in the list!");
        }
    }
}
