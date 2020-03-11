namespace SoftUniBarIncome
{
    using System;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            decimal totalPrice = 0;

            while (true)
            {
                if (input == "end of shift")
                    break;

                string rgx = @"^%([A-Z][a-z]*)%[^|$%.]*<(\w+)>[^|$%.]*\|([0-9]+)\|[^|$%.]*?([0-9]+\.*[0-9]*)\$$";
                var match = Regex.Match(input, rgx);
                string clients = null;
                string product = null;
                int count = 0;
                decimal price = 0;
                
                if (match.Success)
                {
                    clients = match.Groups[1].Value;
                    product = match.Groups[2].Value;
                    count = int.Parse(match.Groups[3].Value);
                    price = decimal.Parse(match.Groups[4].Value);

                    totalPrice += price * count;
                    Console.WriteLine($"{clients}: {product} - {price * count:f2}");
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Total income: {totalPrice:f2}");
        }
    }
}
