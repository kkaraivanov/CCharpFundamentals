using System;

namespace EnglishNameOfTheLastDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int lastNumber = number.Length - 1;

            for (int i = 0; i < number.Length; i++)
            {
                if (i == lastNumber)
                {
                    lastNumber = int.Parse(number[i].ToString());
                }
            }
            Console.WriteLine(GetWordFromLastDigitOfAGivenNumber(lastNumber));
        }

        static string GetWordFromLastDigitOfAGivenNumber(int digit)
        {
            string returnWord = string.Empty;
            switch (digit)
            {
                case 0:
                    returnWord = "zero";
                    break;
                case 1:
                    returnWord = "one";
                    break;
                case 2:
                    returnWord = "two";
                    break;
                case 3:
                    returnWord = "three";
                    break;
                case 4:
                    returnWord = "four";
                    break;
                case 5:
                    returnWord = "five";
                    break;
                case 6:
                    returnWord = "six";
                    break;
                case 7:
                    returnWord = "seven";
                    break;
                case 8:
                    returnWord = "eight";
                    break;
                case 9:
                    returnWord = "nine";
                    break;
                default:
                    break;
            }
            return returnWord;
        }
    }
}
