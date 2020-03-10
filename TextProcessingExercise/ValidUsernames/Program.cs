namespace ValidUsernames
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join($"{Environment.NewLine}", Console.ReadLine()
                .Split(", ")
                .ToArray()
                .Where(x => IsValid(x))));
        }

        static bool IsValid(string line)
        {
            return Regex.IsMatch(line, @"^([\w\d-]{3,16})$");
        }
    }
}
