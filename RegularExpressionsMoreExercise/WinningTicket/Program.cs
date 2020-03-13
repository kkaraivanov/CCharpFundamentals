namespace WinningTicket
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main(string[] args)
        {
            var tikets = Console.ReadLine()
                .Split(new char[] { ' ', ','}, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            foreach (var tiket in tikets)
            {
                if(tiket.Length < 20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }
                
                string pattern = @"^(?:[\w]+)?([\@\#\$\^]{10}|[\@\#\$\^]{6})(?:[\w]+)?(\1)";
                var match = Regex.Match(tiket, pattern);

                if (!match.Success) 
                {
                    Console.WriteLine($"ticket \"{tiket}\" - no match");
                    continue;
                }

                if ((match.Groups[1].Value == match.Groups[2].Value) && match.Groups[1].Value.Length == 10)
                    Console.WriteLine($"ticket \"{tiket}\" - 10{match.Groups[1].Value[0]} Jackpot!");
                else if ((match.Groups[1].Value == match.Groups[2].Value) && match.Groups[1].Value.Length == 6)
                    Console.WriteLine($"ticket \"{tiket}\" - 6{match.Groups[1].Value[0]}");
            }
        }
    }
}
