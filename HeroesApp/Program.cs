using System;
using HeroesLib;

namespace HeroesApp
{
    class Program
    {
        static void Main()
        {
            Hero hero = null;
            
            Console.WriteLine("Выберите расу героя");
            Console.WriteLine("1. Люди");
            Console.WriteLine("2. Орки");
            var selectRace = Console.ReadLine();

            Console.WriteLine("Выберите специализацию героя");
            Console.WriteLine("1. Маг");
            Console.WriteLine("2. Воин");
            var selectSpecialization = Console.ReadLine();

            switch (selectRace)
            {
                case "1":
                    switch (selectSpecialization)
                    {
                        case "1":
                            hero = new HumanMage();
                            break;
                        case "2":
                            hero = new HumanWarior();
                            break;
                    }
                    break;
                case "2":
                    break;
            }
            
            CLI.ShowHero(hero);
        }
    }
}