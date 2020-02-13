using System;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            string command = Console.ReadLine();

            //provided variables
            double totalCoins = 0;
            double price = 0;

            while (command != "Start")
            {
                double coins = double.Parse(command);
                if (coins == 0.1 || coins == 0.2 || coins == 0.5 || coins == 1 || coins == 5)
                {
                    totalCoins += coins;
                }
                else
                    Console.WriteLine($"Cannot accept {coins}");
                
                command = Console.ReadLine();
            }

            while (command != "End")
            {
                bool chekProducts = false;
                if (command != "Start")
                {
                    switch (command)
                    {
                        case "Nuts":
                            price = 2.0;
                            chekProducts = true;
                            break;
                        case "Water":
                            price = 0.7;
                            chekProducts = true;
                            break;
                        case "Crisps":
                            price = 1.5;
                            chekProducts = true;
                            break;
                        case "Soda":
                            price = 0.8;
                            chekProducts = true;
                            break;
                        case "Coke":
                            price = 1.0;
                            chekProducts = true;
                            break;
                        default:
                            Console.WriteLine("Invalid product");
                            chekProducts = false;
                            break;
                    }

                    if (price <= totalCoins && chekProducts)
                    {
                        Console.WriteLine($"Purchased {command.ToLower()}");
                        totalCoins -= price;
                    }
                    else if (price != 0)
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Change: {totalCoins:f2}");
        }
    }
}
