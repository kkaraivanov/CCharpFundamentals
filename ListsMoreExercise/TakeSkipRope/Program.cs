using System;
using System.Linq;
using System.Collections.Generic;

namespace TakeSkipRope
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<int> numbersList = input
                .Where(c => char.IsDigit(c)).Select(s => int.Parse(s.ToString())).ToList();
            List<int> takeList = numbersList
                .Where((c,i) => i % 2 == 0).ToList();
            List<int> skipList = numbersList
                .Where((c,i) => i % 2 != 0).ToList();
            List<string> noNumbersList = input
                .Where(c => !char.IsDigit(c)).Select(s => s.ToString()).ToList();

            List<string> temp = new List<string>();
            string str = "";

            for (int i = 0; i < skipList.Count; i++)
            {
                temp = noNumbersList.Take(takeList[i]).ToList();
                noNumbersList = noNumbersList.Skip(takeList[i]).ToList();
                noNumbersList = noNumbersList.Skip(skipList[i]).ToList();
                str += new string(string.Join("",temp));
            }
            Console.WriteLine(str);
        }
    }
}
