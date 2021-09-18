using HeroesLib.Races;
using HeroesLib.Specializations;

namespace HeroesLib
{
    public class HumanMage : Human, IMage
    {
        public int Mana { get; set; }

        public HumanMage() : base()
        {
            Armor = 10;
            Mana = 100;
        }

        public HumanMage(string name) : base(name)
        {
            Armor = 10;
            Mana = 100;
        }
        
        public void MagicAttack(Hero hero)
        {
            //TODO
        }
    }
}