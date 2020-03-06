namespace Snowwhite
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class EntryPont
    {
        static void Main(string[] args)
        {
            // <collor, dwarf>
            var dwarfs = new Dictionary<string, List<Dwarf>>();
            AddDwarfs(dwarfs);
            var sortedResult = Dwarfs
                .OrderByDescending(x => x.Phisics)
                .ThenByDescending(x => dwarfs[x.Color].Count)
                .ToList();
            
            foreach (var dwarf in sortedResult)
            {
                Console.WriteLine($"({dwarf.Color}) {dwarf.Name} <-> {dwarf.Phisics}");
            }
        }

        static void AddDwarfs(Dictionary<string, List<Dwarf>> dwarfs)
        {
            string input = null;
            while ((input = Console.ReadLine()) != "Once upon a time")
            {
                // name <:> color <:> phisics
                var inputArray = input.Split().ToArray().Where(x => x != "<:>").ToArray();
                string name = inputArray[0];
                string color = inputArray[1];
                int phisics = int.Parse(inputArray[2]);

                if (!dwarfs.ContainsKey(color))
                    dwarfs[color] = new List<Dwarf>();

                if(!dwarfs[color].Any(x => x.Name == name))
                {
                    var dwarf = new Dwarf();
                    dwarf.Name = name;
                    dwarf.Color = color;
                    dwarf.Phisics = phisics;
                    dwarfs[color].Add(dwarf);
                    Dwarfs.Add(dwarf);
                }
                else
                {
                    var dwarf = dwarfs[color].FirstOrDefault(x => x.Name == name);
                    dwarf.Phisics = Math.Max(dwarf.Phisics, phisics);
                }
            }
        }

        static List<Dwarf> Dwarfs { get; set; } = new List<Dwarf>();
    }
}
