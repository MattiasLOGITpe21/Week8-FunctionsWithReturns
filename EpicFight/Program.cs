using System;

namespace EpicFight
{
    class Program
    {
        static void Main(string[] args)
        {
            string hero, villain;
            string heroWeapon, villainWeapon;
            hero = RandomHero();
            heroWeapon = RandomWeapon();
            villain = RandomVillain();
            villainWeapon = RandomWeapon();
            Console.WriteLine($"{hero} will fight {villain}");
            Console.WriteLine($"{hero} will fight with {heroWeapon}");
            Console.WriteLine($"{villain} will fight with {villainWeapon}");
        }

        private static int RandomIndex(string[] someArray)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, someArray.Length);

            return randomIndex;
        }

        private static string RandomHero()
        {
            string[] heroes = { "Batman", "Iron Man", "Spiderman", "Thor", "Doctor Strange", "Hulk"};
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, heroes.Length);

            return heroes[RandomIndex(heroes)];
        }

        private static string RandomVillain()
        {
            string[] villains = { "Venom", "Carnage", "Thanos", "Joker", "Bane", "Darth Vader"};
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, villains.Length);

            string randomVillain = villains[randomIndex];
            return villains[RandomIndex(villains)];
        }

        private static string RandomWeapon()
        {
            string[] weapon = { "Frying Pan", "Keyboard", "Mouse", "Butter knife", "Shoe"};

            return weapon[RandomIndex(weapon)];
        }

    }
}
