using HeroesLib.Races;
using HeroesLib.Specializations;

namespace HeroesLib
{
    public class HumanWarior : Human, IWarior
    {
        public int Strength { get; set; }

        public HumanWarior() : base()
        {
            Strength = 50;
        }

        public HumanWarior(string name) : base(name)
        {
            Strength = 50;
        }
    }
}