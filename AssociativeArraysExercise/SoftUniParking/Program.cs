namespace SoftUniParking
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int line = int.Parse(Console.ReadLine());
            var parking = new Dictionary<string, string>();

            for (int i = 0; i < line; i++)
            {
                string commands = Console.ReadLine();
                string command = commands.Split(" ", 2)[0];
                string action = commands.Split(" ", 2)[1];

                switch (command)
                {
                    case "register":
                        if (!parking.ContainsKey(action.Split()[0]))
                        {
                            parking[action.Split()[0]] = action.Split()[1];
                            Console.WriteLine($"{action.Split()[0]} registered {action.Split()[1]} successfully");
                        }
                        else
                            Console.WriteLine($"ERROR: already registered with plate number {action.Split()[1]}");
                        break;
                    case "unregister":
                        if (!parking.ContainsKey(action))
                            Console.WriteLine($"ERROR: user {action} not found");
                        else
                        {
                            Console.WriteLine($"{action} unregistered successfully");
                            parking.Remove(action);
                        }
                        break;
                }
            }

            Console.WriteLine(string.Join($"{Environment.NewLine}", parking.Select(x => $"{x.Key} => {x.Value}")));
        }
    }
}
