using System;

namespace ExtractPersonInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfLines; i++)
            {
                var line = Console.ReadLine();
                string name = line.Remove(line.IndexOf('|')).Substring(line.IndexOf('@') + 1);
                string age = line.Remove(line.IndexOf('*')).Substring(line.IndexOf('#') + 1);

                Console.WriteLine($"{name} is {age} years old.");
            }
        }
    }
}
