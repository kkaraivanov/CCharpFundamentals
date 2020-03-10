namespace LettersChangeNumbers
{
    using System;
    class EntryPoint
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            decimal result = 0;

            for (int i = 0; i < input.Length; i++)
            {
                string ferstLetter = "" + input[i][0];
                string lastLetter = "" + input[i][input[i].Length - 1];
                decimal number = int.Parse(input[i].Substring(1, input[i].Length - 2));

                number.FromLetter(ferstLetter, lastLetter);
                result += number;
            }

            Console.WriteLine($"{result:f2}");
        }
    }
}
