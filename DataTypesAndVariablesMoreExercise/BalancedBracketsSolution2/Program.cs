using System;
using System.Linq;

namespace BalancedBracketsSolution2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            string[] stringRead = new string[numberOfLines];
            bool chekBracketTrue = false;

            for (int i = 0; i < numberOfLines; i++)
            {
                stringRead[i] = Console.ReadLine();

                if (i == numberOfLines - 1)
                {
                    string str = string.Empty;
                    
                    for (int j = 0; j < stringRead.Length; j++)
                    {
                        string temp = stringRead[j].Trim(' ');
                        if (temp == "(" && !str.Contains('('))
                        {
                            chekBracketTrue = false;
                            str += temp;
                        }
                        else if (temp == "(" && str.Contains('('))
                        {
                            chekBracketTrue = false;
                            break;
                        }
                        else if (temp == ")" && str.Contains('('))
                        {
                            chekBracketTrue = true;
                            str = string.Empty;
                        }
                        else if (temp == ")" && !str.Contains('('))
                        {
                            chekBracketTrue = false;
                            break;
                        }
                    }
                }
            }

            if (chekBracketTrue)
                Console.WriteLine("BALANCED");
            else
                Console.WriteLine("UNBALANCED");
        }
    }
}
