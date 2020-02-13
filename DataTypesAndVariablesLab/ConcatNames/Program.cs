using System;

namespace ConcatNames
{
    class Program
    {
        static void Main(string[] args)
        {
            string ferstName = Console.ReadLine();
            string secondName = Console.ReadLine();
            string delimiter = Console.ReadLine();

            Console.WriteLine($"{ferstName}{delimiter}{secondName}");
        }
    }
}
