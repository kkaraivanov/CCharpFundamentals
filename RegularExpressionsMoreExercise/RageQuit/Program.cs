namespace RageQuit
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"(([^\d]+)(\d+))";
            var regex = new Regex(pattern);
            var matches = regex.Matches(text);
            StringBuilder result = new StringBuilder();

            foreach (Match match in matches)
            {
                string temp = match.Groups[2].Value;
                int repeats = int.Parse(match.Groups[3].Value);

                for (int i = 0; i < repeats; i++)
                {
                    result.Append(temp.ToUpper());
                }
            }
            
            int count = result.ToString().Distinct().Count();
            Console.WriteLine($"Unique symbols used: {count}");
            Console.WriteLine(result);
        }
    }
}