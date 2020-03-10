using System;
using System.Collections.Generic;

namespace MorseCodeTranslator
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(" | ");
            var stringDisplay = new List<string>();

            foreach (var line in input)
            {
                stringDisplay.Add(Word(line.Split()));
            }

            Console.WriteLine(string.Join(" ", stringDisplay));
        }

        static string Word(string[] arr)
        {
            string s = null;
            foreach (var item in arr)
            {
                s += Morse(item);
            }

            return s;
        }
        static string Morse(string s)
        {
            return s == ".-" ? "A" : s == "-..." ? "B" : s == "-.-." ? "C" : s == "-.." ? "D" :s == "." ? "E" : 
                s == "..-." ? "F" : s == "--." ? "G" : s == "...." ? "H" :s == ".." ? "I" : s == ".---" ? "J" :
                s == "-.-" ? "K" : s == ".-.." ? "L" : s == "--" ? "M" : s == "-." ? "N" : s == "---" ? "O" :
                s == ".--." ? "P" : s == "--.-" ? "Q" : s == ".-." ? "R" : s == "..." ? "S" : s == "-" ? "T" :
                s == "..-" ? "U" : s == "...-" ? "V" : s == ".--" ? "W" : s == "-..-" ? "X" : s == "-.--" ? "Y" :
                s == "--.." ? "Z" : null;
        }
    }
}
