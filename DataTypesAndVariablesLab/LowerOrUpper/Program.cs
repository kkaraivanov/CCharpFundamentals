using System;

namespace LowerOrUpper
{
    class Program
    {
        static void Main(string[] args)
        {
            string c = Console.ReadLine();

            bool toLower = c == c.ToLower() ? true : false;
            bool toUpper = c == c.ToUpper() ? true : false;

            if (toUpper)
            {
                Console.WriteLine("upper-case");
            }
            if (toLower)
            {
                Console.WriteLine("lower-case");
            }
        }
    }
}
