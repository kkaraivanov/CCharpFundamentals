using System;
using System.Collections.Generic;
using System.Linq;

namespace MergingLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> listOne = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToList();
            List<double> listTwo = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToList();
            int count = GetCount(listOne, listTwo);

            if (listOne.Count == count)
                listOne = AppendSeccondList(listOne, listTwo).ToList();
            else if (listTwo.Count == count)
                listOne = InsertSeccondList(listOne, listTwo).ToList();

            Console.WriteLine(string.Join(" ",listOne));
        }

        private static List<double> InsertSeccondList(List<double> listOne, List<double> listTwo)
        {
            List<double> temp = new List<double>();
            for (int i = 0; i < listOne.Count; i++)
            {
                temp.Add(listOne[i]);
                if(i <= listTwo.Count - 1)
                    temp.Add(listTwo[i]);
            }
            return temp;
        }

        private static List<double> AppendSeccondList(List<double> listOne, List<double> listTwo)
        {
            List<double> temp = new List<double>();
            for (int i = 0; i < listOne.Count; i++)
            {
                temp.Add(listOne[i]);
                temp.Add(listTwo[i]);
            }
            listTwo
                .Skip(listOne.Count)
                .ToList()
                .ForEach(it => { temp.Add(it); });
            
            return temp;
        }

        static int GetCount(List<double> l1, List<double> l2)
        {
            List<double> temp = new List<double>();
            if (l1.Count >= l2.Count)
                return l2.Count;
            else
                return l1.Count;
        }
    }
}
