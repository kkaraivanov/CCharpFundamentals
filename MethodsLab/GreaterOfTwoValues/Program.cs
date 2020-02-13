using System;

namespace GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string lineType = Console.ReadLine();
            switch (lineType)
            {
                case "int":
                    string ferstValueInt = Console.ReadLine();
                    string secondValueInt = Console.ReadLine();
                    if (!long.TryParse(ferstValueInt, out long i1) && !long.TryParse(secondValueInt, out long i2))
                        break;
                    else
                        Console.WriteLine(GetMaxSize(long.Parse(ferstValueInt), long.Parse(secondValueInt)));
                    break;
                case "char":
                    string ferstValueChar = Console.ReadLine();
                    string secondValueChar = Console.ReadLine();
                    if (!char.TryParse(ferstValueChar, out char c1) && !char.TryParse(secondValueChar, out char c2))
                        break;
                    else
                        Console.WriteLine(GetMaxSize(char.Parse(ferstValueChar), char.Parse(secondValueChar)));
                    break;
                case "string":
                    Console.WriteLine(GetMaxSize(Console.ReadLine(), Console.ReadLine()));
                    break;
                default:
                    break;
            }
        }
        static long GetMaxSize(long ferstValue, long secondValue)
        {
            long result = 0;
            result = ferstValue > secondValue ? ferstValue : ferstValue < secondValue ? secondValue : ferstValue;
            return result;
        }
        static char GetMaxSize(char ferstValue, char secondValue)
        {
            int result = 0;
            result = (int)ferstValue > (int)secondValue ? (int)ferstValue :
                     (int)ferstValue < (int)secondValue ? (int)secondValue : 
                     (int)ferstValue;

            return (char)result;
        }
        static string GetMaxSize(string ferstValue, string secondValue)
        {
            string result = string.Empty;
            int ferst = 0;
            int second = 0;
            if (int.TryParse(ferstValue, out ferst) && int.TryParse(secondValue, out second))
                result = ferst > second ? ferstValue : secondValue;
            else
            {
                for (int i = 0; i < ferstValue.Length; i++)
                {
                    result = ferstValue;
                    for (int j = 0; j < secondValue.Length; j++)
                    {
                        if (secondValue[j] > ferstValue[i]) 
                        {
                            result = secondValue;
                            i = ferstValue.Length - 1;
                            break;
                        }
                    }
                }
            }
            return result;
        }
    }
}