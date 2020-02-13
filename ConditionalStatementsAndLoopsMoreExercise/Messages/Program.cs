using System;
using System.Collections.Generic;

namespace Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            int textLenth = int.Parse(Console.ReadLine());

            Dictionary<int, char> keyboard = new Dictionary<int, char>();
            keyboard.Add(2, 'a');
            keyboard.Add(22, 'b');
            keyboard.Add(222, 'c');
            keyboard.Add(3, 'd');
            keyboard.Add(33, 'e');
            keyboard.Add(333, 'f');
            keyboard.Add(4, 'g');
            keyboard.Add(44, 'h');
            keyboard.Add(444, 'i');
            keyboard.Add(5, 'j');
            keyboard.Add(55, 'k');
            keyboard.Add(555, 'l');
            keyboard.Add(6, 'm');
            keyboard.Add(66, 'n');
            keyboard.Add(666, 'o');
            keyboard.Add(7, 'p');
            keyboard.Add(77, 'q');
            keyboard.Add(777, 'r');
            keyboard.Add(7777, 's');
            keyboard.Add(8, 't');
            keyboard.Add(88, 'u');
            keyboard.Add(888, 'v');
            keyboard.Add(9, 'w');
            keyboard.Add(99, 'x');
            keyboard.Add(999, 'y');
            keyboard.Add(9999, 'z');
            keyboard.Add(0, ' ');

            string text = string.Empty;
            int textChar = int.Parse(Console.ReadLine());
            for (int i = 1; i <= textLenth; i++)
            {
                text += keyboard[textChar];
                if (i == textLenth)
                {
                    break;
                }
                else
                    textChar = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(text);
        }
    }
}
