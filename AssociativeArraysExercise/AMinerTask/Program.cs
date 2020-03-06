namespace AMinerTask
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            string input = null;
            string item = null;
            var counter = 0;
            var items = new Dictionary<string, long>();

            while ((input = Console.ReadLine()) != "stop")
            {
                counter++;
                if (counter % 2 != 0)
                {
                    item = input;
                    if (!items.ContainsKey(item))
                        items[item] = 0;
                }
                else
                    items[item] += long.Parse(input);
            }
            foreach (var currentItem in items)
            {
                Console.WriteLine($"{currentItem.Key} -> {currentItem.Value}");
            }
        }
    }
}
