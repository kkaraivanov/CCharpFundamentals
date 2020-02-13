using System;

namespace SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            int result = 0;
            for (int i = 0; i < n.Length; i++)
            {
                int number = int.Parse(n[i].ToString());
                result += number;
            }
            Console.WriteLine(result);
        }
    }
}
