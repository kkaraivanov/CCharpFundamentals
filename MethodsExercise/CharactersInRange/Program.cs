using System;

namespace CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char ferstCharacter = char.Parse(Console.ReadLine());
            char secondCharacter = char.Parse(Console.ReadLine());

            Console.Write(string.Join(" ", GetCharRange(ferstCharacter, secondCharacter)));
        }

        static char[] GetCharRange(char c1, char c2)
        {
            string result = string.Empty;
            int start = c1;
            int end = c2;
            if (start > end)
            {
                end = start ^ end;
                start = end ^ start;
                end = start ^ end;
            }
            for (int i = start + 1; i < end; i++)
            {
                result += (char)i;
            }

            return result.ToCharArray();
        }
    }
}
