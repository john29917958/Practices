namespace Decorator.Attributes
{
    public abstract class AttributesDecorator : Attributes
    {
        public override int MaxHealth => ParentAttributes.MaxHealth;
        public override int MaxMana => ParentAttributes.MaxMana;
        public override int Attack => ParentAttributes.Attack;
        public override int Defense => ParentAttributes.Defense;
        public override int Critical => ParentAttributes.Critical;

        protected readonly BaseAttributes BaseAttributes;
        protected readonly Attributes ParentAttributes;

        protected AttributesDecorator(BaseAttributes baseAttributes, Attributes parentAttributes)
        {
            BaseAttributes = baseAttributes;
            ParentAttributes = parentAttributes;
        }
    }
}