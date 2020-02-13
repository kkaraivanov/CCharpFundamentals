using System;

namespace PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            int powerMon = int.Parse(Console.ReadLine());           // N
            int rangeMon = int.Parse(Console.ReadLine());           // M
            int exhaustionPowerMon = int.Parse(Console.ReadLine()); // Y

            int counterTaskMon = 0;
            double percentPowerMon = (double)powerMon * 0.50;

            while (powerMon >= rangeMon)
            {
                counterTaskMon++;
                powerMon -= rangeMon;
                if (powerMon == percentPowerMon && exhaustionPowerMon != 0)
                {
                    powerMon /= exhaustionPowerMon;
                }
            }
            Console.WriteLine(powerMon);
            Console.WriteLine(counterTaskMon);
        }
    }
}
