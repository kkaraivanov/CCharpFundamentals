using System;
using System.Linq;
using System.Collections.Generic;

namespace ListManipulationBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> numbers = Console.ReadLine()
                .Split()
                .Select(long.Parse)
                .ToList();
            string commands = string.Empty;

            while ((commands = Console.ReadLine()) != "end")
            {
                string[] command = commands.Split().ToArray();
                int num = 0;

                switch (command[0])
                {
                    case "Add":
                        num = int.Parse(command[1]);
                        numbers.Add(num);
                        break;
                    case "Remove":
                        num = int.Parse(command[1]);
                        numbers.Remove(num);
                        break;
                    case "RemoveAt":
                        num = int.Parse(command[1]);
                        numbers.RemoveAt(num);
                        break;
                    case "Insert":
                        num = int.Parse(command[1]);
                        int index = int.Parse(command[2]);
                        numbers.Insert(index, num);
                        break;
                }
            }

            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
