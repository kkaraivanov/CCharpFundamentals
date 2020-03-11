namespace Furniture
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    class Program
    {
        static void Main()
        {
            string lines = null;
            string rgx = @">>([A-Za-z\s]+)<<(\d+(.\d+)?)!(\d+)";
            var furniture = new List<string>();
            decimal price = 0;

            while ((lines = Console.ReadLine()) != "Purchase")
            {
                Match match = Regex.Match(lines, rgx);
                if (match.Success)
                {
                    furniture.Add(match.Groups[1].Value);
                    price += decimal.Parse(match.Groups[2].Value) * int.Parse(match.Groups[4].Value);
                }
            }

            Console.WriteLine("Bought furniture:");
            if(furniture.Count > 0)
                Console.WriteLine(string.Join(Environment.NewLine,furniture));
            Console.WriteLine($"Total money spend: {price:f2}");
        }
    }
}
