using System;
using Bridge.Spells;

namespace Bridge.Characters
{
    public abstract class Character
    {
        public int Id { get; protected set; }
        public string Name { get; protected set; }
        public int Health { get; protected set; }
        public int Mana { get; protected set; }
        public Spell Spell { get; protected set; }

        protected Character(int id, string name, int health, int mana)
        {
            Id = id;
            Name = name;
            Health = health;
            Mana = mana;
            Spell = new DefaultSpell(10, 10, 10);
        }

        public virtual void SetSpell(Spell spell)
        {
            if (spell == null) throw new ArgumentNullException("Spell cannot be set to null");

            Spell = spell;
        }

        public virtual void CastSpell()
        {
            if (Spell == null) return;
            if (Mana < Spell.Cost) return;

            Console.WriteLine($"{Name} casts a spell.");
            Spell.Cast();
            Mana -= Spell.Cost;
            if (Mana < 0) Mana = 0;            
        }

        public virtual void TakeDamage(int value)
        {
            Health -= value;
            if (Health < 0) Health = 0;
            Console.WriteLine($"{Name} have {Health} health points after taking {value} damage points");
        }
    }
}
