using System;

namespace EvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = Math.Abs(int.Parse(Console.ReadLine()));

            while (input % 2 != 0)
            {
                Console.WriteLine("Please write an even number.");
                input = Math.Abs(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine($"The number is: {input}");
        }
    }
}
