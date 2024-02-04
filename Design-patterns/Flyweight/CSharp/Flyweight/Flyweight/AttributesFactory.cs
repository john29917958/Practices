using System;
using System.Collections.Generic;

namespace Flyweight
{
    public static class AttributesFactory
    {
        private static readonly Dictionary<Characters, IAttributes> BaseAttributes = new Dictionary<Characters, IAttributes>();

        public static CharacterAttributes Make(Characters type)
        {
            if (BaseAttributes.ContainsKey(type))
            {
                return new CharacterAttributes(BaseAttributes[type]);
            }

            IAttributes attributes;

            switch (type)
            {
                case Characters.Spider:
                    attributes = new BaseAttributes
                    {
                        Hp = 100,
                        Mp = 100,
                        Speed = 10
                    };
                    break;
                case Characters.Ghost:
                    attributes = new BaseAttributes
                    {
                        Hp = 150,
                        Mp = 100,
                        Speed = 50
                    };
                    break;
                case Characters.Satan:
                    attributes = new BaseAttributes
                    {
                        Hp = 500,
                        Mp = 1000,
                        Speed = 30
                    };
                    break;
                default:
                    throw new ArgumentException("Unsupported " + type);
            }

            BaseAttributes.Add(type, attributes);
            return new CharacterAttributes(attributes);
        }
    }
}