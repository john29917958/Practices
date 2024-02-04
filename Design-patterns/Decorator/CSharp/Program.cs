using System;
using Decorator.Attributes;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Character character = new Character(new BaseAttributes(100, 50, 10, 5, 1));
            Console.WriteLine("Initial attributes:");
            PrintCharacterAttributes(character);
            Console.WriteLine("=========================");

            LevelDecorator levelDecorator = new LevelDecorator(character.BaseAttributes, character.Attributes, 1);
            character.Attributes = levelDecorator;
            Console.WriteLine($"Level decorator (Lv{levelDecorator.Level}):");
            PrintCharacterAttributes(character);
            Console.WriteLine("=========================");

            levelDecorator.Level += 1;
            Console.WriteLine($"Level decorator (Lv{levelDecorator.Level}):");
            PrintCharacterAttributes(character);
            Console.WriteLine("=========================");

            levelDecorator.Level += 1;
            Console.WriteLine($"Level decorator (Lv{levelDecorator.Level}):");
            PrintCharacterAttributes(character);
            Console.WriteLine("=========================");

            FairyGunIDecorator gunDecorator = new FairyGunIDecorator(character.BaseAttributes, character.Attributes, 1);
            character.Attributes = gunDecorator;
            Console.WriteLine($"Gun decorator (Lv{gunDecorator.Level}):");
            PrintCharacterAttributes(character);
            Console.WriteLine("=========================");

            gunDecorator.Level += 1;
            Console.WriteLine($"Gun decorator (Lv{gunDecorator.Level}):");
            PrintCharacterAttributes(character);
            Console.WriteLine("=========================");

            gunDecorator.Level += 1;
            Console.WriteLine($"Gun decorator (Lv{gunDecorator.Level}):");
            PrintCharacterAttributes(character);
            Console.WriteLine("=========================");

            Console.ReadLine();
        }

        private static void PrintCharacterAttributes(Character character)
        {
            Console.WriteLine(
                "Max health: " + character.Attributes.MaxHealth + Environment.NewLine +
                "Max mana: " + character.Attributes.MaxMana + Environment.NewLine +
                "Attack: " + character.Attributes.Attack + Environment.NewLine +
                "Defense: " + character.Attributes.Defense + Environment.NewLine +
                "Critical: " + character.Attributes.Critical
            );
        }
    }
}
