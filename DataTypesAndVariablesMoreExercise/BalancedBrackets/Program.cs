using System;
using System.Linq;

namespace BalancedBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            string stringRead = "";

            for (int i = 0; i < numberOfLines; i++)
            {
                stringRead += Console.ReadLine() + " ";

                if (i == numberOfLines - 1)
                {
                    bool chekLeftBraket = false;
                    bool chekRightBraket = true;
                    for (int j = 0; j < stringRead.Split().Length; j++)
                    {
                        string[] c = stringRead.Split();
                        if (c[j].Contains("("))
                        {
                            chekLeftBraket = true;
                            chekRightBraket = false;
                            for (int k = j + 1; k < c.Length; k++)
                            {
                                if (c[k].Contains("("))
                                {
                                    chekLeftBraket = false;
                                    chekRightBraket = false;
                                    j = c.Length - 1;
                                    break;
                                }
                                else if (c[k].Contains(")"))
                                {
                                    chekLeftBraket = false;
                                    chekRightBraket = true;
                                    j = k;
                                    break;
                                }
                            }
                        }
                        else if (c[j].Contains(")"))
                        {
                            if (chekRightBraket)
                            {
                                chekLeftBraket = false;
                                chekRightBraket = false;
                                break; ;
                            }
                        }
                    }
                    if (!chekLeftBraket && chekRightBraket)
                    {
                        Console.WriteLine("BALANCED");
                    }
                    else
                        Console.WriteLine("UNBALANCED");
                }
            }
        }
    }
}
