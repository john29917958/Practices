using System;

namespace Decorator.Attributes
{
    public class LevelDecorator : AttributesDecorator
    {
        public int Level;

        public override int MaxHealth => ParentAttributes.MaxHealth + (Level - 1) * 10;
        public override int MaxMana => ParentAttributes.MaxMana + (Level - 1) * 5;
        public override int Attack => ParentAttributes.Attack + Convert.ToInt32(BaseAttributes.Attack * 0.2 * (Level - 1));
        public override int Defense => ParentAttributes.Defense + Convert.ToInt32(BaseAttributes.Defense * 0.1 * (Level - 1));
        public override int Critical => ParentAttributes.Critical + Convert.ToInt32(BaseAttributes.Critical * 0.01 * (Level - 1));        

        public LevelDecorator(BaseAttributes baseAttributes, Attributes parentAttributes, int level) : base(baseAttributes, parentAttributes)
        {
            Level = level;
        }
    }
}
