using System;
using Bridge.Characters;
using Bridge.Spells;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Character character = new Human(0, "Jack", 100, 100);
            character.CastSpell();
            character.SetSpell(new FireSpell(30, 100, 20));
            character.CastSpell();
            character.SetSpell(new IceSpell(30, 50, 20));
            character.CastSpell();
            character.SetSpell(new CurseSpell(40, 60, 20));
            character.CastSpell();

            character = new Orc(1, "Gary", 100, 100);
            character.CastSpell();
            character.SetSpell(new FireSpell(30, 100, 20));
            character.CastSpell();
            character.SetSpell(new IceSpell(30, 50, 20));
            character.CastSpell();
            character.SetSpell(new CurseSpell(40, 60, 20));
            character.CastSpell();

            character = new Vampire(2, "Prince", 100, 100);
            character.CastSpell();
            character.SetSpell(new FireSpell(30, 100, 20));
            character.CastSpell();
            character.SetSpell(new IceSpell(30, 50, 20));
            character.CastSpell();
            character.SetSpell(new CurseSpell(40, 60, 20));
            character.CastSpell();

            Console.ReadLine();
        }
    }
}
