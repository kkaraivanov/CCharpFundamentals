using System;

namespace BackIn30Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hh = int.Parse(Console.ReadLine());
            int mm = int.Parse(Console.ReadLine());

            mm += 30;
            
            if (mm > 59)
            {
                if (hh >= 24)
                {
                    hh = 0;
                }
                else
                {
                    hh++;
                }
                mm = mm - 60;
            }
            if (hh >= 24)
            {
                hh = 0;
            }
            Console.WriteLine($"{hh}:{mm:d2}");
        }
    }
}
