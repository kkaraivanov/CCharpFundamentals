using System;
using System.Text.RegularExpressions;

namespace Digits_LettersAndOther
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            var output = new string[3];

            for (int i = 0; i < line.Length; i++)
            {
                string currentLetter = line[i].ToString();
                if (IsDigit(currentLetter))
                    output[0] += currentLetter;
                else if (IsLetter(currentLetter))
                    output[1] += currentLetter;
                else
                    output[2] += currentLetter;
            }

            Console.WriteLine(string.Join($"{Environment.NewLine}", output));
        }

        static bool IsDigit(string l)
        {
            return Regex.IsMatch(l, "[0-9]");
        }

        static bool IsLetter(string l)
        {
            return Regex.IsMatch(l, "[a-zA-Z]");
        }
    }
}
