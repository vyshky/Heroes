namespace HeroesLib.Races
{
    public abstract class Human : Hero
    {
        protected Human() : base()
        {
            Health = 100;
            Damage = 50;
            Name = "Human";
        }

        protected Human(string name) : base(name)
        {
            Health = 100;
            Damage = 50;
        }
    }
}