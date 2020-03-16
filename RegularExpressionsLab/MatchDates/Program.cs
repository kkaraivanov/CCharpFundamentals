namespace MatchDates
{
    using System;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(\d{2})([-.\/])([A-Z][a-z]{2})\2(\d{4})";
            var input = Console.ReadLine();
            var dates = Regex.Matches(input, pattern);
            
            foreach (Match date in dates)
            {
                string day = date.Groups[1].Value;
                string month = date.Groups[3].Value;
                string year = date.Groups[4].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
