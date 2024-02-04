using System;
using Bridge.Spells;

namespace Bridge.Characters
{
    public class Vampire : Character
    {
        public Vampire(int id, string name, int health, int mana) : base(id, name, health, mana)
        {

        }

        public override void SetSpell(Spell spell)
        {
            base.SetSpell(spell);

            if (spell.GetType() == typeof(CurseSpell))
            {
                Console.WriteLine($"Increases power and speed of cursed spell for Vampire {Name}");
                spell.Power += 10;
                spell.Speed += 5;
                Spell.Cost -= 5;
            }
        }
    }
}
