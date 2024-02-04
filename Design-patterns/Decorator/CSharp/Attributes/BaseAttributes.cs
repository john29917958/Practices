namespace Decorator.Attributes
{
    public sealed class BaseAttributes : Attributes
    {
        public BaseAttributes(int maxHealth, int maxMana, int attack, int defense, int critical)
        {
            MaxHealth = maxHealth;
            MaxMana = maxMana;
            Attack = attack;
            Defense = defense;
            Critical = critical;
        }
    }
}
