namespace LegendaryFarming
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            var materials = new Dictionary<string, int>
            {
                { "shards", 0 },
                { "fragments", 0 },
                { "motes", 0 }
            };
            var junks = new Dictionary<string, int>();

            while (true)
            {
                var material = Console.ReadLine().ToLower().Split();
                bool complete = false;

                for (int i = 0; i < material.Length; i += 2)
                {
                    int quantity = int.Parse(material[i]);
                    string type = material[i + 1];

                    if (materials.ContainsKey(type))
                    {
                        materials[type] += quantity;
                        if (type == "shards") {
                            if (materials[type] >= 250)
                            {
                                Console.WriteLine("Shadowmourne obtained!");
                                materials[type] -= 250;
                                complete = true;
                                break;
                            }
                        }
                        else if (type == "fragments")
                        {
                            if (materials[type] >= 250)
                            {
                                Console.WriteLine("Valanyr obtained!");
                                materials[type] -= 250;
                                complete = true;
                                break;
                            }
                        }
                        else if (type == "motes")
                        {
                            if (materials[type] >= 250)
                            {
                                Console.WriteLine("Dragonwrath obtained!");
                                materials[type] -= 250;
                                complete = true;
                                break;
                            }
                        }
                    }
                    else
                    {
                        if (!junks.ContainsKey(type))
                            junks[type] = 0;

                        junks[type] += quantity;
                    }
                }
                if (complete)
                    break;
            }

            materials = materials
                .OrderByDescending(x => x.Value)
                .ThenBy(x =>  x.Key)
                .ToDictionary(x => x.Key, x => x.Value);
            junks = junks
                .OrderBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);
            
            Console.WriteLine(string.Join("\n", materials.Select(x => $"{x.Key}: {x.Value}")));
            Console.WriteLine(string.Join("\n", junks.Select(x => $"{x.Key}: {x.Value}")));
        }
    }
}
