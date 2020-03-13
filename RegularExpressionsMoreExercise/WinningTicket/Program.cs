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
            var colectionTikets = new Dictionary<string, string>();
            string simpleWin = @"[\@]{6,9}|[\#]{6,9}|[\$]{6,9}|[\^]{6,9}";
            string jacpot = @"[\@]{10}|[\#]{10}|[\$]{10}|[\^]{10}";

            foreach (var tiket in input)
            {
                if (tiket.Length != 20)
                {
                    colectionTikets.Add(tiket, "invalid ticket");
                    continue;
                }

                string partLeft = tiket.Substring(0, 10);
                string partRight = tiket.Substring(10, 10);
                Match simpleWinLeft = Regex.Match(partLeft, simpleWin);
                Match simpleWinRight = Regex.Match(partRight, simpleWin);
                Match jacpotLeft = Regex.Match(partLeft, jacpot);
                Match jacpotRight = Regex.Match(partLeft, jacpot);

                if (jacpotLeft.Success && jacpotRight.Success)
                    colectionTikets.Add(tiket, $"10{jacpotLeft.ToString()[0]} Jackpot!");
                else if (simpleWinLeft.Success && simpleWinRight.Success && simpleWinLeft.ToString()[0].Equals(simpleWinRight.ToString()[0]))
                {
                    var count = Math.Min(simpleWinLeft.Length, simpleWinRight.Length);
                    colectionTikets.Add(tiket, $"{count}{simpleWinLeft.ToString()[0]}");
                }
                else
                    colectionTikets.Add(tiket, "no match");
            }

            foreach (KeyValuePair<string,string> tiket in colectionTikets)
            {
                if (tiket.Value.Equals("invalid ticket"))
                    Console.WriteLine("invalid ticket");
                else
                    Console.WriteLine($"ticket \"{tiket.Key}\" - {tiket.Value}");
            }
        }
    }
}