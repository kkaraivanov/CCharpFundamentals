using System;
using System.Collections.Generic;
using System.Linq;

namespace ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> numbers = Console.ReadLine().Split().Select(long.Parse).ToList();
            string commands = null;

            while ((commands = Console.ReadLine()) != "end")
            {
                string[] commandsLine = commands.Split().ToArray();
                string command = commandsLine[0];

                switch (command)
                {
                    case "Insert":
                        long insertElement = long.Parse(commandsLine[1]);
                        int index = int.Parse(commandsLine[2]);
                        InsertElement(numbers, index, insertElement);
                        break;
                    case "Delete":
                        long deleteElement = long.Parse(commandsLine[1]);
                        DeleteElement(numbers, deleteElement);
                        break;
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }

        private static void DeleteElement(List<long> numbers, long element)
        {
            numbers.Remove(element);

            if (numbers.Contains(element))
                DeleteElement(numbers, element);
        }

        private static void InsertElement(List<long> numbers, int index, long element)
        {
            if (index >= 0 && index <= numbers.Count)
                numbers.Insert(index, element);
        }
    }
}
