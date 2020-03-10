using System;
using System.Text;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var sb = new StringBuilder();

            foreach (var item in input)
            {
                var newItem = item + 3;
                sb.Append((char)newItem);
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
