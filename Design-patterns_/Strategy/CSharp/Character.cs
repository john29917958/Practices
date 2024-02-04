using Strategy.Attributes;
using Strategy.AttributeStrategies;

namespace Strategy
{
    public class Character
    {
        public IAttributes Attributes
        {
            get
            {
                Attributes.Attributes attributes = new Attributes.Attributes();
                attributes.Health = _attributeStrategy.Health;
                attributes.Mana = _attributeStrategy.Mana;
                attributes.Attack = _attributeStrategy.Attack;
                attributes.MagicalAttack = _attributeStrategy.MagicalAttack;
                attributes.Defense = _attributeStrategy.Defense;
                attributes.MagicalDefense = _attributeStrategy.MagicalDefense;

                return attributes;
            }
        }

        private AttributeStrategy _attributeStrategy;
        private readonly CharacterProperties _properties;

        public Character(CharacterProperties properties, AttributeStrategy attributeStrategy)
        {
            _properties = properties;
            _attributeStrategy = attributeStrategy;
            _attributeStrategy.Properites = properties;
        }

        public void SetAttributeStrategy<T>() where T : AttributeStrategy, new()
        {
            T strategy = new T
            {
                Properites = _properties
            };

            _attributeStrategy = strategy;
        }
    }
}
