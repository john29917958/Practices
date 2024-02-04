namespace Bridge.Spells
{
    public abstract class Spell
    {
        public int Power;
        public int Speed;
        public int Cost;

        protected Spell(int power, int speed, int cost)
        {
            Power = power;
            Speed = speed;
            Cost = cost;
        }

        public abstract void Cast();
    }
}
