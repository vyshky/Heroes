using System;
using HeroesLib;
using HeroesLib.Specializations;

namespace HeroesApp
{
    public static class CLI
    {
        public static void ShowHero(Hero hero)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"=== {hero.GetType().Name} ===");
            var info = hero.GetType().GetProperties();
            foreach (var propertyInfo in info)
            {
                Console.WriteLine($"{propertyInfo.Name} - {propertyInfo.GetValue(hero)}");
            }

            switch (hero)
            {
                case IMage mage:
                    ShowMage(mage);
                    break;
                case IWarior warior:
                    ShowWarior(warior);
                    break;
            }

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("=== === ===");
            Console.WriteLine();
            Console.ResetColor();
        }

        private static void ShowMage(IMage mage)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"*** *** ***");
            Console.WriteLine($"Mana - {mage.Mana}");
            Console.WriteLine("*** *** ***");
            Console.ResetColor();
        }

        private static void ShowWarior(IWarior warior)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"<-- <-> --->");
            Console.WriteLine($"Strength - {warior.Strength}");
            Console.WriteLine("<-- <-> --->");
            Console.ResetColor();
        }
    }
}