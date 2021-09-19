namespace HeroesLib
{
    public abstract class Hero
    {
        public string Name { get; init; }
        public int Health { get; set; }
        public int Damage { get; protected set; }
        
        public int Armor { get; protected set; }

        protected Hero() { }

        protected Hero(string name)
        {
            Name = name;
        }
        public void Attack(Hero hero)
        {
            hero.Health -= Damage;
        }
    }
}