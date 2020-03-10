using System;

namespace StringExplosion
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split('>'); // abv>1>1>2>2asdasd || pesho>2sis>1a>2akarate>4hexmaster

            int power = 0;
            int powerLengther = 0;
            for (int i = 1; i < input.Length; i++)
            {
                power = int.Parse("" + input[i][0]) + powerLengther;
                powerLengther = power - input[i].Length;
                if (power > input[i].Length)
                    power = input[i].Length;

                input[i] = input[i].Substring(power);
                if (powerLengther < 0)
                    powerLengther = 0;
            }
            
            Console.WriteLine(string.Join(">", input));
        }
    }
}
