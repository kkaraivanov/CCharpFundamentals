using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> numbers = Console.ReadLine().Split().Select(long.Parse).ToList();
            string commands = null;

            while ((commands = Console.ReadLine()) != "End")
            {
                string[] line = commands.Split().ToArray();
                string command = line[0];

                switch (command)
                {
                    case "Add":
                        long addNumber = long.Parse(line[1]);
                        AddNumberInList(numbers, addNumber);
                        break;
                    case "Insert":
                        long removeNumber = long.Parse(line[1]);
                        int index = int.Parse(line[2]);
                        InsertNumberInList(numbers, index, removeNumber);
                        break;
                    case "Remove":
                        int removeIndex = int.Parse(line[1]);
                        RemoveNumberInList(numbers, removeIndex);
                        break;
                    case "Shift":
                        string subCommand = line[1];
                        switch (subCommand)
                        {
                            case "left":
                                int countMoveLeft = int.Parse(line[2]);
                                MoveLeftNumberInList(numbers, countMoveLeft);
                                break;
                            case "right":
                                int countMoveRight = int.Parse(line[2]);
                                MoveRighttNumberInList(numbers, countMoveRight);
                                break;
                        }
                        break;
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }

        private static void MoveRighttNumberInList(List<long> numbers, int count)
        {
            for (int i = 0; i < count; i++)
            {
                long lastNumber = numbers[numbers.Count - 1];
                numbers.RemoveAt(numbers.Count - 1);
                numbers.Insert(0, lastNumber);
            }
        }

        private static void MoveLeftNumberInList(List<long> numbers, int count)
        {
            for (int i = 0; i < count; i++)
            {
                long ferstNumber = numbers[0];
                numbers.RemoveAt(0);
                numbers.Add(ferstNumber);
            }
        }

        private static void RemoveNumberInList(List<long> numbers, int index)
        {
            if (ChekValidIndex(numbers, index))
                numbers.RemoveAt(index);
        }

        private static void InsertNumberInList(List<long> numbers, int index, long number)
        {
            if (ChekValidIndex(numbers, index))
                numbers.Insert(index, number);
        }

        private static bool ChekValidIndex(List<long> numbers, int index)
        {
            bool result = false;
            if (index >= 0 && index <= numbers.Count)
                result = true;
            else
            {
                Console.WriteLine("Invalid index");
                result = false;
            }

            return result;
        }

        private static void AddNumberInList(List<long> numbers, long number)
        {
            numbers.Add(number);
        }
    }
}
