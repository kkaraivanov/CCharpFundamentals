namespace MatchFullName
{
    using System;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b([A-Z][a-z]+)[\s^\t]([A-Z][a-z]+)";
            var matches = Regex.Matches(Console.ReadLine(),pattern);

            foreach (Match match in matches)
            {
                Console.Write(match.ToString() + " ");
            }

            Console.WriteLine();
        }
    }
}
