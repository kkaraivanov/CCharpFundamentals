namespace DragonArmy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class EntryPoint
    {
        static void Main(string[] args)
        {
            int dragonsCount = int.Parse(Console.ReadLine());
            var dragons = new Dictionary<string, List<Dragon>>();

            // input - {type} {name} {damage} {health} {armor}.
            ColectionDragons(dragonsCount, dragons);
            dragons.DisplayColection();
        }

        static void ColectionDragons(int count, Dictionary<string, List<Dragon>> dragons)
        {
            for (int i = 0; i < count; i++)
            {
                var input = Console.ReadLine().Split();
                double value = 0;
                var type = input[0];
                var name = input[1];
                var damage = double.TryParse(input[2], out value) ? value : 45;
                var health = double.TryParse(input[3], out value) ? value : 250;
                var armor = double.TryParse(input[4], out value) ? value : 10;

                if (!dragons.ContainsKey(type))
                    dragons[type] = new List<Dragon>();

                var dragon = dragons[type].SingleOrDefault(x => x.Name == name && x.Type == type);
                if (dragon != null)
                    dragon.NewStats(damage, health, armor);
                else
                    dragons.AddDragon(type, name, damage, health, armor);
            }
        }
    }
}
