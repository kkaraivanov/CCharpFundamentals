using System;

namespace DecryptingMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int numberOfChars = int.Parse(Console.ReadLine());

            string printMessage = "";
            for (int i = 0; i < numberOfChars; i++)
            {
                int asciiKey = char.Parse(Console.ReadLine()) + key;
                char asciiChar = (char)asciiKey;
                printMessage += asciiChar.ToString();
            }
            Console.WriteLine(printMessage);
        }
    }
}
