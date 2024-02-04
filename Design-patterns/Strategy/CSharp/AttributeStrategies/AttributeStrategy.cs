using Strategy.Attributes;

namespace Strategy.AttributeStrategies
{
    public abstract class AttributeStrategy : IAttributes
    {
        public abstract int Health { get; }
        public abstract int Mana { get; }
        public abstract int Attack { get; }
        public abstract int MagicalAttack { get; }
        public abstract int Defense { get; }
        public abstract int MagicalDefense { get; }

        public CharacterProperties Properites;
    }
}
