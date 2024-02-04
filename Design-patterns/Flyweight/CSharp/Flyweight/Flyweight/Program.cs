using System;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            Characters type = Characters.Spider;
            CharacterAttributes attributes = AttributesFactory.Make(type);
            attributes.FillHpAndMp();

            PrintAttributes(type, attributes);

            type = Characters.Ghost;
            attributes = AttributesFactory.Make(type);
            attributes.FillHpAndMp();
            PrintAttributes(type, attributes);

            type = Characters.Satan;
            attributes = AttributesFactory.Make(type);
            attributes.FillHpAndMp();
            PrintAttributes(type, attributes);

            attributes.Level = 100;
            PrintAttributes(type, attributes);

            Console.ReadLine();
        }

        private static void PrintAttributes(Characters type, CharacterAttributes attributes)
        {
            Console.WriteLine("Attributes of " + type);
            Console.WriteLine("==================================");
            Console.WriteLine("Level: " + attributes.Level);
            Console.WriteLine("HP: " + attributes.Hp);
            Console.WriteLine("MP: " + attributes.Mp);
            Console.WriteLine("Speed: " + attributes.Speed);
        }
    }
}
