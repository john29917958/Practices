using System.Drawing;
using Decorator.Attributes;

namespace Decorator
{
    public class Character
    {
        public Point Position { get; protected set; }
        public BaseAttributes BaseAttributes { get; }
        public Attributes.Attributes Attributes { get; set; }

        public Character(BaseAttributes baseAttributes)
        {
            BaseAttributes = baseAttributes;
            Attributes = baseAttributes;
        }
    }
}
