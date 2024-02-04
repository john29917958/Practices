using Bridge.Spells;

namespace Bridge.Characters
{
    public class Human : Character
    {
        public Human(int id, string name, int health, int mana) : base(id, name, health, mana)
        {

        }

        public override void SetSpell(Spell spell)
        {
            base.SetSpell(spell);
            Spell.Cost -= 10;
            if (Spell.Cost < 0) Spell.Cost = 0;
        }

        public override void CastSpell()
        {
            base.CastSpell();
            base.CastSpell();
        }
    }
}
