using System;
using System.Collections.Generic;
using System.Linq;

namespace DrumSet
{
    class Program
    {
        static void Main(string[] args)
        {
            double savingMoney = double.Parse(Console.ReadLine());
            List<int> drumsGroup = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> tempDrumsGroup = drumsGroup.ToList();
            string line = string.Empty;
            
            while ((line = Console.ReadLine()) != "Hit it again, Gabsy!")
            {
                int hitPower = int.Parse(line);
                for (int i = 0; i < drumsGroup.Count; i++)
                {
                    tempDrumsGroup[i] -= hitPower;
                    if (tempDrumsGroup[i] <= 0)
                    {
                        if (savingMoney <= 0 || savingMoney - drumsGroup[i] * 3 <= 0)
                        {
                            tempDrumsGroup.RemoveAt(i);
                            drumsGroup.RemoveAt(i);
                            i--;
                        }
                        else
                        {
                            tempDrumsGroup[i] = drumsGroup[i];
                            savingMoney -= drumsGroup[i] * 3;
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ",tempDrumsGroup));
            Console.WriteLine($"Gabsy has {savingMoney:f2}lv.");
        }
    }
}
