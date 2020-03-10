using System;
using System.Collections.Generic;
using System.Linq;

namespace TreasureFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var findTreasures = new List<string>();
            string line = null;

            while ((line = Console.ReadLine()) != "find")
            {
                int count = 0;
                string temp = null;
                while (count < line.Length)
                {
                    foreach (var key in numbers)
                    {
                        if (count > line.Length - 1)
                            break;
                        int current = line[count] - key;
                        temp += Convert.ToString((char)current);
                        count++;
                    }
                }
                string type = temp.Split('&')[1];
                string coordinates = temp.Split(new char[] { '<' , '>'})[1];

                findTreasures.Add($"Found {type} at {coordinates}");
            }

            Console.WriteLine(string.Join($"{Environment.NewLine}", findTreasures));
        }
    }
}
