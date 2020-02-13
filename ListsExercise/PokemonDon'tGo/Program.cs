using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonDon_tGo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> pokemons = Console.ReadLine()
                .Split()
                .Select(long.Parse)
                .ToList();
            List<long> removedPokemons = new List<long>();

            while (pokemons.Count > 0)
            {
                int indexes = int.Parse(Console.ReadLine());
                if (indexes < 0)
                {
                    long removedPokemon = pokemons[0];
                    pokemons[0] = pokemons[pokemons.Count - 1];
                    removedPokemons.Add(removedPokemon);
                    UpDownPokemons(pokemons, removedPokemon);
                }
                else if (indexes > pokemons.Count - 1)
                {
                    long removedPokemon = pokemons[pokemons.Count - 1];
                    pokemons[pokemons.Count - 1] = pokemons[0];
                    removedPokemons.Add(removedPokemon);
                    UpDownPokemons(pokemons, removedPokemon);
                }
                else
                {
                    long removedPokemon = pokemons[indexes];
                    pokemons.RemoveAt(indexes);
                    removedPokemons.Add(removedPokemon);
                    UpDownPokemons(pokemons, removedPokemon);
                }
            }

            Console.WriteLine(removedPokemons.Sum());
        }

        static void UpDownPokemons(List<long> pokemons, long removedPokemon)
        {
            for (int i = 0; i < pokemons.Count; i++)
                if (pokemons[i] > removedPokemon)
                    pokemons[i] -= removedPokemon;
                else
                    pokemons[i] += removedPokemon;
        }
    }
}
