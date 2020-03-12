namespace ExtractEmails
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"((?<=\s)[a-zA-Z0-9]+([-.]\w*)*@[a-zA-Z]+?([.-][a-zA-Z]*)*(\.[a-z]{2,}))";
            var matches = Regex.Matches(text, pattern);
            var emails = new List<string>();

            foreach (var match in matches)
            {
                emails.Add(match.ToString());
            }

            Console.WriteLine(string.Join(Environment.NewLine, emails));
        }
    }
}
