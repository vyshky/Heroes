using HeroesLib.Races;
using HeroesLib.Specializations;

namespace HeroesLib
{
    public class OrkMage : Ork, IMage
    {
        public int Mana { get; set; }

        public OrkMage() : base()
        {
            Armor = 30;
            Mana = 100;
        }

        protected OrkMage(string name) : base(name)
        {
            Armor = 30;
            Mana = 100;
        }

        public void MagicAttack(Hero hero) => Attack(hero);
    }
}