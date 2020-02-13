using System;

namespace PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = string.Empty;

            while ((line = Console.ReadLine()) != "END")
            {
                if(GetPalindrome(line))
                    Console.WriteLine("true");
                else
                    Console.WriteLine("false");
            }
        }
        public static bool GetPalindrome(string longToString)
        {
            string originalFirstChar = longToString.Substring(0, longToString.Length / 2);
            char[] tempArray = longToString.ToCharArray();
            Array.Reverse(tempArray);

            string tempString = new string(tempArray);
            string palindromeFerstChar = tempString.Substring(0, tempString.Length / 2);

            return originalFirstChar.Equals(palindromeFerstChar);
        }


    }
}
