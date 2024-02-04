namespace BuffPattern.Attributeses
{
    public class BaseAttributes : IAttributes
    {
        public int MaxHealth { get; }
        public int MaxMana { get; }
        public int Attack { get; }
        public int Defense { get; }
        public int Critical { get; }

        public BaseAttributes(int maxHealth, int maxMana, int attack, int defense, int critical)
        {
            MaxHealth = maxHealth;
            MaxMana = maxMana;
            Attack = attack;
            Defense = defense;
            Critical = critical;
        }

        public BaseAttributes(IAttributes attributes)
        {
            MaxHealth = attributes.MaxHealth;
            MaxMana = attributes.MaxMana;
            Attack = attributes.Attack;
            Defense = attributes.Defense;
            Critical = attributes.Critical;
        }
    }
}
