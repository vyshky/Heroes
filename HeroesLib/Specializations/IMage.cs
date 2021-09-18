using System;

namespace HeroesLib.Specializations
{
    public interface IMage
    {
        public int Mana { get; set; }

        public void MagicAttack(Hero hero);
    }
}