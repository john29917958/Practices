using System;
using Strategy.AttributeStrategies;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Warrior");
            Character character = new Character(new CharacterProperties
            {
                Level = 1,
                Strength = 10,
                Wisdom = 5
            }, new WarriorAttributeStrategy());
            PrintCharacter(character);

            Console.WriteLine("Magica");
            character.SetAttributeStrategy<MagicaAttributeStrategy>();
            PrintCharacter(character);

            Console.ReadLine();
        }

        private static void PrintCharacter(Character character)
        {
            Console.WriteLine($@"Character attributes:
Health: {character.Attributes.Health}
Mana: {character.Attributes.Mana}
Attack: {character.Attributes.Attack}
Defense: {character.Attributes.Defense}
Magical attack: {character.Attributes.MagicalAttack}
Magical defense: {character.Attributes.MagicalDefense}
");
        }
    }
}
