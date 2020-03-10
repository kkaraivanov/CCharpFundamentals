using System;

namespace ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split('\\');

            Console.WriteLine($"File name: {input[input.Length - 1].Split('.')[0]}");
            Console.WriteLine($"File extension: {input[input.Length - 1].Split('.')[1]}");
        }
    }
}
