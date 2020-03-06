namespace DragonArmy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    static class DragonStats
    {
        public static void AddDragon(this Dictionary<string, List<Dragon>> dragons, string type, string name, double damage, double health, double armor)
        {
            var dragon = new Dragon();
            dragon.Type = type;
            dragon.Name = name;
            dragon.Damage = damage;
            dragon.Health = health;
            dragon.Armor = armor;

            dragons[type].Add(dragon);
        }
        public static void NewStats(this Dragon dragon, double damage, double health, double armor)
        {
            dragon.Damage = damage;
            dragon.Health = health;
            dragon.Armor = armor;
        }
        public static void DisplayColection(this Dictionary<string, List<Dragon>> dragons)
        {
            foreach (var dragon in dragons)
            {
                var count = dragon.Value.Count();
                var damageAverage = dragon.Value.Sum(x => x.Damage);
                var healthAverage = dragon.Value.Sum(x => x.Health);
                var armorAverage = dragon.Value.Sum(x => x.Armor);

                Console.WriteLine($"{dragon.Key}::({damageAverage / count:f2}/{healthAverage / count:f2}/{armorAverage / count:f2})");
                Console.WriteLine(string.Join($"{Environment.NewLine}", dragon.Value
                    .OrderBy(x => x.Name)
                    .Select(x => $"-{x.Name} -> damage: {x.Damage}, health: {x.Health}, armor: {x.Armor}")));
            }
        }
    }
}
