using System;
using System.Linq;

namespace ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split('\\');
            var fileParts = input.Last().Split('.').ToArray();
            Console.WriteLine($"File name: {string.Join(".",fileParts.Take(fileParts.Length - 1).ToArray())}");
            Console.WriteLine($"File extension: {fileParts.Last()}");
        }
    }
}
