using System;
using System.Linq;
using System.Text;

namespace KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            string command = string.Empty;
            string dnkLines = string.Empty;

            // променливи, нужни за изходни данни
            int theBestBigerSeries = 0; // най-добра поредица
            int theBestBigerSeriesSum = 0; // сума от едениците на най-добрата поредица
            int theBestIndexPositionFroBigerSeries = 0; //позиция на едениците в масива
            int theBestCounter = 0; // пореден номер на най-добрата поредица
            string bestDnkSeries = string.Empty;
            int counter = 0; // брояч на ДНК поредици

            while ((command = Console.ReadLine()) != "Clone them!")
            {
                string currentDnk = command.Replace("!", ""); // текущият ДНК код
                string[] arrayWithOutZero = currentDnk.Split("0", StringSplitOptions.RemoveEmptyEntries); // масив с единици
                counter++;
                int getBigerSeries = 0; //нмирам най голямата последователност от единици
                int getBigerSeriesSum = 0; // сума от едениците на поредицата
                string seriesDNK = "";

                //нмирам най голямата последователност от единици
                foreach (var bigerSeries in arrayWithOutZero)
                {
                    if (bigerSeries.Length > getBigerSeries)
                    {
                        getBigerSeries = bigerSeries.Length;
                        seriesDNK = bigerSeries;
                    }
                    getBigerSeriesSum += bigerSeries.Length;
                }

                int getIndexPositionFroBigerSeries = currentDnk.IndexOf(seriesDNK); // индексът от който започва последователността
                char[] printDnk = currentDnk.ToArray();

                // 1) ако последователността е най голяма, приемаме за на-добра поредица,
                bool bigSeries = getBigerSeries > theBestBigerSeries;
                // 2) ако има еднакви последователности -> отпечатваме най-лявата,
                bool equalsSeries = getBigerSeries == theBestBigerSeries;
                bool chekLeftIndex = getIndexPositionFroBigerSeries < theBestIndexPositionFroBigerSeries;
                // 3) ако има еднакви последователности с еднакъв индекс -> отпечатваме най-голямата,
                bool chekEqualsIndex = getIndexPositionFroBigerSeries == theBestIndexPositionFroBigerSeries;
                bool chekBestSeriesSum = getBigerSeriesSum > theBestBigerSeriesSum;

                if (bigSeries ||
                    (equalsSeries && chekLeftIndex) ||
                    (equalsSeries && chekEqualsIndex && chekBestSeriesSum) ||
                    counter == 1)
                {
                    theBestBigerSeries = getBigerSeries;
                    theBestBigerSeriesSum = getBigerSeriesSum;
                    theBestIndexPositionFroBigerSeries = getIndexPositionFroBigerSeries;
                    theBestCounter = counter;
                    bestDnkSeries = string.Join(" ", printDnk);
                }
            }

            Console.WriteLine($"Best DNA sample {theBestCounter} with sum: {theBestBigerSeriesSum}.");
            Console.WriteLine(bestDnkSeries);
        }
    }
}
