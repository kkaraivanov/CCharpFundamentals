namespace MatchPhoneNumber
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(\+359([ -])2(\2)(\d{3})(\2)(\d{4}))\b";

            string input = Console.ReadLine();
            var matches = Regex.Matches(input, pattern);
            var phones = matches
                .Cast<Match>()
                .Select(x => x.Value.Trim())
                .ToArray();
            
            Console.WriteLine(string.Join(", ", phones));
        }
    }
}
