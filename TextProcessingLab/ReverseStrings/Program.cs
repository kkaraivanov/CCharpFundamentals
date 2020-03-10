using System;
using System.Text;

namespace ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = null;

            while ((line = Console.ReadLine()) != "end")
            {
                var sb = new StringBuilder();
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    sb.Append(line[i]);
                }

                Console.WriteLine($"{line} = {sb.ToString()}");
            }
        }
    }
}
