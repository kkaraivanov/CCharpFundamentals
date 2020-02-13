using System;
using System.Collections.Generic;
using System.Linq;

namespace Messaging
{
    class Program
    {
        private static string getElementString = string.Empty;
        static void Main(string[] args)
        {
            List<int> lineNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            getElementString = Console.ReadLine();
            string writeMessage = string.Empty;

            foreach (var item in lineNumbers)
            {
                int sumASCIINumber = GetSum(item);
                writeMessage += GetMessage(sumASCIINumber, getElementString);
            }
            Console.WriteLine(writeMessage);
        }

        private static string GetMessage(int value, string stringValue)
        {
            string temporaryMessage = string.Empty;
            if (value >= stringValue.Length)
            {
                while (value > stringValue.Length)
                {
                    value -= stringValue.Length;
                }
                temporaryMessage += stringValue.Substring(value, 1);
            }
            else
                temporaryMessage += stringValue.Substring(value, 1);
            
            getElementString = getElementString.Remove(value, 1);
            return temporaryMessage;
        }

        private static int GetSum(int num)
        {
            string str = num.ToString();
            List<int> temp = new List<int>();

            for (int i = 0; i < str.Length; i++)
                temp.Add(int.Parse(str[i].ToString()));
            return temp.Sum();
        }
    }
}
