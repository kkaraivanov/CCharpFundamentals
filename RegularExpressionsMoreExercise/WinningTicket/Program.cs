namespace WinningTicket
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            string pattern = @"[\@]{6,}|[\#]{6,}|[\$]{6,}|[\^]{6,}";
            var match = new Regex(pattern);

            foreach (var ticket in input)
            {
                if (ticket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }

                var matchLeft = match.Match(ticket.Substring(0, 10));
                var matchRight = match.Match(ticket.Substring(10));
                var length = Math.Min(matchLeft.Length, matchRight.Length);

                if (!matchLeft.Success || !matchRight.Success)
                {
                    Console.WriteLine($"ticket \"{ ticket}\" - no match");
                }
            }
        }
    }
}