namespace BuffPattern.Attributeses
{
    public class Attributes : IAttributes
    {
        public int MaxHealth { get; set; }
        public int MaxMana { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Critical { get; set; }

        public Attributes(int maxHealth, int maxMana, int attack, int defense, int critical)
        {
            MaxHealth = maxHealth;
            MaxMana = maxMana;
            Attack = attack;
            Defense = defense;
            Critical = critical;
        }

        public Attributes(IAttributes attributes)
        {
            MaxHealth = attributes.MaxHealth;
            MaxMana = attributes.MaxMana;
            Attack = attributes.Attack;
            Defense = attributes.Defense;
            Critical = attributes.Critical;
        }
    }
}
