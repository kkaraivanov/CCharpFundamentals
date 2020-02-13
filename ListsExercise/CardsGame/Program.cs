using System;
using System.Collections.Generic;
using System.Linq;

namespace CardsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> ferstPlayer = Console.ReadLine().Split().Select(long.Parse).ToList();
            List<long> secondPlayer = Console.ReadLine().Split().Select(long.Parse).ToList();

            PlayGame(ferstPlayer, secondPlayer);
            Console.WriteLine(ferstPlayer.Count > secondPlayer.Count ? 
                              $"First player wins! Sum: {string.Join(" ", ferstPlayer.Sum())}" :
                              $"Second player wins! Sum: {string.Join(" ", secondPlayer.Sum())}");
        }

        private static void PlayGame(List<long> ferstPlayer, List<long> secondPlayer)
        {
            int counter = ferstPlayer.Count > secondPlayer.Count ? secondPlayer.Count :
                          ferstPlayer.Count < secondPlayer.Count ? ferstPlayer.Count :
                          secondPlayer.Count;
            for (int i = 0; i < counter; i++)
            {
                if (ferstPlayer[i] > secondPlayer[i])
                {
                    long currenFerstPlayertHand = ferstPlayer[i];
                    long currenSecondPlayertHand = secondPlayer[i];
                    ferstPlayer.RemoveAt(i);
                    ferstPlayer.Add(currenFerstPlayertHand);
                    ferstPlayer.Add(currenSecondPlayertHand);
                    secondPlayer.RemoveAt(i);
                }
                else if (ferstPlayer[i] < secondPlayer[i])
                {
                    long currenFerstPlayertHand = ferstPlayer[i];
                    long currenSecondPlayertHand = secondPlayer[i];
                    secondPlayer.RemoveAt(i);
                    secondPlayer.Add(currenSecondPlayertHand);
                    secondPlayer.Add(currenFerstPlayertHand);
                    ferstPlayer.RemoveAt(i);
                }
                else
                {
                    ferstPlayer.RemoveAt(i);
                    secondPlayer.RemoveAt(i);
                }
                break;
            }

            if (ferstPlayer.Count != 0 && secondPlayer.Count != 0)
                PlayGame(ferstPlayer, secondPlayer);
        }
    }
}
