namespace Decorator.Attributes
{
    public class FairyGunIDecorator : AttributesDecorator
    {
        public int Level;

        public override int Attack => ParentAttributes.Attack + 10 * Level;
        public override int Critical => ParentAttributes.Critical + 9 * Level;

        public FairyGunIDecorator(BaseAttributes baseAttributes, Attributes parentAttributes, int level) : base(baseAttributes, parentAttributes)
        {
            Level = level;
        }
    }
}
