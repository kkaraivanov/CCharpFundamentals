using System;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int cost = int.Parse(Console.ReadLine());
            ReturnPrice(product, cost);
        }

        static void ReturnPrice(string product, int cost)
        {
            string[,] productsWithPrices = { { "coffee", "1.50"},
                                             { "water", "1.00" },
                                             { "coke", "1.40"},
                                             { "snacks", "2.00"}};
            double returnPrice = 0;
            for (int i = 0; i < productsWithPrices.GetLength(0); i++)
            {
                for (int j = 0; j < productsWithPrices.GetLength(1); j++)
                {
                    if (productsWithPrices[i,0].Contains(product))
                    {
                        returnPrice = double.Parse(productsWithPrices[i, 1]) * cost;
                    }
                }
            }
            Console.WriteLine($"{returnPrice:f2}");
        }
    }
}
