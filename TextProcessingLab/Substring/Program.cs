using System;

namespace Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string line1 = Console.ReadLine().ToLower();
            string line2 = Console.ReadLine();
            int index = line2.IndexOf(line1);

            while (index != -1)
            {
                line2 = line2.Remove(index, line1.Length);
                index = line2.IndexOf(line1);
            }

            Console.WriteLine(line2);
        }
    }
}
