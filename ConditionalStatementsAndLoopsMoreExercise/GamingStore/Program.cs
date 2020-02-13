using System;

namespace GamingStore
{
    class Program
    {
        static void Main(string[] args)
        {
            double balanceMoney = double.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            double boughtMoney = 0;
            string[] games = { "OutFall 4", "CS: OG", "Zplinter Zell", "Honored 2", "RoverWatch", "RoverWatch Origins Edition" };

            while (command != "Game Time")
            {
                bool chekGameName = false;
                string gameName = string.Empty;
                if (balanceMoney == 0)
                {
                    Console.WriteLine("Out of money!");
                    break;
                }

                for (int i = 0; i < games.Length; i++)
                {
                    if (command.Equals(games[i]))
                    {
                        gameName = games[i];
                        chekGameName = true;
                    }
                }

                if (chekGameName)
                {
                    if (GetGamePrice(gameName) > balanceMoney)
                    {
                        Console.WriteLine("Too Expensive");
                    }
                    else
                    {
                        balanceMoney -= GetGamePrice(gameName);
                        boughtMoney += GetGamePrice(gameName);
                        Console.WriteLine($"Bought {gameName}");
                    }
                }
                else
                    Console.WriteLine("Not Found");

                command = Console.ReadLine();
            }
            Console.WriteLine(balanceMoney > 0 ? 
                $"Total spent: ${boughtMoney:f2}. Remaining: ${balanceMoney:f2}" :
                "Out of money!");
        }

        static double GetGamePrice(string gameName)
        {
            double price = 0;

            switch (gameName)
            {
                case "OutFall 4":
                    price = 39.99;
                    break;
                case "CS: OG":
                    price = 15.99;
                    break;
                case "Zplinter Zell":
                    price = 19.99;
                    break;
                case "Honored 2":
                    price = 59.99;
                    break;
                case "RoverWatch":
                    price = 29.99;
                    break;
                case "RoverWatch Origins Edition":
                    price = 39.99;
                    break;
            }

            return price;
        }
    }
}
