using System;
using System.Linq;
using System.Text;

namespace ReplaceRepeatingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            var temp = ' ';
            var result = new StringBuilder();
            foreach (var item in line)
            {
                if (temp != item)
                {
                    temp = item;
                    result.Append(item);
                }
            }

            Console.WriteLine(result.ToString());
        }
    }
}
