namespace Orders
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            var products = new Dictionary<string, ProductProperty>();
            string command = null;

            while ((command = Console.ReadLine()) != "buy")
            {
                string product = command.Split()[0];
                decimal price = decimal.Parse(command.Split()[1]);
                int quantity = int.Parse(command.Split()[2]);

                if (!products.ContainsKey(product))
                    products[product] = new ProductProperty();

                products[product].Price = price;
                products[product].Quantity += quantity;
            }

            Console.WriteLine(string.Join("\n", products.Select(x => $"{x.Key} -> {x.Value.Quantity * x.Value.Price:f2}")));
        }
    }
}
