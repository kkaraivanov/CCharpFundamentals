using System;
using System.Collections.Generic;
using System.Linq;

namespace AnonymousThreat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inputLine = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            string commands = string.Empty;

            while ((commands = Console.ReadLine()) != "3:1")
            { 
                string[] command = commands.Split().ToArray();
                switch (command[0])
                {
                    case "merge":
                        int startIndex = int.Parse(command[1]);
                        int endIndex = int.Parse(command[2]);
                        inputLine = MargeElements(inputLine, startIndex, endIndex).ToList();
                        break;
                    case "divide":
                        int index = int.Parse(command[1]);
                        int partitions = int.Parse(command[2]);
                        inputLine = DivideElements(inputLine, index, partitions);
                        break;
                }
            }

            Console.WriteLine(string.Join(" ", inputLine));
        }

        private static List<string> DivideElements(List<string> inputLine, int index, int partitions)
        {
            string divideElement = inputLine[index]; // стринг за разделяне с дължина index
            string[] div = new string[partitions];
            int length = divideElement.Length / partitions; // разделям стринга на равни части
            if (length <= 0)
                return inputLine;
            for (int i = 0; divideElement.Length > length; i++)
            {
                //добавям length брой елементи в масива
                if (i >= div.Length - 1)
                    break;
                div[i] = divideElement.Substring(0, length);

                //премахвам от стринга добавените в масива елементи
                //if()
                divideElement = divideElement.Substring(length);
            }
            div[partitions - 1] += divideElement; // добавям последната част от стринга

            return inputLine.Take(index)
                .Concat(div)
                .Concat(inputLine.Skip(index + 1))
                .ToList();
        }
        
    private static List<string> MargeElements(List<string> inputLine, int startIndex, int endIndex)
        {
            string newItem = string.Empty;

            if (startIndex < 0 || startIndex > inputLine.Count)
                startIndex = 0;
            if (endIndex > inputLine.Count || endIndex < 0)
                endIndex = inputLine.Count - 1;
            
            for (int i = startIndex; i <= endIndex; i++)
                newItem += inputLine[i];

            return inputLine.Take(startIndex)
                .Concat(new[] { newItem })
                .Concat(inputLine.Skip(endIndex + 1))
                .ToList();
        }
    }
}
