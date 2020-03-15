namespace PostOffice
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main()
        {
            var texts = Console.ReadLine()
                .Split('|', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var ferstPart = texts[0];
            var ferstLetts = Regex.Match(ferstPart, @"(([#$%&*])([A-Z]+)(\2))").Groups[3].Value;
            var secondPart = texts[1];
            var threePart = texts[2];

            foreach (var ferstLett in ferstLetts)
            {
                int asciiForFerstLett = ferstLett;
                int wordLength = int.Parse(Regex.Match(secondPart, $@"{asciiForFerstLett}:([0-9][0-9])").Groups[1].Value);
                string wordPart = $@"(?<=\s|^){ferstLett}[^\s]{{{wordLength}}}(?=\s|$)";
                string word = Regex.Match(threePart, wordPart).ToString();

                Console.WriteLine(word);
            }

        }
    }
}
