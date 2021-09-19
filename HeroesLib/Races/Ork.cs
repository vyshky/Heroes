namespace HeroesLib.Races
{
    public abstract class Ork : Hero
    {
        protected Ork() : base()
        {
            Health = 150;
            Damage = 100;
            Name = "Ork";
        }

        protected Ork(string name) : base(name)
        {
            Health = 150;
            Damage = 100;
        }
    }
}