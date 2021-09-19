using HeroesLib.Races;
using HeroesLib.Specializations;

namespace HeroesLib
{
    public class OrkWarior : Ork, IWarior
    {
        public int Strength { get; set; }

        public OrkWarior() : base()
        {
            Armor = 50;
            Strength = 50;
        }

        public OrkWarior(string name) : base(name)
        {
            Armor = 50;
            Strength = 50;
        }
    }
}