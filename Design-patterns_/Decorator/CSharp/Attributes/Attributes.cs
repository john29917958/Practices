namespace Decorator.Attributes
{
    public class Attributes
    {
        public virtual int MaxHealth { get; protected set; }
        public virtual int MaxMana { get; protected set; }
        public virtual int Attack { get; protected set; }
        public virtual int Defense { get; protected set; }
        public virtual int Critical { get; protected set; }
    }
}
